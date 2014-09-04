using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{
    public partial class BbElement : BbProduct
    {
        
        public BbElementGeometry BbElementGeometry { get; protected set; }

        public double Length { get; set; }

        [EarlyBindingInstanceCollection]
        public BbSpatialElement BbSpatialElement { get; protected set; }

       


        [EarlyBindingInstance]
        public IfcRelCoversBldgElements IfcRelCoversBldgElements { get; protected set; }


        [EarlyBindingInstance]
        public IfcRelContainedInSpatialStructure IfcRelContainedInSpatialStructure { get; protected set; }


        //public List<BbPaintFinish> PaintFinishes { get; protected set; }


        //public void AddPaintFinish(BbPaintFinish paintFinish)
        //{
        //    if (PaintFinishes == null)
        //    {
        //        PaintFinishes = new List<BbPaintFinish>();
        //    }

        //    if (IfcRelCoversBldgElements == null)
        //    {
        //        IfcRelCoversBldgElements = new IfcRelCoversBldgElements
        //            {
        //                GlobalId = IfcGloballyUniqueId.NewGuid(),
        //                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
        //                RelatingBuildingElement = IfcObject as IfcElement,
        //                RelatedCoverings = new List<IfcCovering>(),
        //            };
        //    }

        //    IfcRelCoversBldgElements.RelatedCoverings.Add(paintFinish.IfcCovering);


        //    PaintFinishes.Add(paintFinish);
        //}

        //public void AddPaintFinish(SemPaintFinishPatch semPaintFinish, BbLocalPlacement3D semLocalPlacement3D)
        //{
        //    AddPaintFinish(semPaintFinish);
        //    semPaintFinish.BbLocalPlacement3D = semLocalPlacement3D;
        //}

        //public ICollection<BbElement> Retrieve();

        public void AddToSpatialElement(BbSpatialElement bbSpatialElement)
        {
            BbSpatialElement = bbSpatialElement;
            var a = EarlyBindingInstanceModel.GetReferencedEntities(bbSpatialElement.IfcSpatialStructureElement.EIN).Values;

            var b = (from x in a.OfType<IfcRelContainedInSpatialStructure>()
                     where x.RelatingStructure.EIN == bbSpatialElement.IfcSpatialStructureElement.EIN
                     select x).ToList();

            switch (b.Count)
            {

                case 0:
                    IfcRelContainedInSpatialStructure = new IfcRelContainedInSpatialStructure
                    {
                        GlobalId = IfcGloballyUniqueId.NewGuid(),
                        OwnerHistory = IfcObject.OwnerHistory,
                        RelatingStructure = bbSpatialElement.IfcSpatialStructureElement,
                        RelatedElements = new List<IfcProduct>() { },
                    };
                    break;
                case 1:
                    IfcRelContainedInSpatialStructure = b[0];
                    break;
                default:
                    throw new NotImplementedException();
            }

            IfcRelContainedInSpatialStructure.RelatedElements.Add(IfcObject as IfcElement);
        }


       



        protected BbElement()
            : this(Guid.NewGuid())
        {
        }

        protected BbElement(Guid guid)
            : base(guid)
        {
        }

    }

}
