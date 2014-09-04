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
    public partial class BbCurveGeometry : BbElementGeometry
    {

        private IfcPolyline _ifcPolyline;

        IfcShapeRepresentation _ifcShapeRepresentation;
        IfcProductDefinitionShape _ifcProductDefinitionShape;

        public BbCoordinate3D[] Points { get; set; }

        [EarlyBindingInstance]
        public override IfcGeometricRepresentationItem IfcGeometricRepresentationItem
        {
            get { return _ifcPolyline; }
            set { base.IfcGeometricRepresentationItem = _ifcPolyline = value as IfcPolyline; }
        }

        [EarlyBindingInstance]
        public override IfcShapeRepresentation IfcShapeRepresentation
        {
            get { return _ifcShapeRepresentation; } 
            
        }
        [EarlyBindingInstance]
        public override IfcProductDefinitionShape IfcProductDefinitionShape { get { return _ifcProductDefinitionShape; } }



        public BbCurveGeometry(
             BbPolyline3D bbPolyline3D
            )
        {
            _ifcPolyline = bbPolyline3D.IfcCurve as IfcPolyline;

            

            _ifcShapeRepresentation = new IfcShapeRepresentation
                {
                    ContextOfItems = BbHeaderSetting.Setting3D.GeometricRepresentationContext,
                    RepresentationIdentifier = "Body",
                    RepresentationType = "GeometricCurveSet",
                    Items = new List<IfcRepresentationItem>(),
                };
            _ifcShapeRepresentation.Items.Add(_ifcPolyline);
			
            _ifcProductDefinitionShape = new IfcProductDefinitionShape
                {
                    // Name=
                    // Description = 
                    Representations = new List<IfcRepresentation>(),
                };
            _ifcProductDefinitionShape.Representations.Add(_ifcShapeRepresentation);
        }

        public BbCurveGeometry() 
        {
        }
        public static BbCurveGeometry Create(
            BbPolyline3D bbPolyline3Durve
            )
        {
            var extrudedGeometry = new BbCurveGeometry(bbPolyline3Durve);
            BbInstanceDB.AddToExport(extrudedGeometry);
            return extrudedGeometry;
        }

    }

}
