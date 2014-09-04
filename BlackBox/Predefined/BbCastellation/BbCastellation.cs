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
    public partial class BbCastellation : BbBase
    {

        static readonly List<string> CastellationTypeStrings = new List<string>
        {
            "Circular",
            "Hexagonal",
            "Octagonal",
            "Undefined"
        };

        public string CastellationType { get; private set; }

        public double CastellationEndPostWidth1  { get; private set; }

        public double CastellationEndPostWidth2 { get; private set; }

        public double CastellationSpacing { get; private set; }

        public double CastellationHeight { get; private set; }

        public double CastellationWidth { get; private set; }

        public double CastellationDepth { get; private set; }


        public BbPropertySet BbPropertySet { get; private set; }


        protected BbCastellation(
            BbPropertySet bbPropertySet,
            string castellationType,
            double castellationEndPostWidth1,
            double castellationEndPostWidth2,
            double castellationSpacing,
            double castellationHeight,
            double castellationWidth,
            double castellationDepth
            )
        {
            BbPropertySet = bbPropertySet;
            if (!string.IsNullOrWhiteSpace(castellationType))
            {
                CastellationType = castellationType;
                bbPropertySet.AddProperty(BbPropertyEnumerated.Create("Castellation Type", CastellationType, true));
            }

            if (!double.IsPositiveInfinity(castellationEndPostWidth1))
            {
                CastellationEndPostWidth1 = castellationEndPostWidth1;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Castellation End Post Width1", CastellationEndPostWidth1, typeof(IfcPositiveLengthMeasure)));
            }

            if (!double.IsPositiveInfinity(castellationEndPostWidth2))
            {
                CastellationEndPostWidth2 = castellationEndPostWidth2;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Castellation End Post Width2", CastellationEndPostWidth2, typeof(IfcPositiveLengthMeasure)));
            }

            if (!double.IsPositiveInfinity(castellationSpacing))
            {
                CastellationSpacing = castellationSpacing;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Castellation Spacing", CastellationSpacing, typeof(IfcPositiveLengthMeasure)));
            }

            if (!double.IsPositiveInfinity(castellationHeight))
            {
                CastellationHeight = castellationHeight;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Castellation Height", CastellationHeight, typeof(IfcPositiveLengthMeasure)));
            }

            if (!double.IsPositiveInfinity(castellationWidth))
            {
                CastellationWidth = castellationWidth;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Castellation Width", CastellationWidth, typeof(IfcPositiveLengthMeasure)));
            }

            if (!double.IsPositiveInfinity(castellationDepth))
            {
                CastellationDepth = castellationDepth;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Castellation Depth", CastellationDepth, typeof(IfcPositiveLengthMeasure)));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bbPropertySet"></param>
        /// <param name="status">One of "Default", "ReadyForProcurement", "ReadyForMill", "IssuedForFabrication"</param>
        /// <param name="changeStatus">One of "Default", "Changed", "Deleted"</param>
        /// <param name="approved"></param>
        /// <returns></returns>
        public static BbCastellation Create(
           BbPropertySet bbPropertySet,
            string castellationType,
            double castellationEndPostWidth1,
            double castellationEndPostWidth2,
            double castellationSpacing,
            double castellationHeight,
            double castellationWidth,
            double castellationDepth)
        {
            var ai = new BbCastellation(
                bbPropertySet,
                castellationType,
                castellationEndPostWidth1,
                castellationEndPostWidth2,
                castellationSpacing,
                castellationHeight,
                castellationWidth,
                castellationDepth);
            return ai;
        }

        public void AssignTo(BbElement element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

    }

}
