using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;


namespace SchemaModel
{

    public enum RegisteredSchema
    {
        IFC2X3,
        IFC4,
    }

    public class SParser
    {
        SData _schemaSet = new SData();
        public SData SchemaSet
        {
            get { return _schemaSet; }
        }

        #region internal variables

        private StreamReader _dataStream;
        private List<SToken> _mIgnoredToken = new List<SToken>();
        private StreamWriter _logFile;

        #endregion // internal variables

        #region Pretty Printer
        public void PrintToFileNonAbastractEntityRoot(string fileName)
        {
            using (var aFile = new StreamWriter(fileName))
            {
                foreach (KeyValuePair<string, SEntity> kvp in SchemaSet.EntityList)
                {
                    // check if current entity is not subtype of other entity
                    if (kvp.Value.SubTypesOf.Count == 0)
                    {
                        if (kvp.Value.IsAbstract)
                        { PrintNonABSSub(kvp.Key, aFile); }
                        else
                        { PrintEntityName(kvp.Key, aFile); }
                    }
                }
            }
        }

        public void PrintToFileRootEntityHierarchy(string fileName)
        {
            using (var aFile = new StreamWriter(fileName))
            {
                //aFile.WriteLine("DICTIONARY;");
                //counter = 0;
                foreach (KeyValuePair<string, SEntity> kvp in SchemaSet.EntityList)
                {
                    // check if current entity is not subtype of other entity
                    if (kvp.Value.SubTypesOf.Count == 0)
                    {
                        //UInt16 a = new UInt16();
                        //a = 0;
                        PrintOneEntityHierarchy(kvp.Key, aFile, 0);
                    }
                }
            }
        }

        public void PrintToFileNonAbstractRootEntityHierarchy(string FileName)
        {
            using (StreamWriter aFile = new StreamWriter(FileName))
            {
                foreach (KeyValuePair<string, SEntity> kvp in SchemaSet.EntityList)
                {
                    if (kvp.Value.SubTypesOf.Count == 0)
                    {
                        if (kvp.Value.IsAbstract)
                        {
                            foreach (SEntity aEntity in kvp.Value.SuperTypesOf)
                            {
                                PrintNonAbstractEntityHierarchy(aEntity.Name, aFile, 0);
                            }
                        }
                        else
                        {
                            PrintNonAbstractEntityHierarchy(kvp.Key, aFile, 0);
                        }
                    }
                }
            }
        }

        private void PrintNonAbstractEntityHierarchy(string SimpleID, StreamWriter sWriter, ushort level)
        {
            if (!SchemaSet.EntityList[SimpleID].IsAbstract)
            {
                string a = new string((char)32, level * 4);
                sWriter.Write("{0}{1}\r\n", a, SimpleID);
            }
            if (SchemaSet.EntityList[SimpleID].SuperTypesOf.Count > 0)
            {
                if (!SchemaSet.EntityList[SimpleID].IsAbstract)
                {
                    level++;
                }
                foreach (SEntity aEntity in SchemaSet.EntityList[SimpleID].SuperTypesOf)
                {
                    PrintNonAbstractEntityHierarchy(aEntity.Name, sWriter, level);
                }
            }
        }

        public void PrintToFileIgnoredToken(string FileName)
        {
            using (StreamWriter aFile = new StreamWriter(FileName))
            {
                foreach (SToken iTok in _mIgnoredToken)
                {
                    aFile.WriteLine(iTok.StringValue);
                }
            }
        }

        private void PrintNonABSSub(string SimpleID, StreamWriter aFile)
        {
            foreach (SEntity aEntity in SchemaSet.EntityList[SimpleID].SuperTypesOf)
            {
                if (aEntity.IsAbstract)
                {
                    foreach (SEntity bEntity in aEntity.SuperTypesOf)
                    {
                        PrintNonABSSub(bEntity.Name, aFile);
                    }
                }
                else
                { PrintEntityName(aEntity.Name, aFile); }
            }
        }

        private void PrintEntityName(string SimpleID, StreamWriter aFile)
        {
            aFile.Write("{0}\r\n", SimpleID);
        }

        private void PrintOneEntityHierarchy(string SimpleID, StreamWriter sWriter, ushort level)
        {
            string a = new string((char)32, level * 4);
            //string b = @"";
            //if (SchemaSet.EntityList[SimpleID].IsAbstract)
            //{ b = @" (abs)"; }

            if (SchemaSet.EntityList[SimpleID].IsAbstract)
            { sWriter.Write("{0}<!--  <item>(abs) {1}</item> --> \r\n", a, SimpleID); }
            else
            { sWriter.Write("{0}<item>{1}</item>\r\n", a, SimpleID); }

            if (SchemaSet.EntityList[SimpleID].SuperTypesOf.Count > 0)
            {

                level++;

                foreach (SEntity aEntity in SchemaSet.EntityList[SimpleID].SuperTypesOf)
                {
                    PrintOneEntityHierarchy(aEntity.Name, sWriter, level);
                }
            }
        }

