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

namespace InstanceModel
{
    [Serializable]
    public class SimpleRecord
    {
        public List<Parameter> ParameterList;

        private int p_IntKeyword;

        private string p_Keyword;

        public string Keyword { get { return p_Keyword; } }

        public SimpleRecord(String Keyword, InstanceDB DataSet)
        {
            p_Keyword = Keyword;
            p_IntKeyword = DataSet.AddKeyword(Keyword);
            ParameterList = new List<Parameter>();
        }

        public int IntKeyword
        { get { return p_IntKeyword; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}<-{1}\r\n", p_Keyword, p_IntKeyword);
            foreach (Parameter p in ParameterList)
            { sb.AppendFormat("\t{0}\r\n", p.ToString()); }
            return sb.ToString();
        }
    }
}
