using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
    public class BbCurveSegment : BbGeometry
    {

        [EarlyBindingInstance]
        public IfcCompositeCurveSegment IfcCompositeCurveSegment { get; private set; }

        private BbCurveSegment(BbCurve bbCurve)
        {
            IfcCompositeCurveSegment
                = new IfcCompositeCurveSegment
                    {
                        Transition = IfcTransitionCode.CONTSAMEGRADIENTSAMECURVATURE,
                        SameSense = true,
                        ParentCurve = bbCurve.IfcCurve
                    };
        }

        public static BbCurveSegment Create(BbCurve bbCurve)
        {
            var cs = new BbCurveSegment(bbCurve);
            BbInstanceDB.AddToExport(cs);
            return cs;
        }

    }
}