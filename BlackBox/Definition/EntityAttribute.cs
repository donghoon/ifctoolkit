using System;

namespace BlackBox
{
    public partial class EntityAttribute
    {
        public EntityAttribute()
        {
        }

        public EntityAttribute(string name, string type)
            : base(name, type)
        {
        }

        public EntityAttribute(string attributeName, Type attributeType, string mappedSAttributeName, Guid mappedSEntityGuid)
            : base(attributeName, attributeType)
        {
            FkSEntityGuid = mappedSEntityGuid;
            IfcEntityAttribute = mappedSAttributeName;
        }

        public EntityAttribute(string attributeName, string attributeType, string mappedSAttributeName, Guid mappedSEntityGuid)
            : base(attributeName, attributeType)
        {
            FkSEntityGuid = mappedSEntityGuid;
            IfcEntityAttribute = mappedSAttributeName;
        }
    }
}