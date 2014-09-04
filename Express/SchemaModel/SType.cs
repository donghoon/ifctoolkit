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



using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SchemaModel
{
	/// <summary>
	///  Base type definition class
	///  real, integer, string and so on can use this class
	/// </summary>
	public class SType : SItem
	{
		//public override string Name
		//{
		//    get { return base.Name; }
		//    set { base.Name = value; }
		//}
		public SParamType Kind;
		public SType(string TypeName)
		//    : base(STokenType.TYPE, TypeName)
		{ this.Name = TypeName; }

		public SType(string TypeName, SParamType SAtt)
		{
			Name = TypeName;
			Kind = SAtt;
		}

		public override string ToString()
		{ return string.Format("{0}:{1}", Name, SParameter.TypeToString(Kind)); }

		public override void ToCSharpClass(StreamWriter stream)
		{
			stream.Write(string.Format("\tpublic partial class {0} : {1}", Name, Kind));

			//if (Select.Count > 0)
			//{
			//    var sb = new StringBuilder();
			//    foreach (var t in Select)
			//    {
			//        stream.Write( string.Format(", {0}", t.Name));
			//    }
			//}
			stream.Write("\r\n\t{\r\n");

            stream.Write("\t\tpublic ");
            stream.Write(Name);
            stream.Write("(){}\n\r");


			AddOperator(Kind, stream);

			stream.Write("\t}\r\n");
		}


		protected void AddOperator(SParamType type, StreamWriter stream)
		{
			string bTypeName;
			string valueForm;
			switch (type)
			{
				case SParamType.NUMBER:
				case SParamType.REAL:
					bTypeName = "double";
					valueForm = "Math.Round(value, Precision)";
					//valueForm = "value";
					break;
				case SParamType.STRING:
					bTypeName = "string";
					valueForm = "value";
					break;
				case SParamType.INTEGER:
					bTypeName = "int";
					valueForm = "value";
					break;
				case SParamType.BOOLEAN:
					bTypeName = "bool";
					valueForm = "value";
					break;
				case SParamType.LOGICAL:
					bTypeName = "int";
					valueForm = "value";
					break;
				default:
					bTypeName = "";
					valueForm = "value";
					break;
			}



			var sb2 = new StringBuilder();
			sb2.Append(string.Format("\t\tpublic static implicit operator {0}({1} value)\r\n", Name, bTypeName));
			sb2.Append(string.Format("\t\t{{\r\n\t\t\treturn new {0}{{ Value = {1} }};\r\n\t\t}}\r\n", Name, valueForm));
			sb2.Append(string.Format("\t\tpublic static implicit operator {0}({1} obj)\r\n", bTypeName, Name));
			sb2.Append("\t\t{\r\n\t\t\treturn obj.Value;\r\n\t\t}\r\n");
			stream.Write(sb2.ToString());
		}

	}




	public class STypeString : SType
	{
		public STypeString(string TypeName)
			: base(TypeName)
		{
			IsFixed = false;
			StringLength = 0;
		}
		public bool IsFixed { get; set; }
		public short StringLength { get; set; }
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(base.ToString());
			if (IsFixed)
			{ sb.Append(" FIXED"); }
			if (StringLength > 0)
			{ sb.AppendFormat(" L:{0}", StringLength.ToString()); }
			return sb.ToString();
		}

		//public override void ToCSharpClass(Stream stream)
		//{
		//    throw new NotImplementedException();
		//}
	}

	/// <summary>
	/// Types with named attribute
	/// </summary>
	public class STypeSimple : SType
	{
		/// <summary>
		/// Name of SimpleID
		/// </summary>
		public string SimpleName { set; get; }
		public STypeSimple(string TypeName, string simpleID)
			: base(TypeName)
		{
			SimpleName = simpleID;
		}
		/// <summary>
		/// reference to defined type with SimpleID
		/// </summary>
		public SItem SimpleTypeReference { get; set; }
		public override string ToString()
		{
			//return string.Format("{0}:{1}:{2}", base.ToString(), SimpleName, SimpleTypeReference.Name);
			return string.Format("{0}:{1}", Name, SimpleName);
		}

		public override void ToCSharpClass(StreamWriter stream)
		{
			stream.Write(string.Format("\tpublic partial class {0} : {1}", Name, SimpleName));
			//if (Select.Count > 0)
			//{
			//    var sb = new StringBuilder();
			//    foreach (var t in Select)
			//    {
			//        stream.Write( string.Format(", {0}", t.Name));
			//    }
			//}

			stream.Write("\r\n\t{\r\n");

			var stype = SimpleTypeReference as SType;
			if (stype != null)
				AddOperator(stype.Kind, stream);

			stream.Write("\t}\r\n");
		}
	}

	/// <summary>
	/// Collection type class definition
	/// array, set, bag, list can use this class
	/// </summary>
	public class STypeCollection : SType
	{
		public STypeCollection(string TypeName, STokenType DataType)
			: base(TypeName)
		{ this.Kind = SParameter.TokenTypeToAttribType(DataType); }
		public int LBound { set; get; }
		public int UBound { set; get; }
		public string CollectionName { get; set; }
		public SItem CollectionReference { set; get; }
		public SParamType CollectionType { get; set; }
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0} L:{1} U:{2}", Name, LBound, UBound);
			if (CollectionType == SParamType.TYPE || CollectionType == SParamType.ENTITY)
			{
				if (CollectionReference != null)
					sb.AppendFormat(" of {0}", CollectionReference.Name);
				else
					sb.Append(" ERROR ");
			}
			else
			{
				sb.AppendFormat(" of {0}", CollectionName);
			}
			return sb.ToString();
		}




		public override void ToCSharpClass(StreamWriter stream)
		{
			stream.Write(string.Format("\tpublic partial class {0} : List<{1}>", Name, CollectionName));


			//if (Select.Count > 0)
			//{
			//    var sb = new StringBuilder();
			//    foreach (var t in Select)
			//    {
			//        stream.Write( string.Format(", {0}", t.Name));
			//    }
			//}
			stream.Write("\r\n\t{\r\n\t\tpublic bool IsDerived;\r\n\t}\r\n");
			// need to imple
			// throw new NotImplementedException();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class STypeEnum : SType
	{
		public STypeEnum(string TypeName)
			: base(TypeName)
		{
			EnumList = new List<string>();
		}
		public List<string> EnumList { set; get; }
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}:Enum\r\n", Name);
			foreach (string en in EnumList)
			{ sb.AppendLine(en); }
			return sb.ToString();
		}

		public override void ToCSharpClass(StreamWriter stream)
		{
			stream.Write(string.Format("\tpublic class {0} : BaseType\r\n", Name));
			stream.Write("\t{\r\n");

			stream.Write("\tprivate readonly string ename;\r\n");

			stream.Write(string.Format("\t\tprivate {0} (string enumName)\r\n\t\t{{ ename = enumName; }}\r\n", Name));

			foreach (var en in EnumList)
			{ stream.Write(string.Format("\t\tpublic static readonly {0} {1} = new {0}( \"{1}\" );\r\n", Name, en)); }

			stream.Write("\t\tpublic override void WriteToP21(StreamWriter writer)\r\n");
			stream.Write("\t\t{\r\n");

            stream.Write("\t\t\twriter.Write(\".\" + ename + \".\");\r\n");

			stream.Write("\t\t}\r\n");

			stream.Write("\t}\r\n");

			//stream.Write( string.Format("\tpublic enum {0} {{\r\n", Name));
			//foreach (var en in EnumList)
			//{ stream.Write( string.Format("\t\t{0},\r\n", en)); }
			//stream.Write( "\t}\r\n");
		}
	}

	public class STypeSelect : SType
	{
		public STypeSelect(string TypeName)
			: base(TypeName)
		{
			SelectList = new SortedList<string, SItem>();
		}
		public SortedList<string, SItem> SelectList { set; get; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}:Select\r\n", Name);
			foreach (KeyValuePair<string, SItem> kv in SelectList)
			{ sb.AppendLine(kv.Key.ToString()); }
			return sb.ToString();
		}

		public override void ToCSharpClass(StreamWriter stream)
		{
			stream.Write("\t[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]\r\n");
			stream.Write(string.Format("\tpublic struct {0}\r\n", Name));
			stream.Write("\t{\r\n");
			stream.Write("\t\t[System.Runtime.InteropServices.FieldOffset(0)]\r\n");
			stream.Write("\t\tpublic P21Base Value;\r\n");
			foreach (var kv in SelectList)
			{
				stream.Write("\t\t[System.Runtime.InteropServices.FieldOffset(0)]\r\n");
				stream.Write(string.Format("\t\tpublic {0} A{0};\r\n", kv.Key));
			}

			stream.Write("\t\tpublic void WriteToP21(StreamWriter writer)\r\n");
			stream.Write("\t\t{\r\n");

			stream.Write("\t\t\tif(Value != null)\r\n");

			//stream.Write( "\t\t\t{ Value.WriteToP21(writer); }\r\n");


			stream.Write("\t\t\t{\r\n");
			stream.Write("\t\t\t\tif (Value is P21Instance)\r\n");
			stream.Write("\t\t\t\t{\r\n");
			stream.Write("\t\t\t\t\tvar vi = Value as P21Instance;\r\n");
			stream.Write("\t\t\t\t\twriter.Write(EbConstants.Sharp + vi.EIN.ToString());\r\n");
			stream.Write("\t\t\t\t}\r\n");
			stream.Write("\t\t\t\telse\r\n");
			stream.Write("\t\t\t\t{\r\n");
			stream.Write("\t\t\t\t\twriter.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);\r\n");
			stream.Write("\t\t\t\t\tValue.WriteToP21(writer);\r\n");
			stream.Write("\t\t\t\t\twriter.Write(EbConstants.RParentheses);\r\n");
			stream.Write("\t\t\t\t}\r\n");
			stream.Write("\t\t\t}\r\n");

			stream.Write("\t\t\telse\r\n");
			stream.Write("\t\t\t{ writer.Write(EbConstants.Dollar); }\r\n");

			stream.Write("\t\t}\r\n");

			stream.Write("\t}\r\n");




		}
	}
}
