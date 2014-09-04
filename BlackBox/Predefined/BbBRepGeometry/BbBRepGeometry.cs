using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

	public class BbBRepGeometry : BbElementGeometry
    {

		IfcFacetedBrep ifcFacetedBrep;
		
		IfcShapeRepresentation _ifcShapeRepresentation;
		IfcProductDefinitionShape _ifcProductDefinitionShape;

		public BbCoordinate3D[] Points { get; set; }
				
		[EarlyBindingInstance]
		public override IfcGeometricRepresentationItem IfcGeometricRepresentationItem { 
			get{return ifcFacetedBrep;}
		}

		[EarlyBindingInstance]
		public override IfcShapeRepresentation  IfcShapeRepresentation{ get { return _ifcShapeRepresentation; } }
		[EarlyBindingInstance]
		public override IfcProductDefinitionShape IfcProductDefinitionShape { get { return _ifcProductDefinitionShape; } }

		public BbBRepGeometry (
			IList<BbFace> faces
		)
		{

			var _faces = new List<IfcFace> ();
			foreach (var item in faces) {
				_faces.Add(item.IfcFace);
			}

			ifcFacetedBrep = new IfcFacetedBrep{
				Outer = new IfcClosedShell{
					CfsFaces = _faces,
				},
//				SweptArea = profile.IfcProfileDef,
//				Position = position3D.IfcAxis2Placement3D,
//				ExtrudedDirection = direction3D.IfcDirection,
//				Depth = depth,
			};
			
			_ifcShapeRepresentation = new IfcShapeRepresentation
			{
                ContextOfItems = BbHeaderSetting.Setting3D.GeometricRepresentationContext,
				RepresentationIdentifier = "Body",
				RepresentationType = "Brep",
				Items = new List<IfcRepresentationItem>(),
			};
			_ifcShapeRepresentation.Items.Add(ifcFacetedBrep);
			
			_ifcProductDefinitionShape = new IfcProductDefinitionShape
			{
				// Name=
				// Description = 
				Representations = new List<IfcRepresentation>(),
			};
			_ifcProductDefinitionShape.Representations.Add(_ifcShapeRepresentation);
		}
		
		public static BbBRepGeometry Create(
			IList<BbFace> faces)
		{
			var extrudedGeometry = new BbBRepGeometry(faces);
			
			return extrudedGeometry;
		}
	
	}
}
