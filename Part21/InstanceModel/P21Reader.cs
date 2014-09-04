/*
 * 
 *  < IFC - ISO 10303 (STEP) Part 21 instance file reader >
 *	Copyright (C) <2012>  <Donghoon Yang>
 *
 * 	This program is free software: you can redistribute it and/or modify
 *	it under the terms of the GNU General Public License as published by
 *	the Free Software Foundation, either version 3 of the License, or
 *	(at your option) any later version.
 *
 *	This program is distributed in the hope that it will be useful,
 *	but WITHOUT ANY WARRANTY; without even the implied warranty of
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *	GNU General Public License for more details.
 *
 *	You should have received a copy of the GNU General Public License
 *	along with this program.  If not, see <http://www.gnu.org/licenses/>. 
 * 
 */


using System;
using System.Collections.Generic;
using System.IO;
using SchemaModel;

namespace InstanceModel
{
    enum ParserStatus
    {
        ISO,
        HEADER,
        DATA,
        READY
    }

    public partial class InstanceDB
    {
        //StreamReader DataStream; // variable for instance data stream reader.
        //static InstanceModel theDataSet;
        SData p_schemaModel;
        //InstanceDB p_InstanceModel;
        ParserStatus currStatus;
        StreamReader DataStream;


        //public InstanceDB InstanceModel { get { return p_InstanceModel; } }

        public SData SchemaModel { get { return p_schemaModel; } }

        public InstanceDB(string schemaFileName, string instanceFileName, string logFileName)
            : this(instanceFileName)
        {
            //SParser aParser = new SParser();
            //p_schemaModel = aParser.ReadSchemaFile(schemaFileName, schemaFileName + ".log");
            p_schemaModel = SParser.ReadSchema(schemaFileName);
            AssignEntityDefToInstance(logFileName);

            //p_InstanceModel.UpdateGuidToIFCInstanceGuid();
        }


