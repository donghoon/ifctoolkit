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
    public partial class BbVersion : BbBase
    {

        public string VersionNumber { get; private set; }


        public BbPropertySet BbPropertySet { get; private set; }


        protected BbVersion(
            BbPropertySet bbPropertySet,
            string versionNumber
            )
        {
            BbPropertySet = bbPropertySet;
            if (!string.IsNullOrWhiteSpace(versionNumber))
            {
                VersionNumber = versionNumber;
                bbPropertySet.AddProperty(BbSingleProperty.Create("VersionNumber", VersionNumber, true));
            }
        }


        public static BbVersion Create(
           BbPropertySet bbPropertySet,
            string versionNumber)
        {
            var ai = new BbVersion(
                bbPropertySet,
             versionNumber);
            return ai;
        }

        public void AssignTo(BbElement element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

    }

}
