using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

using System.Diagnostics;
//using NLog;

using InstanceModel;
using SchemaModel;



namespace EbInstanceModel
{
    public class EarlyBindingInstanceModel
    {



        #region variable



        #region private

        private static readonly Assembly P21Assembly = Assembly.Load(EbConstants.Part21NSName);
        private readonly Assembly _ifcAssembly;

        private uint _index;
        private uint _interval;

        //private readonly static Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly ConcurrentDictionary<uint, P21Instance> _dataSection = new ConcurrentDictionary<uint, P21Instance>();

        private readonly ConcurrentDictionary<string, ConcurrentDictionary<uint, P21Instance>> _dataByType
            = new ConcurrentDictionary<string, ConcurrentDictionary<uint, P21Instance>>();

        private readonly ConcurrentDictionary<uint, ConcurrentDictionary<uint, P21Instance>> _referencedEntities
            = new ConcurrentDictionary<uint, ConcurrentDictionary<uint, P21Instance>>();

        private IDictionary<uint, P21Instance> _getDataByType(string entityName)
        {
            if (!_dataByType.ContainsKey(entityName)) return new Dictionary<uint, P21Instance>();
            return _dataByType[entityName];
        }

        private IDictionary<uint, P21Instance> _getDataByType(Type entityType)
        {
            if (!_dataByType.ContainsKey(entityType.Name)) return new Dictionary<uint, P21Instance>();
            return _dataByType[entityType.Name];
        }

        private IDictionary<uint, P21Instance> _getReferencedEntities(uint entityInstanceName)
        {
            if (!_referencedEntities.ContainsKey(entityInstanceName)) return new Dictionary<uint, P21Instance>();
            return _referencedEntities[entityInstanceName];
        }

        private static readonly EarlyBindingInstanceModel Instance = new EarlyBindingInstanceModel();


        #endregion


        #region parameters


        public static uint Index
        {
            get { return Instance._index; }
        }

        /// <summary>Interval number of instance (e.g. #10, #20)</summary>
        public static uint Interval
        {
            get { return Instance._interval; }
            set { Instance._interval = value; }
        }

        #endregion

        #endregion





        #region private functions

