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
    public class InstanceComplex : Instance
    {
        public List<SimpleRecord> SimpleRecordList;

        public InstanceComplex(uint theInstanceName)
            : base(theInstanceName)
        {
            SimpleRecordList = new List<SimpleRecord>();
        }

        public override string Keyword
        {
            get
            {
                StringBuilder kword = new StringBuilder();
                foreach (SimpleRecord aRecord in SimpleRecordList)
                {
                    kword.Append(@"+");
                    kword.Append(aRecord.ToString());
                }
                kword.Remove(0, 1); // remove first + sign
                return kword.ToString();
            }
        }

        public override int KeywordKey
        {
            get { return 0; }
        }

        public override List<Parameter> AttributeList
        {
            get
            {
                List<Parameter> p_AttList = new List<Parameter>();
                foreach (SimpleRecord sRecord in SimpleRecordList)
                {
                    foreach (Parameter aParam in sRecord.ParameterList)
                    {
                        p_AttList.Add(aParam);
                    }
                }
                return p_AttList;
            }
        }
    }
}
