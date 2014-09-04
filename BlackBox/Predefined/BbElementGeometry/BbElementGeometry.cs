using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
	public partial class BbElementGeometry : BbBase
	{
		[EarlyBindingInstance]
		public virtual IfcGeometricRepresentationItem IfcGeometricRepresentationItem { get; set; }

		[EarlyBindingInstance]
		public virtual IfcShapeRepresentation IfcShapeRepresentation{ get; set;}

		[EarlyBindingInstance]
		public virtual IfcProductDefinitionShape IfcProductDefinitionShape { get;  set;}

//		[EarlyBindingInstance]
//		public virtual IfcProductDefinitionShape IfcProductDefinitionShape { get; set; }
	}

}
