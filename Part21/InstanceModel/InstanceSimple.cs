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
    public class InstanceSimple : Instance
    {

        public SimpleRecord Record { get { return sRecord; } set { sRecord = value; } }

        private SimpleRecord sRecord;

        //public SimpleInstance(uint InstanceName, SimpleRecord theSimpleRecord)
        //    : base(InstanceName)
        //{ sRecord = theSimpleRecord; }

        public InstanceSimple(uint theInstanceName)
            : base(theInstanceName) { }

        public override string Keyword
        { get { return Record.Keyword; } }

        public override int KeywordKey
        { get { return Record.IntKeyword; } }

        public override List<Parameter> AttributeList
        { get { return sRecord.ParameterList; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("#{0}={1}({2})\r\n{3}\r\nParameters\r\n", 
                EntityInstanceName, Keyword, KeywordKey, EntityInstanceName);
            foreach (Parameter p in AttributeList)
            { sb.AppendLine(p.ToString()); }
            sb.AppendLine(@"Used by");
            foreach (Instance ist in UsedBy)
            { sb.AppendFormat("#{0}, ", ist.EntityInstanceName); }
            return sb.ToString();
        }
    }
}
