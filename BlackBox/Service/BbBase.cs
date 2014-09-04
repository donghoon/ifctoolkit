#region Copyright (C) Tekla Corporation 2012

// //
// // All rights are reserved. Reproduction or transmission in whole or in part, in
// // any form or by any means, electronic, mechanical or otherwise, is prohibited
// // without the prior written permission of the copyright owner.
// //
// // Filename: SEMProject.cs
// //
// // Created by: Wang Frank
// // Created date: 06/16/2012
// // Last Modified: $CURRENT_MONTH/16/2012

#endregion Copyright (C) Tekla Corporation 2012

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
//using NLog;
using EbInstanceModel;



namespace BlackBox.Service
{
    /// <summary>
    /// Base class of all SEM objects
    /// </summary>
    /// <remarks>Obtains all common API methods to be accessible via complied DLL</remarks>
    [TypeConverter(typeof(PropertySorter))]
    public partial class BbBase : IComparable
    {
        #region LOG
        //[BrowsableAttribute(false)]
        //internal readonly static Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion LOG

        #region Reflection Properties

        [Browsable(false)]
        private static readonly Field<string> _relfName = new Field<string>("TypeName");

        [Browsable(false)]
        private static readonly Field<Guid> _reflGuid = new Field<Guid>("Guid");

        #endregion


        [Browsable(false)]
        internal const string ConstStringErrorFormat = "File : {0}\nLine : {1}\nException : {2}\nTrace : {3}";


        [Browsable(false)]
        public string ReflectedName
        {
            get { return _relfName[this]; }
            set { _relfName[this] = value; }
        }

        [Browsable(false)]
        public Guid ReflectedGuid
        {
            get { return _reflGuid[this]; }
            set { _reflGuid[this] = value; }
        }


        public Guid Guid { get; protected set; }



        protected BbBase()
            : this(Guid.NewGuid())
        {

        }

        protected BbBase(Guid guid)
        {
            Guid = guid;
        }



        /*public BbBase(XElement element)
        {
            if (element == null ) throw new ArgumentNullException("element");
            XElement = element;
        }*/

        virtual public void BuildHierarchyFromXml()
        {

        }

        /// <summary>
        /// Rules that are associated with this SEM
        /// </summary>
        /// <remarks>Rules are edited from SEM editor</remarks>
        virtual public void SetRules()
        {

        }

        /// <summary>
        /// Generic validate method
        /// </summary>
        /// <returns></returns>
        virtual public bool Validate(bool doValidate)
        {
            return false;
        }



        /// <summary>
        /// Compile
        /// </summary>
        /// <returns></returns>
        virtual public bool Compile()
        {
            return false;
        }


        /// <summary>
        /// Convert to MVDXml element
        /// </summary>
        virtual public XElement ToMvdXml()
        {
            return new XElement("Element");
        }

        /// <summary>
        /// Serialize to XML/Binary. This shall be override in sub classes 
        /// </summary>
        virtual public void Serialize()
        {

        }


        //virtual public Dictionary<uint, P21Instance> P21Intances(uint startEIN, uint interval)
        //{
        //    return new Dictionary<uint, P21Instance>();
        //}


        //public List<Part21.P21Instance> InstancesPopulated = new List<P21Instance>();

        public virtual int CompareTo(object obj)
        {

            var sBase = obj as BbBase;
            if (sBase == null) return -1;

            if (sBase.GetType() != GetType()) return -1;


            if (Guid == sBase.Guid) return 0;

            return 1;
        }


        public SortedDictionary<string, P21Instance> GetEarlyBindingInstances()
        {
            var myPropertyInfos = new SortedDictionary<string, P21Instance>();
            foreach (var propertyInfo in GetType().GetProperties())
            {
                if (!propertyInfo.GetCustomAttributes(typeof(EarlyBindingInstance), false).Any()) continue;
                var a = propertyInfo.Name;
                var c = propertyInfo.GetValue(this, null) as P21Instance;
                if (c == null) continue;
                myPropertyInfos.Add(a, c);
            }
            return myPropertyInfos;
        }


        //public SortedDictionary<string, P21Instance> IfcInstances {
        //    get { return GetIfcEarlyBindingP21Instances(); }
        //}



        /// <summary>
        /// get Early Binding IFC instances in the class ordered by the name of Ifc Entity name
        /// </summary>
        /// <param name="semBase">Sem Instance</param>
        /// <returns>sorted dictionary of Ifc Instances</returns>
        private SortedDictionary<string, P21Instance> GetIfcEarlyBindingP21Instances()
        {
            var ret = new SortedDictionary<string, P21Instance>();

            foreach (var propertyInfo in GetType().GetProperties())
            {
                foreach (var attribute in propertyInfo.GetCustomAttributes(true))
                {
                    if (!(attribute is EarlyBindingInstance)) continue;
                    var a = propertyInfo.Name;
                    var c = propertyInfo.GetValue(this, null) as P21Instance;
                    if (!string.IsNullOrWhiteSpace(a) && c != null)
                        ret.Add(a, c);
                }
            }
            return ret;
        }

        public virtual int CompareToIfcValues(BbBase sBase)
        {

            if (sBase == null) return -1;

            var thisIns = GetEarlyBindingInstances();
            var thatIns = sBase.GetEarlyBindingInstances();

            return thisIns.Any(p21Instance => p21Instance.Value.EIN != thatIns[p21Instance.Key].EIN) ? 1 : 0;
        }



    }
}