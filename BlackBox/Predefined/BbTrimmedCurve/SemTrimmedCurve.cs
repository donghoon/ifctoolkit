using IFC2X3;
using Sem.Service;

namespace Sem.Predefined
{
    public class SemTrimmedCurve : SemCurve
    {
        private IfcTrimmedCurve ifcTrimmedCurve;


        [EarlyBindingInstance]
        public override IfcCurve IfcCurve
        {
            get
            {
                return ifcTrimmedCurve;
            }
        } 
    }

}