using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchemaModel;
using System.Xml;


namespace BlackBox
{

    //public class Mapping : ICSharpClass
    //{
    //    readonly Guid _guid;
    //    //string _attributeName;
    //    //Type _attributeType;
    //    //private SEntity _sEntity;
    //    //private SAttribute _sAttribute;



    //    protected Mapping()
    //    {
    //        _guid = Guid.NewGuid();
    //    }

    //    public System.Guid MappingGuid
    //    {
    //        get { return _guid; }
    //    }

    //    //DH
    //    //public string AttributeName {
    //    //    get{return _attributeName;} }

    //    //public Type AttributeType {
    //    //    get{return _attributeType;} }


    //    //public SEntity MappedEntity { get; set; }
    //    //public SAttribute MapptedAttribute { get; set; }



    //    //Mapping	(
    //    //    string attributeName, Type attributeType, SEntity mappedEntity, SAttribute mappedAttribute)
    //    //    :this()
    //    //{
    //    //    _attributeName = attributeName;
    //    //    _attributeType = attributeType;
    //    //    _sEntity = mappedEntity;
    //    //    _sAttribute = mappedAttribute;
    //    //    if(!_sEntity.FlatList.Contains(_sAttribute)) throw  new Exception();

    //    //}


    //    //Mapping (BbDefinition sem, SEntity entity)
    //    //    :this()
    //    //{
    //    //    sem.AddEntityMapping(this);
    //    //    _sEntity = entity;
    //    //}

    //    //public static Mapping Create(
    //    //    string attributeName, Type attributeType, SEntity mappedEntity, SAttribute mappedAttribute)
    //    //{
    //    //    var mapping = new Mapping(attributeName, attributeType, mappedEntity, mappedAttribute);
    //    //    return mapping;
    //    //}


    //    //public static Mapping Create (BbDefinition sem, SEntity entity)
    //    //{
    //    //    var mapping = new Mapping(sem, entity);
    //    //    return mapping;
    //    //}

    //    //    public void ToCSharpClass(StreamWriter stream)
    //    //    {
    //    //        var sb = new stringbuilder();

    //    //        public ifcbuilding ifcbuilding { get; set; }
    //    //        sb.appendline("\t\t[earlybindinginstance]");
    //    //        sb.appendline(string.format("\t\tpublic {0} {0} {{ get; set; }}", _sentity.name));
    //    //        sb.appendline();
    //    //        stream.write( sb.tostring());

    //    //    }
    //    //}




    //    public void ToCSharpClass(StreamWriter stream)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}