        /// <summary>
        /// check syntax of instance
        /// associate 
        /// </summary>
        /// <param name="logFileName"></param>
        private void AssignEntityDefToInstance(string logFileName)
        {
            using (StreamWriter sWriter = new StreamWriter(logFileName))
            {
                foreach (KeyValuePair<uint, Instance> kvp in DataList)
                {
                    if (kvp.Value is InstanceSimple)
                    {
                        // assign schema entity information to instance
                        InstanceSimple sInstance = (InstanceSimple)kvp.Value;
                        SEntity sEntity;

                        try
                        {
                            //p_schemaModel.EntityList.ContainsKey()


                            sEntity = p_schemaModel.EntityList[sInstance.Keyword];

                            for (int i = 0; i < sEntity.FlatList.Count; i++)
                            {
                                SAttribute sAtt = sEntity.FlatList[i];
                                sInstance.AttributeList[i].SchemaAttDef = sAtt;
                                if (sInstance.AttributeList[i].ParameterType == SParamType.SET)
                                {
                                    var sparam = sAtt.Type as SParamCollection;
                                    var pList = sInstance.AttributeList[i] as ParamList;
                                    foreach (var item in pList.ParameterList)
                                    {
                                        if (sparam != null)
                                        {
                                            item.SchemaAttDef = new SAttribute(null, sparam.ParamReference);
                                        }
                                        else
                                        {

                                        }
                                    }
                                    sInstance.AttributeList[i].updateParameterType(sAtt.Type.ParamType);
                                }

                                //{ sInstance.AttributeList[i].updateParameterType(SAttribType.LIST); }
                                //else if (sAtt.AttributeValue.AttTypeAtSchema == SAttribType.ARRAY)
                                //{ sInstance.AttributeList[i].updateParameterType(SAttribType.ARRAY); }
                                //else if (sAtt.AttributeValue.AttTypeAtSchema == SAttribType.BAG)
                                //{ sInstance.AttributeList[i].updateParameterType(SAttribType.BAG); }
                                //else if (sAtt.AttributeValue.AttTypeAtSchema == SAttribType.SET)
                                //{ sInstance.AttributeList[i].updateParameterType(SAttribType.SET); }


                                //if (sAtt.AttributeValue.AttTypeAtSchema == AttribType.LIST ||
                                //    sAtt.AttributeValue.AttTypeAtSchema == AttribType.ARRAY ||
                                //    sAtt.AttributeValue.AttTypeAtSchema == AttribType.BAG ||
                                //    sAtt.AttributeValue.AttTypeAtSchema == AttribType.SET)
                                //    if (sInstance.AttributeList[i] is ParamList)
                                //    {
                                //        ParamList pList = (ParamList)sInstance.AttributeList[i];
                                //        if (sAtt.AttributeValue is SParamCollection)
                                //        {
                                //            SParamCollection sP = (SParamCollection)sAtt.AttributeValue;
                                //            foreach (Parameter p in pList.ParameterList)
                                //            {
                                //                p.SchemaAttDef = new SAttribute(sP.AttTypeAtSchemaName, sP.CollectionItem);
                                //            }
                                //        }
                                //        else
                                //        {
                                //            SParamNamed spn = (SParamNamed)sAtt.AttributeValue;
                                //            if (spn.NamedAttribute is STypeArray)
                                //            { }
                                //        }
                                //    }
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            sWriter.WriteLine(
                                string.Format(
                                "Instance Syntax error : #{0} = {1}",
                                sInstance.EntityInstanceName,
                                sInstance.Keyword));
                        }

                        catch (KeyNotFoundException)
                        {
                            sWriter.WriteLine(
                                string.Format(
                                "Included schema doesn't have definition of {0}",
                                sInstance.Keyword));
                        }
                    }
                    else if (kvp.Value is InstanceComplex)
                    {
                        // need to implement
                    }
                    else
                    {
                        throw new InvalidDataException(
                            string.Format("Undefined instantiation of instance at {0} : {1}",
                            kvp.Value.EntityInstanceName, kvp.Value.Keyword));
                    }
                }
            }
        }


        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="InstanceFileName"></param>
        /// <param name="InstanceData"></param>
        public InstanceDB(string InstanceFileName)
        {
            //schemaModel = new scha
            //    SchemaParser.ReadSchemaFile(schemaFileName);
            //p_InstanceModel = new InstanceDB();

            using (DataStream = new StreamReader(InstanceFileName))
            {
                try
                {
                    if (!RetrieveFileInfomation(InstanceFileName))
                    { throw new Exception("Error in retrieving Instance File information."); }

                    Parse();

                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }
        }


        //void ReadP21File(string schemaFileName, string InstanceFileName)
        //{
        //    //schemaModel = new scha
        //    //    SchemaParser.ReadSchemaFile(schemaFileName);
        //    p_InstanceModel = new InstanceDB();

        //    using (DataStream = new StreamReader(InstanceFileName))
        //    {
        //        try
        //        {
        //            if (!RetrieveFileInfomation(InstanceFileName))
        //            { throw new Exception("Error in retrieving Instance File information."); }

        //            Parse();

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("The file could not be read:");
        //            Console.WriteLine(e.Message);
        //        }
        //    }
        //}

        Boolean RetrieveFileInfomation(String InstanceFileName)
        {
            FileInfo InstanceFileInfo = new FileInfo(InstanceFileName);
            if (InstanceFileInfo.Exists)
            {
                FullFileName = InstanceFileInfo.FullName;
                FileName = InstanceFileInfo.Name;
                FileExtension = InstanceFileInfo.Extension;
                FileSize = InstanceFileInfo.Length;
                return true;
            }
            else
            {
                Console.WriteLine("The instance file doesn't exist at the specified location");
                return false;
            }
        }

        /// <summary>
        /// Parse Function
        /// </summary>
        /// <param name="DataStream"></param>
        /// <param name="InstanceData"></param>
        void Parse()
        {
            Token oneToken = Lexer.Tokenizer(DataStream);
            //int pCounter = 0;
            while (oneToken.TokenTypeValue != TokenType.EOF)
            {
                ProcessToken(oneToken);
                oneToken = Lexer.Tokenizer(DataStream);
            }
        }


        /// <summary>
        /// Parsing with late binding scheme
        /// </summary>
        void ParseLB()
        {
            Token oneToken = Lexer.Tokenizer(DataStream);
            //int pCounter = 0;
            while (oneToken.TokenTypeValue != TokenType.EOF)
            {
                ProcessTokenLB(oneToken);
                oneToken = Lexer.Tokenizer(DataStream);
            }
        }



        /// <summary>
        /// Process token according to late bind scheme
        /// </summary>
        /// <param name="TokenToAdd">Lexer generated token</param>
        void ProcessTokenLB(Token TokenToAdd)
        {

            try
            {
                switch (TokenToAdd.TokenTypeValue)
                {
                    case TokenType.ISO1030321:
                        Lexer.Tokenizer(DataStream);
                        currStatus = ParserStatus.ISO;
                        break;
                    case TokenType.ISO1030321END:
                        Lexer.Tokenizer(DataStream);
                        currStatus = ParserStatus.READY;
                        break;
                    case TokenType.HEADER:
                        Lexer.Tokenizer(DataStream);
                        currStatus = ParserStatus.HEADER;
                        break;
                    case TokenType.ENDSEC:
                        Lexer.Tokenizer(DataStream);
                        currStatus = ParserStatus.ISO;
                        break;
                    case TokenType.ENTITYINSTANCENAME:
                        switch (currStatus)
                        {
                            case ParserStatus.DATA:
                                Token oneToken = Lexer.Tokenizer(DataStream);
                                if (oneToken.TokenTypeValue != TokenType.EQUAL)
                                {
                                    Console.WriteLine("Syntax Error in Entity Instance : #" + TokenToAdd.IntegerValue.ToString());
                                    return;
                                }
                                oneToken = Lexer.Tokenizer(DataStream);
                                if (oneToken.TokenTypeValue == TokenType.KEYWORD)
                                {
                                    SortedDictionary<uint, Instance> toAdd = DataList;
                                    if (toAdd.ContainsKey((uint)TokenToAdd.IntegerValue))
                                    {
                                        // when instance is already created by other caller
                                        //P21Instance a =   toAdd[(uint)TokenToAdd.IntegerValue];
                                        InstanceSimple aSimpleInstance = (InstanceSimple)toAdd[(uint)TokenToAdd.IntegerValue];
                                        ModifySimpleInstanceRecord(aSimpleInstance, oneToken.StringValue);
                                    }
                                    else
                                    {
                                        // when it is the first time of parsing entity instance name #???
                                        InstanceSimple aSimpleInstance = AddSimpleInstance((uint)TokenToAdd.IntegerValue, oneToken.StringValue);
                                        toAdd.Add((uint)TokenToAdd.IntegerValue, aSimpleInstance);
                                    }


                                    // adding instances to instanceByType according to instance type
                                    if (InstanceByType.ContainsKey(oneToken.StringValue))
                                    {
                                        List<uint> existingList = InstanceByType[oneToken.StringValue];
                                        existingList.Add((uint)TokenToAdd.IntegerValue);
                                    }
                                    else
                                    {
                                        List<uint> newList = new List<uint>();
                                        newList.Add((uint)TokenToAdd.IntegerValue);
                                        InstanceByType.Add(oneToken.StringValue, newList);
                                    }

                                }
                                else if (oneToken.TokenTypeValue == TokenType.LEFTPARENTHESIS)
                                {
                                    // need update for complex type
                                    SortedDictionary<uint, Instance> toAdd = DataList;
                                    InstanceComplex aComplexInstance = AddComplexInstance((uint)TokenToAdd.IntegerValue);
                                    if (toAdd.ContainsKey((uint)TokenToAdd.IntegerValue))
                                    { toAdd[(uint)TokenToAdd.IntegerValue] = aComplexInstance; }
                                    else
                                    { toAdd.Add((uint)TokenToAdd.IntegerValue, aComplexInstance); }

                                }
                                else
                                {
                                    Console.WriteLine("Syntax Error at value defintion in Entity Instance : #" + TokenToAdd.IntegerValue.ToString());
                                    return;
                                }
                                break;
                            default:
                                Console.WriteLine("Parser Error : Not defined parsing condition in Entity Instance Name : " + currStatus);
                                break;
                        }
                        break;
                    case TokenType.KEYWORD:
                        switch (currStatus)
                        {
                            case ParserStatus.HEADER:
                                SimpleRecord aSimpleRecord = AddSimpleRecord(null, TokenToAdd.StringValue);
                                HeaderList.Add(aSimpleRecord);

                                Lexer.Tokenizer(DataStream); // cleans semicolon at the end of header instance
                                break;
                            case ParserStatus.DATA:
                                Console.WriteLine("Syntax Error : Instance without Entity Instance Name");
                                break;
                            default:
                                Console.WriteLine("Parser Error : Not defined parsing condition in Keyword");
                                break;
                        }
                        break;

                    case TokenType.DATA:
                        Lexer.Tokenizer(DataStream);
                        currStatus = ParserStatus.DATA;

                        //theDataSet.aDataSectionList.Add(new DataSection());


                        break;

                    default:
                        Console.WriteLine("not defined condition : " + TokenToAdd.TokenTypeValue.ToString());
                        break;
                }
            }
            catch (Exception)
            {

                throw new FormatException("Parse Error!");
            }


        }




        /// <summary>
        /// Process Token 
        /// </summary>
        /// <param name="TokenToAdd"></param>
        /// <param name="InstanceData"></param>
        /// <param name="DataStream"></param>
        void ProcessToken(Token TokenToAdd)
        {

            switch (TokenToAdd.TokenTypeValue)
            {
                case TokenType.ISO1030321:
                    Lexer.Tokenizer(DataStream);
                    currStatus = ParserStatus.ISO;
                    break;
                case TokenType.ISO1030321END:
                    Lexer.Tokenizer(DataStream);
                    currStatus = ParserStatus.READY;
                    break;
                case TokenType.HEADER:
                    Lexer.Tokenizer(DataStream);
                    //InstanceData.aHeaderSection = new HeaderSection();
                    currStatus = ParserStatus.HEADER;

                    break;
                case TokenType.ENDSEC:
                    Lexer.Tokenizer(DataStream);
                    currStatus = ParserStatus.ISO;
                    break;
                case TokenType.ENTITYINSTANCENAME:
                    switch (currStatus)
                    {
                        case ParserStatus.DATA:
                            Token oneToken = Lexer.Tokenizer(DataStream);
                            if (oneToken.TokenTypeValue != TokenType.EQUAL)
                            {
                                Console.WriteLine("Syntax Error in Entity Instance : #" + TokenToAdd.IntegerValue.ToString());
                                return;
                            }
                            oneToken = Lexer.Tokenizer(DataStream);
                            if (oneToken.TokenTypeValue == TokenType.KEYWORD)
                            {
                                SortedDictionary<uint, Instance> toAdd = DataList;
                                if (toAdd.ContainsKey((uint)TokenToAdd.IntegerValue))
                                {
                                    // when instance is already created by other caller
                                    //P21Instance a =   toAdd[(uint)TokenToAdd.IntegerValue];
                                    InstanceSimple aSimpleInstance = (InstanceSimple)toAdd[(uint)TokenToAdd.IntegerValue];
                                    ModifySimpleInstanceRecord(aSimpleInstance, oneToken.StringValue);
                                }
                                else
                                {
                                    // when it is the first time of parsing entity instance name #???
                                    InstanceSimple aSimpleInstance = AddSimpleInstance((uint)TokenToAdd.IntegerValue, oneToken.StringValue);
                                    toAdd.Add((uint)TokenToAdd.IntegerValue, aSimpleInstance);
                                }


                                // adding instances to instanceByType according to instance type
                                if (InstanceByType.ContainsKey(oneToken.StringValue))
                                {
                                    List<uint> existingList = InstanceByType[oneToken.StringValue];
                                    existingList.Add((uint)TokenToAdd.IntegerValue);
                                }
                                else
                                {
                                    List<uint> newList = new List<uint>();
                                    newList.Add((uint)TokenToAdd.IntegerValue);
                                    InstanceByType.Add(oneToken.StringValue, newList);
                                }

                            }
                            else if (oneToken.TokenTypeValue == TokenType.LEFTPARENTHESIS)
                            {
                                // need update for complex type
                                SortedDictionary<uint, Instance> toAdd = DataList;
                                InstanceComplex aComplexInstance = AddComplexInstance((uint)TokenToAdd.IntegerValue);
                                if (toAdd.ContainsKey((uint)TokenToAdd.IntegerValue))
                                { toAdd[(uint)TokenToAdd.IntegerValue] = aComplexInstance; }
                                else
                                { toAdd.Add((uint)TokenToAdd.IntegerValue, aComplexInstance); }

                            }
                            else
                            {
                                Console.WriteLine("Syntax Error at value defintion in Entity Instance : #" + TokenToAdd.IntegerValue.ToString());
                                return;
                            }
                            break;
                        default:
                            Console.WriteLine("Parser Error : Not defined parsing condition in Entity Instance Name : " + currStatus);
                            break;
                    }
                    break;
                case TokenType.KEYWORD:
                    switch (currStatus)
                    {
                        case ParserStatus.HEADER:
                            SimpleRecord aSimpleRecord = AddSimpleRecord(null, TokenToAdd.StringValue);
                            HeaderList.Add(aSimpleRecord);

                            Lexer.Tokenizer(DataStream); // cleans semicolon at the end of header instance
                            break;
                        case ParserStatus.DATA:
                            Console.WriteLine("Syntax Error : Instance without Entity Instance Name");
                            break;
                        default:
                            Console.WriteLine("Parser Error : Not defined parsing condition in Keyword");
                            break;
                    }
                    break;

                case TokenType.DATA:
                    Lexer.Tokenizer(DataStream);
                    currStatus = ParserStatus.DATA;

                    //theDataSet.aDataSectionList.Add(new DataSection());


                    break;

                default:
                    Console.WriteLine("not defined condition : " + TokenToAdd.TokenTypeValue.ToString());
                    break;
            }

        }

        InstanceSimple AddSimpleInstance(uint EntityInstanceName, String EntityName)
        {
            InstanceSimple aInstance = new InstanceSimple(EntityInstanceName);
            aInstance.Record = AddSimpleRecord(aInstance, EntityName);

            // new SimpleInstance(EntityInstanceName, AddSimpleRecord(EntityName));
            // Check SemiColon
            Token aToken = Lexer.Tokenizer(DataStream);
            if (aToken.TokenTypeValue != TokenType.SEMICOLON)
            {
                Console.WriteLine("Syntax Error at the end of instance #" + EntityInstanceName.ToString());
            }
            return aInstance;
        }

        void ModifySimpleInstanceRecord(InstanceSimple aInstance, String EntityName)
        {
            aInstance.Record = AddSimpleRecord(aInstance, EntityName);
            // Check SemiColon
            Token aToken = Lexer.Tokenizer(DataStream);
            if (aToken.TokenTypeValue != TokenType.SEMICOLON)
            {
                Console.WriteLine("Syntax Error at the end of instance #" + aInstance.EntityInstanceName.ToString());
            }
        }

        InstanceComplex AddComplexInstance(uint EntityInstanceName)
        {
            InstanceComplex aInstance = new InstanceComplex(EntityInstanceName);
            Token aToken = Lexer.Tokenizer(DataStream);
            while (aToken.TokenTypeValue == TokenType.KEYWORD)
            {
                aInstance.SimpleRecordList.Add(AddSimpleRecord(aInstance, aToken.StringValue));
                aToken = Lexer.Tokenizer(DataStream);
            }
            return aInstance;
        }

        ParamSelect getSelectParameter(string EntityName)
        {
            Token aToken = Lexer.Tokenizer(DataStream);
            if (aToken.TokenTypeValue != TokenType.LEFTPARENTHESIS)
            { return null; }

            aToken = Lexer.Tokenizer(DataStream);
            Parameter param = GetParameter(aToken);
            aToken = Lexer.Tokenizer(DataStream);

            return new ParamSelect(EntityName, param);
        }


        SimpleRecord AddSimpleRecord(Instance cInstance, String EntityName)
        {
            SimpleRecord aRecord = new SimpleRecord(EntityName, this);
            Token aToken = Lexer.Tokenizer(DataStream);
            if (aToken.TokenTypeValue != TokenType.LEFTPARENTHESIS)
            {
                Console.WriteLine("Syntax error in parameter values ");
            }
            else
            {
                aToken = Lexer.Tokenizer(DataStream);
                while (aToken.TokenTypeValue != TokenType.RIGHTPARENTHESIS)
                {
                    aRecord.ParameterList.Add(AddParameterValue(cInstance, aToken));
                    aToken = Lexer.Tokenizer(DataStream);
                }
            }
            return aRecord;
        }


        Parameter AddParameterValue(Instance cInstance, Token TokenToAdd)
        {
            //Token TokenToAdd = Lexer.Tokenizer( DataStream);

            Parameter aParameter;
            switch (TokenToAdd.TokenTypeValue)
            {
                case TokenType.ENTITYINSTANCENAME:
                    //aParameter = new EntityInstanceParameter(TokenToAdd.IntegerValue);
                    //if(DataSet.DataList.ContainsKey(TokenToAdd.IntegerValue))
                    aParameter = new ParamEntity((uint)TokenToAdd.IntegerValue, cInstance, this);
                    //new Parameter(ParameterType.ENTITY_INSTANCE_NAME, TokenToAdd.IntegerValue);
                    break;
                case TokenType.KEYWORD:
                    aParameter = getSelectParameter(TokenToAdd.StringValue);
                    //new Parameter(AddSimpleRecord(TokenToAdd.StringValue, DataStream));
                    break;
                case TokenType.DOLLAR:
                    aParameter = new ParamNullValue();
                    //new Parameter(ParameterType.NULL_VALUE);
                    break;
                case TokenType.INTEGER:
                    aParameter = new ParamInteger(TokenToAdd.IntegerValue);
                    //new Parameter(ParameterType.INTEGER, TokenToAdd.IntegerValue);
                    //InstanceData.aDataSectionList[HeaderCounter -1].DataList[0];
                    break;
                case TokenType.REAL:
                    aParameter = new ParamReal(TokenToAdd.RealValue);
                    //new Parameter(TokenToAdd.RealValue);
                    break;
                case TokenType.STRING:
                    aParameter = new ParamString(TokenToAdd.StringValue);
                    //new Parameter(ParameterType.STRING, TokenToAdd.StringValue, DataSet);
                    break;
                case TokenType.ENUMERATION:
                    aParameter = new ParamEnum(TokenToAdd.StringValue, this);
                    //new Parameter(ParameterType.ENUMERATION, TokenToAdd.StringValue, DataSet);
                    break;
                case TokenType.BINARY:
                    //aParameter = new Parameter(ParameterType.BINARY);
                    aParameter = new ParamBinary(SParamType.BINARY);
                    // need to update
                    break;
                case TokenType.LEFTPARENTHESIS:
                    aParameter = new ParamList(new List<Parameter>());
                    //new Parameter(new List<Parameter>());
                    Token listToken = Lexer.Tokenizer(DataStream);
                    while (listToken.TokenTypeValue != TokenType.RIGHTPARENTHESIS)
                    {
                        Parameter subParam = AddParameterValue(cInstance, listToken);

                        ((ParamList)aParameter).ParameterList.Add(subParam);
                        //List<Parameter> ParameterList = (List<Parameter>)aParameter.ParameterValue;
                        //ParameterList.Add(AddParameterValue( listToken,  DataStream));
                        listToken = Lexer.Tokenizer(DataStream);
                    }
                    break;
                case TokenType.OMITTED:
                    aParameter = new ParamOmitted();
                    //new Parameter(ParameterType.OMITTED_PARAMETER);
                    break;
                case TokenType.TRUE:
                    aParameter = new ParamBoolean(1);
                    break;
                case TokenType.FALSE:
                    aParameter = new ParamBoolean(-1);
                    break;
                case TokenType.UNKNOWN:
                    aParameter = new ParamBoolean(0);
                    break;
                case TokenType.RIGHTPARENTHESIS:
                case TokenType.COMMA:
                    //Console.WriteLine("not defined condition : " + TokenToAdd.TokenTypeValue.ToString());
                    TokenToAdd = Lexer.Tokenizer(DataStream);
                    aParameter = AddParameterValue(cInstance, TokenToAdd);
                    break;
                default:
                    //Console.WriteLine("not defined condition : " + TokenToAdd.TokenTypeValue.ToString());
                    TokenToAdd = Lexer.Tokenizer(DataStream);
                    aParameter = AddParameterValue(cInstance, TokenToAdd);
                    break;
            }
            return aParameter;
        }


        Parameter GetParameter(Token TokenToAdd)
        {
            //Token TokenToAdd = Lexer.Tokenizer( DataStream);

            Parameter aParameter;
            switch (TokenToAdd.TokenTypeValue)
            {
                case TokenType.ENTITYINSTANCENAME:
                    aParameter = new ParamEntity((uint)TokenToAdd.IntegerValue, this);
                    break;
                case TokenType.KEYWORD:
                    aParameter = getSelectParameter(TokenToAdd.StringValue);
                    break;
                case TokenType.DOLLAR:
                    aParameter = new ParamNullValue();
                    break;
                case TokenType.INTEGER:
                    aParameter = new ParamInteger(TokenToAdd.IntegerValue);
                    break;
                case TokenType.REAL:
                    aParameter = new ParamReal(TokenToAdd.RealValue);
                    break;
                case TokenType.STRING:
                    aParameter = new ParamString(TokenToAdd.StringValue);
                    break;
                case TokenType.ENUMERATION:
                    aParameter = new ParamEnum(TokenToAdd.StringValue, this);
                    break;
                case TokenType.BINARY:
                    aParameter = new ParamBinary(SParamType.BINARY);
                    // need to update
                    break;
                case TokenType.LEFTPARENTHESIS:
                    aParameter = new ParamList(new List<Parameter>());
                    Token listToken = Lexer.Tokenizer(DataStream);
                    while (listToken.TokenTypeValue != TokenType.RIGHTPARENTHESIS)
                    {
                        Parameter subParam = GetParameter(listToken);

                        ((ParamList)aParameter).ParameterList.Add(subParam);
                        listToken = Lexer.Tokenizer(DataStream);
                    }
                    break;
                case TokenType.OMITTED:
                    aParameter = new ParamOmitted();
                    break;
                case TokenType.TRUE:
                    aParameter = new ParamBoolean(1);
                    break;
                case TokenType.FALSE:
                    aParameter = new ParamBoolean(-1);
                    break;
                case TokenType.UNKNOWN:
                    aParameter = new ParamBoolean(0);
                    break;
                case TokenType.RIGHTPARENTHESIS:
                case TokenType.COMMA:
                    TokenToAdd = Lexer.Tokenizer(DataStream);
                    aParameter = GetParameter(TokenToAdd);
                    break;
                default:
                    TokenToAdd = Lexer.Tokenizer(DataStream);
                    aParameter = GetParameter(TokenToAdd);
                    break;
            }
            return aParameter;
        }
    }
}
