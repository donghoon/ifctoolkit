using System;
using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

    //public interface ISemSpatialElement
    //{
    //    IfcSpatialStructureElement IfcSpatialStructureElement { get; set; }
    //    IfcRelAggregates IfcRelAggregates { get; set; }
    //    List<BbElement> SpatialComponents { get; set; }
    //    void AddContained(BbElement element);
    //    ISemSpatialElement Create(string name, ISemSpatialElement container);
    //}

    public partial class BbSpatialElement : BbProduct //, ISemSpatialElement
	{

		[EarlyBindingInstance]
		public virtual IfcSpatialStructureElement IfcSpatialStructureElement{ get; set;}

        //[EarlyBindingInstance]
        //public virtual IfcRelAggregates IfcRelAggregates { get; set; }

        //[SpatialContainmentsCollection]
        //public virtual List<BbElement> SpatialComponents { get; set; }

        //[EarlyBindingInstance]
        //public virtual IfcRelContainedInSpatialStructure IfcRelContainedInSpatialStructure { get; set; }


        protected BbSpatialElement()
        {
        }

        protected BbSpatialElement(Guid guid)
            : base(guid)
        {
        }


        //public void AddContained (BbElement element)
        //{
        //    if (IfcRelContainedInSpatialStructure == null) {
        //        IfcRelContainedInSpatialStructure = new IfcRelContainedInSpatialStructure
        //        { 
        //            GlobalId = IfcGloballyUniqueId.NewGuid(),
        //            OwnerHistory = element.IfcElement.OwnerHistory,
        //            RelatingStructure = IfcSpatialStructureElement,
        //            RelatedElements = new List<IfcProduct>(),
        //        };
                
        //    }
        //    IfcRelContainedInSpatialStructure.RelatedElements.Add (element.IfcElement);

        //    if (SpatialComponents == null) {
        //        SpatialComponents = new List<BbElement> ();
        //    }
        //    SpatialComponents.Add (element);
        //}


        //public virtual ISemSpatialElement Create(string name, ISemSpatialElement container)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
