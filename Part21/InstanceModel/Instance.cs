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

namespace InstanceModel
{
    [Serializable]
    abstract public class Instance : IEquatable<Instance>
    {
        //protected Guid p_InstanceID;

        //public Guid InstanceID
        //{
        //    get { return p_InstanceID; }
        //    set { p_InstanceID = value; }
        //}
        /// <summary>
        /// Instance row number
        /// </summary>
        protected uint p_EIName;
        public uint EntityInstanceName { get { return p_EIName; } }

        /// <summary>
        /// flagging for processed item in cpd converter
        /// </summary>
        public bool IsProcessed { get; set; }

        /// <summary>
        /// list of referencing instances
        /// </summary>
        public List<Instance> UsedBy { get; set; }

        protected Instance(uint instanceName)
        {
            //p_InstanceID = Guid.NewGuid();
            p_EIName = instanceName;
            UsedBy = new List<Instance>();
        }

        /// <summary>
        /// abstract for getting keyword
        /// </summary>
        abstract public string Keyword { get; }

        /// <summary>
        /// abstract for getting Keyword Key as appears in Keyword Dic
        /// </summary>
        abstract public int KeywordKey { get; }
        //public P21Instance()
        //{
        //    EntityInstanceName = 0;
        //}


        abstract public List<Parameter> AttributeList { get; }


        //public override string ToString()
        //{
        //    return string.Format("{0} : {1}", EntityInstanceName, Keyword);
        //}



        bool IEquatable<Instance>.Equals(Instance other)
        {
            if (this.p_EIName == other.EntityInstanceName)
            { return true; }
            else
            { return false; }
        }
    }
}
