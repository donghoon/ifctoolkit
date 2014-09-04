using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
    public partial class BbLocalPlacement3D : BbBase
    {
        [EarlyBindingInstance]
        public IfcLocalPlacement IfcLocalPlacement { get; set; }


        public BbLocalPlacement3D()
            : this(null, null)
        { }

        BbLocalPlacement3D(BbPosition3D relativePlacement)
            : this(null, relativePlacement)
        {

        }

        BbLocalPlacement3D(BbLocalPlacement3D placementRelTo)
            : this(placementRelTo, null)
        {
        }

        BbLocalPlacement3D(
           BbLocalPlacement3D placementRelTo, BbPosition3D relativePlacement)
        {
            if (placementRelTo != null && relativePlacement != null)
            {
                IfcLocalPlacement = new IfcLocalPlacement
                {
                    PlacementRelTo = placementRelTo.IfcLocalPlacement,
                    RelativePlacement = new IfcAxis2Placement
                    {
                        Value = relativePlacement.IfcAxis2Placement3D,
                    },

                };
            }
            else if (placementRelTo == null && relativePlacement != null)
            {
                IfcLocalPlacement = new IfcLocalPlacement
                {
                    RelativePlacement = new IfcAxis2Placement
                    {
                        Value = relativePlacement.IfcAxis2Placement3D,
                    },

                };
            }
            else
            {
                IfcLocalPlacement = new IfcLocalPlacement
                {


                    RelativePlacement = new IfcAxis2Placement
                    {
                        Value = BbHeaderSetting.Setting3D.DefaultBbPosition3D.IfcAxis2Placement3D,
                    },

                };
            }
        }

        protected BbLocalPlacement3D(IfcLocalPlacement ifcLocalPlacement)
        {
            IfcLocalPlacement = ifcLocalPlacement;
        }

        public static BbLocalPlacement3D OriginPlacement;

        //static LocalPlacement3D ()
        //{
        //    OriginPlacement = Create();
        //}

        //public static LocalPlacement3D Create()
        //{
        //    LocalPlacement3D placement3D = new LocalPlacement3D();
        //    BbInstanceDB.Add(placement3D);
        //    return placement3D;
        //}

        public static BbLocalPlacement3D Create(BbPosition3D relativePlacement)
        {
            var placement3D = new BbLocalPlacement3D(relativePlacement);
            BbInstanceDB.AddToExport(placement3D);
            return placement3D;
        }

        public static BbLocalPlacement3D Create(BbLocalPlacement3D placementRelTo)
        {
            var placement3D = new BbLocalPlacement3D(placementRelTo);
            BbInstanceDB.AddToExport(placement3D);
            return placement3D;
        }

        public static BbLocalPlacement3D Create(BbLocalPlacement3D placementRelTo, BbPosition3D relativePlacement)
        {
            var placement3D = new BbLocalPlacement3D(placementRelTo, relativePlacement);
            BbInstanceDB.AddToExport(placement3D);
            return placement3D;
        }

        public static BbLocalPlacement3D Create(IfcLocalPlacement ifcLocalPlacement)
        {
            
            var placement3D = new BbLocalPlacement3D(ifcLocalPlacement);
            BbInstanceDB.AddToExport(placement3D);
            return placement3D;
        }

    }

}