        /// <summary>
        /// Singleton for service
        /// </summary>
        internal EarlyBindingInstanceModel()
        {
            _index = 0;
            _interval = 10;
            //_headerSection = new List<P21Instance>();
            //_p21Assembly  // "EbInstanceModel"
            //var a = RegisteredSchema.IFC2X3.ToString();
            _ifcAssembly = Assembly.Load(RegisteredSchema.IFC2X3.ToString()); // "IFC2X3"
            //PopulateHeader();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="instanceDb"></param>
        private void ConvertToEarlyBinding(InstanceDB instanceDb)
        {
            #region header section
            FILE_DESCRIPTION _fileDescription = null;
            FILE_NAME _fileName = null;
            FILE_SCHEMA _fileSchema = null;

            foreach (var header in instanceDb.HeaderList)
            {
                //FILE_DESCRIPTION fd = new FILE_DESCRIPTION();
                //var aa = fd.GetType().Assembly;
                //var bb = aa.CreateInstance(header.Keyword);
                var obj = Activator.CreateInstance(EbConstants.Part21NSName,
                                                   EbConstants.Part21NSName + "." + header.Keyword);
                var cobj = obj.Unwrap() as P21Instance;

                if (cobj is FILE_DESCRIPTION)
                {
                    var fdesc = cobj as FILE_DESCRIPTION;
                    fdesc.DESCRIPTION = new List<STRING>();
                    var list = header.ParameterList[0] as ParamList;
                    foreach (var item in list.ParameterList)
                    {
                        var str = item as ParamString;
                        fdesc.DESCRIPTION.Add(str.StringValue);
                    }

                    var pstr = header.ParameterList[1] as ParamString;
                    fdesc.IMPLEMTATION_LEVEL = pstr.StringValue;

                    if (fdesc.DESCRIPTION.Count > 0)
                        _fileDescription = fdesc;
                    //_headerSection.Add(fdesc);
                }
                else if (cobj is FILE_NAME)
                {
                    var fname = cobj as FILE_NAME;
                    ParamString pstring;

                    if (header.ParameterList[0].ParameterType == SParamType.STRING)
                    {
                        pstring = header.ParameterList[0] as ParamString;
                        fname.NAME = pstring.StringValue;
                    }
                    if (header.ParameterList[1].ParameterType == SParamType.STRING)
                    {
                        pstring = header.ParameterList[1] as ParamString;
                        fname.TIME_STAMP = new TIME_STAMP_TEXT();
                        fname.TIME_STAMP.Value = pstring.StringValue;
                    }

                    ParamList list;
                    if (header.ParameterList[2].ParameterType == SParamType.SET)
                    {
                        list = header.ParameterList[2] as ParamList;
                        if (list != null && list.ParameterList.Count > 0)
                        {
                            fname.AUTHOR = new List<STRING>();
                            foreach (var item in list.ParameterList)
                            {
                                var str = item as ParamString;
                                fname.AUTHOR.Add(str.StringValue);
                            }
                        }
                    }

                    if (header.ParameterList[3].ParameterType == SParamType.SET)
                    {
                        list = header.ParameterList[3] as ParamList;
                        if (list != null && list.ParameterList.Count > 0)
                        {
                            fname.ORGANIZATION = new List<STRING>();
                            foreach (var item in list.ParameterList)
                            {
                                var str = item as ParamString;
                                fname.ORGANIZATION.Add(str.StringValue);
                            }
                        }
                    }

                    if (header.ParameterList[4].ParameterType == SParamType.STRING)
                    {
                        pstring = header.ParameterList[4] as ParamString;
                        fname.PREPROCESSOR_VERSION = pstring.StringValue;
                    }

                    if (header.ParameterList[5].ParameterType == SParamType.STRING)
                    {
                        pstring = header.ParameterList[5] as ParamString;
                        fname.ORIGINATING_SYSTEM = pstring.StringValue;
                    }

                    if (header.ParameterList[6].ParameterType == SParamType.STRING)
                    {
                        pstring = header.ParameterList[6] as ParamString;
                        fname.AUTHORIZATION = pstring.StringValue;
                    }

                    if (null != fname.NAME)
                    {
                        // _headerSection.Add(fname);
                        _fileName = fname;
                    }
                }
                else if (cobj is FILE_SCHEMA)
                {
                    var fsch = cobj as FILE_SCHEMA;
                    if (header.ParameterList[0].ParameterType == SParamType.SET)
                    {
                        ParamList list = header.ParameterList[0] as ParamList;
                        if (list != null && list.ParameterList.Count > 0)
                        {
                            fsch.SCHEMA_IDENTIFIERS = new List<SCHEMA_NAME>();
                            foreach (var item in list.ParameterList)
                            {
                                var str = item as ParamString;
                                SCHEMA_NAME sname = new SCHEMA_NAME();
                                sname.Value = str.StringValue;
                                fsch.SCHEMA_IDENTIFIERS.Add(sname);
                            }
                        }
                    }
                    if (fsch.SCHEMA_IDENTIFIERS != null && fsch.SCHEMA_IDENTIFIERS.Count > 0)
                    {
                        //_headerSection.Add(fsch);
                        _fileSchema = fsch;
                    }
                }
            }

            if (_fileDescription != null && _fileName != null && _fileSchema != null)
                HeaderSection.SetHeader(_fileSchema, _fileDescription, _fileName);

            #endregion header section

            #region body section



            //foreach (var kvp in instanceDb.DataList)
            //{
            //    if (!_dataSection.ContainsKey(kvp.Key))
            //        ConvertInstance(kvp.Value);
            //}

            foreach (var kvp in instanceDb.DataList.Where(kvp => !_dataSection.ContainsKey(kvp.Key)))
            {
                ConvertInstance(kvp.Value);
            }

            #endregion body section
        }

        private P21Instance ConvertInstance(Instance instance)
        {

            //var name = _ifcAssembly.GetName().Name;
            Type insType = _ifcAssembly.GetType(_ifcAssembly.GetName().Name + "." + instance.Keyword, false, true);
            //var atype = ifcAssembly.GetTypes();
            //var ains = Activator.CreateInstance(_ifcAssemblyName, _ifcAssemblyName + "." + instance.Keyword).Unwrap() as P21Instance;
            var ains = Activator.CreateInstance(insType) as P21Instance;
            if (ains == null) return null;

            ains.EIN = instance.EntityInstanceName;

            AddToData(ains);

            foreach (var parameter in instance.AttributeList)
            {
                ConvertAttribute(parameter, ains);
            }
            return ains;
        }


        private void AddToData(P21Instance p21Instance)
        {

            if (p21Instance.EIN == 0)
            {
                MessageBox.Show("what?");
            }

            _dataSection.TryAdd(p21Instance.EIN, p21Instance);

            var name = p21Instance.GetType().Name;

            if (!_dataByType.ContainsKey(name))
            {
                _dataByType.TryAdd(name, new ConcurrentDictionary<uint, P21Instance>());
            }
            _dataByType[p21Instance.GetType().Name].TryAdd(p21Instance.EIN, p21Instance);


        }


        private void ConvertAttribute(Parameter att, P21Instance p21Instance)
        {
            if (att.ParameterType == SParamType.UNSET) return;
            var attName = att.SchemaAttDef.Name;
            FieldInfo fieldInfo = p21Instance.GetType().GetField(attName);

            object attribute = ConvertSwitch(p21Instance, att);

            if (attribute == null) return;

            if (fieldInfo.FieldType.IsClass)
                fieldInfo.SetValue(p21Instance, attribute);
            else
            {
                if (fieldInfo.FieldType == attribute.GetType())
                {
                    fieldInfo.SetValue(p21Instance, attribute);
                }
                else
                {
                    Type tSelect = fieldInfo.FieldType;
                    var selectAtt = Activator.CreateInstance(tSelect);
                    tSelect.GetField("Value").SetValue(selectAtt, attribute);
                    fieldInfo.SetValue(p21Instance, selectAtt);
                }
            }
        }

        private void AddReferenced(P21Instance host, P21Instance attribute)
        {
            if (!_referencedEntities.ContainsKey(attribute.EIN))
            {
                _referencedEntities.TryAdd(attribute.EIN, new ConcurrentDictionary<uint, P21Instance>());
            }
            _referencedEntities[attribute.EIN].TryAdd(host.EIN, host);
        }

        private object ConvertSwitch(P21Instance p21Instance, Parameter attribute)
        {
            object retValue = null;
            switch (attribute.ParameterType)
            {
                #region case

                case SParamType.ENTITY:

                    #region entity

                    var pop = attribute as ParamEntity;
                    if (pop == null) return null;
                    var value
                        = _dataSection.ContainsKey(pop.EntityInstance.EntityInstanceName)
                              ? _dataSection[pop.EntityInstance.EntityInstanceName]
                              : ConvertInstance(pop.EntityInstance);
                    AddReferenced(p21Instance, value);
                    retValue = value;
                    break;

                    #endregion entity

                case SParamType.NUMBER:
                    if (attribute.SchemaAttDef.Type is SParamNamed)
                    {
                        SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
                        var aparam =
                            //Activator.CreateInstance(_ifcAssemblyName, _ifcAssemblyName + "." + sParam.NamedRefString)
                            Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
                                     .Unwrap() as NUMBER;
                        aparam.Value = ((ParamReal)attribute).RealValue;
                        retValue = aparam;
                    }
                    else
                    {
                        NUMBER realValue = ((ParamReal)attribute).RealValue;
                        retValue = realValue;
                    }
                    break;
                case SParamType.REAL:

                    #region real

                    if (attribute.SchemaAttDef.Type is SParamNamed)
                    {
                        SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
                        var aparam =
                            Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
                                     .Unwrap() as REAL;
                        aparam.Value = ((ParamReal)attribute).RealValue;
                        retValue = aparam;
                    }
                    else
                    {
                        REAL realValue = ((ParamReal)attribute).RealValue;
                        retValue = realValue;
                    }
                    break;

                    #endregion real

                case SParamType.INTEGER:

                    #region integer

                    if (attribute.SchemaAttDef.Type is SParamNamed)
                    {
                        SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
                        var aparam =
                            Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
                                     .Unwrap() as INTEGER;
                        aparam.Value = ((ParamInteger)attribute).IntegerValue;
                        retValue = aparam;
                    }
                    else
                    {
                        INTEGER intValue = ((ParamInteger)attribute).IntegerValue;
                        //fieldInfo.SetValue(ains, intValue);
                        retValue = intValue;
                    }
                    break;

                    #endregion integer

                case SParamType.STRING:

                    #region string

                    if (attribute.SchemaAttDef.Type is SParamNamed)
                    {
                        SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
                        var aparam =
                            Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
                                     .Unwrap() as STRING;
                        aparam.Value = ((ParamString)attribute).StringValue;
                        retValue = aparam;
                    }
                    else
                    {
                        //throw new NotImplementedException();
                        //STRING strValue = ((ParamString)attribute).StringValue;
                        ////fieldInfo.SetValue(ains, strValue);
                        //retValue = strValue;
                    }
                    break;

                    #endregion string

                case SParamType.ENUMERATION:

                    #region enumeration

                    string estr = ((ParamEnum)attribute).EnumerationValueString;
                    SParamNamed eparam = attribute.SchemaAttDef.Type as SParamNamed;

                    var fi = _ifcAssembly.GetType(_ifcAssembly.GetName().Name + "." + eparam.NamedRefString).GetField(estr);
                    retValue = fi.GetValue(null);
                    break;

                    #endregion enumeration

                case SParamType.LOGICAL:
                case SParamType.BOOLEAN:

                    #region boolean

                    if (attribute.SchemaAttDef.Type is SParamNamed)
                    {
                        SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
                        var aparam =
                            Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
                                     .Unwrap();
                        if (aparam is BOOLEAN)
                        {
                            if (((ParamBoolean)attribute).BoolValue == 1)
                            {
                                ((BOOLEAN)aparam).Value = true;
                            }
                            else
                            {
                                ((BOOLEAN)aparam).Value = false;
                            }
                        }
                        else if (aparam is LOGICAL)
                        {
                            ((LOGICAL)aparam).Value = ((ParamBoolean)attribute).BoolValue;
                        }
                        else
                        {
                            throw new InvalidDataException();
                        }
                        retValue = aparam;
                    }
                    else
                    {
                        if (attribute.SchemaAttDef.Type.ParamType == SParamType.BOOLEAN)
                        {
                            BOOLEAN bvalue;
                            if (((ParamBoolean)attribute).BoolValue == 1)
                            {
                                bvalue = true;
                            }
                            else
                                bvalue = false;
                            retValue = bvalue;
                        }
                        else if (attribute.SchemaAttDef.Type.ParamType == SParamType.LOGICAL)
                        {
                            LOGICAL bvalue = new LOGICAL();
                            bvalue.Value = ((ParamBoolean)attribute).BoolValue;
                            retValue = bvalue;
                        }
                        else
                        {
                            throw new InvalidDataException();
                        }
                    }
                    break;

                    #endregion boolean

                case SParamType.SELECT:

                    #region select

                    SParamNamed selectParam = attribute.SchemaAttDef.Type as SParamNamed;

                    var selectAtt =
                        Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + selectParam.NamedRefString)
                                 .Unwrap();

                    ParamSelect paramSelect = attribute as ParamSelect;

                    Type insType = _ifcAssembly.GetType(_ifcAssembly.GetName().Name + "." + paramSelect.SelectName, false, true);
                    var pSelect =
                        //Activator.CreateInstance(insType);
                        Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + insType.Name).Unwrap();

                    switch (paramSelect.SelectValue.ParameterType)
                    {
                        case SParamType.INTEGER:
                            var ri = paramSelect.SelectValue as ParamInteger;
                            ((INTEGER)pSelect).Value = ri.IntegerValue;
                            break;
                        case SParamType.REAL:
                            var rr = paramSelect.SelectValue as ParamReal;
                            ((REAL)pSelect).Value = rr.RealValue;
                            break;
                        case SParamType.STRING:
                            var rs = paramSelect.SelectValue as ParamString;
                            ((STRING)pSelect).Value = rs.StringValue;
                            break;
                        case SParamType.BOOLEAN:
                            var rb = paramSelect.SelectValue as ParamBoolean;
                            ((BOOLEAN)pSelect).Value = rb.BoolValue == 1;
                            break;
                        default:
                            throw new NotImplementedException();
                        //                            break;
                    }
                    Type tSelect = selectAtt.GetType();
                    tSelect.GetField("Value").SetValue(selectAtt, pSelect);

                    retValue = selectAtt;
                    break;

                    #endregion select

                case SParamType.TYPE:

                    #region Type in Collection form

                    SParamNamed tParamName = attribute.SchemaAttDef.Type as SParamNamed;

                    if (tParamName == null)
                    {
                        throw new InvalidCastException();
                    }
                    if (tParamName.NamedReference is STypeCollection)
                    {
                        var stc = tParamName.NamedReference as STypeCollection;

                        var aparam =
                            Activator.CreateInstance(_ifcAssembly.GetName().Name,
                                                     _ifcAssembly.GetName().Name + "." + tParamName.NamedRefString).Unwrap()
                            as IList;

                        ParamList tParamList = attribute as ParamList;

                        switch (stc.CollectionType)
                        {
                            case SParamType.INTEGER:
                                foreach (var pitem in tParamList.ParameterList)
                                {
                                    var p = pitem as ParamInteger;
                                    INTEGER p21Int = p.IntegerValue;
                                    aparam.Add(p21Int);
                                }

                                break;
                            case SParamType.REAL:
                                foreach (var pitem in tParamList.ParameterList)
                                {
                                    var p = pitem as ParamReal;
                                    REAL p21real = p.RealValue;
                                    aparam.Add(p21real);
                                }
                                break;
                            default:
                                throw new NotImplementedException();
                            //                                break;
                        }
                        //fieldInfo.SetValue(ains, aparam);
                        retValue = aparam;
                        //throw new NotImplementedException();
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }

                    break;

                    #endregion Type in Collection form

                case SParamType.UNSET:

                    break;
                case SParamType.SELFDERIVED:

                    #region derived

                    if (attribute.SchemaAttDef.Type is SParamNamed)
                    {
                        var sde = attribute.SchemaAttDef.Type as SParamNamed;
                        var aparam =
                            Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sde.NamedRefString)
                                     .Unwrap();

                        if (aparam.GetType().IsClass)
                        {
                            ((P21Base)aparam).IsDerived = true;
                        }
                        else
                        {
                            Type apType = aparam.GetType();
                            var pbase = new P21Base { IsDerived = true };
                            apType.GetField("Value").SetValue(aparam, pbase);
                        }

                        //aparam.isDerived = true;
                        retValue = aparam;
                    }
                    else
                    {
                        var sde = attribute.SchemaAttDef.Type as SParameter;
                        var aparam =
                            Activator.CreateInstance(EbConstants.Part21NSName,
                                                     EbConstants.Part21NSName + "." + sde.ParamTypeString).Unwrap() as
                            P21Base;
                        aparam.IsDerived = true;
                        retValue = aparam;
                    }

