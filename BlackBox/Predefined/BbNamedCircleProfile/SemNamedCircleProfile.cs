using BlackBox.Service;
using IFC2X3;


namespace BlackBox.Predefined
{

	public class BbBbNamedCircleProfile : BbNamedProfile
	{
		IfcCircleProfileDef ifcCircleProfileDef;

		double radius;

		public double Radius{ get { return radius; }}

		[EarlyBindingInstance]
		public override IfcProfileDef IfcProfileDef
		{
			get { return ifcCircleProfileDef; }
			set { ifcCircleProfileDef = value as IfcCircleProfileDef; }
		}

		BbBbNamedCircleProfile(double radius)
		{
			this.radius = radius;
			ifcCircleProfileDef = new IfcCircleProfileDef
			{
				ProfileType = IfcProfileTypeEnum.AREA,
				//ProfileName = Name,
				Position = BbHeaderSetting.Setting3D.Position2D.IfcAxis2Placement2D,
				Radius = radius,
			};
		}

        private BbBbNamedCircleProfile()
        {
        }


		public static BbBbNamedCircleProfile Create(double radius)
		{
			var circleProfile = new BbBbNamedCircleProfile(radius);
			BbInstanceDB.AddToExport(circleProfile);
			return circleProfile;
		}

        /// <summary>
        /// wrong implementation
        /// </summary>
        /// <param name="extrudedGeometry"></param>
        /// <returns></returns>
        public static BbBbNamedCircleProfile Retrieve(BbExtrudedGeometry extrudedGeometry)
        {
            var ret = new BbBbNamedCircleProfile();
            //var profileDef = extrudedGeometry._ifcExtrudedAreaSolid.SweptArea as IfcCircleProfileDef;
            //var semCiProfile = new BbBbNamedCircleProfile { IfcProfileDef = profileDef };
            //BbInstanceDB.AddToExport(semCiProfile);
            //ret = semCiProfile;
            return ret;
        }
	}


}