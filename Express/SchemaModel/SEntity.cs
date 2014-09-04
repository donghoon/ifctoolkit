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
using System.Text;

namespace SchemaModel
{

    [Serializable]
	public class SEntity : SItem
	{
		//public override string Name
		//{
		//    get { return base.Name; }
		//    set { base.Name = value; }
		//}

		public List<SAttribute> ParameterList { get; set; }

		public List<SAttributeDerived> DerivedList { get; set; }

        public List<SAttributeInverse> InverseList { get; set; } 

		/// <summary>
		/// stores flattened attribute list
		/// </summary>
		public List<SAttribute> FlatList { get; set; }

		public List<int> SelfDerivedIndex { get; set; }



	    public bool IsAbstract
		{ get; set; }

		public List<SEntity> SuperTypesOf
		{ get; set; }

		public List<SEntity> SubTypesOf
		{ get; set; }


		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Entity:{0}\r\n", Name);
			sb.AppendFormat("\tAttributes\r\n", Name);
			foreach (SAttribute sa in ParameterList)
			{ sb.AppendFormat("\t{0}\r\n", sa.ToString()); }
			if (DerivedList.Count > 0)
			{
				sb.AppendFormat("\tDerived Attributes\r\n", Name);
				foreach (SAttributeDerived sd in DerivedList)
				{ sb.AppendFormat("\t{0}\r\n", sd.ToString()); }
			}
			sb.AppendFormat("\tFlat Attributes\r\n", Name);
			foreach (SAttribute sa in FlatList)
			{ sb.AppendFormat("\t{0}\r\n", sa.ToString()); }
			return sb.ToString();
		}

		public override void ToCSharpClass (StreamWriter stream)
		{
			var sb = new StringBuilder ();

			sb.Append (string.Format ("\tpublic partial class {0}", Name));

			if (SubTypesOf.Count > 0) {
				sb.Append (string.Format (" : {0}", SubTypesOf [0].Name));
			} else {
				sb.Append (" : P21Instance");
			}

			//if (Select.Count > 0)
			//{
			//    for (int i = 0; i< Select.Count; i++)
			//    {
			//        if (i == 0 && SubTypesOf.Count == 0)
			//        {sb.Append(" : ");}
			//        else
			//        { sb.Append(", "); }
			//        sb.Append(Select[i].Name);
			//    }
			//}

			sb.AppendLine ("\n\r\t{");
			sb.Append ("\t\tpublic ");
			sb.Append (Name);
			sb.Append ("(){}\n\r");
			stream.Write (sb.ToString ());
			foreach (var att in ParameterList) {
				//if(att is SAttributeInverse) continue;
				att.ToCSharpClass (stream);
			}

			foreach (var iatt in InverseList) {
				iatt.ToCSharpClass(stream);
			}



			//sb.Clear();
			//sb.Append(
			//    "\t\tpublic override void ReadP21(IList<Token> tokens)\r\n");
			//sb.Append("\t\t{\r\n");
			//sb.Append("\t\t\tthrow new NotImplementedException();\r\n");
			//sb.Append("\t\t}\r\n");

			//stream.Write( sb.ToString());


			sb.Clear();
			sb.Append(
				"\t\tpublic override void WriteToP21(StreamWriter p21File)\r\n");
			sb.Append("\t\t{\r\n");

			// sb.Append("\t\t\tthrow new NotImplementedException();\r\n");


			sb.Append("\t\t\tp21File.Write(GetType().Name.ToUpper());\r\n");
			sb.Append("\t\t\tp21File.Write(EbConstants.LParentheses);\r\n");
			//if (i != 0) 

			bool notFirst = false;
			foreach (var sAtt in FlatList) {
				if(sAtt is SAttributeInverse)
				{
					continue;
				}

				if(notFirst)
                { sb.Append("\t\t\tp21File.Write(EbConstants.Comma);\r\n"); }
				else
				{notFirst = true;}

				#region switch normal
				switch (sAtt.Type.ParamType)
				{
				case SParamType.ENTITY:
					sb.Append("\t\t\tif (");
					sb.Append(sAtt.Name);
					sb.Append(" == null)\r\n");
					sb.Append("\t\t\t{ p21File.Write(EbConstants.Dollar); }\r\n");
					sb.Append("\t\t\telse if (");
					sb.Append(sAtt.Name);
					sb.Append(".IsDerived)\r\n");
					sb.Append("\t\t\t{ p21File.Write(EbConstants.Asterisk); }\r\n\t\t\telse\r\n");
					sb.Append("\t\t\t{ p21File.Write(\"#\" + ");
					sb.Append(sAtt.Name);
					sb.Append(".EIN); }\r\n");
					break;
				case SParamType.NUMBER:
				case SParamType.BOOLEAN:
				case SParamType.LOGICAL:
				case SParamType.REAL:
				case SParamType.INTEGER:
				case SParamType.STRING:
				case SParamType.ENUMERATION:
					sb.Append("\t\t\tif (");
					sb.Append(sAtt.Name);
					sb.Append(" == null)\r\n");
					sb.Append("\t\t\t{ p21File.Write(EbConstants.Dollar); }\r\n");
					sb.Append("\t\t\telse if (");
					sb.Append(sAtt.Name);
					sb.Append(".IsDerived)\r\n");
					sb.Append("\t\t\t{ p21File.Write(EbConstants.Asterisk); }\r\n\t\t\telse\r\n");
					sb.Append("\t\t\t{ ");
					sb.Append(sAtt.Name);
					sb.Append(".WriteToP21(p21File); }\r\n");
					
					break;
					
				case SParamType.LIST:
				case SParamType.BAG:
				case SParamType.ARRAY:
				case SParamType.SET:
					
					sb.Append("\t\t\t");
					sb.Append(sAtt.Name);
					sb.Append(".WriteToP21(p21File);\r\n");
					break;
					
				case SParamType.TYPE:
					var spn = sAtt.Type as SParamNamed;
					var sts = spn.NamedReference as STypeSelect;
					
					if (sts == null)
					{
						sb.Append("\t\t\tif (");
						sb.Append(sAtt.Name);
						sb.Append(" == null)\r\n");
						sb.Append("\t\t\t{ p21File.Write(EbConstants.Dollar); }\r\n");
						sb.Append("\t\t\telse if (");
						sb.Append(sAtt.Name);
						sb.Append(".IsDerived)\r\n");
						sb.Append("\t\t\t{ p21File.Write(EbConstants.Asterisk); }\r\n\t\t\telse\r\n");
						sb.Append("\t\t\t{ ");
						sb.Append(sAtt.Name);
						sb.Append(".WriteToP21(p21File); }\r\n");
					}
					else
					{
						sb.Append("\t\t\tif (");
						sb.Append(sAtt.Name);
						sb.Append(".Value == null)\r\n");
						sb.Append("\t\t\t{ p21File.Write(EbConstants.Dollar); }\r\n");
						sb.Append("\t\t\telse if (");
						sb.Append(sAtt.Name);
						sb.Append(".Value.IsDerived)\r\n");
						sb.Append("\t\t\t{ p21File.Write(EbConstants.Asterisk); }\r\n\t\t\telse\r\n");
						sb.Append("\t\t\t{ ");
						sb.Append(sAtt.Name);
						sb.Append(".WriteToP21(p21File); }\r\n");
						
					}
					break;
				default:
					//throw new NotImplementedException();
					break;
				}
				#endregion
			}


			sb.Append("\t\t\tp21File.Write(EbConstants.RParentheses);\r\n");

			sb.Append("\t\t}\r\n");

			stream.Write( sb.ToString());

			stream.Write( "\t}\r\n");
		}

