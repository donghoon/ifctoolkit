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
    public class ParamBoolean : Parameter
    {
        public short BoolValue;

        // 1 true
        // 0 unknown
        // -1 false
        public ParamBoolean(short booleanValue)
            : base(SParamType.BOOLEAN)
        { BoolValue = booleanValue; }

        public override string ToString()
        {
            if (BoolValue == 1)
                return string.Format("{0}-true", base.ToString());
            if (BoolValue == -1)
                return string.Format("{0}-false", base.ToString());

            return string.Format("{0}-unknown", base.ToString());
        }

    }

}
