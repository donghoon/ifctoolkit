using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;
using System.Collections.Generic;

namespace BlackBox.Predefined
{

	public class BbNamedRectangleProfile : BbNamedProfile
	{
		IfcRectangleProfileDef ifcRectangleProfileDef;

		double LengthX;
		double LengthY;

		[EarlyBindingInstance]
		public override IfcProfileDef IfcProfileDef
		{
			get { return ifcRectangleProfileDef; }
			set { ifcRectangleProfileDef = value as IfcRectangleProfileDef; }
		}

		BbNamedRectangleProfile (double lengthX, double lengthY)
		{
			LengthX = lengthX;
			LengthY = lengthY;
			ifcRectangleProfileDef = new IfcRectangleProfileDef
			{
				ProfileType = IfcProfileTypeEnum.AREA,
				//ProfileName = Name,
				Position = BbHeaderSetting.Setting3D.Position2D.IfcAxis2Placement2D,
				XDim = LengthX,
				YDim = LengthY
			};
		}

        private BbNamedRectangleProfile()
        {
        }

		public static BbNamedRectangleProfile Create(double lengthX, double lengthY)
		{
			var rectProfile = new BbNamedRectangleProfile(lengthX, lengthY);
			BbInstanceDB.AddToExport(rectProfile);
			return rectProfile;
		}

        /// <summary>
        /// wrong implementation
        /// </summary>
        /// <param name="extrudedGeometry"></param>
        /// <returns></returns>
        public static BbNamedRectangleProfile Retrieve(BbExtrudedGeometry extrudedGeometry)
        {
            var ret = new BbNamedRectangleProfile();
            //var profileDef = extrudedGeometry._ifcExtrudedAreaSolid.SweptArea as IfcRectangleProfileDef;
            //var semRProfile = new BbNamedRectangleProfile { IfcProfileDef = profileDef };
            //BbInstanceDB.AddToExport(semRProfile);
            //ret = semRProfile;            
            return ret;
        }
	}

}