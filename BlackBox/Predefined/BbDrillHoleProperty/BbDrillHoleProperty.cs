using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;
using System.Linq;

namespace BlackBox.Predefined
{
    public partial class BbDrillHoleProperty : BbBase
    {

        static readonly List<string> featureSubtype = new List<string>
        {
            "BeveledHole",
            "TappedHole",
            "ThreadedHole"
        };




        public double BoltHoleDiameter { get; private set; }

        public bool PartialHoleIndicator { get; private set; }

        public double PartialHoleDepth { get; private set; }




        public BbPropertySet BbPropertySet { get; private set; }


        protected BbDrillHoleProperty(
            BbPropertySet bbPropertySet,
            string featureSubType,
            double boltHoleDiameter,
            bool partialHoleIndicator,
            double partialHoleDepth
            )
        {
            BoltHoleDiameter = boltHoleDiameter;
            PartialHoleIndicator = partialHoleIndicator;
            PartialHoleDepth = partialHoleDepth;
            BbPropertySet = bbPropertySet;
            bbPropertySet.AddProperty(BbPropertyEnumerated.Create("FeatureSubtype", featureSubType, true));
            bbPropertySet.AddProperty(BbSingleProperty.Create("BoltHoleDiameter", boltHoleDiameter, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("PartialHoleIndicator", partialHoleIndicator));
            bbPropertySet.AddProperty(BbSingleProperty.Create("PartialHoleDepth", partialHoleDepth, typeof(IfcPositiveLengthMeasure)));


        }


        public static BbDrillHoleProperty Create(
           BbPropertySet bbPropertySet,
            string featureSubType,
            double boltHoleDiameter,
            bool partialHoleIndicator,
            double partialHoleDepth)
        {
            var dh = new BbDrillHoleProperty(
                bbPropertySet,
             featureSubType,
            boltHoleDiameter,
            partialHoleIndicator,
            partialHoleDepth);
            return dh;
        }

        public void AssignTo(BbFeature feature)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(feature);
        }

        public void AssignTo(IEnumerable<BbFeature> features)
        {
            foreach (var a in features)
            {
                AssignTo(a);
            }
        }

    }

}
