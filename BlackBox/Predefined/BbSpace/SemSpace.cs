using Sem.Service;
using IFC2X3;

namespace Sem.Predefined
{

    public partial class SemSpace : SemSpatialElement
    {
        [EarlyBindingInstance]
        public IfcSpace IfcSpace { get; set; }
    }
}
