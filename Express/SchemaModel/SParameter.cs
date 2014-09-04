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
using System.IO;

namespace SchemaModel
{
    public enum SParamType
    {
        UNSET,
        ENTITY,
        TYPE,
        NAMED,
        STRING,
        REAL,
        NUMBER,
        INTEGER,
        BOOLEAN,
        ENUMERATION,
        BINARY,
        LIST,
        LOGICAL,
        SET,
        BAG,
        ARRAY,
        DERIVED,
        SELFDERIVED,
        SELECT,
    }

    [Serializable]
    public class SParameter : ICSharpClass
    {
        /// <summary>
        /// parameter type name, 
        /// </summary>
        private string p_ParamTypeString;
        public string ParamTypeString { get { return p_ParamTypeString; } }

        /// <summary>
        /// parameter type
        /// </summary>
        private SParamType p_ParamType;
        public SParamType ParamType { get { return p_ParamType; } }

        /// <summary>
        /// optional prefix
        /// </summary>
        public bool IsOptional;

        /// <summary>
        /// unique non unique prefix
        /// </summary>
        public bool IsUnique;

        /// <summary>
        /// length of attribute ex) ifc guid
        /// </summary>
        public short TypeLength;

        public bool IsFixed;

        public SParameter()
        { }


        public SParameter(string ParamName)
        { p_ParamTypeString = ParamName; }


        public SParameter(SParamType stype)
        { SetType(stype); }


        public override string ToString()
        { return string.Format("{0}", p_ParamTypeString); }

        public virtual void ToCSharpClass(StreamWriter stream)
        {
            stream.Write( string.Format(" {0}", p_ParamTypeString));
        }

        public void SetType(SParamType stype)
        {
            p_ParamType = stype;
            p_ParamTypeString = TypeToString(stype);
        }

        public static string TypeToString(SParamType stype)
        {
            //p_AttType = stype;
            string ret;
            switch (stype)
            {
                case SParamType.ENTITY:
                    ret = @"ENTITY";
                    break;
                case SParamType.TYPE:
                    ret = @"TYPE";
                    break;
                case SParamType.NAMED:
                    ret = @"NAMED";
                    break;
                case SParamType.STRING:
                    ret = @"STRING";
                    break;
                case SParamType.REAL:
                    ret = @"REAL";
                    break;
                case SParamType.NUMBER:
                    ret = @"NUMBER";
                    break;
                case SParamType.INTEGER:
                    ret = @"INTEGER";
                    break;
                case SParamType.BOOLEAN:
                    ret = @"BOOLEAN";
                    break;
                case SParamType.ENUMERATION:
                    ret = @"ENUMERATION";
                    break;
                case SParamType.BINARY:
                    ret = @"BINARY";
                    break;
                case SParamType.LIST:
                    ret = @"LIST";
                    break;
                case SParamType.LOGICAL:
                    ret = @"LOGICAL";
                    break;
                case SParamType.SET:
                    ret = @"SET";
                    break;
                case SParamType.BAG:
                    ret = @"BAG";
                    break;
                case SParamType.ARRAY:
                    ret = @"ARRAY";
                    break;
                case SParamType.DERIVED:
                    ret = @"DERIVED";
                    break;
                case SParamType.SELFDERIVED:
                    ret = @"SELFDERIVED";
                    break;
                case SParamType.SELECT:
                    ret = @"SELECT";
                    break;
                case SParamType.UNSET:
                default:
                    ret = @"UNSET";
                    break;
            }
            return ret;
        }

        /// <summary>
        /// token type conversion to attrib type
        /// </summary>
        /// <param name="tType">token type to convert</param>
        /// <returns></returns>
        public static SParamType TokenTypeToAttribType(STokenType tType)
        {
            SParamType saType;
            switch (tType)
            {
                case STokenType.SET:
                    saType = SParamType.SET;
                    break;
                case STokenType.LIST:
                    saType = SParamType.LIST;
                    break;
                case STokenType.ARRAY:
                    saType = SParamType.ARRAY;
                    break;
                case STokenType.BAG:
                    saType = SParamType.BAG;
                    break;
                case STokenType.REAL:
                    saType = SParamType.REAL;
                    break;
                case STokenType.NUMBER:
                    saType = SParamType.NUMBER;
                    break;
                case STokenType.INTEGER:
                    saType = SParamType.INTEGER;
                    break;
                case STokenType.BOOLEAN:
                    saType = SParamType.BOOLEAN;
                    break;
                case STokenType.STRING:
                    saType = SParamType.STRING;
                    break;
                case STokenType.BINARY:
                    saType = SParamType.BINARY;
                    break;
                case STokenType.SIMPLEID:
                    saType = SParamType.NAMED;
                    break;
                case STokenType.LOGICAL:
                    saType = SParamType.LOGICAL;
                    break;
                case STokenType.ENUMERATION:
                    saType = SParamType.ENUMERATION;
                    break;
                case STokenType.SELECT:
                    saType = SParamType.SELECT;
                    break;
                default:
                    saType = SParamType.UNSET;
                    //logFile.WriteLine(String.Format("Undefined attribute Type at {0}:{1}", SLexer.CurrentRow, SLexer.CurrentColumn));
                    break;
            }
            return saType;
        }


    }

    [Serializable]
    public class SParamNamed : SParameter
    {
        public SParamNamed(string NamedString)
        { NamedRefString = NamedString; }

        public string NamedRefString;
        public SItem NamedReference;

        public override string ToString()
        {
            if (NamedReference != null)
                return NamedReference.Name;
            else
                return " ERROR ";
        }

        public override void ToCSharpClass(StreamWriter stream)
        {
            stream.Write( string.Format(" {0}", NamedRefString));
        }
    }

    [Serializable]
    public class SParamCollection : SParameter
    {
        public SParamCollection(SParamType stype)
            : base(stype)
        { }

        public SParameter ParamReference;
        /// <summary>
        /// lower bound of array -2 is ? (undefined)
        /// </summary>
        public short LBound { get; set; }

        /// <summary>
        /// upper bound of array -2 is ? (undefined)
        /// </summary>
        public short UBound { get; set; }

        public override string ToString()
        {
            return string.Format("{0} L:{1} U:{2} of {3}", base.ToString(), LBound, UBound, ParamReference);
        }

        public override void ToCSharpClass(StreamWriter stream)
        {
            stream.Write( " List<");
            ParamReference.ToCSharpClass(stream);
            stream.Write( ">");
        }
    }

}
