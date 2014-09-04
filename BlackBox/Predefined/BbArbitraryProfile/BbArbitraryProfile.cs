using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

    public partial class BbArbitraryProfile : BbProfile
    {
        IfcArbitraryClosedProfileDef ifcArbitraryClosedProfileDef;

        [EarlyBindingInstance]
        public override IfcProfileDef IfcProfileDef
        {
            get { return ifcArbitraryClosedProfileDef; }
            set { ifcArbitraryClosedProfileDef = value as IfcArbitraryClosedProfileDef; }
        }


        protected BbArbitraryProfile()
        {
            ifcArbitraryClosedProfileDef = new IfcArbitraryClosedProfileDef
            {
                ProfileType = IfcProfileTypeEnum.AREA,
               
            };
        }

        protected BbArbitraryProfile(BbPolyline2D bbPolyline2D)
            :this()
        {
            ifcArbitraryClosedProfileDef.OuterCurve = bbPolyline2D.IfcCurve;
        }

        public static BbArbitraryProfile Create(BbPolyline2D bbPolyline2D)
        {
            var arb = new BbArbitraryProfile(bbPolyline2D);
            BbInstanceDB.AddToExport(arb);
            return arb;
        }
    }
}