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
    public partial class BbLayoutTolerance : BbBase
    {

        public double Tolerance { get; private set; }


        public BbPropertySet BbPropertySet { get; private set; }


        protected BbLayoutTolerance(
            BbPropertySet bbPropertySet,
            double tolerance
            )
        {
            BbPropertySet = bbPropertySet;

            if (!double.IsPositiveInfinity(tolerance))
            {
                Tolerance = tolerance;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Tolerance", Tolerance, typeof(IfcPositiveLengthMeasure)));
            }

        }

        public static BbLayoutTolerance Create(
           BbPropertySet bbPropertySet,
            double tolerance)
        {
            var ai = new BbLayoutTolerance(
                bbPropertySet,
             tolerance);
            return ai;
        }

        public void AssignTo(BbElement element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

    }

}
