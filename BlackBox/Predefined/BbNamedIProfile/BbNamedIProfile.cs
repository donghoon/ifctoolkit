using BlackBox.Service;
using IFC2X3;
using System.Collections.Generic;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    public partial class BbNamedIProfile : BbNamedProfile
	{
		public IfcIShapeProfileDef _iShapeProfileDef;
       // public  double FilletRadius { get;  set; }
        public double WebThickness { get;  set; }
        public double FlangeThickness { get;  set; }


		public BbNamedIProfile(string name, string standard, double width, double depth, double webThickness,
		                     double flangeThickness )
		{
			Name = name;
            Stardard = standard;
			Width = width;
			Depth = depth;
			WebThickness = webThickness;
			FlangeThickness = flangeThickness;
		    //FilletRadius = filletRadius;

            _iShapeProfileDef = new IfcIShapeProfileDef
			{
				ProfileType = IfcProfileTypeEnum.AREA,
				ProfileName = Name,
				Position = BbHeaderSetting.Setting3D.Position2D.IfcAxis2Placement2D,
				OverallWidth = Width,
				OverallDepth = Depth,
				WebThickness = WebThickness,
				FlangeThickness = FlangeThickness,
                //FilletRadius = FilletRadius,
			};
		}

//        public override double Width { get; set; }
//        public override double Depth { get; set; }

        [EarlyBindingInstance]
        public override IfcProfileDef IfcProfileDef
        {
            get { return _iShapeProfileDef; }
            set { _iShapeProfileDef = value as IfcIShapeProfileDef; }
        }



        public BbNamedIProfile() 
        {
        }



        public static BbNamedIProfile Create(string standard, string name, double width, double depth, double webThickness,
                                           double flangeThickness)
        {
            var namedIProfile = new BbNamedIProfile(name, standard, width, depth, webThickness, flangeThickness);
			BbInstanceDB.AddToExport(namedIProfile);
            return namedIProfile;
        }
        

        /// <summary>
        /// wrong implementation
        /// </summary>
        /// <param name="extrudedGeometry"></param>
        /// <returns></returns>
        public static BbNamedIProfile Retrieve(BbExtrudedGeometry extrudedGeometry)
        {
            var ret = new BbNamedIProfile();
            //var profileDef = extrudedGeometry._ifcExtrudedAreaSolid.SweptArea as IfcIShapeProfileDef;
            //var semHProfile = new BbNamedIProfile { IfcProfileDef = profileDef };
            ////BbInstanceDB.Add(semHProfile);
            //ret = semHProfile;
            return ret;
        }
    }
}