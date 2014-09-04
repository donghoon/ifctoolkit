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
using System.Text;
using SchemaModel;


namespace InstanceModel
{

    [Serializable]
    public abstract class Parameter
    {
        protected SParamType m_ParameterType;
        protected string m_ParameterTypeName;
        public SParamType ParameterType { get { return m_ParameterType; } }
        public string ParameterTypeName { get { return m_ParameterTypeName; } }

        public SAttribute SchemaAttDef { get; set; }
        
        public Parameter(SParamType ParameterType)
        {
            updateParameterType(ParameterType);
        }

        public void updateParameterType(SParamType ParameterType)
        {
            m_ParameterType = ParameterType;
            m_ParameterTypeName = SParameter.TypeToString(m_ParameterType);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (SchemaAttDef == null)
            { sb.AppendFormat("IT:{0}, ST:null", m_ParameterTypeName); }
            else
            { sb.AppendFormat("IT:{0}, ST:{1}", m_ParameterTypeName, SchemaAttDef.ToString()); }
            return sb.ToString();
        }
    }
}

 