        #endregion //Pretty Printer

        #region Parser

        private SData ReadSchemaFile(String schemaFileName, string logFileName)
        {

            _dataStream = new StreamReader(schemaFileName);
            _logFile = new StreamWriter(logFileName);
            Parse();

            foreach (KeyValuePair<string, SEntity> kvp in SchemaSet.EntityList)
            { kvp.Value.UpdateFlatList(); }

            SchemaSet.UpdateAttributes();

            _dataStream.Close();
            _logFile.Close();
            return SchemaSet;
        }


        /// <summary>
        /// schema parser runs off stream
        /// </summary>
        /// <param name="schemaFile">Stream of Schema File</param>
        /// <returns></returns>
        private SData ReadSchemaFile(Stream schemaFile)
        {
            SData sData;
            using (_dataStream = new StreamReader(schemaFile))
            {
                ReadSchemaFile();
                sData = ReadSchema();
            }
            return sData;
        }

        /// <summary>
        /// read schema file off file without logfile
        /// </summary>
        /// <param name="schemaFile"></param>
        /// <returns></returns>
        private SData ReadSchemaFile(string schemaFile)
        {
            SData sData;
            using (_dataStream = new StreamReader(schemaFile))
            {
                ReadSchemaFile();
                sData = ReadSchema();
            }
            return sData;
        }


        private void ReadSchemaFile()
        {
            Parse();
            foreach (KeyValuePair<string, SEntity> kvp in SchemaSet.EntityList)
            { kvp.Value.UpdateFlatList(); }
            SchemaSet.UpdateAttributes();
        }


        public static SData ReadSchema(RegisteredSchema registeredSchema)
        {
            return new SParser().ReadSchemaFile(GetResourceStream(registeredSchema.ToString()));
        }


        public static SData ReadSchema(string schemaFile)
        {
            return new SParser().ReadSchemaFile(schemaFile);
        }


        private SData ReadSchema()
        {
            _mIgnoredToken = new List<SToken>();

            Parse();

            // update flat list and self derived value list
            foreach (KeyValuePair<string, SEntity> kvp in SchemaSet.EntityList)
            { kvp.Value.UpdateFlatList(); }

            // update all attributes;
            SchemaSet.UpdateAttributes();

            return SchemaSet;
        }



        private static Stream GetResourceStream(string resName)
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //var strResources = assembly.GetName().Name + ".IFC4.exp"; // + resName + ".exp"; //".g.resources";
            //var rStream = assembly.GetManifestResourceStream(strResources);

            Stream _textStreamReader = null;
            try
            {
                var _assembly = Assembly.GetExecutingAssembly();
                // var _imageStream = _assembly.GetManifestResourceStream("MyNamespace.MyImage.bmp");
                _textStreamReader = _assembly.GetManifestResourceStream(@"SchemaModel.Resources." + resName + @".exp");
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }


            return _textStreamReader;



            //var resourceReader = new ResourceReader(rStream);
            //var items = resourceReader.OfType<DictionaryEntry>();
            //var stream = items.First(x => (x.Key as string) == resName.ToLower()).Value;
            //return (UnmanagedMemoryStream)stream;
        }


        /// <summary>
        /// Parser main
        /// </summary>
        private void Parse()
        {
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            //int pCounter = 0;
            while (oneToken.TokenType != STokenType.EOF)
            {
                //AddToken(oneToken, InstanceData, DataStream);
                switch (oneToken.TokenType)
                {
                    case STokenType.SCHEMA:
                        ProcessSchemaTitle();
                        break;
                    case STokenType.ENTITY:
                        ProcessEntity();
                        break;
                    case STokenType.TYPE:
                        ProcessType();
                        break;

                    case STokenType.FUNCTION:
                        ProcessFuction();
                        break;
                    case STokenType.RULE:
                        ProcessRule();
                        break;
                    case STokenType.END_SCHEMA:
                        ProcessSchemaEnd();
                        break;
                    default:
                        IgnoredToken(oneToken);
                        break;
                }
                oneToken = SLexer.Tokenizer(_dataStream);
            }
        }

        private void ProcessSchemaEnd()
        {
            SLexer.Tokenizer(_dataStream);
        }

