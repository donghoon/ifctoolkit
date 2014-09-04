using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

    /// <summary>
    /// Cope location.
    /// </summary>
    public enum SemCopeLocation
    {
        BottomLeft,
        BottomRight,
        TopLeft,
        TopRight,
    }

	/// <summary>
	/// Cope profile.
	/// </summary>
	public class BbCopeProfile : BbArbitraryProfile
	{
		public BbCopeProfile (double copeWidth,
		                         double copeDepth,
		                         double copeRadius)
			:base()
		{
			/*
			 *          |      | width (length) 
			 *        -        |-------
			 * depth  - |------| <- radius
			 *          |
			 *          |--------------
			 * 
			 * */
			
			//1 point
			BbCoordinate2D first = BbHeaderSetting.Setting3D.Origin2D;
			BbCoordinate2D second = BbCoordinate2D.Create (new double[]{copeWidth, 0});
			BbCoordinate2D third = BbCoordinate2D.Create (new double[] {
				copeWidth,
				copeRadius - copeDepth
			});
			BbCoordinate2D fourth = BbCoordinate2D.Create (new double[] {
				copeWidth - copeRadius,
				-copeDepth
			});
			BbCoordinate2D fifth = BbCoordinate2D.Create (new double[]{0,  -copeDepth});
			
			BbPolyline2D bbPolyline2D = BbPolyline2D.Create (new BbCoordinate2D[] {
				first,
				second,
				third,
				fourth,
				fifth
			});

			var profile = IfcProfileDef as IfcArbitraryClosedProfileDef;
			profile.OuterCurve = bbPolyline2D.IfcCurve;
			
		}
		
		public static BbCopeProfile Create (double copeWidth,
		                                       double copeDepth,
		                                       double copeRadius)
		{
			var profile = new BbCopeProfile (copeWidth, copeDepth, copeRadius);
			BbInstanceDB.AddToExport (profile);
			return profile;
		}
		
		public BbCopeProfile (  double copeWidth,
		                         double copeDepth,
		                         double copeRadius,
		                         SemCopeLocation copeLocation)
			:base()
		{
			/*
			 *          |      | width (length) 
			 *        -        |-------
			 * depth  - |------| <- radius
			 *          |
			 *          |--------------
			 * 
			 * */
			
			BbCoordinate2D first;
			BbCoordinate2D second;
			BbCoordinate2D third;
			BbCoordinate2D fourth;
			BbCoordinate2D fifth;

			switch (copeLocation) {
			case SemCopeLocation.BottomLeft:
                    first = BbHeaderSetting.Setting3D.Origin2D;
				second = BbCoordinate2D.Create (new double[]{0, copeDepth});
				third = BbCoordinate2D.Create (new double[] {
					copeWidth - copeRadius,
					copeDepth
				});
				fourth = BbCoordinate2D.Create (new double[] {
					copeWidth,
					copeDepth - copeRadius
				});
				fifth = BbCoordinate2D.Create (new double[]{copeWidth,  0});
				break;
			case SemCopeLocation.BottomRight:
                first = BbHeaderSetting.Setting3D.Origin2D;
				second = BbCoordinate2D.Create (new double[] {
					 - copeWidth,
					0
				});
				third = BbCoordinate2D.Create (new double[] {
					 - copeWidth,
					copeDepth - copeRadius
				});
				fourth = BbCoordinate2D.Create (new double[] {
					 - copeWidth + copeRadius,
					copeDepth
				});
				fifth = BbCoordinate2D.Create (new double[]{0,  copeDepth});
				break;
			case SemCopeLocation.TopRight:
                first = BbHeaderSetting.Setting3D.Origin2D;
				second = BbCoordinate2D.Create (new double[]{0, -copeDepth});
				third = BbCoordinate2D.Create (new double[] {
				- copeWidth + copeRadius,
				 - copeDepth
				});
				fourth = BbCoordinate2D.Create (new double[] {
					- copeWidth,
					-copeDepth + copeRadius
				});
				fifth = BbCoordinate2D.Create (new double[]{- copeWidth,  0});
				break;
			default:
                first = BbHeaderSetting.Setting3D.Origin2D;
				second = BbCoordinate2D.Create (new double[]{copeWidth, 0});
				third = BbCoordinate2D.Create (new double[] {
					copeWidth,
					copeRadius - copeDepth
				});
				fourth = BbCoordinate2D.Create (new double[] {
					copeWidth - copeRadius,
					-copeDepth
				});
				fifth = BbCoordinate2D.Create (new double[]{0,  -copeDepth});
				break;
			}
			
			BbPolyline2D bbPolyline2D = BbPolyline2D.Create (new BbCoordinate2D[] {
				first,
				second,
				third,
				fourth,
				fifth,
                first
			});
			var profile = this.IfcProfileDef as IfcArbitraryClosedProfileDef;
			profile.OuterCurve = bbPolyline2D.IfcCurve;
			
			//
		}

        private BbCopeProfile()
        {
        }
		
		public static BbCopeProfile Create (                              double copeWidth,
		                                       double copeDepth,
		                                       double copeRadius,
		                                       SemCopeLocation copeLocation)
		{
			var profile = new BbCopeProfile (copeWidth, copeDepth, copeRadius, copeLocation);
			BbInstanceDB.AddToExport (profile);
			return profile;
		}

        /// <summary>
        /// wrong implementation
        /// </summary>
        /// <param name="extrudedGeometry"></param>
        /// <returns></returns>
        public static BbCopeProfile Retrieve(BbExtrudedGeometry extrudedGeometry)
        {
            var ret = new BbCopeProfile();
            //var profileDef = extrudedGeometry._ifcExtrudedAreaSolid.SweptArea as IfcArbitraryClosedProfileDef;
            //var semCoProfile = new BbCopeProfile { IfcProfileDef = profileDef };
            //BbInstanceDB.AddToExport(semCoProfile);
            //ret = semCoProfile;
            return ret;
        }

	}
}
