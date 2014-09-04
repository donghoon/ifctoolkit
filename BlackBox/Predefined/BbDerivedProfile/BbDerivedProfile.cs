using System;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
    public class BbDerivedProfile : BbProfile
    {
        private IfcDerivedProfileDef _ifcDerivedProfileDef;

        [EarlyBindingInstance]
        public override IfcProfileDef IfcProfileDef
        {
            get { return _ifcDerivedProfileDef; }
            set { _ifcDerivedProfileDef = value as IfcDerivedProfileDef; }
        }


		public BbDerivedProfile (BbProfile parentProfile)
		{
			_ifcDerivedProfileDef = new IfcDerivedProfileDef{
				ProfileType = IfcProfileTypeEnum.AREA,
				ParentProfile = parentProfile.IfcProfileDef,
			};

			Name = parentProfile.Name;

			Width = parentProfile.Width;
			Depth = parentProfile.Depth;
		}

		public BbDerivedProfile (BbProfile parentProfile, double rotationRadian)
			:this(parentProfile)
		{
			var ifcCartesianTransformationOperator2D 
			= new IfcCartesianTransformationOperator2D{

				Axis1 = new IfcDirection(Math.Cos(rotationRadian), Math.Sin(rotationRadian)),
				Axis2 = new IfcDirection(-Math.Sin(rotationRadian), Math.Cos(rotationRadian)),
                LocalOrigin = BbHeaderSetting.Setting3D.Origin2D.IfcCartesianPoint,
				Scale = 1,
			};
			_ifcDerivedProfileDef.Operator = ifcCartesianTransformationOperator2D;
		}



		/// <summary>
		/// Initializes a new instance of the <see cref="BlackBox.Aisc.EM11.DerivedProfile"/> class.
		/// </summary>
		/// <param name='parentProfile'>
		/// Parent profile.
		/// </param>
		/// <param name='mirrorXAxis'>
		/// If set to <c>true</c> mirror X axis.
		/// </param>
		/// <param name='mirrorYAxis'>
		/// If set to <c>true</c> mirror Y axis.
		/// </param>
		public BbDerivedProfile (BbProfile parentProfile, bool mirrorXAxis, bool mirrorYAxis)
			:this(parentProfile)
		{
			IfcDirection axis1 = null;
			IfcDirection axis2 = null;

			if (mirrorXAxis && mirrorYAxis) {
				axis1 = BbHeaderSetting.Setting3D.XAxisMinus2D.IfcDirection;
                axis2 = BbHeaderSetting.Setting3D.YAxisMinus2D.IfcDirection;

			} else if (mirrorXAxis && !mirrorYAxis) {
                axis1 = BbHeaderSetting.Setting3D.XAxis2D.IfcDirection;
                axis2 = BbHeaderSetting.Setting3D.YAxisMinus2D.IfcDirection;
			} else if (!mirrorXAxis && mirrorYAxis) {
                axis1 = BbHeaderSetting.Setting3D.XAxisMinus2D.IfcDirection;
                axis2 = BbHeaderSetting.Setting3D.YAxis2D.IfcDirection;
			}


			var ifcCartesianTransformationOperator2D 
			= new IfcCartesianTransformationOperator2D{
				Axis1 = axis1,
				Axis2 = axis2,
                LocalOrigin = BbHeaderSetting.Setting3D.Origin2D.IfcCartesianPoint,
				Scale = 1,
			};
			_ifcDerivedProfileDef.Operator = ifcCartesianTransformationOperator2D;
		}

        private BbDerivedProfile()
        { }


		public static BbDerivedProfile Create(BbProfile parentProfile, double rotationAngle)
		{
			var derivedProfile = new BbDerivedProfile(parentProfile, rotationAngle);
			BbInstanceDB.AddToExport(derivedProfile);
			return derivedProfile;
		}

		public static BbDerivedProfile Create(BbProfile parentProfile, bool mirrorXAxis, bool mirrorYAxis)
		{
			var derivedProfile = new BbDerivedProfile(parentProfile, mirrorXAxis, mirrorYAxis);
			BbInstanceDB.AddToExport(derivedProfile);
			return derivedProfile;
		}

        /// <summary>
        /// wrong implmentation
        /// </summary>
        /// <param name="extrudedGeometry"></param>
        /// <returns></returns>
        public static BbDerivedProfile Retrieve(BbExtrudedGeometry extrudedGeometry)
        {
            var ret = new BbDerivedProfile();
            //var profileDef = extrudedGeometry._ifcExtrudedAreaSolid.SweptArea as IfcDerivedProfileDef;
            //var semDProfile = new BbDerivedProfile { IfcProfileDef = profileDef };

            ////Retrieving ParentProfile
            //var parent = profileDef.ParentProfile;
            //if (parent.GetType() == typeof(IfcIShapeProfileDef))
            //{ var parentProfile = BbNamedIProfile.Retrieve(extrudedGeometry); }
            //if (parent.GetType() == typeof(IfcLShapeProfileDef))
            //{ var parentProfile = BbNamedLProfile.Retrieve(extrudedGeometry); }

            ////BbInstanceDB.Add(semLProfile);
            //ret = semDProfile;
            return ret;
        }

    }
}