using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    public class BbPolyline2D : BbCurve
    {
        public IfcPolyline ifcPolyline;

        [EarlyBindingInstance]
        public override IfcCurve IfcCurve{ get { return ifcPolyline; } }

        public BbPolyline2D (BbCoordinate2D[] points)
        {
            ifcPolyline = new IfcPolyline();

            ifcPolyline.Points = new List<IfcCartesianPoint> ();

            foreach (var point in points) {
                ifcPolyline.Points.Add( point.IfcCartesianPoint);
            }
        }

        public BbPolyline2D() 
        {
        }

        public static BbPolyline2D Create(BbCoordinate2D[] points)
        {
            var pLine = new BbPolyline2D(points);

            BbInstanceDB.AddToExport(pLine);
            return pLine;
        }

        /*
        public static ICollection<BbPolyline2D> RetrievePolylines(BbElementGeometry surfaceGeometry)
        {
            if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcPolyline")) return null;

            var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcPolyline"].Values;

            var ret = new List<BbPolyline2D>();
            foreach (var item in collection)
            {
                if (item.EIN == surfaceGeometry.ifcCurveBoundedPlane.OuterBoundary.EIN)
                {
                    var polyLine = item as IfcPolyline;
                    if (polyLine == null) continue;
                    var semPolyLine = new BbPolyline2D { ifcPolyline = polyLine };
                    BbInstanceDB.Add(semPolyLine);
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
                        BbInstanceDB.Add(semPolyLine);
                        ret.Add(semPolyLine);
                    }
                }
            }
            return ret;
        }
        */


        /// <summary>
        /// wrong implementation, do not use constructor
        /// </summary>
        /// <param name="polyLine"></param>
        /// <returns></returns>
        public static ICollection<BbCoordinate2D> RetrieveCartesianPoints(BbPolyline2D polyLine)
        {
            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcCartesianPoint")) return null;

            var collection = EarlyBindingInstanceModel.GetDataByType("IfcCartesianPoint").Values;

            var ret = new List<BbCoordinate2D>();
            foreach (var item in collection)
            {
                var points = polyLine.ifcPolyline.Points;
                foreach (var point in points)
                {
                    if (item.EIN == point.EIN)
                    {
                        var pt = item as IfcCartesianPoint;
                        if (pt == null) continue;
                        //var semPoint = new BbCoordinate2D { ifcCartesianPoint = pt };
                        //BbInstanceDB.AddToExport(semPoint);
                        //ret.Add(semPoint);
                    }
                }
            }
            return ret;
        }
    }
}