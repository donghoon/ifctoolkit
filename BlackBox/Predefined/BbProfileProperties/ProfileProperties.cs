using Sem.Service;

namespace Sem.Predefined
{
    public class ProfileProperties : SemBase{
        public string Type{ get; set; }
        public double? WNominalWeight{ get; set; }
        public double? ACrossSectionalArea{ get; set; }
        public double? dOveralDepth{ get; set; }
        public double? ddetDetailingDepth{ get; set; }
        public double? HtOveralDepthRectangle{ get; set; }


    }
}