using System.Collections.Generic;
using IFC2X3;
using Sem.Service;

namespace Sem.Predefined
{
    public partial class SemTextGeometry : SemReferenceableGeometry
    {
		
        IfcTextLiteral _ifcTextLiteral;
        IfcShapeRepresentation _ifcShapeRepresentation;
        IfcProductDefinitionShape _ifcProductDefinitionShape;
		
		
        [EarlyBindingInstance]
        public override IfcGeometricRepresentationItem IfcGeometricRepresentationItem { 
            get{return _ifcTextLiteral;}
        }
		
        [EarlyBindingInstance]
        public override IfcShapeRepresentation  IfcShapeRepresentation{ get { return _ifcShapeRepresentation; } }
        [EarlyBindingInstance]
        public override IfcProductDefinitionShape IfcProductDefinitionShape { get { return _ifcProductDefinitionShape; } }
		
		
        public SemTextGeometry (
            string literal,
            SemPosition2D position2D
            )
        {
            _ifcTextLiteral = new IfcTextLiteral{
                Literal = literal,
                Placement = new IfcAxis2Placement(),
                Path = IfcTextPath.RIGHT,
            };

            _ifcTextLiteral.Placement.Value = position2D.IfcAxis2Placement2D;
            _ifcShapeRepresentation = new IfcShapeRepresentation
                {
                    ContextOfItems = SemHeaderSetting.Setting3D.GeometricRepresentationContext,
                    RepresentationIdentifier = "GeometricCurveSet",
                    RepresentationType = "Annotation2D",
                    Items = new List<IfcRepresentationItem>(),
                };
            _ifcShapeRepresentation.Items.Add(_ifcTextLiteral);
			
            _ifcProductDefinitionShape = new IfcProductDefinitionShape
                {
                    // Name=
                    // Description = 
                    Representations = new List<IfcRepresentation>(),
                };
            _ifcProductDefinitionShape.Representations.Add(_ifcShapeRepresentation);
        }
		
		
        public static SemTextGeometry Create(
            string literal,
            SemPosition2D position2D)
        {
            var textGeometry = new SemTextGeometry( literal,
                                                 position2D);
			
            return textGeometry;
        }

    }
}