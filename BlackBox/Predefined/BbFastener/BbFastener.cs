using BlackBox.Service;
using IFC2X3;


namespace BlackBox.Predefined
{
    /// <summary>
    /// Fastener.
    /// </summary>
    public class BbFastener : BbElement
    {

        [EarlyBindingInstance]
        public IfcRelConnectsElements IfcRelConnectsElements { get; set; }


    }
}