        private void ProcessFuction()
        {
            SToken Token = SLexer.Tokenizer(_dataStream);
            while (Token.TokenType != STokenType.END_FUNCTION)
            { Token = SLexer.Tokenizer(_dataStream); }
            Token = SLexer.Tokenizer(_dataStream);
        }

        private void ProcessRule()
        {
            var token = SLexer.Tokenizer(_dataStream);
            while (token.TokenType != STokenType.END_RULE)
            { token = SLexer.Tokenizer(_dataStream); }
            token = SLexer.Tokenizer(_dataStream);
        }

        private void ProcessSchemaTitle()
        {
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            if (oneToken.TokenType != STokenType.SIMPLEID)
                throw new Exception("Syntax error in Schema Name Definition");
            SchemaSet.SchemaName = oneToken.StringValue;
            oneToken = SLexer.Tokenizer(_dataStream);
            //SchemaEntity aEntity = getEntity(oneToken.StringValue);
        }

        private void ProcessEntity()
        {
            SToken oneToken = SLexer.Tokenizer(_dataStream);

            if (oneToken.TokenType != STokenType.SIMPLEID)
                throw new Exception("Syntax error in Entity Definition");

            SEntity aEntity = getEntity(oneToken.StringValue);

            oneToken = SLexer.Tokenizer(_dataStream);
            if (oneToken.TokenType == STokenType.SEMICOLON)
            {   //get new token for next step
                oneToken = SLexer.Tokenizer(_dataStream);
            }

            if (oneToken.TokenType == STokenType.ABSTRACT ||
                oneToken.TokenType == STokenType.SUPERTYPE ||
                oneToken.TokenType == STokenType.SUBTYPE)
            { oneToken = ProcessSuperSub(oneToken, aEntity); }

            if (oneToken.TokenType == STokenType.SIMPLEID)
            {
                while (oneToken.TokenType == STokenType.SIMPLEID)
                {
                    ProcessAttribute(aEntity, oneToken.StringValue);
                    oneToken = SLexer.Tokenizer(_dataStream);
                }
            }

            if (oneToken.TokenType == STokenType.DERIVE)
            {
                // oneToken = DummySubLoop();
                // next one after derived
                oneToken = SLexer.Tokenizer(_dataStream);

                while (oneToken.TokenType == STokenType.SIMPLEID || oneToken.TokenType == STokenType.SELF)
                {
                    ProcessDerivedAttribute(aEntity, oneToken);
                    oneToken = SLexer.Tokenizer(_dataStream);
                }
            }

            if (oneToken.TokenType == STokenType.INVERSE)
            {
                //oneToken = DummySubLoop(); 
                oneToken = SLexer.Tokenizer(_dataStream);

                while (oneToken.TokenType == STokenType.SIMPLEID)
                {
                    ProcessInverse(aEntity, oneToken);
                    oneToken = SLexer.Tokenizer(_dataStream);
                }
            }

            if (oneToken.TokenType == STokenType.UNIQUE)
            { oneToken = DummySubLoop(); }

            if (oneToken.TokenType == STokenType.UNDEFINED)
            { oneToken = DummySubLoop(); }

            if (oneToken.TokenType == STokenType.WHERE)
            { oneToken = DummySubLoop(); }

            if (oneToken.TokenType == STokenType.END_ENTITY)
            {
                oneToken = SLexer.Tokenizer(_dataStream); // semi colon
            }

        }


        short getBound(SToken token)
        {
            short ret;
            if (token.TokenType == STokenType.INTEGER)
            { ret = (short)token.IntegerValue; }
            else if (token.TokenType == STokenType.QUESTIONMARK)
            { ret = -2; }
            else if (token.TokenType == STokenType.SIMPLEID)
            { ret = -3; }
            else
            {
                ret = -4;
                //throw new Exception("Syntax error");
            }
            return ret;
        }





