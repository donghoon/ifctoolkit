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
    public class ParamReal : Parameter
    {
		public const int Precision = 9;
        private double aRealValue;
        public double RealValue
        {
            get { return aRealValue; }
            set { aRealValue = Math.Round(value, Precision); }
        }

        public ParamReal(double value)
            : base(SParamType.REAL)
		{ this.RealValue = Math.Round(value, Precision); }

        public override string ToString()
        { return string.Format("{0} Value:{1}", base.ToString(), RealValue); }
    }


    public class ParamNumber : Parameter
    {
        public const int Precision = 9;
        private double aNumberValue;
        public double NumberValue
        {
            get { return aNumberValue; }
            set { aNumberValue = Math.Round(value, Precision); }
        }

        public ParamNumber(double value)
            : base(SParamType.NUMBER)
        { this.NumberValue = Math.Round(value, Precision); }

        public override string ToString()
        { return string.Format("{0} Value:{1}", base.ToString(), NumberValue); }
    }
}
