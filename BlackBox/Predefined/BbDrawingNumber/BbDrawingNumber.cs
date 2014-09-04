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
    public partial class BbDrawingNumber : BbBase
    {

        //public List<string> DrawingNumber { get; private set; }
        public List<string> DrawingNumber = new List<string>();

        public BbPropertySet BbPropertySet { get; private set; }


        protected BbDrawingNumber(
            BbPropertySet bbPropertySet,
            List<string> drawingNumbers)
        {
            BbPropertySet = bbPropertySet;
            foreach (var drawingNumber in drawingNumbers)
            {
                if (!string.IsNullOrWhiteSpace(drawingNumber))
                {
                    DrawingNumber.Add(drawingNumber);
                }
            }
            bbPropertySet.AddProperty(BbListProperty.Create("Drawing Number", DrawingNumber, typeof(IfcIdentifier)));

        }

        public static BbDrawingNumber Create(
           BbPropertySet bbPropertySet,
            List<string> drawingNumbers
            )
        {
            var ai = new BbDrawingNumber(
                bbPropertySet,
             drawingNumbers);
            return ai;
        }

        public void AssignTo(BbElement element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

    }

}
