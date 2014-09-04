using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchemaModel;
using System.Xml;

namespace BlackBox
{



    public partial class AttributeDefinition
    {

        //private string _attributeName;
        //private Type _attributeType;
        ////private SAttribute _mappedAttribute;
        //private string _mappedSAttributeName;
        //private string _mappedSEntityName;

        public AttributeDefinition()
        {
        }

        public bool Multi { get; set; }



        public AttributeDefinition(string attributeName, Type attributeType)
            : base(attributeName)
        {
            DataType = attributeType.ToString();
        }


        public AttributeDefinition(string attributeName, string attributeType)
            : base(attributeName)
        {
            DataType = attributeType;
        }

        ////public AttributeMapping(string attributeName, Type attributeType)
        ////    : this(attributeName, attributeType, null, null)
        ////{

        ////}

        ////public static AttributeMapping Create(string attributeName, Type attributeType)
        ////{
        ////    AttributeMapping attMapping = new AttributeMapping(attributeName, attributeType);
        ////    return attMapping;
        ////}

        ////public static AttributeMapping Create(string attributeName, Type attributeType, SAttribute mappedAttribute, string mappedSEntityName)
        ////{
        ////    AttributeMapping attMapping = new AttributeMapping(attributeName, attributeType, mappedAttribute, mappedSEntityName);
        ////    return attMapping;
        ////}

        //public static AttributeDefinition Create(string attributeName, Type attributeType, string mappedSAttributeName, string mappedSEntityName)
        //{
        //    AttributeDefinition attMapping = new AttributeDefinition(attributeName, attributeType, mappedSAttributeName, mappedSEntityName);
        //    return attMapping;
        //}


        //public string AttributeName
        //{
        //    get { return _attributeName; }
        //    set { _attributeName = value; }
        //}

        //public Type AttributeType
        //{
        //    get { return _attributeType; }
        //    set { _attributeType = value; }
        //}

        ////public SAttribute MappedAttribute
        ////{
        ////    get { return _mappedAttribute; }
        ////}

        //public string MappedAttributeName
        //{
        //    get { return _mappedSAttributeName; }
        //    set { _mappedSAttributeName = value; }
        //}

        //public string MappedSEntityName 
        //{
        //    get { return _mappedSEntityName; }
        //    set { _mappedSEntityName = value;}
        //}



    }
}
