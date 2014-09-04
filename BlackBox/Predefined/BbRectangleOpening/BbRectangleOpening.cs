using BlackBox.Service;
using IFC2X3;
using System.Collections.Generic;
using EbInstanceModel;


namespace BlackBox.Predefined
{
    public class BbRectangleOpening : BbOpening
    {

        protected BbRectangleOpening(
            BbElement hostElement,
            BbCoordinate2D position,
            double width,
            double height,
            SemHoleLocation location,
            bool through
            )
            : base(hostElement, position, BbNamedRectangleProfile.Create(width, height), location, through, "Rectangle Opening")
        {
        }

        protected BbRectangleOpening()
        {
        }

        public static BbRectangleOpening Create(BbElement hostElement,
                                     BbCoordinate2D position,
                                     double width,
                                     double height,
                                     SemHoleLocation location,
                                     bool through)
        {
            var hole = new BbRectangleOpening(hostElement, position, width, height, location, through);
            BbInstanceDB.AddToExport(hole);
            return hole;
        }

        public static BbRectangleOpening Create(BbElement hostElement,
                             BbCoordinate2D position,
                             double width,
                             double height,
                             SemHoleLocation location,
                             bool through,
                             BbPropertySet bbPropertySet,
                             string featureSubType,
                             double rectangleOpeningRoundRadius)
        {
            var hole = new BbRectangleOpening(hostElement, position, width, height, location, through);
            hole.AddRectangleOpeningProperty(bbPropertySet, featureSubType, width, height, rectangleOpeningRoundRadius);
            BbInstanceDB.AddToExport(hole);
            return hole;
        }

        public void AddRectangleOpeningProperty(BbPropertySet bbPropertySet, string featureSubType,
                                        double rectangleOpeningWidth,
                                        double rectangleOpeningHeight,
                                        double rectangleOpeningRoundRadius)
        {
            bbPropertySet.AddProperty(BbPropertyEnumerated.Create("FeatureSubtype", featureSubType, true));
            bbPropertySet.AddProperty(BbSingleProperty.Create("RectangleOpeningWidth", rectangleOpeningWidth, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("RectangleOpeningHeight", rectangleOpeningHeight, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("RectangleOpeningRoundRadius", rectangleOpeningRoundRadius, typeof(IfcPositiveLengthMeasure)));

        }
    }
}