        private SParameter ProcessParameter()
        {
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            bool isOptional = false;

            if (oneToken.TokenType == STokenType.OPTIONAL)
            {
                oneToken = SLexer.Tokenizer(_dataStream);
                isOptional = true;
            }

            bool isUnique = false;
            if (oneToken.TokenType == STokenType.UNIQUE)
            {
                isUnique = true;
                oneToken = SLexer.Tokenizer(_dataStream);
            }

            SParamType stype = SParameter.TokenTypeToAttribType(oneToken.TokenType);

            SParameter sParam;

            if (stype == SParamType.SET ||
                stype == SParamType.LIST ||
                stype == SParamType.ARRAY ||
                stype == SParamType.BAG)
            {
                sParam = new SParamCollection(stype);
                var sParamCol = sParam as SParamCollection;
                // get leftbracket
                oneToken = SLexer.Tokenizer(_dataStream);

                // after adding lower bound, upper bound lexer
                oneToken = SLexer.Tokenizer(_dataStream);
                sParamCol.LBound = getBound(oneToken);

                // get colon
                oneToken = SLexer.Tokenizer(_dataStream);
                // get upper bound
                oneToken = SLexer.Tokenizer(_dataStream);
                sParamCol.UBound = getBound(oneToken);

                // get rightbracket
                oneToken = SLexer.Tokenizer(_dataStream);
                // get of
                oneToken = SLexer.Tokenizer(_dataStream);
                sParamCol.ParamReference = ProcessParameter();
            }
            else if (stype == SParamType.NAMED)
            { sParam = new SParamNamed(oneToken.StringValue); }
            else
            { sParam = new SParameter(stype); }

            sParam.IsUnique = isUnique;
            sParam.IsOptional = isOptional;


            // either semi colon or left parenthesis
            //oneToken = SLexer.Tokenizer(DataStream);
            if (!(sParam is SParamCollection))
            {
                oneToken = SLexer.Tokenizer(_dataStream);
                if (oneToken.TokenType == STokenType.LEFTPARENTHESIS)
                {
                    oneToken = SLexer.Tokenizer(_dataStream); // integer
                    // add integer
                    sParam.TypeLength = (short)oneToken.IntegerValue;
                    oneToken = SLexer.Tokenizer(_dataStream); // right parenthesis
                    oneToken = SLexer.Tokenizer(_dataStream);
                    if (oneToken.TokenType == STokenType.FIXED)
                    {
                        // process fixed
                        sParam.IsFixed = true;
                        // semicolon
                        oneToken = SLexer.Tokenizer(_dataStream);
                    }
                }
            }



            //SAttribute oneAttribute = new SAttribute(AttributeName, sParam);

            return sParam;

        }

        private void ProcessAttribute(
            SEntity oneEntity,
            string AttributeName)
        {
            SAttribute satt = new SAttribute(AttributeName);
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            if (oneToken.TokenType != STokenType.COLON)
            { throw new Exception("Error in attribute : " + SLexer.CurrentRow + " : " + SLexer.CurrentColumn); }

            satt.Type = ProcessParameter();
            oneEntity.ParameterList.Add(satt);
        }


        private void ProcessInverse(SEntity sEntity, SToken sToken)
        {
            SAttributeInverse sAttributeInverse = new SAttributeInverse(sToken.StringValue);
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            if (oneToken.TokenType != STokenType.COLON)
            { throw new Exception("Error in inverse attribute : " + SLexer.CurrentRow + " : " + SLexer.CurrentColumn); }

            sAttributeInverse.Type = ProcessInverseParameter();
            oneToken = SLexer.Tokenizer(_dataStream);
            // referencing entity's attribute name
            oneToken = SLexer.Tokenizer(_dataStream);
            sAttributeInverse.InversingAttributeName = oneToken.StringValue;
            sEntity.InverseList.Add(sAttributeInverse);
            // semi colon
            oneToken = SLexer.Tokenizer(_dataStream);
        }


        private SParameter ProcessInverseParameter()
        {
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            bool isOptional = false;

            if (oneToken.TokenType == STokenType.OPTIONAL)
            {
                oneToken = SLexer.Tokenizer(_dataStream);
                isOptional = true;
            }

            bool isUnique = false;
            if (oneToken.TokenType == STokenType.UNIQUE)
            {
                isUnique = true;
                oneToken = SLexer.Tokenizer(_dataStream);
            }

            SParamType stype = SParameter.TokenTypeToAttribType(oneToken.TokenType);

            SParameter sParam;

            if (stype == SParamType.SET ||
                stype == SParamType.LIST ||
                stype == SParamType.ARRAY ||
                stype == SParamType.BAG)
            {
                sParam = new SParamCollection(stype);
                var sParamCol = sParam as SParamCollection;
                // get leftbracket
                oneToken = SLexer.Tokenizer(_dataStream);

                // after adding lower bound, upper bound lexer
                oneToken = SLexer.Tokenizer(_dataStream);
                sParamCol.LBound = getBound(oneToken);

                // get colon
                oneToken = SLexer.Tokenizer(_dataStream);
                // get upper bound
                oneToken = SLexer.Tokenizer(_dataStream);
                sParamCol.UBound = getBound(oneToken);

                // get rightbracket
                oneToken = SLexer.Tokenizer(_dataStream);
                // get of
                oneToken = SLexer.Tokenizer(_dataStream);
                sParamCol.ParamReference = ProcessInverseParameter();
            }
            else if (stype == SParamType.NAMED)
            { sParam = new SParamNamed(oneToken.StringValue); }
            else
            { sParam = new SParameter(stype); }

            sParam.IsUnique = isUnique;
            sParam.IsOptional = isOptional;


            // either semi colon or left parenthesis
            //oneToken = SLexer.Tokenizer(DataStream);
            //if (!(sParam is SParamCollection))
            //{
            //    oneToken = SLexer.Tokenizer(_dataStream);
            //    if (oneToken.TokenType == STokenType.LEFTPARENTHESIS)
            //    {
            //        oneToken = SLexer.Tokenizer(_dataStream); // integer
            //        // add integer
            //        sParam.TypeLength = (short)oneToken.IntegerValue;
            //        oneToken = SLexer.Tokenizer(_dataStream); // right parenthesis
            //        oneToken = SLexer.Tokenizer(_dataStream);
            //        if (oneToken.TokenType == STokenType.FIXED)
            //        {
            //            // process fixed
            //            sParam.IsFixed = true;
            //            // semicolon
            //            oneToken = SLexer.Tokenizer(_dataStream);
            //        }
            //    }
            //}



            //SAttribute oneAttribute = new SAttribute(AttributeName, sParam);

            return sParam;

        }



