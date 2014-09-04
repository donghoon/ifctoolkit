using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.Linq;
using System.Text;
using SchemaModel;
using System.Xml;

namespace BlackBox
{

    public partial class BbDefinition : Definition
	{
        //List<string> ReferenceList= new List<string> ();// for using from Shani???
        List<AttributeDefinition> _inputList = new List<AttributeDefinition>();
        //String _semNamespace;// from Shani???

		#region ICSharpClass implementation
        //public void ToCSharpClass (System.IO.StreamWriter stream)
        //{

        //    var sb = new StringBuilder();

        //    sb.AppendLine("using IFC2X3;");
        //    sb.AppendLine("using System.Collections.Generic;");
            
        //    //foreach (var refer in ReferenceList)
        //    //{
        //    //    sb.AppendLine(string.Format("using {0};", refer));
        //    //}
        //    sb.AppendLine("using Sem.Service;\r\n\r\n");
            
        //    sb.AppendLine(string.Format("namespace {0}", "_semNamespace")); 
        //    sb.AppendLine("{\r\n");

        //    //sb.AppendLine(string.Format("\tpublic class {0}", " : {1}", Name, _mainEntity.SubTypesOf));//where to get _SEMsuperTypeName???
        //    sb.AppendLine("\t{");

        //    foreach (var parm in _inputList)
        //    {
        //        //sb.AppendLine(string.Format("\t\t", parm.variableType, " ", parm.variableName, ";\r\n"));
        //    }
        //    sb.AppendLine();

        //    sb.AppendLine("\t\t[EarlyBindingInstance]");
        //    sb.AppendLine("\t\tpublic _mainEntity _mainEntity");
        //    sb.Append(" { get; set; }");
        //    sb.AppendLine();
                 
        //    //IfcAttributeList---
        //    //SemAttributeList---

        //    //sb.AppendLine(string.Format("\t\tpublic {0}", "(string {1},", " string {2},", " type {3})", Name, SemPieceMark, SemType));
        //    //(Name, variables, SemType SemType)--> attributes (STypeString=type & ToString=stringtype)

        //    //sb.AppendLine(_mainEntity.FlatList.ToString);
        //    sb.AppendLine("\t\t{");
        //    //-----
        //    sb.AppendLine("\t\t}\r\n");

            

        //    /*
        //    stream.Write( sb.ToString());
        //    sb.Clear();
        //    //			foreach (var att in ParameterList)
        //    //			{
        //    //				att.ToCSharpClass(stream);
        //    //			}
        //    foreach (var map in MappingList) {
        //        map.ToCSharpClass(stream);
        //    }
			
        //    sb.AppendLine(string.Format("\t\t{0}\r\n:this()(", Name));

