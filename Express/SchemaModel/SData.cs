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
using System.Linq;
using System.Text;
using System.IO;

namespace SchemaModel
{



    [Serializable]
	public class SData : ICSharpClass
	{
		private string _schemaName;

		public string SchemaName {
			get { return _schemaName; }
			set { _schemaName = value; }
		}

		public Dictionary<string, SEntity> EntityList { get; set; }

		public Dictionary<string, SType> TypeList { get; set; }

		public SData ()
		{
			TypeList = new Dictionary<string, SType> (StringComparer.InvariantCultureIgnoreCase);
			EntityList = new Dictionary<string, SEntity> (StringComparer.InvariantCultureIgnoreCase);
		}

		public override string ToString ()
		{
			var sb = new StringBuilder ();
			sb.AppendFormat ("{0}\r\n\r\nEntities\r\n", _schemaName);

			foreach (KeyValuePair<string, SEntity> se in EntityList) {
				sb.AppendLine (se.Value.ToString ());
			}
			sb.AppendFormat ("\r\nTypes\r\n");
			foreach (KeyValuePair<string, SType> st in TypeList) {
				sb.AppendLine (st.Value.ToString ());
			}

			return sb.ToString ();
		}

		private void UpdateParamCollection (SParamCollection sc)
		{
			if (sc.ParamReference is SParamNamed) {
				var sn = (SParamNamed)sc.ParamReference;
				sn.NamedReference = FindNamedSItem (sn.NamedRefString);
			} else if (sc.ParamReference is SParamCollection) {
				UpdateParamCollection ((SParamCollection)sc.ParamReference);
			}
		}

		private void UpdateInverseAttribute (SAttributeInverse sAttributeInverse)
		{
            
			//SParamNamed inParam;

			if (sAttributeInverse.Type is SParamCollection) {
				var sc = sAttributeInverse.Type as SParamCollection;
				if (sc.ParamReference is SParamNamed) {
					var scn = sc.ParamReference as SParamNamed;
					scn.NamedReference = EntityList[scn.NamedRefString];
					var sen = scn.NamedReference as SEntity;
					
					foreach (var item in sen.ParameterList) {
						if(item.Name == sAttributeInverse.InversingAttributeName)
						{
							sAttributeInverse.InversingAttribute = item;
						}
					}
				}
			} else {
				var sc = sAttributeInverse.Type as SParamNamed;
				sc.NamedReference = EntityList[sc.NamedRefString];
				var sen = sc.NamedReference as SEntity;

				foreach (var item in sen.ParameterList) {
					if(item.Name == sAttributeInverse.InversingAttributeName)
					{
						sAttributeInverse.InversingAttribute = item;
					}
				}
				
			}
            
		}

		private void UpateEntityAttribute (SAttribute sAtt)
		{

			if (sAtt.Type is SParamNamed) {
				var sn = (SParamNamed)sAtt.Type;
				sn.NamedReference = FindNamedSItem (sn.NamedRefString);
				if (sn.NamedReference is SEntity) {
					sn.SetType (SParamType.ENTITY);
				} else {
					sn.SetType (SParamType.TYPE);
				}
			} else if (sAtt.Type is SParamCollection) {
				UpdateParamCollection ((SParamCollection)sAtt.Type);
			}

		}

		private void UpdateTypeAttribute (SType sType)
		{
			if (sType is STypeSimple) {
				var ss = (STypeSimple)sType;
				ss.SimpleTypeReference = FindNamedSItem (ss.SimpleName);
			} else if (sType is STypeCollection) {
				var so = (STypeCollection)sType;
				if (so.CollectionType == SParamType.UNSET)
					so.CollectionReference = FindNamedSItem (so.CollectionName);
				if (so.CollectionReference is SType)
					so.CollectionType = SParamType.TYPE;
				else if (so.CollectionReference is SEntity)
					so.CollectionType = SParamType.ENTITY;
			} else if (sType is STypeSelect) {
				var st = (STypeSelect)sType;
				var il = st.SelectList.Keys;
				var ilNew = il.ToList ();
				foreach (var s in ilNew) {
					st.SelectList [s] = FindNamedSItem (s);
				}
			}
		}

		public void UpdateAttributes ()
		{
			foreach (var kPair in EntityList) {
				foreach (var sAtt in kPair.Value.ParameterList) {
					UpateEntityAttribute (sAtt);
				}
			}
			foreach (var kvp in TypeList) {
				UpdateTypeAttribute (kvp.Value);
			}
			foreach (var pair in EntityList) {
				foreach (var attInv in pair.Value.InverseList) {
					UpdateInverseAttribute (attInv);    
				}

                
			}
		}