        /// <summary>
        /// not a complete derive implementation
        /// intended to identify omitted value in instance population
        /// </summary>
        /// <param name="oneEntity"></param>
        /// <param name="AttributeName"></param>
        private void ProcessDerivedAttribute(
            SEntity oneEntity,
            SToken mToken)
        {
            SAttributeDerived drvAtt;
            //SParam sParam;

            if (mToken.TokenType == STokenType.SELF)
            {
                //drvAtt = new SAttributeDerived(AttribType.DERIVED);
                // defines self drived attribute

                // reverse_solidus
                mToken = SLexer.Tokenizer(_dataStream);

                // super entity
                mToken = SLexer.Tokenizer(_dataStream);
                if (mToken.TokenType != STokenType.SIMPLEID)
                    throw new InvalidDataException(string.Format(
                        "schema is not in syntax at {0} : {1}",
                        oneEntity.Name, mToken.TokenType.ToString()));

                string orgSuperTypeName = mToken.StringValue;

                // period
                mToken = SLexer.Tokenizer(_dataStream);
                // attribute name
                mToken = SLexer.Tokenizer(_dataStream);

                string sAttName = mToken.StringValue;

                drvAtt = new SAttributeDerived(sAttName);
                drvAtt.OriginatingSuperType = orgSuperTypeName;
                drvAtt.Name = sAttName;
                drvAtt.isInherited = true;

                // colon
                mToken = SLexer.Tokenizer(_dataStream);
                drvAtt.Type = ProcessParameter();
                oneEntity.DerivedList.Add(drvAtt);
            }
            else //if (mToken.TokenType == SchemaTokenType.SIMPLEID)
            {
                string sAttName = mToken.StringValue;

                drvAtt = new SAttributeDerived(sAttName);
                drvAtt.Name = sAttName;
                drvAtt.isInherited = false;

                mToken = SLexer.Tokenizer(_dataStream);

                drvAtt.Type = ProcessParameter();
                oneEntity.DerivedList.Add(drvAtt);
            }

            //mToken = SLexer.Tokenizer(DataStream);
            //oneEntity.AttributeList.Add(oneAttribute);
            while (mToken.TokenType != STokenType.SEMICOLON)
            {
                mToken = SLexer.Tokenizer(_dataStream);
            }
        }

        private SEntity getEntity(string SimpleID)
        {
            SEntity aEntity;

            if (SchemaSet.EntityList.ContainsKey(SimpleID))
            {
                aEntity = SchemaSet.EntityList[SimpleID];
            }
            else
            {
                aEntity = new SEntity(SimpleID);
                SchemaSet.EntityList.Add(SimpleID, aEntity);
            }
            return aEntity;
        }

        private SToken ProcessSuperSub(SToken oneToken, SEntity aEntity)
        {
            if (oneToken.TokenType == STokenType.ABSTRACT)
            {
                aEntity.IsAbstract = true;
                //get new token for next step
                oneToken = SLexer.Tokenizer(_dataStream);
            }

            if (oneToken.TokenType == STokenType.SUPERTYPE)
            {   // remove OF token after supertype token
                oneToken = SLexer.Tokenizer(_dataStream);
                ProcessSupertypeOf(aEntity);
                //get new token for next step
                oneToken = SLexer.Tokenizer(_dataStream);
            }

            if (oneToken.TokenType == STokenType.SUBTYPE)
            {   // remove of token after supertype token
                oneToken = SLexer.Tokenizer(_dataStream);
                ProcessSubtypeOf(aEntity);
                //get new token for next step
                oneToken = SLexer.Tokenizer(_dataStream);
            }

            return SLexer.Tokenizer(_dataStream);
        }

