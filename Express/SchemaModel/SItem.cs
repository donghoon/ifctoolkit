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
using System.IO;

namespace SchemaModel
{
    [Serializable]
    public class SItem: ICSharpClass
    {

        public virtual string Name { set; get; }

        public override string ToString()
        {
            return Name;
        }


        public List<SItem> Select; 

        public SItem()
        {
            Select = new List<SItem>();
        }


        //public STokenType ItemType { set; get; }

        //public SItem(STokenType ItemType)
        //    : this(ItemType, "") { }

        //public SItem(string ItemName)
        //    : this(STokenType.UNDEFINED, ItemName) { }

        //public SItem(STokenType ItemType, string ItemName)
        //{
        //    this.ItemType = ItemType;
        //    this.ItemName = ItemName;
        //}



        public virtual void ToCSharpClass(StreamWriter stream)
        {
            throw new NotImplementedException();
        }
    }
}
