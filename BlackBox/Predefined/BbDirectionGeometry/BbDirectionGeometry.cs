using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;
using System.Linq;

namespace BlackBox.Predefined
{
    public partial class BbDirectionGeometry : BbElementGeometry
    {

        private IfcDirection _ifcDirection;

        IfcShapeRepresentation _ifcShapeRepresentation;
        IfcProductDefinitionShape _ifcProductDefinitionShape;

        public BbCoordinate3D[] Points { get; set; }

        [EarlyBindingInstance]
        public override IfcGeometricRepresentationItem IfcGeometricRepresentationItem
        {
            get { return _ifcDirection; }
            set { base.IfcGeometricRepresentationItem = _ifcDirection = value as IfcDirection; }
        }

        [EarlyBindingInstance]
        public override IfcShapeRepresentation IfcShapeRepresentation { get { return _ifcShapeRepresentation; } }
        [EarlyBindingInstance]
        public override IfcProductDefinitionShape IfcProductDefinitionShape { get { return _ifcProductDefinitionShape; } }



        public BbDirectionGeometry(
             BbDirection3D bbDirection
            )
        {
            _ifcDirection = bbDirection.IfcDirection;



            _ifcShapeRepresentation = new IfcShapeRepresentation
                {
                    ContextOfItems = BbHeaderSetting.Setting3D.GeometricRepresentationContext,
                    RepresentationIdentifier = "Body",
                    RepresentationType = "GeometricCurveSet",
                    Items = new List<IfcRepresentationItem>(),
                };
            _ifcShapeRepresentation.Items.Add(_ifcDirection);

            _ifcProductDefinitionShape = new IfcProductDefinitionShape
                {
                    // Name=
                    // Description = 
                    Representations = new List<IfcRepresentation>(),
                };
            _ifcProductDefinitionShape.Representations.Add(_ifcShapeRepresentation);
        }

        public BbDirectionGeometry()
        {
        }
        public static BbDirectionGeometry Create(
            BbDirection3D bbDirection
            )
        {
            var extrudedGeometry = new BbDirectionGeometry(bbDirection);
            BbInstanceDB.AddToExport(extrudedGeometry);
            return extrudedGeometry;
        }

    }

}
