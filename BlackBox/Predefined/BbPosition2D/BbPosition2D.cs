using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

	public partial class BbPosition2D : BbBase
	{
		IfcAxis2Placement2D ifcAxis2Placement2D;
		
		[EarlyBindingInstance]
		public IfcAxis2Placement2D IfcAxis2Placement2D {
			get {
				return ifcAxis2Placement2D;
			}
			set {
				ifcAxis2Placement2D = value;
			}
		}
		
        // BbPosition2D ()
        //    :this(BbCoordinate2D.Origin2D)
        //{
        //}
		
        // BbPosition2D (BbCoordinate2D coordinate2D)
        //    :this(coordinate2D, BbDirection2D.RefDirection2D)
        //{
        //}
		
		 BbPosition2D (BbCoordinate2D coordinate2D,
		                   BbDirection2D refDirection)
		{
			ifcAxis2Placement2D = new IfcAxis2Placement2D{
				Location = coordinate2D.IfcCartesianPoint,
				RefDirection = refDirection.IfcDirection,

			};
		}
		
        // BbPosition2D (double[] position)
        //    :this(BbCoordinate2D.Create(position))
        //{
        //}
		
//		public static Position2D Create ()
//		{
//			Position2D position = new Position2D ();
//			
//			BbInstanceDB.Add (position);
//			return position;
//		}
		
        //public static BbPosition2D Create (double[] position)
        //{
        //    BbPosition2D position2D = new BbPosition2D (position);
        //    BbInstanceDB.AddToExport (position2D);
        //    return position2D;
        //}
		
        //public static BbPosition2D Create (BbCoordinate2D coordinate2D)
        //{
        //    BbPosition2D position2D = new BbPosition2D (coordinate2D);
        //    BbInstanceDB.AddToExport (position2D);
        //    return position2D;
        //}
		
		public static BbPosition2D Create (BbCoordinate2D coordinate2D,
		                                 BbDirection2D refDirection)
		{
			BbPosition2D position = new BbPosition2D (coordinate2D, refDirection);
			BbInstanceDB.AddToExport (position);
			return position;
		}

        //public static BbPosition2D DefaultPosition2D;

        //static BbPosition2D()
        //{
        //    DefaultPosition2D = new BbPosition2D();
        //}
		
	}
	
}
