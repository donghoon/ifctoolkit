using System;
using System.Collections.Generic;
using BlackBox.Service;
using IfcBase;
using IFC2X3;
using EbInstanceModel;


namespace BlackBox.Predefined
{
    public partial class BbDirection3D : BbBase
    {
        IfcDirection ifcDirection;

        [EarlyBindingInstance]
        public IfcDirection IfcDirection
        {
            get
            {
                return ifcDirection;
            }
            set
            {
                ifcDirection = value;
            }
        }


        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public double this[int index]
        {
            get
            {
                if (index == 0) return X;
                if (index == 1) return Y;
                if (index == 2) return Z;
                throw new IndexOutOfRangeException();
            }
        }


        BbDirection3D(double x, double y, double z)
            : this(new double[] { x, y, z })
        {
        }

        BbDirection3D(double[] x)
        {
            if (x.Length == 3)
            {

                x = MathService.Normalize(x);

                X = x[0];
                Y = x[1];
                Z = x[2];

                IfcDirection = new IfcDirection
                {
                    DirectionRatios = new List<REAL> { X, Y, Z },
                };
            }
            else
            {
                throw new ArgumentException();
            }
        }

        

        public static BbDirection3D Create(double[] x)
        {
            var direction3D = new BbDirection3D(x);
            BbInstanceDB.AddToExport(direction3D);
            return direction3D;


        }

        public static BbDirection3D Create(double x, double y, double z)
        {
            var direction3D = new BbDirection3D(x, y, z);
            BbInstanceDB.AddToExport(direction3D);
            return direction3D;
        }
    }


}
