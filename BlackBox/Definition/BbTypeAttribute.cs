using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchemaModel;
using System.Xml;

namespace BlackBox
{
    public partial class  BbTypeAttribute
    {
        public BbTypeAttribute()
        {
        }

        public BbTypeAttribute(string name, string type)
            : base(name, type)
        {
        }


        ////private BbDefinition _semDefinition;

        //private string _subSemName;
        //private  Guid _guid;

        //public BbTypeAttribute()
        //{
        //}


        //public BbTypeAttribute(string subSemName, Guid guid)
        //    :base()
        //{
        //    _subSemName = subSemName;
        //    _guid = guid;
        //}
        ////SubSemMapping(BbDefinition BbDefinition)
        ////    :base()
        ////{
        ////    _semDefinition = BbDefinition;
        ////}

        //public static BbTypeAttribute Create(string subSemName, Guid guid)
        //{
        //    BbTypeAttribute semMapping = new BbTypeAttribute(subSemName, guid);
        //    //_subSemMappingList.Add(semMapping);
        //    return semMapping;
        //}
        ////public static SubSemMapping Create(BbDefinition semDef) {
        ////    SubSemMapping semMapping = new SubSemMapping(semDef);
        ////    //_subSemMappingList.Add(semMapping);
        ////    return semMapping;
        ////}


        //public string mappedSubSemName
        //{
        //    get { return _subSemName; }
        //    set { _subSemName = value; }
        //}
        //public Guid mappedSubSemGuid
        //{
        //    get { return _guid; }
        //    set { _guid = value; }
        //}
        ////public BbDefinition mappedSubSem {
        ////    get { return _semDefinition; }
        ////}




    }
}
