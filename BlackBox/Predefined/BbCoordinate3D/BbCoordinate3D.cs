using System;
using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

    public partial class BbCoordinate3D : BbBase
    {

        IfcCartesianPoint ifcCartesianPoint;

        double x;
        double y;
        double z;
        List<IfcLengthMeasure> list3D = new List<IfcLengthMeasure>();


        public double X { get { return x; } }
        public double Y { get { return y; } }
        public double Z { get { return z; } }

        [EarlyBindingInstance]
        public IfcCartesianPoint IfcCartesianPoint
        {
            get
            {
                return ifcCartesianPoint;
            }
            set
            {
                ifcCartesianPoint = value;
            }
        }

        //		public Coordinate3D ()
        //			:this (new double[]{0,0,0})
        //		{
        //		}


        BbCoordinate3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;


            list3D.Add(x);
            list3D.Add(y);
            list3D.Add(z);

            IfcCartesianPoint = new IfcCartesianPoint
            {
                Coordinates = list3D,

            };
        }

        BbCoordinate3D(double[] coordinate)
            : this(coordinate[0], coordinate[1], coordinate[2])
        {
        }

        //public static BbCoordinate3D Origin;

        //static BbCoordinate3D ()
        //{
        //    Origin = new BbCoordinate3D (0,0,0);
        //}

        public static BbCoordinate3D Create()
        {
            return Create(0, 0, 0);
        }


        public static BbCoordinate3D Create(double[] x)
        {
            if (x.Length != 3) throw new InvalidCastException();
            return Create(x[0], x[1], x[2]);
        }

        public static BbCoordinate3D Create(double x, double y, double z)
        {
            BbCoordinate3D coord3D = new BbCoordinate3D(x, y, z);
            BbInstanceDB.AddToExport(coord3D);
            return coord3D;
        }



        //public static ICollection<BbCoordinate3D> Retrieve()
        //{
        //    if (list3D.Count== 3) // list ro begir az tarighe yek function
        //    {
        //        if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcCartesianPoint")) return null;

        //        var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcCartesianPoint"].Values;

        //        var ret = new List<BbCoordinate3D>();
        //        foreach (var item in collection)
        //        {
        //            var point3D = item as IfcCartesianPoint;
        //            if (point3D == null) continue;
        //            var semPoint3D = new BbCoordinate3D { ifcCartesianPoint = point3D };
        //            BbInstanceDB.Add(semPoint3D);
        //            ret.Add(semPoint3D);
        //        }
        //        return ret;
        //    }
        //    else return null;
        //}


    }


}