        private void ProcessSubtypeOf(SEntity aEntity)
        {
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            if (oneToken.TokenType != STokenType.LEFTPARENTHESIS)
                throw new Exception("Syntax Error : Supertype Definition (");
            oneToken = SLexer.Tokenizer(_dataStream);
            if (oneToken.TokenType != STokenType.SIMPLEID)
                throw new Exception("Syntax Error : Supertype Definition simpleId");
            aEntity.SubTypesOf.Add(getEntity(oneToken.StringValue));
            oneToken = SLexer.Tokenizer(_dataStream);
            while (oneToken.TokenType != STokenType.RIGHTPARENTHESIS)
            {
                if (oneToken.TokenType != STokenType.COMMA)
                    throw new Exception("Syntax Error : Supertype Definition ,");
                oneToken = SLexer.Tokenizer(_dataStream);
                if (oneToken.TokenType != STokenType.SIMPLEID)
                    throw new Exception("Syntax Error : Supertype Definition simpleid2");
                aEntity.SuperTypesOf.Add(getEntity(oneToken.StringValue));
                oneToken = SLexer.Tokenizer(_dataStream);
            }
            //
            //oneToken = SchemaLexer.Tokenizer(DataStream);
        }

        private void ProcessSupertypeOf(SEntity aEntity)
        {
            //319 supertype_constraint = abstract_entity_declaration |
            //    abstract_supertype_declaration | supertype_rule .
            //164 abstract_entity_declaration = ABSTRACT .
            //166 abstract_supertype_declaration = ABSTRACT SUPERTYPE [ subtype_constraint ] .
            //313 subtype_constraint = OF ’(’ supertype_expression ’)’ .
            //320 supertype_expression = supertype_factor { ANDOR supertype_factor } .
            //321 supertype_factor = supertype_term { AND supertype_term } .
            //323 supertype_term = entity_ref | one_of | ’(’ supertype_expression ’)’ .
            //263 one_of = ONEOF ’(’ supertype_expression { ’,’ supertype_expression } ’)’ .
            //322 supertype_rule = SUPERTYPE subtype_constraint .


            int parenthesisCounter = 0;

            SToken oneToken = SLexer.Tokenizer(_dataStream);
            if (oneToken.TokenType != STokenType.LEFTPARENTHESIS)
            { throw new Exception("Syntax Error : Supertype Definition ("); }
            else { parenthesisCounter += 1; }


            while (parenthesisCounter != 0)
            {
                oneToken = SLexer.Tokenizer(_dataStream);

                switch (oneToken.TokenType)
                {
                    case STokenType.LEFTPARENTHESIS:
                        parenthesisCounter += 1;
                        break;
                    case STokenType.RIGHTPARENTHESIS:
                        parenthesisCounter -= 1;
                        break;
                    case STokenType.ONEOF:
                    case STokenType.COMMA:
                        break;
                    case STokenType.SIMPLEID:
                        aEntity.SuperTypesOf.Add(getEntity(oneToken.StringValue));
                        break;
                    default:
                        string logout = String.Format("Undefined supertype definition at row : {0}, column : {1}",
                            SLexer.CurrentRow,
                            SLexer.CurrentColumn);
                        if (_logFile != null)
                            _logFile.WriteLine(logout);
                        break;
                }

            }

            //if (oneToken.TokenType != SchemaTokenType.ONEOF)
            //    throw new Exception("Syntax Error : Supertype Definition oneof");

            //oneToken = SchemaLexer.Tokenizer(DataStream);

            //if (oneToken.TokenType != SchemaTokenType.LEFTPARENTHESIS)
            //    throw new Exception("Syntax Error : Supertype Definition (2");

            //oneToken = SchemaLexer.Tokenizer(DataStream);

            //if (oneToken.TokenType != SchemaTokenType.SIMPLEID)
            //    throw new Exception("Syntax Error : Supertype Definition simpleId");

            //aEntity.SuperTypesOf.Add(getEntity(oneToken.StringValue));

            //oneToken = SchemaLexer.Tokenizer(DataStream);

            //while (oneToken.TokenType != SchemaTokenType.RIGHTPARENTHESIS)
            //{
            //    if (oneToken.TokenType != SchemaTokenType.COMMA)
            //        throw new Exception("Syntax Error : Supertype Definition ,");
            //    oneToken = SchemaLexer.Tokenizer(DataStream);
            //    if (oneToken.TokenType != SchemaTokenType.SIMPLEID)
            //        throw new Exception("Syntax Error : Supertype Definition simpleid2");
            //    aEntity.SuperTypesOf.Add(getEntity(oneToken.StringValue));
            //    oneToken = SchemaLexer.Tokenizer(DataStream);
            //}
            //// for second parenthesis
            //oneToken = SchemaLexer.Tokenizer(DataStream);
        }

