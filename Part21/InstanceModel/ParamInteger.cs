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
using SchemaModel;


namespace InstanceModel
{
    [Serializable]
    public class ParamInteger : Parameter
    {
        private int aIntValue;
        public int IntegerValue
        {
            get { return aIntValue; }
            set { aIntValue = value; }
        }
        public ParamInteger(int value)
            : base(SParamType.INTEGER)
        {
            IntegerValue = value;
        }

        public override string ToString()
        {
            return string.Format("{0} Value:{1}", base.ToString(), IntegerValue);
        }
    }
}
