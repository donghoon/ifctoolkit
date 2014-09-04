using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackBox.Service
{
    //[AttributeUsage(AttributeTargets.Field)]
    [AttributeUsage(AttributeTargets.Property)]
    public class EarlyBindingInstance : Attribute
    {

    }


    /// <summary>
    /// Indicate the first early binding instances
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class FirstEarlyBindingInstance : Attribute
    {

    }



    //[AttributeUsage(AttributeTargets.Field)]
    [AttributeUsage(AttributeTargets.Property)]
    public class EarlyBindingInstanceCollection : Attribute
    {
    }

    //[AttributeUsage(AttributeTargets.Field)]
    [AttributeUsage(AttributeTargets.Property)]
    public class SpatialContainmentsCollection : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class BbAttributeRetrieve : Attribute
    {
    }


    //// indicate an attribute in SEM data type
    //[AttributeUsage(AttributeTargets.Property)]
    //public class SemTypeAttribute : Attribute
    //{
    //}


    //// indicate an attribute in base data type
    //[AttributeUsage(AttributeTargets.Property)]
    //public class BaseTypeAttribute : Attribute
    //{
    //}


}