        private void ProcessType()
        {
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            if (oneToken.TokenType != STokenType.SIMPLEID)
            { throw new Exception("Syntax error in Type Name Definition"); }

            SType st = ProcessTypeSub(oneToken);

            oneToken = SLexer.Tokenizer(_dataStream);

            if (oneToken.TokenType == STokenType.WHERE)
            { oneToken = DummySubLoop(); }

            while (oneToken.TokenType != STokenType.END_TYPE)
            {
                IgnoredToken(oneToken);
                oneToken = SLexer.Tokenizer(_dataStream);
            }
            CleanUpSemiColon();

            SchemaSet.TypeList.Add(st.Name, st);
        }

        private SType ProcessTypeSub(SToken oneToken)
        {
            SType ret;
            string t_TypeName = oneToken.StringValue;

            // tokenlist for syntax checking
            List<SToken> tokenList = new List<SToken>();

            oneToken = SLexer.Tokenizer(_dataStream);
            #region switch
            switch (oneToken.TokenType)
            {
                case STokenType.BOOLEAN:
                case STokenType.REAL:
                case STokenType.INTEGER:
                case STokenType.LOGICAL:
                case STokenType.NUMBER:
                    ret = new SType(t_TypeName, SParameter.TokenTypeToAttribType(oneToken.TokenType));
                    CleanUpSemiColon();
                    break;
                case STokenType.STRING:
                    ret = new STypeString(t_TypeName);
                    ret.Kind = SParameter.TokenTypeToAttribType(oneToken.TokenType);
                    oneToken = SLexer.Tokenizer(_dataStream);
                    if (oneToken.TokenType == STokenType.LEFTPARENTHESIS)
                    {
                        // process width
                        oneToken = SLexer.Tokenizer(_dataStream);

                        ((STypeString)ret).StringLength = (short)oneToken.IntegerValue;
                        oneToken = SLexer.Tokenizer(_dataStream); // right parenthesis
                        oneToken = SLexer.Tokenizer(_dataStream);

                        if (oneToken.TokenType == STokenType.FIXED)
                        {
                            // process fixed
                            ((STypeString)ret).IsFixed = true;
                            // semicolon
                            oneToken = SLexer.Tokenizer(_dataStream);
                        }
                    }

                    break;
                case STokenType.SIMPLEID:
                    ret = new STypeSimple(t_TypeName, oneToken.StringValue);
                    ret.Kind = SParameter.TokenTypeToAttribType(oneToken.TokenType);
                    CleanUpSemiColon();
                    break;
                case STokenType.ARRAY:
                case STokenType.LIST:
                case STokenType.SET:
                case STokenType.BAG:
                    ret = new STypeCollection(t_TypeName, oneToken.TokenType);
                    ret.Kind = SParameter.TokenTypeToAttribType(oneToken.TokenType);
                    collection((STypeCollection)ret);
                    break;
                case STokenType.ENUMERATION:
                    ret = new STypeEnum(t_TypeName);
                    ret.Kind = SParameter.TokenTypeToAttribType(oneToken.TokenType);
                    oneToken = SLexer.Tokenizer(_dataStream);
                    if (oneToken.TokenType != STokenType.OF)
                    { throw new Exception("Syntax error in Schema Name Definition"); }

                    GetInsideSingleParenthesis(tokenList);
                    foreach (SToken aToken in tokenList)
                    {
                        if (aToken.TokenType == STokenType.SIMPLEID)
                        { ((STypeEnum)ret).EnumList.Add(aToken.StringValue); }
                        else
                        { throw new Exception("Syntax error in Enumeration Type Definition : " + ret.Name); }
                    }
                    CleanUpSemiColon();
                    break;
                case STokenType.SELECT:
                    ret = new STypeSelect(t_TypeName);
                    ret.Kind = SParameter.TokenTypeToAttribType(oneToken.TokenType);
                    GetInsideSingleParenthesis(tokenList);
                    foreach (SToken aToken in tokenList)
                    {
                        if (aToken.TokenType == STokenType.SIMPLEID)
                        {
                            ((STypeSelect)ret).SelectList.Add(aToken.StringValue, null);
                        }
                        else
                        { throw new Exception("Syntax error in Select Type Definition : " + ret.Name); }
                    }

                    CleanUpSemiColon();

                    break;


                default:
                    ret = null;
                    if (_logFile != null)
                        _logFile.WriteLine(oneToken.TokenType.ToString() + " : " + oneToken.StringValue);
                    break;
            }
            #endregion // switch
            return ret;
        }

