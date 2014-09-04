using System;
using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

	public partial class BbCoordinate2D : BbBase
	{
		public IfcCartesianPoint ifcCartesianPoint;

		double x;
		double y;

		public double X { get { return x; } }
		public double Y { get { return y; } }
		
		[EarlyBindingInstance]
		public IfcCartesianPoint IfcCartesianPoint {
			get {
				return ifcCartesianPoint;
			}
			set {
				ifcCartesianPoint = value;
			}
		}
		
//		public Coordinate2D ()
//			:this (new double[]{0,0})
//		{
//		}

        protected BbCoordinate2D(double[] coordinate)
			:this(coordinate[0], coordinate[1])
		{
		}

		protected BbCoordinate2D (double x, double y)
		{
			this.x = x;
			this.y = y;
			var list = new List<IfcLengthMeasure> {x, y};

		    IfcCartesianPoint = new IfcCartesianPoint{
				Coordinates = list,
			};
		}


        protected BbCoordinate2D() 
            :this(0,0)
        {
        }

		public static BbCoordinate2D Create(double[] x)
		{
			if(x.Length != 2) throw new InvalidCastException();
			return Create(x[0], x[1]);
		}


		public static BbCoordinate2D Create(double x, double y)
		{
			var coord2D = new BbCoordinate2D(x, y);
			BbInstanceDB.AddToExport(coord2D);
			return coord2D;
		}

	    public static BbCoordinate2D Create()
	    {
	        return Create(0, 0);
	    }

	    /*
        public static ICollection<BbCoordinate2D> Retrieve()
        {
            if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcCartesianPoint")) return null;

            var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcCartesianPoint"].Values;

            var ret = new List<BbCoordinate2D>();
            foreach (var item in collection)
            {
                var point = item as IfcCartesianPoint;
                if (point == null) continue;
                var semPoint = new BbCoordinate2D { ifcCartesianPoint = point };
                BbInstanceDB.Add(semPoint);
                ret.Add(semPoint);
            }
            return ret;
        }
        */

	}
	
}
