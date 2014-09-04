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
using System.Text;
using System.Collections.Specialized;

namespace InstanceModel
{

    [Serializable]
    public partial class InstanceDB //: ISerializable
    {
        public String FileName { get; private set; }
        public String FullFileName { get; private set; }
        public String FileExtension { get; private set; }
        public Int64 FileSize { get; private set; }

        public StringCollection KeywordDic
        {
            get { return _keywordDic; }
        }

        // list instances according to entity types
        public SortedDictionary<string, List<uint>> InstanceByType {
            get { return _instanceByType; }
        }

        public List<SimpleRecord> HeaderList
        {
            get { return _headerList; }
        }

        public SortedDictionary<uint, Instance> DataList
        { get { return _dataList; } }



        #region privates

        private StringCollection _keywordDic = new StringCollection();

        private SortedDictionary<string, List<uint>> _instanceByType = new SortedDictionary<string, List<uint>>();

        private List<SimpleRecord> _headerList = new List<SimpleRecord>();

        private SortedDictionary<uint, Instance> _dataList = new SortedDictionary<uint, Instance>();



        #endregion


        public InstanceDB()
        {
        }


        public String GetKeyword(int keyID)
        {
            if (keyID >= 0 && KeywordDic.Count >= keyID)
                return KeywordDic[keyID];
            return @"";
        }

        public int AddKeyword(string keyword)
        {
            var ret = KeywordDic.IndexOf(keyword);
            if (ret != -1) return ret;
            return KeywordDic.Add(keyword);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("File Name : {0}\r\n", FileName);
            sb.AppendFormat("Full File Name : {0}\r\n", FullFileName);
            sb.AppendFormat("File Extension : {0}\r\n", FileExtension);
            sb.AppendFormat("File Size : {0}\r\n", FileSize.ToString());
            sb.AppendLine();
            KeywordDicToString(sb);
            sb.AppendLine();
            InstanceByTypeToString(sb);
            sb.AppendLine();
            HeaderListToString(sb);
            sb.AppendLine();
            DataListToString(sb);
            return sb.ToString();
        }


        private void KeywordDicToString(StringBuilder addHere)
        {
            addHere.AppendLine(@"Contents of Keyword Dictionary");
            foreach (string str in KeywordDic)
            { addHere.AppendLine(str); }
            addHere.AppendLine(@"End of Keyword Dictionary");
        }

        private void InstanceByTypeToString(StringBuilder addHere)
        {
            addHere.AppendLine(@"Contents of Instance by Type");
            foreach (KeyValuePair<string, List<uint>> kvp in InstanceByType)
            {
                addHere.AppendFormat("{0} :", kvp.Key);
                foreach (uint vInt in kvp.Value)
                { addHere.AppendFormat(" {0},", vInt.ToString()); }
                addHere.Append("\r\n");
            }
            addHere.AppendLine(@"End of Instance by Type");
        }

        private void HeaderListToString(StringBuilder addHere)
        {
            addHere.AppendLine(@"Contents of Header List");
            foreach (SimpleRecord sr in HeaderList)
            { addHere.AppendLine(sr.ToString()); }
            addHere.AppendLine(@"End of Header List");
        }

        private void DataListToString(StringBuilder addHere)
        {
            addHere.AppendLine(@"Contents of Data List");
            foreach (KeyValuePair<uint, Instance> kvp in DataList)
            {
                addHere.AppendFormat("{0}\r\n", kvp.Value.ToString());
            }
            addHere.AppendLine(@"End of Data List");
        }


        //public void UpdateGuidToIFCInstanceGuid()
        //{
        //    bool runit = false;
        //    foreach(var hl in HeaderList)
        //    {
        //        if(hl.Keyword.ToLower() == @"file_schema")
        //        {
        //            var ps = (ParamList)hl.ParameterList[0];
        //            var pss = (ParamString) ps.ParameterList[0];
        //            if (ps != null && pss.StringValue.Substring(0, 3).ToLower() == @"ifc")
        //            { 
        //                runit = true;
        //            }
        //        }
        //    }

        //    if (!runit)
        //        return;

        //    foreach (KeyValuePair<uint, Instance> kvp in DataList)
        //    {
        //        var a = kvp.Value.AttributeList[0];
        //        if(a.ParameterTypeName != null && a.SchemaAttDef.Name.ToLower() == @"globalid")
        //        {
        //            var ps = (ParamString) a;
        //            kvp.Value.InstanceID = IfcGuid.FromIfcGUID(ps.StringValue);

        //        }
        //    }
        //}

    }
}
