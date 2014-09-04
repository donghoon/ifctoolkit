using System;
using System.Collections.Generic;
using BlackBox.Service;
using IfcBase;
using IFC2X3;
using EbInstanceModel;


namespace BlackBox.Predefined
{

	public partial class BbDirection2D : BbBase
	{
		IfcDirection ifcDirection;
		
		[EarlyBindingInstance]
		public IfcDirection IfcDirection {
			get {
				return ifcDirection;
			}
			set {
				ifcDirection = value;
			}
		}
		
		 BbDirection2D (double x, double y)
			:this( new double[] {x, y})
		{
		}
		
		 BbDirection2D (double[] x)
		{
			if (x.Length == 2) {
				
				x = MathService.Normalize (x);
				
				List<REAL> list = new List<REAL>();
				list.Add(x[0]);
				list.Add(x[1]);

				IfcDirection = new IfcDirection{
					DirectionRatios = list,
				};
			} else {
				throw new ArgumentException ();
			}
		}
		
		
		
		public static BbDirection2D Create(double[] x)
		{
			BbDirection2D direction2D = new BbDirection2D (x);
			BbInstanceDB.AddToExport (direction2D);
			return direction2D;
			
		}
		
		public static BbDirection2D Create(double x, double y)
		{
			BbDirection2D direction2D = new BbDirection2D (x, y);
			BbInstanceDB.AddToExport (direction2D);
			return direction2D;
		}
	}
}