        private void collection(STypeCollection sTypeCol)
        {
            // Left brackett
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            // lbound
            oneToken = SLexer.Tokenizer(_dataStream);
            sTypeCol.LBound = getBound(oneToken);
            oneToken = SLexer.Tokenizer(_dataStream);
            oneToken = SLexer.Tokenizer(_dataStream);
            sTypeCol.UBound = getBound(oneToken);
            // right bracket
            oneToken = SLexer.Tokenizer(_dataStream);
            // of
            oneToken = SLexer.Tokenizer(_dataStream);
            // type
            oneToken = SLexer.Tokenizer(_dataStream);
            SParamType sp = SParameter.TokenTypeToAttribType(oneToken.TokenType);

            switch (oneToken.TokenType)
            {
                case STokenType.BOOLEAN:
                case STokenType.REAL:
                case STokenType.INTEGER:
                case STokenType.LOGICAL:
                case STokenType.NUMBER:
                case STokenType.STRING:
                case STokenType.ARRAY:
                case STokenType.LIST:
                case STokenType.SET:
                case STokenType.BAG:
                    sTypeCol.CollectionType = sp;
                    sTypeCol.CollectionName = SParameter.TypeToString(sp);
                    break;
                case STokenType.SIMPLEID:
                    sTypeCol.CollectionName = oneToken.StringValue;
                    break;
                default:
                    if (_logFile != null)
                        _logFile.WriteLine(oneToken.TokenType.ToString() + " : " + oneToken.StringValue);
                    break;
            }
        }

        private SType getType(string SimpleID)
        {
            if (SchemaSet.TypeList.ContainsKey(SimpleID))
            {
                return SchemaSet.TypeList[SimpleID];
            }
            else
            {
                SType at = new SType(SimpleID);
                SchemaSet.TypeList.Add(SimpleID, at);
                return at;
            }
        }




        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private SToken DummySubLoop()
        {
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            while (oneToken.TokenType == STokenType.SIMPLEID)
            {
                while (oneToken.TokenType != STokenType.SEMICOLON)
                { oneToken = SLexer.Tokenizer(_dataStream); }
                oneToken = SLexer.Tokenizer(_dataStream);
            }
            return oneToken;
        }

        private void IgnoredToken(SToken aToken)
        {
            aToken.StringValue = string.Format("Unprocessed {0} at Row {1}, Column {2} with String Value '{3}'",
                aToken.TokenType.ToString(), SLexer.CurrentRow, SLexer.CurrentColumn, aToken.StringValue);
            _mIgnoredToken.Add(aToken);
        }

        /// <summary>
        /// returns list of schema token surrouned by parenthesis from Stream
        /// </summary>
        /// <param name="tokenList"></param>
        private void GetInsideSingleParenthesis(List<SToken> tokenList)
        {
            tokenList.Clear();
            // dummy token to begin
            SToken oneToken = SLexer.Tokenizer(_dataStream);

            int counter = 0;
            while (oneToken.TokenType != STokenType.RIGHTPARENTHESIS)
            {

                if (counter == 0)
                {
                    if (oneToken.TokenType != STokenType.LEFTPARENTHESIS)
                    { throw new Exception("Syntax error in Single Parenthesis : Type 1"); }
                }
                else
                {
                    oneToken = SLexer.Tokenizer(_dataStream);
                    if (oneToken.TokenType == STokenType.COMMA) { }
                    else if (oneToken.TokenType == STokenType.RIGHTPARENTHESIS)
                    {
                        break;
                    }
                    else
                    { throw new Exception("Syntax error in Single Parenthesis : Type 2"); }

                }

                oneToken = SLexer.Tokenizer(_dataStream);
                if (oneToken.TokenType == STokenType.SIMPLEID)
                {
                    tokenList.Add(oneToken);
                    counter += 1;
                }
                else
                { throw new Exception("Syntax error in Single Parenthesis : Type 3"); }
            }

        }

        private void CleanUpSemiColon()
        {
            // clean up semicolon
            SToken oneToken = SLexer.Tokenizer(_dataStream);
            if (oneToken.TokenType != STokenType.SEMICOLON)
            { throw new Exception("Syntax error : " + SLexer.CurrentRow.ToString() + " : " + SLexer.CurrentColumn.ToString()); }
        }

        #endregion // Parser
    }
}
