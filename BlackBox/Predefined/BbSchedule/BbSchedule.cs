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
    public partial class BbSchedule : BbBase
    {

        public string PhaseSequence { get; private set; }

        public string SequenceLevel { get; private set; }

        public DateTime OnSiteBy { get; private set; }




        public BbPropertySet BbPropertySet { get; private set; }


        protected BbSchedule(
            BbPropertySet bbPropertySet,
            string phaseSequence,
            string sequenceLevel,
            DateTime onSiteBy
            )
        {
            BbPropertySet = bbPropertySet;
            if (!string.IsNullOrWhiteSpace(phaseSequence))
            {
                PhaseSequence = phaseSequence;
                bbPropertySet.AddProperty(BbPropertyEnumerated.Create("PhaseSequence", PhaseSequence, true));
            }

            if (!string.IsNullOrWhiteSpace(sequenceLevel))
            {
                SequenceLevel = sequenceLevel;
                bbPropertySet.AddProperty(BbPropertyEnumerated.Create("SequenceLevel", SequenceLevel, true));
            }
            
                OnSiteBy = onSiteBy;
                bbPropertySet.AddProperty(BbSingleProperty.Create("OnSiteBy", OnSiteBy));
           


        }


        public static BbSchedule Create(
           BbPropertySet bbPropertySet,
            string phaseSequence,
            string sequenceLevel,
            DateTime onSiteBy)
        {
            var ai = new BbSchedule(
                bbPropertySet,
             phaseSequence,
             sequenceLevel,
             onSiteBy);
            return ai;
        }

        public void AssignTo(BbElement element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

    }

}