                    break;

                    #endregion derived

                case SParamType.ARRAY:
                case SParamType.LIST:
                case SParamType.SET:
                case SParamType.BAG:

                    #region array

                    SParamCollection collection = attribute.SchemaAttDef.Type as SParamCollection;
                    SParameter pRef = collection.ParamReference;
                    ParamList pList = attribute as ParamList;

                    IList ppList;
                    Type spnType;
                    if (pRef is SParamNamed)
                    {
                        SParamNamed spn = pRef as SParamNamed;
                        //spnType = Type.GetType(_ifcAssemblyName + "." + spn.NamedRefString);
                        spnType = _ifcAssembly.GetType(_ifcAssembly.GetName().Name + "." + spn.NamedRefString);

                        var a = typeof(System.Collections.Generic.List<>);

                        Type listType = a.MakeGenericType(spnType);
                        // Type.GetType("System.Collections.Generic.List").MakeGenericType(spnType);
                        //Type.GetType("System.Collections.Generic.List").MakeGenericType(spnType);
                        ppList = Activator.CreateInstance(listType) as IList;
                    }
                    else if (pRef is SParamCollection)
                    {
                        throw new NotImplementedException();
                    }
                    else
                    {
                        //string assm = EbConstants.Part21NSName+"." + pRef.ParamTypeString + ", " + p21Assembly.FullName;
                        spnType = P21Assembly.GetType(EbConstants.Part21NSName + "." + pRef.ParamTypeString);
                        //Type.GetType(assm);

                        var a = typeof(System.Collections.Generic.List<>);
                        Type listType = a.MakeGenericType(spnType);
                        //Type.GetType("System.Collections.Generic.List").MakeGenericType(spnType);
                        //Type.GetType("System.Collections.Generic.List").MakeGenericType(spnType);
                        ppList = Activator.CreateInstance(listType) as IList;
                    }

                    if (pList.ParameterList.Count > 0)
                    {
                        foreach (var pItem in pList.ParameterList)
                        {
                            var convItem = ConvertSwitch(p21Instance, pItem);
                            if (convItem == null) continue;

                            if (spnType.IsClass)
                                ppList.Add(convItem);
                            else
                            {
                                var sAtt = Activator.CreateInstance(spnType);
                                Type tSel = sAtt.GetType();
                                while (!(convItem is P21Base))
                                {
                                    convItem = convItem.GetType().GetField("Value").GetValue(convItem);
                                }

                                tSel.GetField("Value").SetValue(sAtt, convItem);
                                ppList.Add(sAtt);
                            }
                        }
                    }

                    //fieldInfo.SetValue(ains, ppList);

                    retValue = ppList;
                    break;

                    #endregion array

                default:
                    throw new NotImplementedException();
                //                    break;

                #endregion case
            }

