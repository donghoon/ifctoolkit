using BlackBox.Service;
using IFC2X3;
using System.Collections.Generic;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    public class BbNamedLProfile : BbNamedProfile
    {
        public IfcLShapeProfileDef _lShapeProfileDef;


		/// <summary>
		/// Initializes a new instance of the <see cref="BlackBox.Aisc.EM11.NamedLProfile"/> class.
		/// </summary>
		/// <param name='name'>
		/// Name.
		/// </param>
		/// <param name='standard'>
		/// Standard.
		/// </param>
		/// <param name='width'>
		/// Width.
		/// </param>
		/// <param name='depth'>
		/// Depth.
		/// </param>
		/// <param name='thickness'>
		/// Thickness.
		/// </param>
        public BbNamedLProfile(string name, string standard, double width, double depth, double thickness)
        {
            Name = name;
            Stardard = standard;
            Width = width;
            Depth = depth;
            Thickness = thickness;

            _lShapeProfileDef = new IfcLShapeProfileDef
                                    {
                                        ProfileType = IfcProfileTypeEnum.AREA,
                                        ProfileName = Name,
                                        Position =  BbHeaderSetting.Setting3D.Position2D.IfcAxis2Placement2D,
                                        Width = Width,
                                        Depth = Depth,
                                        Thickness = thickness,
                                    };
        }

//        public double Width { get; set; }
//        public double Depth { get; set; }
        public double Thickness { get; set; }

        [EarlyBindingInstance]
        public override IfcProfileDef IfcProfileDef
        {
            get { return _lShapeProfileDef; }
            set { _lShapeProfileDef = value as IfcLShapeProfileDef; }
        }

		/// <summary>
		/// Create the specified standard, name, width, depth and thickness.
		/// </summary>
		/// <param name='standard'>
		/// Standard.
		/// </param>
		/// <param name='name'>
		/// Name.
		/// </param>
		/// <param name='width'>
		/// Width.
		/// </param>
		/// <param name='depth'>
		/// Depth.
		/// </param>
		/// <param name='thickness'>
		/// Thickness.
		/// </param>
        public BbNamedLProfile() 
        {
        }
        public static BbNamedLProfile Create(string standard, string name, double width, double depth, double thickness)
        {
            var namedLProfile = new BbNamedLProfile(name, standard, width, depth, thickness);
			BbInstanceDB.AddToExport(namedLProfile);

            return namedLProfile;
        }

        /// <summary>
        /// wrong implmentation
        /// </summary>
        /// <param name="extrudedGeometry"></param>
        /// <returns></returns>
        public static BbNamedLProfile Retrieve(BbExtrudedGeometry extrudedGeometry)
        {
            var ret = new BbNamedLProfile();
            //var profileDef = extrudedGeometry._ifcExtrudedAreaSolid.SweptArea as IfcLShapeProfileDef;
            //var semLProfile = new BbNamedLProfile { IfcProfileDef = profileDef };
            ////BbInstanceDB.Add(semLProfile);
            //ret = semLProfile;
            return ret;
        }  
    }

}