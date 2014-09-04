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
    public partial class BbBoltHoleProperties : BbBase
    {
        
        static readonly List<string> FabricationMethodStrings = new List<string>
        {
            "Punching",
            "Sub-Punching and Reaming",
            "Drilling",
            "Hole Sawing",
            "Flame Piercing and Reaming",
            "Flame Cutting",
            "Milling",
            "Face Machining",
            "Planning",
            "Grinding",
            "Sawing",
            "Friction Sawing",
            "Cold Sawing",
            "Oxygen-Acetylene Flame Cutting",
            "Plasma Cutting",
            "Laser Cutting",
            "Shearing"
        };

        static readonly List<string> CriticalFaceStrings = new List<string>
        {
            "Front",
            "Top",
            "Bottom",
            "Behind"
        };
        
        
        static readonly List<string> FeatureSubTypeStrings = new List<string>
        {
            "Beveled Hole",
            "Tapped Hole",
            "Threaded Hole"
        };



        public string FabricationMethod { get; private set; }

        public string CriticalFace { get; private set; }

        public string DesignConstraint { get; private set; }

        public string FeatureSubTypes { get; private set; }

        public double BoltHoleDiameter { get; private set; }

        public bool PartialHoleIndicator { get; private set; }

        public double PartialHoleDepth { get; private set; }



        public BbPropertySet BbPropertySet { get; private set; }


        protected BbBoltHoleProperties(
            BbPropertySet bbPropertySet,
            string fabricationMethod,
            string criticalFace,
            string designConstraint,
            string featureSubTypes,
            double boltHoleDiameter,
            bool? partialHoleIndicator,
            double partialHoleDepth
            )
        {
            BbPropertySet = bbPropertySet;

            if (!string.IsNullOrWhiteSpace(fabricationMethod))
            {
                FabricationMethod = fabricationMethod;
                bbPropertySet.AddProperty(BbPropertyEnumerated.Create("Fabrication Method", FabricationMethod, true));
            }

            if (!string.IsNullOrWhiteSpace(criticalFace))
            {
                CriticalFace = criticalFace;
                bbPropertySet.AddProperty(BbPropertyEnumerated.Create("Critical Face", CriticalFace, true));
            }

            if (!string.IsNullOrWhiteSpace(designConstraint))
            {
                DesignConstraint = designConstraint;
                bbPropertySet.AddProperty(BbPropertyEnumerated.Create("Design Constraint", DesignConstraint, true));
            }

            if (!string.IsNullOrWhiteSpace(featureSubTypes))
            {
                FeatureSubTypes = featureSubTypes;
                bbPropertySet.AddProperty(BbPropertyEnumerated.Create("Feature Sub Types", FeatureSubTypes, true));
            }

            if (!double.IsPositiveInfinity(boltHoleDiameter))
            {
                BoltHoleDiameter = boltHoleDiameter;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Bolt Hole Diameter", BoltHoleDiameter, typeof(IfcPositiveLengthMeasure)));
            }
            if (partialHoleIndicator != null)
            {
                PartialHoleIndicator = partialHoleIndicator.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Partial Hole Indicator", PartialHoleIndicator));
            }

            if (!double.IsPositiveInfinity(partialHoleDepth) && partialHoleDepth > 0)
            {
                PartialHoleDepth = partialHoleDepth;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Partial Hole Depth", PartialHoleDepth, typeof(IfcPositiveLengthMeasure)));
            }
        }

        public static BbBoltHoleProperties Create(
           BbPropertySet bbPropertySet,
            string fabricationMethod,
            string criticalFace,
            string designConstraint,
            string featureSubTypes,
            double boltHoleDiameter,
            bool? partialHoleIndicator,
            double partialHoleDepth)
        {
            var ai = new BbBoltHoleProperties(
                bbPropertySet,
                fabricationMethod,
                criticalFace,
                designConstraint,
                featureSubTypes,
                boltHoleDiameter,
                partialHoleIndicator,
                partialHoleDepth);
            return ai;
        }

        public void AssignTo(BbProduct element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

    }

}
