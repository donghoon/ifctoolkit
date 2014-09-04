using System;
using System.Collections.Generic;
using System.Linq;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{

    public partial class BbProduct : BbBase
    {

        [EarlyBindingInstance]
        public virtual IfcRelAggregates IfcRelAggregates { get; protected set; }


		public BbLocalPlacement3D ObjectBbLocalPlacement { get; protected set; }
        
        
        public virtual IfcObject IfcObject { get; protected set; }

        public string Name
        {
            get { return IfcObject.Name; }
            protected set { IfcObject.Name = value; }
        }

        public string Description
        {
            get { return IfcObject.Description; }
            protected set { IfcObject.Description = value; }
        }

        public string ObjectType
        {
            get { return IfcObject.ObjectType; }
            protected set { IfcObject.ObjectType = value; }
        }


        [EarlyBindingInstanceCollection]
        public BbProduct HostObject { get; protected set; }



        protected BbProduct()
            : this(Guid.NewGuid())
        {
        }

        protected BbProduct(Guid guid)
            : base(guid)
        {
        }




        public void AddToHostObject(BbProduct hostObject)
        {
            HostObject = hostObject;
            var a = EarlyBindingInstanceModel.GetReferencedEntities(hostObject.IfcObject.EIN).Values;

            var b = (from x in a.OfType<IfcRelAggregates>()
                     where x.RelatingObject.EIN == hostObject.IfcObject.EIN
                     select x).ToList();

            switch (b.Count)
            {

                case 0:
                    IfcRelAggregates = new IfcRelAggregates
                    {
                        GlobalId = IfcGloballyUniqueId.NewGuid(),
                        OwnerHistory = hostObject.IfcObject.OwnerHistory,
                        RelatingObject = hostObject.IfcObject,
                        RelatedObjects = new List<IfcObjectDefinition>() { },
                    };
                    break;
                case 1:
                    IfcRelAggregates = b[0];
                    break;
                default:
                    throw new NotImplementedException();
            }
            var aa = GetType().GetProperty("IfcObject").GetValue(this, null) as IfcObject;

            IfcRelAggregates.RelatedObjects.Add(aa);
        }

    }
    
}
