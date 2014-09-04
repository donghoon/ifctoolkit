using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EbInstanceModel
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ImmediateAttribute : Attribute
    {
    }

    //[AttributeUsage(AttributeTargets.Field)]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class InverseAttribute : Attribute
    {
    }


    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class CollectionAttriubte : Attribute
    {
    }


}