            return retValue;
        }


        /// <summary>
        /// Write P21 instance file
        /// </summary>
        /// <param name="aFile">stream writer</param>
        public void WriteToP21(StreamWriter aFile)
        {
            aFile.WriteLine(P21Writer.ISOstr);
            aFile.WriteLine(P21Writer.HEADERstr);

            foreach (P21Instance t in HeaderSection.HeaderInstances)
            {
                t.WriteToP21(aFile);
                aFile.WriteLine(";");
            }

            aFile.WriteLine(P21Writer.ENDSECstr);

            aFile.WriteLine(P21Writer.DATAstr);

            foreach (var kvp in _dataSection)
            {
                aFile.Write("#");
                aFile.Write(kvp.Key);
                aFile.Write("=");
                kvp.Value.WriteToP21(aFile);
                aFile.WriteLine(";");
            }

            aFile.WriteLine(P21Writer.ENDSECstr);

            aFile.WriteLine(P21Writer.ENDISOstr);
        }

        /// <summary>(
        /// IFC MODEL Reader
        /// </summary>
        /// <param name="p21FileName">Filename to read</param>
        private EarlyBindingInstanceModel(string p21FileName)
            : this()
        {
            var model = new InstanceDB(p21FileName);
            ConvertToEarlyBinding(model);
        }


        /// <summary>
        /// use this function
        /// </summary>
        /// <param name="sData"></param>
        /// <param name="instanceDb"></param>
        private void AssignEntityDefToInstance(SData sData, InstanceDB instanceDb)
        {

            foreach (KeyValuePair<uint, Instance> kvp in instanceDb.DataList)
            {
                if (kvp.Value is InstanceSimple)
                {
                    var sInstance = kvp.Value as InstanceSimple;

                    var sEntity = sData.EntityList[sInstance.Keyword];

                    AddSimpleDef(sInstance, sEntity);
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


        private void AddSimpleDef(InstanceSimple instanceSimple, SEntity sEntity)
        {
            var j = 0;
            foreach (var t in sEntity.FlatList)
            {
                if (t is SAttributeInverse) continue;
                var parameter = instanceSimple.AttributeList[j];
                var sAttribute = t;
                AddAttributeDef(parameter, sAttribute);
                j++;
            }
        }


        private void AddAttributeDef(Parameter parameter, SAttribute sAtt)
        {

            if (parameter.ParameterType == SParamType.UNSET) return;

            parameter.SchemaAttDef = sAtt;


            if (parameter.ParameterType == SParamType.SET)
            {
                var sparam = sAtt.Type as SParamCollection;
                var pList = parameter as ParamList;
                if (sparam == null || pList == null) return;
                foreach (var item in pList.ParameterList)
                {
                    item.SchemaAttDef = new SAttribute(null, sparam.ParamReference);
                }
                parameter.updateParameterType(sAtt.Type.ParamType);
            }


        }


        private void Clear()
        {
            _dataSection.Clear();
            _dataByType.Clear();
            _referencedEntities.Clear();
        }



        #endregion


        #region static public

        public static void Reset()
        {
            Instance._index = 0;
            Instance._interval = 10;
            Instance.Clear();
        }


        public static bool Read(string filename)
        {
            //var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            //if (directoryInfo == null) return false;
            //if (directoryInfo.Parent == null) return false;
            //var sampleLoc = directoryInfo.Parent.FullName;

            //var model = new InstanceDB(
            //    sampleLoc + @"\IFC2X3_TC1.exp",
            //    filename,
            //    sampleLoc + @"\ins.log");
            //Instance.ConvertToEarlyBinding(model);
            //return true;
            return Read(RegisteredSchema.IFC2X3, filename);
        }


        /// <summary>
        /// Populate an instance file into earlybiding data structure according to the specified schema name
        /// </summary>
        /// <param name="schemaName">The name has to be either IFC2X3_TC1 or IFC4</param>
        /// <param name="p21FileName">file name</param>
        /// <returns></returns>
        public static bool Read(string schemaName, string p21FileName)
        {
            try
            {
                var registeredSchema = (RegisteredSchema) Enum.Parse(typeof (RegisteredSchema), schemaName, false);
                return Read(registeredSchema, p21FileName);
            }
            catch (ArgumentNullException )
            {
                MessageBox.Show(string.Format("{0} is not a predefined schema name.", schemaName));
                return false;
            }

        }


        public static bool Read(RegisteredSchema schemaName, string p21FileName)
        {
            try
            {
                var p21 = new InstanceDB(p21FileName);
                var sData = SParser.ReadSchema(schemaName);
                Instance.AssignEntityDefToInstance(sData, p21);
                Instance.ConvertToEarlyBinding(p21);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("There was an error in parsing {0}.", Path.GetFileName(p21FileName)));
                return false;
            }
           
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p21Instance"></param>
        /// <returns></returns>
        public static uint Add(P21Instance p21Instance)
        {
            if (p21Instance == null) return 0;

            if (p21Instance.IsDerived) return 0;


            if (p21Instance.EIN <= 0)
            {

                Instance._index = Instance._index + Instance._interval;
            }
            //else
            //{
            //    throw new NotSupportedException();
            //}
            //else
            //{
            //    Instance._index = p21Instance.EIN;
            //}

            return Add(Instance._index, p21Instance);

        }

        public static uint Add(uint index, P21Instance p21Instance)
        {
            if (p21Instance == null) return 0;
            if (Instance._dataSection.ContainsKey(index)) return 0;
            if (!Instance._dataSection.TryAdd(index, p21Instance)) return 0;


            var name = p21Instance.GetType().Name;

            if (!Instance._dataByType.ContainsKey(name))
            {
                Instance._dataByType.TryAdd(name, new ConcurrentDictionary<uint, P21Instance>());
            }
            Instance._dataByType[p21Instance.GetType().Name].TryAdd(p21Instance.EIN, p21Instance);



            p21Instance.EIN = index;


            foreach (FieldInfo field in p21Instance.GetType().GetFields())
            {
                var ins = field.GetValue(p21Instance) as P21Instance;
                if (ins != null)
                {
                    Add(ins);
                    continue;
                }

                if (field.FieldType.IsValueType)
                {
                    var sel = field.GetValue(p21Instance);
                    var selval = sel.GetType().GetField("Value");
                    if (selval != null)
                    {
                        var select = selval.GetValue(sel) as P21Instance;

                        if (select != null)
                        {
                            Add(select);
                            continue;
                        }
                    }

                }


                if (!field.FieldType.IsGenericType) continue;
                var listIns = field.GetValue(p21Instance) as IList;
                if (listIns == null) continue;
                foreach (var instance in listIns)
                {
                    //if(instance == null) continue;
                    
                    if (instance.GetType().IsSubclassOf(typeof(P21Instance)))
                    {
                        Add((P21Instance)instance);
                        continue;

                    }

                    var valField = instance.GetType().GetField("Value");
                    if (valField != null)
                    {
                        var select = valField.GetValue(instance) as P21Instance;

                        if (select != null)
                        {
                            Add(select);
                            continue;
                        }
                    }

                }
                //string a = listIns.ToString();
            }

            return p21Instance.EIN;
        }

        public static P21Instance Get(uint ein)
        {
            return Instance._dataSection.ContainsKey(ein) ? Instance._dataSection[ein] : null;
        }

        private static ConcurrentDictionary<uint, P21Instance> DataSection
        {
            get { return Instance._dataSection; }
        }


        public static bool Write(string filename)
        {
            try
            {
                //Header.WriteHeader(filename);
                using (var sw = new StreamWriter(filename))
                {
                    sw.WriteLine(EbConstants.ISOstr);
                    sw.WriteLine(EbConstants.HEADERstr);

                    //HeaderSection.SetHeader(EbConstants.Em11MvdName, Path.GetFileName(filename),
                    //EbConstants.DefaultOrganization, _ifcAssembly.GetName().Name);

                    HeaderSection.WriteToP21(sw);

                    sw.WriteLine(EbConstants.ENDSECstr);
                    sw.WriteLine();
                    sw.WriteLine(EbConstants.DATAstr);

                    var sorted =
                        (from x in DataSection
                         orderby x.Key
                         select x).ToList();

                    foreach (var kvp in sorted)
                    {
                        // added to handle NULL derived instance created for flaggin 
                        // ???
                        if (kvp.Value.IsDerived) continue;

                        sw.Write(EbConstants.Sharp);
                        sw.Write(kvp.Key);
                        sw.Write(EbConstants.Equal);
                        kvp.Value.WriteToP21(sw);
                        sw.WriteLine(EbConstants.SemiColon);
                    }

                    sw.WriteLine(EbConstants.ENDSECstr);
                    sw.WriteLine(EbConstants.ENDISOstr);
                }


            }
            catch (Exception ex)
            {
                var fileInfo = new StackFrame(true);
                //Logger.Debug(string.Format("File : {0}\nLine : {1}\nException : {2}\nTrace : {3}",
                //                            fileInfo.GetFileName(), fileInfo.GetFileLineNumber(), ex.Message,
                //                            ex.StackTrace));
            }
            return true;
        }


        public static IDictionary<uint, P21Instance> GetDataByType(string entityName)
        {
            //if (!DataByType.ContainsKey(entityName)) return new Dictionary<uint, P21Instance>();
            return Instance._getDataByType(entityName);
        }


        public static IDictionary<uint, P21Instance> GetDataByType(Type entityType)
        {
            return Instance._getDataByType(entityType);
        }


        public static IDictionary<uint, P21Instance> GetReferencedEntities(uint entityInstanceName)
        {
            return Instance._getReferencedEntities(entityInstanceName);
        }





        #endregion


        #region commented out


        //private static IEnumerable<P21Instance> HeaderSection
        //{
        //    get { return Instance._headerSection; }
        //}


        //private void PopulateHeader(StreamWriter sw)
        //{
        //    //            sw.WriteLine(EbConstants.ISOstr);
        //    //            sw.WriteLine(EbConstants.HEADERstr);

        //    var fileStream = sw.BaseStream as FileStream;
        //    if (fileStream != null)
        //    {
        //        HeaderSection.SetHeader(Constants.DefaultModelViewName, Path.GetFileName(fileStream.Name),
        //            Constants.DefaultOrganization, Constants.Ifc2X3Name);
        //    }
        //    //Header.SetName(Path.GetFileName(fileStream.Name));
        //    //Header.Schema = "aade";
        //    //Header.Organization = "adadf";
        //    //Header.OriginatingSystem = "gt toolikt";

        //    //_headerSection.Add(HeaderSection.GetHeaderDescription());
        //    ////            sw.WriteLine(EbConstants.SemiColon);
        //    //_headerSection.Add(HeaderSection.GetHeaderFilename());
        //    ////            sw.WriteLine(EbConstants.SemiColon);
        //    //_headerSection.Add(HeaderSection.GetHeaderFileSchema());
        //    ////            sw.WriteLine(EbConstants.SemiColon);
        //    ////            sw.WriteLine(EbConstants.ENDSECstr);
        //    ////            sw.WriteLine();
        //    ////            sw.WriteLine(EbConstants.DATAstr);
        //}

        //public partial class EarlyBindingInstanceModel
        //{
        //private readonly ConcurrentDictionary<uint, P21Instance> _dataSection = new ConcurrentDictionary<uint, P21Instance>();

        //private readonly ConcurrentDictionary<string, ConcurrentDictionary<uint, P21Instance>> _dataByType
        //    = new ConcurrentDictionary<string, ConcurrentDictionary<uint, P21Instance>>();

        //private readonly ConcurrentDictionary<uint, ConcurrentDictionary<uint, P21Instance>> _referencedEntities
        //    = new ConcurrentDictionary<uint, ConcurrentDictionary<uint, P21Instance>>();


        //private IDictionary<uint, P21Instance> _getDataByType(string entityName)
        //{
        //    if (!_dataByType.ContainsKey(entityName)) return new Dictionary<uint, P21Instance>();
        //    return _dataByType[entityName];
        //}

        //public static IDictionary<uint, P21Instance> GetDataByType(string entityName)
        //{
        //    //if (!DataByType.ContainsKey(entityName)) return new Dictionary<uint, P21Instance>();
        //    return TheModel._getDataByType(entityName);
        //}

        //private IDictionary<uint, P21Instance> _getDataByType(Type entityType)
        //{
        //    if (!_dataByType.ContainsKey(entityType.Name)) return new Dictionary<uint, P21Instance>();
        //    return _dataByType[entityType.Name];
        //}

        //public static IDictionary<uint, P21Instance> GetDataByType(Type entityType)
        //{
        //    return TheModel._getDataByType(entityType);
        //}

        //private IDictionary<uint, P21Instance> _getReferencedEntities(uint entityInstanceName)
        //{
        //    if (!_referencedEntities.ContainsKey(entityInstanceName)) return new Dictionary<uint, P21Instance>();
        //    return _referencedEntities[entityInstanceName];
        //}

        //public static IDictionary<uint, P21Instance> GetReferencedEntities(uint entityInstanceName)
        //{
        //    return TheModel._getReferencedEntities(entityInstanceName);
        //}

        //private readonly List<P21Instance> _headerSection = new List<P21Instance>();

        //private readonly Assembly _p21Assembly = Assembly.Load(EbConstants.Part21NSName);
        //private readonly Assembly _ifcAssembly = Assembly.Load(_ifcAssembly.GetName().Name);

        //private readonly string _ifcAssemblyName;

        //public static EarlyBindingInstanceModel TheModel;


        //public EarlyBindingInstanceModel()
        //{
        //    //p21Assembly 
        //    //ifcAssembly 
        //    _ifcAssemblyName = _ifcAssembly.GetName().Name;
        //}





        ///// <summary>
        ///// use this function
        ///// </summary>
        ///// <param name="sData"></param>
        ///// <param name="instanceDb"></param>
        //private void AssignEntityDefToInstance(SData sData, InstanceDB instanceDb)
        //{

        //    foreach (KeyValuePair<uint, Instance> kvp in instanceDb.DataList)
        //    {
        //        if (kvp.Value is InstanceSimple)
        //        {
        //            var sInstance = kvp.Value as InstanceSimple;

        //            var sEntity = sData.EntityList[sInstance.Keyword];

        //            AddSimpleDef(sInstance, sEntity);
        //        }
        //        else if (kvp.Value is InstanceComplex)
        //        {
        //            // need to implement
        //        }
        //        else
        //        {
        //            throw new InvalidDataException(
        //                string.Format("Undefined instantiation of instance at {0} : {1}",
        //                              kvp.Value.EntityInstanceName, kvp.Value.Keyword));
        //        }
        //    }
        //}


        //private void AddSimpleDef(InstanceSimple instanceSimple, SEntity sEntity)
        //{
        //    var j = 0;
        //    foreach (var t in sEntity.FlatList)
        //    {
        //        if (t is SAttributeInverse) continue;
        //        var parameter = instanceSimple.AttributeList[j];
        //        var sAttribute = t;
        //        AddAttributeDef(parameter, sAttribute);
        //        j++;
        //    }
        //}


        //private void AddAttributeDef(Parameter parameter, SAttribute sAtt)
        //{

        //    if (parameter.ParameterType == SParamType.UNSET) return;

        //    parameter.SchemaAttDef = sAtt;


        //    if (parameter.ParameterType == SParamType.SET)
        //    {
        //        var sparam = sAtt.Type as SParamCollection;
        //        var pList = parameter as ParamList;
        //        if (sparam == null || pList == null) return;
        //        foreach (var item in pList.ParameterList)
        //        {
        //            item.SchemaAttDef = new SAttribute(null, sparam.ParamReference);
        //        }
        //        parameter.updateParameterType(sAtt.Type.ParamType);
        //    }

        //}


        //public static EarlyBindingInstanceModel ReadP21File(string schemaName, string p21FileName)
        //{
        //    try
        //    {
        //        var registeredSchema = (RegisteredSchema)Enum.Parse(typeof(RegisteredSchema), schemaName, false);
        //        var model = new EarlyBindingInstanceModel();
        //        var p21 = new InstanceDB(p21FileName);
        //        var sData = SParser.ReadSchema(registeredSchema);
        //        model.AssignEntityDefToInstance(sData, p21);
        //        model.ConvertToEarlyBinding(p21);
        //        TheModel = model;
        //    }
        //    catch (ArgumentException)
        //    {
        //        MessageBox.Show("{0} is not a predefined schema name.", schemaName);
        //    }


        //    return TheModel;
        //}


        ///// <summary>
        ///// Convert late binding p21 file (instance model) to early binding model (p21 instance Db)
        ///// </summary>
        ///// <param name="instanceDB"></param>
        //private void ConvertToEarlyBinding(InstanceDB instanceDB)
        //{
        //    #region header section

        //    FILE_DESCRIPTION _fileDescription = null;
        //    FILE_NAME _fileName = null;
        //    FILE_SCHEMA _fileSchema = null;

        //    foreach (var header in instanceDB.HeaderList)
        //    {
        //        #region foreach headerlist

        //        var obj = Activator.CreateInstance(EbConstants.Part21NSName, EbConstants.Part21NSName + "." + header.Keyword);
        //        var cobj = obj.Unwrap() as P21Instance;

        //        if (cobj is FILE_DESCRIPTION)
        //        {
        //            var fdesc = cobj as FILE_DESCRIPTION;
        //            fdesc.DESCRIPTION = new List<STRING>();
        //            var list = header.ParameterList[0] as ParamList;
        //            foreach (var item in list.ParameterList)
        //            {
        //                var str = item as ParamString;
        //                fdesc.DESCRIPTION.Add(str.StringValue);
        //            }

        //            var pstr = header.ParameterList[1] as ParamString;
        //            fdesc.IMPLEMTATION_LEVEL = pstr.StringValue;

        //            if (fdesc.DESCRIPTION.Count > 0)
        //                _fileDescription = fdesc;
        //        }
        //        else if (cobj is FILE_NAME)
        //        {
        //            var fname = cobj as FILE_NAME;
        //            ParamString pstring;

        //            if (header.ParameterList[0].ParameterType == SParamType.STRING)
        //            {
        //                pstring = header.ParameterList[0] as ParamString;
        //                fname.NAME = pstring.StringValue;
        //            }
        //            if (header.ParameterList[1].ParameterType == SParamType.STRING)
        //            {
        //                pstring = header.ParameterList[1] as ParamString;
        //                fname.TIME_STAMP = new TIME_STAMP_TEXT();
        //                fname.TIME_STAMP.Value = pstring.StringValue;
        //            }

        //            ParamList list;
        //            if (header.ParameterList[2].ParameterType == SParamType.SET)
        //            {
        //                list = header.ParameterList[2] as ParamList;
        //                if (list != null && list.ParameterList.Count > 0)
        //                {
        //                    fname.AUTHOR = new List<STRING>();
        //                    foreach (var item in list.ParameterList)
        //                    {
        //                        var str = item as ParamString;
        //                        fname.AUTHOR.Add(str.StringValue);
        //                    }
        //                }
        //            }

        //            if (header.ParameterList[3].ParameterType == SParamType.SET)
        //            {
        //                list = header.ParameterList[3] as ParamList;
        //                if (list != null && list.ParameterList.Count > 0)
        //                {
        //                    fname.ORGANIZATION = new List<STRING>();
        //                    foreach (var item in list.ParameterList)
        //                    {
        //                        var str = item as ParamString;
        //                        fname.ORGANIZATION.Add(str.StringValue);
        //                    }
        //                }
        //            }

        //            if (header.ParameterList[4].ParameterType == SParamType.STRING)
        //            {
        //                pstring = header.ParameterList[4] as ParamString;
        //                fname.PREPROCESSOR_VERSION = pstring.StringValue;
        //            }

        //            if (header.ParameterList[5].ParameterType == SParamType.STRING)
        //            {
        //                pstring = header.ParameterList[5] as ParamString;
        //                fname.ORIGINATING_SYSTEM = pstring.StringValue;
        //            }

        //            if (header.ParameterList[6].ParameterType == SParamType.STRING)
        //            {
        //                pstring = header.ParameterList[6] as ParamString;
        //                fname.AUTHORIZATION = pstring.StringValue;
        //            }

        //            if (null != fname.NAME)
        //            {
        //                _fileName = fname;
        //            }
        //        }
        //        else if (cobj is FILE_SCHEMA)
        //        {
        //            var fsch = cobj as FILE_SCHEMA;
        //            if (header.ParameterList[0].ParameterType == SParamType.SET)
        //            {
        //                ParamList list = header.ParameterList[0] as ParamList;
        //                if (list != null && list.ParameterList.Count > 0)
        //                {
        //                    fsch.SCHEMA_IDENTIFIERS = new List<SCHEMA_NAME>();
        //                    foreach (var item in list.ParameterList)
        //                    {
        //                        var str = item as ParamString;
        //                        SCHEMA_NAME sname = new SCHEMA_NAME();
        //                        sname.Value = str.StringValue;
        //                        fsch.SCHEMA_IDENTIFIERS.Add(sname);
        //                    }
        //                }
        //            }
        //            if (fsch.SCHEMA_IDENTIFIERS != null && fsch.SCHEMA_IDENTIFIERS.Count > 0)
        //            { _fileSchema = fsch; }
        //        }
        //        #endregion
        //    }

        //    if (_fileDescription != null && _fileName != null && _fileSchema != null)
        //        HeaderSection.SetHeader(_fileSchema, _fileDescription, _fileName);

        //    #endregion header section

        //    #region body section

        //    foreach (var kvp in instanceDB.DataList)
        //    {
        //        if (!_dataSection.ContainsKey(kvp.Key))
        //            AddInstance(kvp.Value);
        //    }

        //    #endregion body section
        //}

        //private P21Instance AddInstance(Instance p21Instance)
        //{
        //    Type insType = _ifcAssembly.GetType(_ifcAssembly.GetName().Name + "." + p21Instance.Keyword, false, true);
        //    if (insType == null) return null;

        //    var ains = Activator.CreateInstance(insType) as P21Instance;
        //    ains.EIN = p21Instance.EntityInstanceName;
        //    _dataSection.TryAdd(ains.EIN, ains);

        //    foreach (var att in p21Instance.AttributeList)
        //    {
        //        var attName = att.SchemaAttDef.Name;
        //        FieldInfo fieldInfo = insType.GetField(attName);

        //        object attribute = ConvertSwitch(ains, att);
        //        if (attribute == null) continue;

        //        if (fieldInfo.FieldType.IsClass)
        //            fieldInfo.SetValue(ains, attribute);
        //        else
        //        {
        //            if (fieldInfo.FieldType == attribute.GetType())
        //            {
        //                fieldInfo.SetValue(ains, attribute);
        //            }
        //            else
        //            {
        //                Type tSelect = fieldInfo.FieldType;
        //                var selectAtt = Activator.CreateInstance(tSelect);
        //                tSelect.GetField("Value").SetValue(selectAtt, attribute);
        //                fieldInfo.SetValue(ains, selectAtt);
        //            }
        //        }
        //    }
        //    return ains;
        //}


        //private object ConvertSwitch(P21Instance p21Instance, Parameter attribute)
        //{
        //    object retValue = null;
        //    switch (attribute.ParameterType)
        //    {
        //        #region case

        //        case SParamType.ENTITY:

        //            #region entity

        //            var pop = attribute as ParamEntity;
        //            if (pop == null) return null;
        //            var value
        //                = _dataSection.ContainsKey(pop.EntityInstance.EntityInstanceName)
        //                      ? _dataSection[pop.EntityInstance.EntityInstanceName]
        //                      : ConvertInstance(pop.EntityInstance);
        //            AddReferenced(p21Instance, value);
        //            retValue = value;
        //            break;

        //            #endregion entity

        //        case SParamType.NUMBER:
        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam =
        //                    Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
        //                             .Unwrap() as NUMBER;
        //                aparam.Value = ((ParamReal)attribute).RealValue;
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                NUMBER realValue = ((ParamReal)attribute).RealValue;
        //                retValue = realValue;
        //            }
        //            break;
        //        case SParamType.REAL:

        //            #region real

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam =
        //                    Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
        //                             .Unwrap() as REAL;
        //                aparam.Value = ((ParamReal)attribute).RealValue;
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                REAL realValue = ((ParamReal)attribute).RealValue;
        //                retValue = realValue;
        //            }
        //            break;

        //            #endregion real

        //        case SParamType.INTEGER:

        //            #region integer

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam =
        //                    Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
        //                             .Unwrap() as INTEGER;
        //                aparam.Value = ((ParamInteger)attribute).IntegerValue;
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                INTEGER intValue = ((ParamInteger)attribute).IntegerValue;
        //                //fieldInfo.SetValue(ains, intValue);
        //                retValue = intValue;
        //            }
        //            break;

        //            #endregion integer

        //        case SParamType.STRING:

        //            #region string

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam =
        //                    Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
        //                             .Unwrap() as STRING;
        //                aparam.Value = ((ParamString)attribute).StringValue;
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                //throw new NotImplementedException();
        //                //STRING strValue = ((ParamString)attribute).StringValue;
        //                ////fieldInfo.SetValue(ains, strValue);
        //                //retValue = strValue;
        //            }
        //            break;

        //            #endregion string

        //        case SParamType.ENUMERATION:

        //            #region enumeration

        //            string estr = ((ParamEnum)attribute).EnumerationValueString;
        //            SParamNamed eparam = attribute.SchemaAttDef.Type as SParamNamed;

        //            var fi = _ifcAssembly.GetType(_ifcAssembly.GetName().Name + "." + eparam.NamedRefString).GetField(estr);
        //            retValue = fi.GetValue(null);
        //            break;

        //            #endregion enumeration

        //        case SParamType.LOGICAL:
        //        case SParamType.BOOLEAN:

        //            #region boolean

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam =
        //                    Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + sParam.NamedRefString)
        //                             .Unwrap();
        //                if (aparam is BOOLEAN)
        //                {
        //                    if (((ParamBoolean)attribute).BoolValue == 1)
        //                    {
        //                        ((BOOLEAN)aparam).Value = true;
        //                    }
        //                    else
        //                    {
        //                        ((BOOLEAN)aparam).Value = false;
        //                    }
        //                }
        //                else if (aparam is LOGICAL)
        //                {
        //                    ((LOGICAL)aparam).Value = ((ParamBoolean)attribute).BoolValue;
        //                }
        //                else
        //                {
        //                    throw new InvalidDataException();
        //                }
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                if (attribute.SchemaAttDef.Type.ParamType == SParamType.BOOLEAN)
        //                {
        //                    BOOLEAN bvalue;
        //                    if (((ParamBoolean)attribute).BoolValue == 1)
        //                    {
        //                        bvalue = true;
        //                    }
        //                    else
        //                        bvalue = false;
        //                    retValue = bvalue;
        //                }
        //                else if (attribute.SchemaAttDef.Type.ParamType == SParamType.LOGICAL)
        //                {
        //                    LOGICAL bvalue = new LOGICAL();
        //                    bvalue.Value = ((ParamBoolean)attribute).BoolValue;
        //                    retValue = bvalue;
        //                }
        //                else
        //                {
        //                    throw new InvalidDataException();
        //                }
        //            }
        //            break;

        //            #endregion boolean

        //        case SParamType.SELECT:

        //            #region select

        //            SParamNamed selectParam = attribute.SchemaAttDef.Type as SParamNamed;

        //            var selectAtt =
        //                Activator.CreateInstance(_ifcAssembly.GetName().Name, _ifcAssembly.GetName().Name + "." + selectParam.NamedRefString)
        //                         .Unwrap();

        //            ParamSelect paramSelect = attribute as ParamSelect;

        //            Type insType = _ifcAssembly.GetType(_ifcAssembly.GetName().Name + "." + paramSelect.SelectName, false, true);
        //            var pSelect =
        //                //Activator.CreateInstance(insType);
        //                Activator.CreateInstance(_ifcAssembly.GetName().Name, EbConstants.Ifc2X3Name + "." + insType.Name).Unwrap();

        //            switch (paramSelect.SelectValue.ParameterType)
        //            {
        //                case SParamType.INTEGER:
        //                    var ri = paramSelect.SelectValue as ParamInteger;
        //                    ((INTEGER)pSelect).Value = ri.IntegerValue;
        //                    break;
        //                case SParamType.REAL:
        //                    var rr = paramSelect.SelectValue as ParamReal;
        //                    ((REAL)pSelect).Value = rr.RealValue;
        //                    break;
        //                case SParamType.STRING:
        //                    var rs = paramSelect.SelectValue as ParamString;
        //                    ((STRING)pSelect).Value = rs.StringValue;
        //                    break;
        //                case SParamType.BOOLEAN:
        //                    var rb = paramSelect.SelectValue as ParamBoolean;
        //                    ((BOOLEAN)pSelect).Value = rb.BoolValue == 1;
        //                    break;
        //                default:
        //                    throw new NotImplementedException();
        //                //                            break;
        //            }
        //            Type tSelect = selectAtt.GetType();
        //            tSelect.GetField("Value").SetValue(selectAtt, pSelect);

        //            retValue = selectAtt;
        //            break;

        //            #endregion select

        //        case SParamType.TYPE:

        //            #region Type in Collection form

        //            SParamNamed tParamName = attribute.SchemaAttDef.Type as SParamNamed;

        //            if (tParamName == null)
        //            {
        //                throw new InvalidCastException();
        //            }
        //            if (tParamName.NamedReference is STypeCollection)
        //            {
        //                var stc = tParamName.NamedReference as STypeCollection;

        //                var aparam =
        //                    Activator.CreateInstance(EbConstants.Ifc2X3Name,
        //                                             EbConstants.Ifc2X3Name + "." + tParamName.NamedRefString).Unwrap()
        //                    as IList;

        //                ParamList tParamList = attribute as ParamList;

        //                switch (stc.CollectionType)
        //                {
        //                    case SParamType.INTEGER:
        //                        foreach (var pitem in tParamList.ParameterList)
        //                        {
        //                            var p = pitem as ParamInteger;
        //                            INTEGER p21Int = p.IntegerValue;
        //                            aparam.Add(p21Int);
        //                        }

        //                        break;
        //                    case SParamType.REAL:
        //                        foreach (var pitem in tParamList.ParameterList)
        //                        {
        //                            var p = pitem as ParamReal;
        //                            REAL p21real = p.RealValue;
        //                            aparam.Add(p21real);
        //                        }
        //                        break;
        //                    default:
        //                        throw new NotImplementedException();
        //                    //                                break;
        //                }
        //                //fieldInfo.SetValue(ains, aparam);
        //                retValue = aparam;
        //                //throw new NotImplementedException();
        //            }
        //            else
        //            {
        //                throw new NotImplementedException();
        //            }

        //            break;

        //            #endregion Type in Collection form

        //        case SParamType.UNSET:

        //            break;
        //        case SParamType.SELFDERIVED:

        //            #region derived

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                var sde = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam =
        //                    Activator.CreateInstance(EbConstants.Ifc2X3Name, EbConstants.Ifc2X3Name + "." + sde.NamedRefString)
        //                             .Unwrap();

        //                if (aparam.GetType().IsClass)
        //                {
        //                    ((P21Base)aparam).IsDerived = true;
        //                }
        //                else
        //                {
        //                    Type apType = aparam.GetType();
        //                    var pbase = new P21Base { IsDerived = true };
        //                    apType.GetField("Value").SetValue(aparam, pbase);
        //                }

        //                //aparam.isDerived = true;
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                var sde = attribute.SchemaAttDef.Type as SParameter;
        //                var aparam =
        //                    Activator.CreateInstance(EbConstants.Part21NSName,
        //                                             EbConstants.Part21NSName + "." + sde.ParamTypeString).Unwrap() as
        //                    P21Base;
        //                aparam.IsDerived = true;
        //                retValue = aparam;
        //            }

        //            break;

        //            #endregion derived

        //        case SParamType.ARRAY:
        //        case SParamType.LIST:
        //        case SParamType.SET:
        //        case SParamType.BAG:

        //            #region array

        //            SParamCollection collection = attribute.SchemaAttDef.Type as SParamCollection;
        //            SParameter pRef = collection.ParamReference;
        //            ParamList pList = attribute as ParamList;

        //            IList ppList;
        //            Type spnType;
        //            if (pRef is SParamNamed)
        //            {
        //                SParamNamed spn = pRef as SParamNamed;
        //                //spnType = Type.GetType(_ifcAssemblyName + "." + spn.NamedRefString);
        //                spnType = _ifcAssembly.GetType(EbConstants.Ifc2X3Name + "." + spn.NamedRefString);

        //                var a = typeof(System.Collections.Generic.List<>);

        //                Type listType = a.MakeGenericType(spnType);
        //                // Type.GetType("System.Collections.Generic.List").MakeGenericType(spnType);
        //                //Type.GetType("System.Collections.Generic.List").MakeGenericType(spnType);
        //                ppList = Activator.CreateInstance(listType) as IList;
        //            }
        //            else if (pRef is SParamCollection)
        //            {
        //                throw new NotImplementedException();
        //            }
        //            else
        //            {
        //                //string assm = EbConstants.Part21NSName+"." + pRef.ParamTypeString + ", " + p21Assembly.FullName;
        //                spnType = _p21Assembly.GetType(EbConstants.Part21NSName + "." + pRef.ParamTypeString);
        //                //Type.GetType(assm);

        //                var a = typeof(System.Collections.Generic.List<>);
        //                Type listType = a.MakeGenericType(spnType);
        //                //Type.GetType("System.Collections.Generic.List").MakeGenericType(spnType);
        //                //Type.GetType("System.Collections.Generic.List").MakeGenericType(spnType);
        //                ppList = Activator.CreateInstance(listType) as IList;
        //            }

        //            if (pList.ParameterList.Count > 0)
        //            {
        //                foreach (var pItem in pList.ParameterList)
        //                {
        //                    var convItem = ConvertSwitch(p21Instance, pItem);
        //                    if (convItem == null) continue;

        //                    if (spnType.IsClass)
        //                        ppList.Add(convItem);
        //                    else
        //                    {
        //                        var sAtt = Activator.CreateInstance(spnType);
        //                        Type tSel = sAtt.GetType();
        //                        while (!(convItem is P21Base))
        //                        {
        //                            convItem = convItem.GetType().GetField("Value").GetValue(convItem);
        //                        }

        //                        tSel.GetField("Value").SetValue(sAtt, convItem);
        //                        ppList.Add(sAtt);
        //                    }
        //                }
        //            }

        //            //fieldInfo.SetValue(ains, ppList);

        //            retValue = ppList;
        //            break;

        //            #endregion array

        //        default:
        //            throw new NotImplementedException();
        //        //                    break;

        //        #endregion case
        //    }

        //    return retValue;
        //}

        //private P21Instance ConvertInstance(Instance instance)
        //{

        //    Type insType = _ifcAssembly.GetType(EbConstants.Ifc2X3Name + "." + instance.Keyword, false, true);
        //    //var atype = ifcAssembly.GetTypes();
        //    //var ains = Activator.CreateInstance(_ifcAssemblyName, _ifcAssemblyName + "." + instance.Keyword).Unwrap() as P21Instance;
        //    var ains = Activator.CreateInstance(insType) as P21Instance;
        //    if (ains == null) return null;

        //    ains.EIN = instance.EntityInstanceName;

        //    AddToData(ains);

        //    foreach (var parameter in instance.AttributeList)
        //    {
        //        ConvertAttribute(parameter, ains);
        //    }
        //    return ains;
        //}


        //private void AddToData(P21Instance p21Instance)
        //{
        //    _dataSection.TryAdd(p21Instance.EIN, p21Instance);

        //    var name = p21Instance.GetType().Name;

        //    if (!_dataByType.ContainsKey(name))
        //    {
        //        _dataByType.TryAdd(name, new ConcurrentDictionary<uint, P21Instance>());
        //    }
        //    _dataByType[p21Instance.GetType().Name].TryAdd(p21Instance.EIN, p21Instance);


        //}


        //private void ConvertAttribute(Parameter att, P21Instance p21Instance)
        //{
        //    if (att.ParameterType == SParamType.UNSET) return;
        //    var attName = att.SchemaAttDef.Name;
        //    FieldInfo fieldInfo = p21Instance.GetType().GetField(attName);

        //    object attribute = ConvertSwitch(p21Instance, att);

        //    if (attribute == null) return;

        //    if (fieldInfo.FieldType.IsClass)
        //        fieldInfo.SetValue(p21Instance, attribute);
        //    else
        //    {
        //        if (fieldInfo.FieldType == attribute.GetType())
        //        {
        //            fieldInfo.SetValue(p21Instance, attribute);
        //        }
        //        else
        //        {
        //            Type tSelect = fieldInfo.FieldType;
        //            var selectAtt = Activator.CreateInstance(tSelect);
        //            tSelect.GetField("Value").SetValue(selectAtt, attribute);
        //            fieldInfo.SetValue(p21Instance, selectAtt);
        //        }
        //    }
        //}

        //private void AddReferenced(P21Instance host, P21Instance attribute)
        //{
        //    if (!_referencedEntities.ContainsKey(attribute.EIN))
        //    {
        //        _referencedEntities.TryAdd(attribute.EIN, new ConcurrentDictionary<uint, P21Instance>());
        //    }
        //    _referencedEntities[attribute.EIN].TryAdd(host.EIN, host);
        //}







        //private object ConvertSwitch(Parameter attribute)
        //{
        //    object retValue = null;
        //    switch (attribute.ParameterType)
        //    {
        //        #region case

        //        case SParamType.ENTITY:

        //            #region entity

        //            var pop = attribute as ParamEntity;

        //            if (_dic.Dictionary.ContainsKey(pop.EntityInstance.EntityInstanceName))
        //            { retValue = _dic.Dictionary[pop.EntityInstance.EntityInstanceName]; }
        //            else
        //            {
        //                retValue = AddInstance(pop.EntityInstance);
        //            }

        //            break;

        //            #endregion entity

        //        case SParamType.NUMBER:
        //            throw new NotImplementedException();
        //        //break;
        //        case SParamType.REAL:

        //            #region real

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam = Activator.CreateInstance(EbConstants.IfcSchemaNSName, EbConstants.IfcSchemaNSName + "." + sParam.NamedRefString).Unwrap() as REAL;
        //                aparam.Value = ((ParamReal)attribute).RealValue;
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                REAL realValue = ((ParamReal)attribute).RealValue;
        //                retValue = realValue;
        //            }
        //            break;

        //            #endregion real

        //        case SParamType.INTEGER:

        //            #region integer

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam = Activator.CreateInstance(EbConstants.IfcSchemaNSName, EbConstants.IfcSchemaNSName + "." + sParam.NamedRefString).Unwrap() as INTEGER;
        //                aparam.Value = ((ParamInteger)attribute).IntegerValue;
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                INTEGER intValue = ((ParamInteger)attribute).IntegerValue;
        //                //fieldInfo.SetValue(ains, intValue);
        //                retValue = intValue;
        //            }
        //            break;

        //            #endregion integer

        //        case SParamType.STRING:

        //            #region string

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam = Activator.CreateInstance(EbConstants.IfcSchemaNSName, EbConstants.IfcSchemaNSName + "." + sParam.NamedRefString).Unwrap() as STRING;
        //                aparam.Value = ((ParamString)attribute).StringValue;
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                throw new NotImplementedException();
        //                //STRING strValue = ((ParamString)attribute).StringValue;
        //                //fieldInfo.SetValue(ains, strValue);
        //                //retValue = strValue;
        //            }
        //            break;

        //            #endregion string

        //        case SParamType.ENUMERATION:

        //            #region enumeration

        //            string estr = ((ParamEnum)attribute).EnumerationValueString;
        //            SParamNamed eparam = attribute.SchemaAttDef.Type as SParamNamed;

        //            var fi = _ifcAssembly.GetType(EbConstants.IfcSchemaNSName + "." + eparam.NamedRefString).GetField(estr);
        //            retValue = fi.GetValue(null);
        //            break;

        //            #endregion enumeration

        //        case SParamType.LOGICAL:
        //        case SParamType.BOOLEAN:

        //            #region boolean

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                SParamNamed sParam = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam = Activator.CreateInstance(EbConstants.IfcSchemaNSName, EbConstants.IfcSchemaNSName + "." + sParam.NamedRefString).Unwrap();
        //                if (aparam is BOOLEAN)
        //                {
        //                    if (((ParamBoolean)attribute).BoolValue == 1)
        //                    { ((BOOLEAN)aparam).Value = true; }
        //                    else
        //                    { ((BOOLEAN)aparam).Value = false; }
        //                }
        //                else if (aparam is LOGICAL)
        //                {
        //                    ((LOGICAL)aparam).Value = ((ParamBoolean)attribute).BoolValue;
        //                }
        //                else
        //                {
        //                    throw new InvalidDataException();
        //                }
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                if (attribute.SchemaAttDef.Type.ParamType == SParamType.BOOLEAN)
        //                {
        //                    BOOLEAN bvalue;
        //                    if (((ParamBoolean)attribute).BoolValue == 1)
        //                    { bvalue = true; }
        //                    else
        //                        bvalue = false;
        //                    retValue = bvalue;
        //                }
        //                else if (attribute.SchemaAttDef.Type.ParamType == SParamType.LOGICAL)
        //                {
        //                    LOGICAL bvalue = new LOGICAL();
        //                    bvalue.Value = ((ParamBoolean)attribute).BoolValue;
        //                    retValue = bvalue;
        //                }
        //                else
        //                {
        //                    throw new InvalidDataException();
        //                }
        //            }
        //            break;

        //            #endregion boolean

        //        case SParamType.SELECT:

        //            #region select

        //            SParamNamed selectParam = attribute.SchemaAttDef.Type as SParamNamed;
        //            var selectAtt = Activator.CreateInstance(EbConstants.IfcSchemaNSName, EbConstants.IfcSchemaNSName + "." + selectParam.NamedRefString).Unwrap();

        //            ParamSelect paramSelect = attribute as ParamSelect;
        //            var pSelect = Activator.CreateInstance(EbConstants.IfcSchemaNSName, EbConstants.IfcSchemaNSName + "." + paramSelect.SelectName).Unwrap();

        //            switch (paramSelect.SelectValue.ParameterType)
        //            {
        //                case SParamType.INTEGER:
        //                    var ri = paramSelect.SelectValue as ParamInteger;
        //                    ((INTEGER)pSelect).Value = ri.IntegerValue;
        //                    break;
        //                case SParamType.REAL:
        //                    var rr = paramSelect.SelectValue as ParamReal;
        //                    ((REAL)pSelect).Value = rr.RealValue;
        //                    break;
        //                case SParamType.STRING:
        //                    var rs = paramSelect.SelectValue as ParamString;
        //                    ((STRING)pSelect).Value = rs.StringValue;
        //                    break;
        //                case SParamType.BOOLEAN:
        //                    var rb = paramSelect.SelectValue as ParamBoolean;
        //                    ((BOOLEAN)pSelect).Value = rb.BoolValue == 1;
        //                    break;
        //                default:
        //                    throw new NotImplementedException();
        //                //break;
        //            }
        //            Type tSelect = selectAtt.GetType();
        //            tSelect.GetField("Value").SetValue(selectAtt, pSelect);

        //            retValue = selectAtt;
        //            break;

        //            #endregion select

        //        case SParamType.TYPE:

        //            #region Type in Collection form

        //            SParamNamed tParamName = attribute.SchemaAttDef.Type as SParamNamed;

        //            if (tParamName == null)
        //            {
        //                throw new InvalidCastException();
        //            }
        //            if (tParamName.NamedReference is STypeCollection)
        //            {
        //                var stc = tParamName.NamedReference as STypeCollection;

        //                var aparam =
        //                    Activator.CreateInstance(EbConstants.IfcSchemaNSName, EbConstants.IfcSchemaNSName + "." + tParamName.NamedRefString).Unwrap()
        //                    as IList;

        //                ParamList tParamList = attribute as ParamList;

        //                switch (stc.CollectionType)
        //                {
        //                    case SParamType.INTEGER:
        //                        foreach (var pitem in tParamList.ParameterList)
        //                        {
        //                            var p = pitem as ParamInteger;
        //                            INTEGER p21Int = p.IntegerValue;
        //                            aparam.Add(p21Int);
        //                        }

        //                        break;
        //                    case SParamType.REAL:
        //                        foreach (var pitem in tParamList.ParameterList)
        //                        {
        //                            var p = pitem as ParamReal;
        //                            REAL p21real = p.RealValue;
        //                            aparam.Add(p21real);
        //                        }
        //                        break;
        //                    default:
        //                        throw new NotImplementedException();
        //                    //break;
        //                }
        //                //fieldInfo.SetValue(ains, aparam);
        //                retValue = aparam;
        //                //throw new NotImplementedException();
        //            }
        //            else
        //            {
        //                throw new NotImplementedException();
        //            }

        //            break;

        //            #endregion Type in Collection form

        //        case SParamType.UNSET:

        //            break;
        //        case SParamType.SELFDERIVED:

        //            #region derived

        //            if (attribute.SchemaAttDef.Type is SParamNamed)
        //            {
        //                var sde = attribute.SchemaAttDef.Type as SParamNamed;
        //                var aparam = Activator.CreateInstance(EbConstants.IfcSchemaNSName, EbConstants.IfcSchemaNSName + "." + sde.NamedRefString).Unwrap();

        //                if (aparam.GetType().IsClass)
        //                {
        //                    ((P21Base)aparam).IsDerived = true;
        //                }
        //                else
        //                {
        //                    Type apType = aparam.GetType();
        //                    var pbase = new P21Base { IsDerived = true };
        //                    apType.GetField("Value").SetValue(aparam, pbase);
        //                }

        //                //aparam.isDerived = true;
        //                retValue = aparam;
        //            }
        //            else
        //            {
        //                var sde = attribute.SchemaAttDef.Type as SParameter;
        //                var aparam = Activator.CreateInstance(EbConstants.Part21NSName, EbConstants.Part21NSName + "." + sde.ParamTypeString).Unwrap() as P21Base;
        //                aparam.IsDerived = true;
        //                retValue = aparam;
        //            }

        //            break;

        //            #endregion derived

        //        case SParamType.ARRAY:
        //        case SParamType.LIST:
        //        case SParamType.SET:
        //        case SParamType.BAG:

        //            #region array

        //            SParamCollection collection = attribute.SchemaAttDef.Type as SParamCollection;
        //            SParameter pRef = collection.ParamReference;
        //            ParamList pList = attribute as ParamList;

        //            IList ppList;
        //            Type spnType;
        //            if (pRef is SParamNamed)
        //            {
        //                SParamNamed spn = pRef as SParamNamed;
        //                spnType = Type.GetType(EbConstants.IfcSchemaNSName + "." + spn.NamedRefString);
        //                Type listType =
        //                    Type.GetType("System.Collections.Generic.List`1").MakeGenericType(spnType);
        //                ppList = Activator.CreateInstance(listType) as IList;
        //            }
        //            else if (pRef is SParamCollection)
        //            {
        //                throw new NotImplementedException();
        //            }
        //            else
        //            {
        //                //string assm = EbConstants.Part21NSName+"." + pRef.ParamTypeString + ", " + p21Assembly.FullName;
        //                spnType = _p21Assembly.GetType(EbConstants.Part21NSName + "." + pRef.ParamTypeString); //Type.GetType(assm);
        //                Type listType =
        //                    Type.GetType("System.Collections.Generic.List`1").MakeGenericType(spnType);
        //                ppList = Activator.CreateInstance(listType) as IList;
        //            }

        //            if (pList.ParameterList.Count > 0)
        //            {
        //                foreach (var pItem in pList.ParameterList)
        //                {
        //                    var convItem = ConvertSwitch(pItem);
        //                    if (convItem == null) continue;

        //                    if (spnType.IsClass)
        //                        ppList.Add(convItem);
        //                    else
        //                    {
        //                        var sAtt = Activator.CreateInstance(spnType);
        //                        Type tSel = sAtt.GetType();
        //                        while (!(convItem is P21Base))
        //                        {
        //                            convItem = convItem.GetType().GetField("Value").GetValue(convItem);
        //                        }

        //                        tSel.GetField("Value").SetValue(sAtt, convItem);
        //                        ppList.Add(sAtt);
        //                    }
        //                }
        //            }

        //            //fieldInfo.SetValue(ains, ppList);

        //            retValue = ppList;
        //            break;

        //            #endregion array

        //        default:
        //            throw new NotImplementedException();
        //        //break;

        //        #endregion case
        //    }

        //    return retValue;
        //}



        #endregion

    }
}