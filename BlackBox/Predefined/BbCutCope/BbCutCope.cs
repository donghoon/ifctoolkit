using BlackBox.Service;
using IFC2X3;
using System;
using EbInstanceModel;
using System.Collections.Generic;

namespace BlackBox.Predefined
{
    /// <summary>
    /// Cut cope.
    /// </summary>
    public class BbCutCope : BbFeature
    {
        private IfcOpeningElement _ifcOpeningElement;
        private IfcRelVoidsElement _ifcRelVoidsElement;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcOpeningElement; }
            protected set
            {
                var a = value as IfcOpeningElement;
                if (a != null) _ifcOpeningElement = a;
            }
        }


        [EarlyBindingInstance]
        public IfcRelVoidsElement IfcRelVoidsElement
        {
            get { return _ifcRelVoidsElement; }
        }

        BbCutCope(
            BbElement hostElement,
            double copeWidth,
            double copeDepth,
            double copeRadius,
            SemCopeLocation copeLocation)
        {

            BbCopeProfile profile = BbCopeProfile.Create(copeWidth, copeDepth, copeRadius, copeLocation);

            var mainPart = hostElement as BbPiece;
            if (mainPart == null)
                return;

            BbPosition3D pos;

            switch (copeLocation)
            {

                case SemCopeLocation.BottomLeft:
                    pos = BbPosition3D.Create(
                        BbCoordinate3D.Create(new double[] {
					mainPart.Profile.Width / 2,
					-mainPart.Profile.Depth / 2,
					0
				}),
                        BbHeaderSetting.Setting3D.XAxisMinus,
                        BbHeaderSetting.Setting3D.ZAxis);
                    break;
                case SemCopeLocation.BottomRight:
                    pos = BbPosition3D.Create(
                        BbCoordinate3D.Create(new double[] {
					mainPart.Profile.Width / 2,
					- mainPart.Profile.Depth / 2,
					mainPart.Length
				}),
                        BbHeaderSetting.Setting3D.XAxisMinus,
                        BbHeaderSetting.Setting3D.ZAxis);
                    break;
                case SemCopeLocation.TopRight:
                    pos = BbPosition3D.Create(
                        BbCoordinate3D.Create(new double[] {
					mainPart.Profile.Width / 2,
					mainPart.Profile.Depth / 2,
					mainPart.Length
				}),
                        BbHeaderSetting.Setting3D.XAxisMinus,
                        BbHeaderSetting.Setting3D.ZAxis);
                    break;
                default: // TopLeft
                    pos = BbPosition3D.Create(
                        BbCoordinate3D.Create(new double[] {
					mainPart.Profile.Width / 2,
					mainPart.Profile.Depth / 2,
					0
				}),
                        BbHeaderSetting.Setting3D.XAxisMinus,
                        BbHeaderSetting.Setting3D.ZAxis);
                    break;
            }

            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                hostElement.ObjectBbLocalPlacement, pos);

            BbExtrudedGeometry bbExtrudedGeometry = BbExtrudedGeometry.Create(
                profile,
                BbHeaderSetting.Setting3D.DefaultBbPosition3D,
                BbHeaderSetting.Setting3D.ZAxis,
                mainPart.Profile.Width);

            _ifcOpeningElement = new IfcOpeningElement
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = hostElement.IfcObject.OwnerHistory,
                // Name = 
                // Description =
                ObjectType = "Opening",
                ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
                Representation = bbExtrudedGeometry.IfcProductDefinitionShape,
            };

            _ifcRelVoidsElement = new IfcRelVoidsElement
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = hostElement.IfcObject.OwnerHistory,
                Name = "Cope",
                RelatingBuildingElement = hostElement.IfcObject as IfcElement,
                RelatedOpeningElement = _ifcOpeningElement,
            };
        }

        public BbCutCope(
            BbElement hostElement,
            double copeWidth,
            double copeDepth,
            double copeRadius,
            double[] position)
        {
            BbCopeProfile profile = BbCopeProfile.Create(copeWidth, copeDepth, copeRadius);

            var mainPart = hostElement as BbPiece;
            if (mainPart == null)
                return;

            BbPosition3D pos = BbPosition3D.Create(
                BbCoordinate3D.Create(position),
                BbHeaderSetting.Setting3D.XAxisMinus,
                BbHeaderSetting.Setting3D.ZAxis);

            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                hostElement.ObjectBbLocalPlacement, pos);

            BbExtrudedGeometry bbExtrudedGeometry = BbExtrudedGeometry.Create(
                profile,
                BbHeaderSetting.Setting3D.DefaultBbPosition3D,
                BbHeaderSetting.Setting3D.ZAxis,
                mainPart.Profile.Width);

            _ifcOpeningElement = new IfcOpeningElement
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = hostElement.IfcObject.OwnerHistory,
                // Name = 
                // Description =
                ObjectType = "Opening",
                ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
                Representation = bbExtrudedGeometry.IfcProductDefinitionShape,
            };

            _ifcRelVoidsElement = new IfcRelVoidsElement
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = hostElement.IfcObject.OwnerHistory,
                Name = "Cope",
                RelatingBuildingElement = hostElement.IfcObject as IfcElement,
                RelatedOpeningElement = _ifcOpeningElement,
            };
        }

        public BbCutCope(
            BbElement hostElement,
            BbProfile profile,
            double length,
            double[] zAxis,
            double[] xAxis,
            double[] extrudeDirection,
            double[] position)
        {
            //ObjectLocalPlacement = new LocalPlacement3D(hostElement.ObjectLocalPlacement, new Position3D(position));

            /// from main piece
            BbPosition3D pos = BbPosition3D.Create(
                BbCoordinate3D.Create(position),
                BbDirection3D.Create(zAxis),
                BbDirection3D.Create(xAxis));

            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                hostElement.ObjectBbLocalPlacement, pos);

            BbDirection3D exDir;

            if (Math.Round(extrudeDirection[0], 8) == 0.0 && Math.Round(extrudeDirection[0], 8) == 0 && Math.Round(extrudeDirection[0], 8) == 1)
            {
                exDir = BbHeaderSetting.Setting3D.ZAxis;
            }
            else
            {
                exDir = BbDirection3D.Create(extrudeDirection);
            }


            BbExtrudedGeometry bbExtrudedGeometry = BbExtrudedGeometry.Create(
                profile,
                BbHeaderSetting.Setting3D.DefaultBbPosition3D,
                exDir,
                length);

            _ifcOpeningElement = new IfcOpeningElement
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = hostElement.IfcObject.OwnerHistory,
                // Name = 
                // Description =
                ObjectType = "Opening",
                ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
                Representation = bbExtrudedGeometry.IfcProductDefinitionShape,
            };

            _ifcRelVoidsElement = new IfcRelVoidsElement
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = hostElement.IfcObject.OwnerHistory,
                Name = "Cope",
                RelatingBuildingElement = hostElement.IfcObject as IfcElement,
                RelatedOpeningElement = _ifcOpeningElement,
            };
        }

        private BbCutCope()
        {
        }

        public static BbCutCope Create(BbElement hostElement,
                                     BbProfile profile,
                                     double length,
                                     double[] zAxis,
                                     double[] xAxis,
                                     double[] extrudeDirection,
                                     double[] position)
        {
            var cutCope = new BbCutCope(hostElement,
                                       profile,
                                       length,
                                       zAxis,
                                      xAxis,
                                       extrudeDirection,
                                      position);

            BbInstanceDB.AddToExport(cutCope);
            return cutCope;
        }

        public static BbCutCope Create(BbElement hostElement,
                                     double copeWidth,
                                     double copeDepth,
                                     double copeRadius,
                                     double[] position)
        {
            var cutCope = new BbCutCope(hostElement, copeWidth, copeDepth, copeRadius, position);
            BbInstanceDB.AddToExport(cutCope);
            return cutCope;
        }
        public static BbCutCope Create(BbElement hostElement,
                                      double copeWidth,
                                      double copeDepth,
                                      double copeRadius,
                                      SemCopeLocation copeLocation)
        {
            var cutCope = new BbCutCope(hostElement, copeWidth, copeDepth, copeRadius, copeLocation);
            BbInstanceDB.AddToExport(cutCope);
            return cutCope;
        }

        public static BbCutCope Create(BbElement hostElement,
                                      double copeWidth,
                                      double copeDepth,
                                      double copeRadius,
                                      SemCopeLocation copeLocation,
                                      BbPropertySet bbPropertySet,
                                      double chamferLength,
                                      double chamferDepth,
                                      double flangeChamferLength,
                                      double flangeChamferWidth,
                                      double flangeNotchLength,
                                      double flangeNotchWidth,
                                      double flangeNotchRadius,
                                      double notchLength,
                                      double notchDepth,
                                      double notchRadius)
        {
            var cutCope = new BbCutCope(hostElement, copeWidth, copeDepth, copeRadius, copeLocation);
            cutCope.AddCutCopeProperty(bbPropertySet, chamferLength, chamferDepth, flangeChamferLength, flangeChamferWidth, flangeNotchLength,
                                        flangeNotchWidth, flangeNotchRadius, notchLength, notchDepth, notchRadius);
            BbInstanceDB.AddToExport(cutCope);
            return cutCope;
        }


        public void AddCutCopeProperty(BbPropertySet bbPropertySet, double chamferLength,
                                        double chamferDepth,
                                        double flangeChamferLength,
                                        double flangeChamferWidth,
                                        double flangeNotchLength,
                                        double flangeNotchWidth,
                                        double flangeNotchRadius,
                                        double notchLength,
                                        double notchDepth,
                                        double notchRadius
                                        )
        {
            bbPropertySet.AddProperty(BbSingleProperty.Create("ChamferLength", chamferLength, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("ChamferDepth", chamferDepth, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("FlangeChamferLength", flangeChamferLength, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("FlangeChamferWidth", flangeChamferWidth, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("FlangeNotchLength", flangeNotchLength, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("FlangeNotchWidth", flangeNotchWidth, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("FlangeNotchRadius", flangeNotchRadius, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("NotchLength", notchLength, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("NotchDepth", notchDepth, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("NotchRadius", notchRadius, typeof(IfcPositiveLengthMeasure)));
        }


        public static ICollection<BbCutCope> Retrieve(BbElement element) 
        {
            var ret = new List<BbCutCope>();
            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelVoidsElement")) return null;
            var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelVoidsElement").Values;
            //if (collection.Count != 1) throw new NotImplementedException();
            foreach (var item in collection)
            {
                var theItem = item as IfcRelVoidsElement;
                if (theItem == null) continue;
                // need modification
                //if (theItem.RelatingBuildingElement.EIN == element.IfcObject.EIN)
                //{
                //    var OpeningElement = theItem.RelatedOpeningElement as IfcOpeningElement;
                //    if (theItem.Name == "Cope")
                //    {
                //        var semCutCope = new BbCutCope { ifcOpeningElement = OpeningElement, ifcRelVoidsElement = theItem };
                //        //BbInstanceDB.Add(semCutCope);
                //        ret.Add(semCutCope);

                //        // Retrieve localPlacement of BbCutCope
                //        var placement = semCutCope.ifcOpeningElement.ObjectPlacement as IfcLocalPlacement;
                //        var objectLocalPlacement = new BbLocalPlacement3D { IfcLocalPlacement = placement };
                //        semCutCope.ObjectBbLocalPlacement = objectLocalPlacement;

                //        //Retrieve related Sems
                //        var semPosition3D = BbFeature.RetrievePosition(semCutCope);
                //        var semExtrudedGeometry = BbExtrudedGeometry.RetrieveFromFeature(semCutCope);
                //        var semCopeProfile = BbCopeProfile.Retrieve(semExtrudedGeometry);
                //    }
                //}
            }        
            return ret;
        }
    }
}