		private SItem FindNamedSItem (string name)
		{
			if (EntityList.ContainsKey (name)) {
				return EntityList [name];
			}
			if (TypeList.ContainsKey (name)) {
				return TypeList [name];
			}
			return null;
		}

		/// <summary>
		/// generate c sharp classes for step schema
		/// </summary>
		/// <param name="schemaFilename">schema file name</param>
		/// <param name="classFilename">class file name</param>
		/// <param name="logFilename">log file name</param>
		public static void CSharpModelMaker (string schemaFilename, string classFilename, string logFilename)
		{
			//var aParser = new SParser ();
		    var sData = SParser.ReadSchema(schemaFilename);
			//aParser.ReadSchemaFile (schemaFilename, logFilename);

			using (var fs = new StreamWriter(classFilename, false)) {
				sData.ToCSharpClass (fs);
			}
		}

		public void ToCSharpClass (StreamWriter stream)
		{
			AddSelectTypeInfo ();
			var sb = new StringBuilder ();

			sb.AppendLine ("/*");
			sb.AppendLine (" *");
			sb.AppendLine (" *\t< IFC - ISO 10303 (STEP) Part 21 instance file reader >");
			sb.AppendLine (" *\tCopyright (C) <2012>  <Donghoon Yang>");
			sb.AppendLine (" *");
			sb.AppendLine (" *\tThis program is free software: you can redistribute it and/or modify");
			sb.AppendLine (" *\tit under the terms of the GNU General Public License as published by");
			sb.AppendLine (" *\tthe Free Software Foundation, either version 3 of the License, or");
			sb.AppendLine (" *\t(at your option) any later version.");
			sb.AppendLine (" *");
			sb.AppendLine (" *\tThis program is distributed in the hope that it will be useful,");
			sb.AppendLine (" *\tbut WITHOUT ANY WARRANTY; without even the implied warranty of");
			sb.AppendLine (" *\tMERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the");
			sb.AppendLine (" *\tGNU General Public License for more details.");
			sb.AppendLine (" *");
			sb.AppendLine (" *\tYou should have received a copy of the GNU General Public License");
			sb.AppendLine (" *\talong with this program.  If not, see <http://www.gnu.org/licenses/>. ");
			sb.AppendLine (" *");
			sb.AppendLine (" *");
			sb.AppendLine (" *\tThis file is generated with SchemaModel.SData.CSharpClassMaker");
			sb.AppendLine (" *\tincluded in this program.");
			sb.AppendLine (" *");
			sb.AppendLine (" */");
			sb.AppendLine ("");
			sb.AppendLine ("");
			sb.AppendLine ("");

			sb.AppendLine ("using System;");
			sb.AppendLine ("using System.IO;");
			sb.AppendLine ("using System.Collections.Generic;");
			sb.AppendLine ("using EbInstanceModel;\r\n\r\n");

			sb.AppendLine (string.Format ("namespace {0}", _schemaName));
			sb.AppendLine ("{\r\n");

			stream.Write (sb.ToString ());
			foreach (var pair in TypeList) {
				pair.Value.ToCSharpClass (stream);
				stream.WriteLine ();
			}
			foreach (var pair in EntityList) {
				pair.Value.ToCSharpClass (stream);
				stream.WriteLine ();
			}
			stream.Write ("\r\n}");
		}

		//public static void AddText(Stream fs, string value)
		//{
		//    byte[] info = new UTF8Encoding(true).GetBytes(value);
		//    fs.Write(info, 0, info.Length);
		//}

		/// <summary>
		/// use for ToCSharpClass in associating select type to its components
		/// </summary>
		void AddSelectTypeInfo ()
		{
			foreach (var pair in TypeList) {
				if (!(pair.Value is STypeSelect))
					continue;
				var sel = pair.Value as STypeSelect;
				foreach (var item in sel.SelectList) {
					if (EntityList.ContainsKey (item.Value.Name) && !EntityList [item.Value.Name].Select.Contains (pair.Value)) {
						EntityList [item.Value.Name].Select.Add (pair.Value);
					} else if (TypeList.ContainsKey (item.Value.Name) && !TypeList [item.Value.Name].Select.Contains (pair.Value)) {
						TypeList [item.Value.Name].Select.Add (pair.Value);
					}
				}
			}
		}

	}
}