        //    int mcount = 0;
        //    foreach (var map in MappingList) {
        //        if(mcount > 0) sb.AppendLine(",");
        //        mcount++;
        //    }
        //    sb.AppendLine(")\r\n\t\t{");
        //    sb.Append("\t\t\tp21File.Write(GetType().Name.ToUpper());\r\n");
        //    sb.Append("\t\t\tp21File.Write(EbConstants.LParentheses);\r\n");
        //    //			for (int i = 0; i < FlatList.Count; i++)
        //    //			{
        //    //				if (i != 0) sb.Append("\t\t\tp21File.Write(EbConstants.Comma);\r\n");
        //    //				
        //    //				
        //    //				switch (FlatList[i].Type.ParamType)
        //    //				{
        //    //				case SParamType.ENTITY:
        //    //					sb.Append("\t\t\tif (");
        //    //					sb.Append(FlatList[i].Name);
        //    //					sb.Append(" == null)\r\n");
        //    //					sb.Append("\t\t\t{ p21File.Write(EbConstants.Dollar); }\r\n");
        //    //					sb.Append("\t\t\telse if (");
        //    //					sb.Append(FlatList[i].Name);
        //    //					sb.Append(".IsDerived)\r\n");
        //    //					sb.Append("\t\t\t{ p21File.Write(EbConstants.Asterisk); }\r\n\t\t\telse\r\n");
        //    //					sb.Append("\t\t\t{ p21File.Write(\"#\" + ");
        //    //					sb.Append(FlatList[i].Name);
        //    //					sb.Append(".EIN); }\r\n");
        //    //					break;
        //    //				case SParamType.NUMBER:
        //    //				case SParamType.BOOLEAN:
        //    //				case SParamType.LOGICAL:
        //    //				case SParamType.REAL:
        //    //				case SParamType.INTEGER:
        //    //				case SParamType.STRING:
        //    //				case SParamType.ENUMERATION:
        //    //					sb.Append("\t\t\tif (");
        //    //					sb.Append(FlatList[i].Name);
        //    //					sb.Append(" == null)\r\n");
        //    //					sb.Append("\t\t\t{ p21File.Write(EbConstants.Dollar); }\r\n");
        //    //					sb.Append("\t\t\telse if (");
        //    //					sb.Append(FlatList[i].Name);
        //    //					sb.Append(".IsDerived)\r\n");
        //    //					sb.Append("\t\t\t{ p21File.Write(EbConstants.Asterisk); }\r\n\t\t\telse\r\n");
        //    //					sb.Append("\t\t\t{ ");
        //    //					sb.Append(FlatList[i].Name);
        //    //					sb.Append(".WriteToP21(p21File); }\r\n");
        //    //					
        //    //					break;
        //    //					
        //    //				case SParamType.LIST:
        //    //				case SParamType.BAG:
        //    //				case SParamType.ARRAY:
        //    //				case SParamType.SET:
        //    //					
        //    //					sb.Append("\t\t\t");
        //    //					sb.Append(FlatList[i].Name);
        //    //					sb.Append(".WriteToP21(p21File);\r\n");
        //    //					break;
        //    //					
        //    //				case SParamType.TYPE:
        //    //					var spn = FlatList[i].Type as SParamNamed;
        //    //					var sts = spn.NamedReference as STypeSelect;
        //    //					
        //    //					if (sts == null)
        //    //					{
        //    //						sb.Append("\t\t\tif (");
        //    //						sb.Append(FlatList[i].Name);
        //    //						sb.Append(" == null)\r\n");
        //    //						sb.Append("\t\t\t{ p21File.Write(EbConstants.Dollar); }\r\n");
        //    //						sb.Append("\t\t\telse if (");
        //    //						sb.Append(FlatList[i].Name);
        //    //						sb.Append(".IsDerived)\r\n");
        //    //						sb.Append("\t\t\t{ p21File.Write(EbConstants.Asterisk); }\r\n\t\t\telse\r\n");
        //    //						sb.Append("\t\t\t{ ");
        //    //						sb.Append(FlatList[i].Name);
        //    //						sb.Append(".WriteToP21(p21File); }\r\n");
        //    //					}
        //    //					else
        //    //					{
        //    //						sb.Append("\t\t\tif (");
        //    //						sb.Append(FlatList[i].Name);
        //    //						sb.Append(".Value == null)\r\n");
        //    //						sb.Append("\t\t\t{ p21File.Write(EbConstants.Dollar); }\r\n");
        //    //						sb.Append("\t\t\telse if (");
        //    //						sb.Append(FlatList[i].Name);
        //    //						sb.Append(".Value.IsDerived)\r\n");
        //    //						sb.Append("\t\t\t{ p21File.Write(EbConstants.Asterisk); }\r\n\t\t\telse\r\n");
        //    //						sb.Append("\t\t\t{ ");
        //    //						sb.Append(FlatList[i].Name);
        //    //						sb.Append(".WriteToP21(p21File); }\r\n");
        //    //						
        //    //					}
        //    //					break;
        //    //				default:
        //    //					//throw new NotImplementedException();
        //    //					break;
        //    //				}
        //    //				
        //    //				
        //    //				
        //    //				
        //    //			}
        //    sb.Append("\t\t\tp21File.Write(EbConstants.RParentheses);\r\n");
        //    // public static SemName Create (...list...)
        //    // {
        //    // var semName = new SemName(...list...);
        //    // container.AddElement(semName);
        //    // EarlyBindingInstanceModel.AddSem(semName);
        //    // return semName;
        //    */




        //    stream.Write(sb.ToString());
        //    sb.Clear();
        //    stream.Write( "\t}\r\n");
        //    //check if this Sem isAvailable or not
        //}
		#endregion
	}
	

}