		public SEntity(string EntityName)
		{
			Name = EntityName;
			IsAbstract = false;
			SuperTypesOf = new List<SEntity>();
			SubTypesOf = new List<SEntity>();
			ParameterList = new List<SAttribute>();
			DerivedList = new List<SAttributeDerived>();
			SelfDerivedIndex = new List<int>();
            InverseList = new List<SAttributeInverse>();
		}

		/// <summary>
		/// find all attributes of supertypes and tag self derived attribute as selfderived attribute type
		/// </summary>
		public void UpdateFlatList()
		{
			if (this.FlatList == null)
			{ this.FlatList = new List<SAttribute>(); }
			else
			{ this.FlatList.Clear(); }


			// stack for adding super type entities of current entity
			Stack<SEntity> hierarchyStack = new Stack<SEntity>();
			// adding current entity to the stack

			hierarchyStack.Push(this);

			if (SubTypesOf.Count > 0)
			{ recurseSuper(this, hierarchyStack); }

			// checking self derived attribute
			List<SAttributeDerived> selfDerived = new List<SAttributeDerived>();
			foreach (SEntity aEntity in hierarchyStack)
			{
				if (aEntity.DerivedList.Count > 0)
				{
					foreach (SAttributeDerived aTT in aEntity.DerivedList)
					{
						if (aTT.isInherited)
						{ selfDerived.Add(aTT); }
					}
				}
			}


			int sIndex = 0;
			foreach (SEntity aEntity in hierarchyStack)
			{
                // add regular attribute
				foreach (SAttribute aAttrib in aEntity.ParameterList)
				{
					// adding attributes to flattened list
					this.FlatList.Add(aAttrib);

					int count = 0;

					// if there is self derived attribute and if self derived is not found yet
					if (selfDerived.Count > 0 && count < selfDerived.Count)
					{
						foreach (SAttributeDerived drvatt in selfDerived)
						{
							if (drvatt.OriginatingSuperType.Equals(aEntity.Name, StringComparison.InvariantCultureIgnoreCase))
							{
								if (drvatt.Name.Equals(aAttrib.Name, StringComparison.InvariantCultureIgnoreCase) )
								{
									this.SelfDerivedIndex.Add(sIndex);
									count++;
									break;
								}
							}
						}
					}
					sIndex++;
				}

                ///// adding inverse Attribute to the List
                foreach (var aInverse in aEntity.InverseList)
                {
                    FlatList.Add(aInverse);
                }
			}

            
		}


		/// <summary>
		/// Called by updateFlatList, recursive function to add all supertypes of entity
		/// </summary>
		/// <param name="sEntity">entity to start from</param>
		/// <param name="hierarchyStack">hierarcy stack to contain supertypes of base entity</param>
		private void recurseSuper(SEntity sEntity, Stack<SEntity> hierarchyStack)
		{
			foreach (SEntity aEntity in sEntity.SubTypesOf)
			{
				hierarchyStack.Push(aEntity);
				if (aEntity.SubTypesOf.Count > 0)
				{ recurseSuper(aEntity, hierarchyStack); }
			}
		}

	}
}
