using System.Collections.Generic;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{
    public class BbCompositeCurve : BbCurve
    {
        private IfcCompositeCurve ifcCompositeCurve;


        [EarlyBindingInstance]
        public override IfcCurve IfcCurve
        {
            get
            {
                return ifcCompositeCurve;
            }
        }

        public BbCompositeCurve()
        {
            ifcCompositeCurve = new IfcCompositeCurve
                {
                    Segments = new List<IfcCompositeCurveSegment>(),
                    SelfIntersect = LOGICAL.dbTrue,
                };
        }

        

    }
}