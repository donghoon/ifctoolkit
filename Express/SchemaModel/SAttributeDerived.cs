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

namespace SchemaModel
{
    [Serializable]
    public class SAttributeDerived : SAttribute
    {
        // true if it refers to attribute of supertype
        public bool isInherited { get; set; }

        public string OriginatingSuperType { get; set; }

        public SAttributeDerived(string Name, SParameter Type)
            : base(Name, Type) { }

        public SAttributeDerived(string Name)
            : base(Name)
        { }

        public override string ToString()
        {
            if (OriginatingSuperType != null && OriginatingSuperType.Length > 0)
            { return string.Format("{0}-{1}", base.ToString(), OriginatingSuperType); }

            return base.ToString();
        }
    }
}
