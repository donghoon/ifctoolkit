using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    public class BbSurfaceGeometry : BbElementGeometry
    {

        public IfcCurveBoundedPlane ifcCurveBoundedPlane;

        IfcShapeRepresentation _ifcShapeRepresentation;
        IfcProductDefinitionShape _ifcProductDefinitionShape;

        public BbCoordinate3D[] Points { get; set; }

        [EarlyBindingInstance]
        public override IfcGeometricRepresentationItem IfcGeometricRepresentationItem
        {
            get { return ifcCurveBoundedPlane; }
        }

        [EarlyBindingInstance]
        public override IfcShapeRepresentation IfcShapeRepresentation { get { return _ifcShapeRepresentation; } }
        [EarlyBindingInstance]
        public override IfcProductDefinitionShape IfcProductDefinitionShape { get { return _ifcProductDefinitionShape; } }



        public BbSurfaceGeometry(
            BbPolyline2D outerCurve,
            IEnumerable<BbPolyline2D> innerCurves 
            )
        {
            ifcCurveBoundedPlane = new IfcCurveBoundedPlane
                {
                    BasisSurface = new IfcPlane
                        {
                            Position = BbHeaderSetting.Setting3D.DefaultBbPosition3D.IfcAxis2Placement3D,
                        },
                    OuterBoundary = outerCurve.IfcCurve,
                    InnerBoundaries = new List<IfcCurve>()
                };

            if (innerCurves != null)
            {
                foreach (var inn in innerCurves)
                {
                    ifcCurveBoundedPlane.InnerBoundaries.Add(inn.IfcCurve);
                }
            }
            

            _ifcShapeRepresentation = new IfcShapeRepresentation
                {
                    ContextOfItems = BbHeaderSetting.Setting3D.GeometricRepresentationContext,
                    RepresentationIdentifier = "Surface",
                    RepresentationType = "GeometricSet",
                    Items = new List<IfcRepresentationItem>(),
                };
            _ifcShapeRepresentation.Items.Add(ifcCurveBoundedPlane);
			
            _ifcProductDefinitionShape = new IfcProductDefinitionShape
                {
                    // Name=
                    // Description = 
                    Representations = new List<IfcRepresentation>(),
                };
            _ifcProductDefinitionShape.Representations.Add(_ifcShapeRepresentation);
        }

        public BbSurfaceGeometry() 
        {
        }
        public static BbSurfaceGeometry Create(
            BbPolyline2D outerCurve,
            IEnumerable<BbPolyline2D> innerCurves)
        {
            var extrudedGeometry = new BbSurfaceGeometry(outerCurve, innerCurves);
            return extrudedGeometry;
        }

        /*
        public static ICollection<BbSurfaceGeometry> Retrieve(PaintFinish ) 
        {
            if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcCurveBoundedPlane")) return null;
            //IfcShapeRepresentation
            //IfcProductDefinitionShape 
            var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcCurveBoundedPlane"].Values;

            var ret = new List<BbSurfaceGeometry>(); //sem BbSurfaceGeometry list nist
            foreach (var item in collection)
            {
                var curvePlane = item as IfcCurveBoundedPlane;
                if (curvePlane == null) continue;
                var surfaceGeometry = new BbSurfaceGeometry { ifcCurveBoundedPlane = curvePlane };
                BbInstanceDB.Add(surfaceGeometry);
                ret.Add(surfaceGeometry); //sem BbSurfaceGeometry list nist
            }
            return ret;
        }
        */

        public static ICollection<BbPolyline2D> RetrievePolylines(BbSurfaceGeometry surfaceGeometry)
        {
            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcPolyline")) return null;

            var collection = EarlyBindingInstanceModel.GetDataByType("IfcPolyline").Values;

            var ret = new List<BbPolyline2D>();
            foreach (var item in collection)
            {
                if (item.EIN == surfaceGeometry.ifcCurveBoundedPlane.OuterBoundary.EIN) 
                {
                    var polyLine = item as IfcPolyline;
                    if (polyLine == null) continue;
                    var semPolyLine = new BbPolyline2D { ifcPolyline = polyLine };
                    BbInstanceDB.AddToExport(semPolyLine);
                    ret.Add(semPolyLine);
                }

                var innerBoundries = surfaceGeometry.ifcCurveBoundedPlane.InnerBoundaries;
                foreach (var innerBoundry in innerBoundries)
                {
                    if (item.EIN == innerBoundry.EIN)
                    {
                        var polyLine = item as IfcPolyline;
                        if (polyLine == null) continue;
                        var semPolyLine = new BbPolyline2D { ifcPolyline = polyLine };
                        BbInstanceDB.AddToExport(semPolyLine);
                        ret.Add(semPolyLine);
                    }
                }
            }
            return ret;
        }
    }
}