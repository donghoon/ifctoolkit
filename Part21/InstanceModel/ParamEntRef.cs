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

namespace InstanceModel
{
    [Serializable]
    public class ParamEntRef : ParamEntity
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Referenced Entity Instance Name</param>
        /// <param name="cInstance">Instance having the instance as attribute</param>
        /// <param name="DataSet"></param>
        public ParamEntRef(uint value, Instance cInstance, InstanceDB DataSet)
            : base(value, cInstance, DataSet)
        {      }

        public ParamEntRef(uint value, InstanceDB DataSet)
            : base(value, DataSet)
        {
        }

        public override string ToString()
        {
            return string.Format("<{0}>{1}</{0}>", base.EntityInstance.Keyword, base.EntityInstance.EntityInstanceName);
        }
    }
}
