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
    public partial class BbPolyline3D : BbCurve
    {
        private IfcPolyline _ifcPolyline;

        [EarlyBindingInstance]
        public override IfcCurve IfcCurve{ 
            get { return _ifcPolyline; }
            protected set { _ifcPolyline = value as IfcPolyline; }
        }

        public BbPolyline3D (BbCoordinate3D[] points)
        {
            base.IfcCurve = _ifcPolyline = new IfcPolyline();

            _ifcPolyline.Points = new List<IfcCartesianPoint> ();

            foreach (var point in points) {
                _ifcPolyline.Points.Add( point.IfcCartesianPoint);
            }
        }

        public BbPolyline3D() 
        {
        }

        public static BbPolyline3D Create(BbCoordinate3D[] points)
        {
            var pLine = new BbPolyline3D(points);

            BbInstanceDB.AddToExport(pLine);
            return pLine;
        }



        
        
    }

}
