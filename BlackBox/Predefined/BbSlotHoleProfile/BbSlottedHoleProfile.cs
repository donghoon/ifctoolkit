using System;
using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
    public class BbSlottedHoleProfile : BbArbitraryProfile
    {
        IfcArbitraryClosedProfileDef _ifcProfileDef;

        [EarlyBindingInstance]
        public override IfcProfileDef IfcProfileDef
        {
            get { return _ifcProfileDef; }
            set { _ifcProfileDef = value as IfcArbitraryClosedProfileDef; }
        }

        public double CenterToCenterDistance { get; private set; }
        public double Radius { get; protected set; }

        public BbSlottedHoleProfile(double cToCDistance, double radius)
           
        {

            var cir1 = new IfcCircle
                {
                    Position = new IfcAxis2Placement
                        {
                            Value =  new IfcAxis2Placement2D
                                {
                                    Location = new IfcCartesianPoint(cToCDistance / 2.0, 0),
                                },
                        },
                    Radius = radius,
                };
            var trimmed1 = new IfcTrimmedCurve
                {
                    BasisCurve = cir1,
                    Trim1 = new List<IfcTrimmingSelect>{new IfcTrimmingSelect{Value = new IfcParameterValue{Value = 270}}},
                    Trim2 = new List<IfcTrimmingSelect> { new IfcTrimmingSelect { Value = new IfcParameterValue { Value = 90 } } },
                    SenseAgreement = true,
                    MasterRepresentation = IfcTrimmingPreference.PARAMETER,
                };

            var line1 = new IfcPolyline
                {
                    Points = new List<IfcCartesianPoint>
                        {
                            new IfcCartesianPoint(cToCDistance / 2.0, radius),
                            new IfcCartesianPoint(cToCDistance / -2.0, radius),
                        },
                };

            var cir2 = new IfcCircle
                {
                    Position = new IfcAxis2Placement
                        {
                            Value = new IfcAxis2Placement2D
                                {
                                    Location = new IfcCartesianPoint(cToCDistance / -2.0, 0),
                                },
                        },
                    Radius = radius,
                };
            var trimmed2 = new IfcTrimmedCurve
                {
                    BasisCurve = cir2,
                    Trim1 = new List<IfcTrimmingSelect> { new IfcTrimmingSelect { Value = new IfcParameterValue { Value = 90 } } },
                    Trim2 = new List<IfcTrimmingSelect> { new IfcTrimmingSelect { Value = new IfcParameterValue { Value = 270 } } },
                    SenseAgreement = true,
                    MasterRepresentation = IfcTrimmingPreference.PARAMETER,
                };

            var line2 = new IfcPolyline
                {
                    Points = new List<IfcCartesianPoint>
                        {
                            new IfcCartesianPoint(cToCDistance / -2.0, -radius),
                            new IfcCartesianPoint(cToCDistance / 2.0, -radius),
                        },
                };


            var seg1 = new IfcCompositeCurveSegment
                {
                    Transition = IfcTransitionCode.CONTSAMEGRADIENTSAMECURVATURE,
                    SameSense = true,
                    ParentCurve = trimmed1,
                };
            var seg2 = new IfcCompositeCurveSegment
                {
                    Transition = IfcTransitionCode.CONTSAMEGRADIENTSAMECURVATURE,
                    SameSense = true,
                    ParentCurve = line1,
                };

            var seg3 = new IfcCompositeCurveSegment
                {
                    Transition = IfcTransitionCode.CONTSAMEGRADIENTSAMECURVATURE,
                    SameSense = true,
                    ParentCurve = trimmed2,
                };
            var seg4 = new IfcCompositeCurveSegment
                {
                    Transition = IfcTransitionCode.CONTSAMEGRADIENTSAMECURVATURE,
                    SameSense = true,
                    ParentCurve = line2,
                };


            var cCurve = new IfcCompositeCurve
                {
                    Segments = new List<IfcCompositeCurveSegment>
                        {
                            seg1, seg2, seg3, seg4
                        },
                    SelfIntersect = EbInstanceModel.LOGICAL.dbTrue,


                };

            _ifcProfileDef = new IfcArbitraryClosedProfileDef
                {
                    ProfileType = IfcProfileTypeEnum.AREA,
                    OuterCurve = cCurve,
                };

        }

        private BbSlottedHoleProfile()
        {
        }


        public static BbProfile Create(double cToCDistance, double radius, BbDirection2D refDirection)
        {
            BbProfile ch = new BbSlottedHoleProfile(cToCDistance, radius);
            
            // what is this?
            // why it creates derived?
            if (refDirection.IfcDirection.DirectionRatios[0] != 1 && refDirection.IfcDirection.DirectionRatios[1] != 0)
            {
                ch = BbDerivedProfile.Create(ch,
                                           Math.Atan2(refDirection.IfcDirection.DirectionRatios[1],
                                                      refDirection.IfcDirection.DirectionRatios[0]));
            }
            else {
                BbInstanceDB.AddToExport(ch);
            }
            
            return ch;
        }

        /// <summary>
        /// wrong implmentation
        /// </summary>
        /// <param name="extrudedGeometry"></param>
        /// <returns></returns>
        public static BbSlottedHoleProfile Retrieve(BbExtrudedGeometry extrudedGeometry)
        {
            var ret = new BbSlottedHoleProfile();
            //var profileDef = extrudedGeometry._ifcExtrudedAreaSolid.SweptArea as IfcArbitraryClosedProfileDef;
            //var semHProfile = new BbSlottedHoleProfile { IfcProfileDef = profileDef };
            //BbInstanceDB.AddToExport(semHProfile);
            //ret = semHProfile;
            return ret;
        }
    }
}