using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

	public class BbFace :BbBase{

        [EarlyBindingInstance]
		public IfcFace IfcFace { get; set;}


        protected BbFace (IList<BbCoordinate3D> points)
		{

			List<IfcCartesianPoint> cPoints = new List<IfcCartesianPoint> ();
			foreach (var p in points) {
				cPoints.Add(p.IfcCartesianPoint);
			}

			IfcPolyLoop ifcPolyLoop = new IfcPolyLoop{
				Polygon = cPoints,};
			IfcFaceOuterBound ifFaceBound = new IfcFaceOuterBound{
				Bound = ifcPolyLoop,
				Orientation = true,
			};

			IfcFace = new IfcFace{
				Bounds = new List<IfcFaceBound>(){ifFaceBound},
			};
		}

		public static BbFace Create (IList<BbCoordinate3D> points)
		{
			return new BbFace(points);
		}

	}

}
