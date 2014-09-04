using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

    public partial class BbPosition3D : BbBase
    {
        public IfcAxis2Placement3D ifcAxis2Placement3D;

        [EarlyBindingInstance]
        public IfcAxis2Placement3D IfcAxis2Placement3D
        {
            get
            {
                return ifcAxis2Placement3D;
            }
            set
            {
                ifcAxis2Placement3D = value;
            }
        }


        public BbCoordinate3D Coordinate3D { get; set; }
        public BbDirection3D Axis { get; set; }
        public BbDirection3D RefDirection { get; set; }

        //BbPosition3D()
        //    : this(BbCoordinate3D.Origin)
        //{
        //}

        //BbPosition3D(BbCoordinate3D coordinate3D)
        //    : this(coordinate3D,  BbDirection3D.Axis, BbDirection3D.RefDirection)
        //{
        //}

        BbPosition3D(BbCoordinate3D coordinate3D,
                          BbDirection3D axis, BbDirection3D refDirection)
        {
            Coordinate3D = coordinate3D;
            Axis = axis;
            RefDirection = refDirection;

            ifcAxis2Placement3D = new IfcAxis2Placement3D
            {
                Location = coordinate3D.IfcCartesianPoint,
                RefDirection = refDirection.IfcDirection,
                Axis = axis.IfcDirection,
            };
        }

        //		public Position3D (double[] position)
        //			:this(Coordinate3D.Create(position))
        //		{
        //		}

        //		public static Position3D Create ()
        //		{
        //			Position3D position = new Position3D ();
        //
        //			BbInstanceDB.Add (position);
        //			return position;
        //		}


        //		public static Position3D Create (double[] position)
        //		{
        //			Position3D position3D = new Position3D (position);
        //			BbInstanceDB.Add (position3D);
        //			return position3D;
        //		}


        //public static BbPosition3D Create()
        //{
        //    return Create(BbCoordinate3D.Create());
        //}

        //public static BbPosition3D Create(BbCoordinate3D coordinate3D)
        //{
        //    BbPosition3D position3D = new BbPosition3D(coordinate3D);
        //    BbInstanceDB.AddToExport(position3D);
        //    return position3D;
        //}

        public static BbPosition3D Create(BbCoordinate3D coordinate3D,
                                         BbDirection3D axis, BbDirection3D refDirection)
        {
            BbPosition3D position = new BbPosition3D(coordinate3D, axis, refDirection);
            BbInstanceDB.AddToExport(position);
            return position;
        }


        
        //private static BbPosition3D _defaultPosition;

        //public static BbPosition3D DefaultPosition
        //{
        //    get
        //    {
        //        if (_defaultPosition == null)
        //        {
        //            _defaultPosition = Create();
        //        }
        //        return _defaultPosition;
        //    }
        //}


    }



}
