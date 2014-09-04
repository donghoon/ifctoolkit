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
    public class ParamEntity : Parameter
    {
        //private P21Instance aInstance;

        public Instance EntityInstance
        { get; set; }

        //public int EntityInstanceName
        //{ get; set; }

        //public EntityInstanceParameter(int value)
        //{
        //    this.EntityInstanceName = value;
        //}

        //public EntityInstanceParameter

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Referenced Entity Instance Name</param>
        /// <param name="cInstance">Instance having the instance as attribute</param>
        /// <param name="DataSet"></param>
        public ParamEntity(uint value, Instance cInstance, InstanceDB DataSet)
            : base(SParamType.ENTITY)
        {
            // this fucntion only works with SimpleInstance Populations
            if (DataSet.DataList.ContainsKey(value))
            { EntityInstance = DataSet.DataList[value]; }
            else
            {
                EntityInstance = new InstanceSimple(value);
                DataSet.DataList.Add((uint)value, EntityInstance);
            }

            EntityInstance.UsedBy.Add(cInstance);

        }

        public ParamEntity(uint value, InstanceDB DataSet)
            : base(SParamType.ENTITY)
        {
            // this fucntion only works with SimpleInstance Populations
            if (DataSet.DataList.ContainsKey(value))
            { EntityInstance = DataSet.DataList[value]; }
            else
            {
                EntityInstance = new InstanceSimple(value);
                DataSet.DataList.Add((uint)value, EntityInstance);
            }
        }


        public override string ToString()
        {
            return string.Format("{0} Value:#{1}={2}", base.ToString(), EntityInstance.EntityInstanceName, EntityInstance.Keyword);
        }
    }
}
