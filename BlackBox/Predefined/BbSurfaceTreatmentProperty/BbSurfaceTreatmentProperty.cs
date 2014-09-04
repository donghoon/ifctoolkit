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
    public partial class BbSurfaceTreatmentProperty : BbBase
    {

        static readonly List<string> SequentialOrderStrings = new List<string>
        {
            "Blast",
            "Painted",
            "Galvanized",
            "Primed"
        };



        List<string> _sOrder = new List<string>();
        public List<string> SequentialOrder { get {return _sOrder;}  }


        public BbPropertySet BbPropertySet { get; private set; }


        protected BbSurfaceTreatmentProperty(
            BbPropertySet bbPropertySet,
            List<string> sequentialOrders)
        {
            BbPropertySet = bbPropertySet;
            foreach (var sequentialOrder in sequentialOrders)
            {
                if (!string.IsNullOrWhiteSpace(sequentialOrder))
                {
                    SequentialOrder.Add(sequentialOrder);
                }
            }

            bbPropertySet.AddProperty(BbListProperty.Create("Sequential Order", SequentialOrder, typeof(IfcIdentifier)));
        }


        public static BbSurfaceTreatmentProperty Create(
           BbPropertySet bbPropertySet,
            List<string> sequentialOrders)
        {
            var ai = new BbSurfaceTreatmentProperty(
                bbPropertySet,
             sequentialOrders);
            return ai;
        }

        public void AssignTo(BbElement element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

    }

}
