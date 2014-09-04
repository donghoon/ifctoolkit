using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;



namespace BlackBox.Predefined
{
    /// <summary>
    /// Weld.
    /// </summary>
    public class BbWasher : BbFastener
    {

        IfcMechanicalFastener _ifcElement;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcElement; }
            protected set { base.IfcObject = _ifcElement = value as IfcMechanicalFastener; }
        }




        public BbPropertySet BbPropertySet { get; private set; }





        protected BbWasher()
        {
            _ifcElement = new IfcMechanicalFastener
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,

                ObjectType = "Washer",

            };
        }

        public static BbWasher Create(BbProduct bbBoltAssembly)
        {
            var bolt = new BbWasher();
            bolt.AddToHostObject(bbBoltAssembly);
            BbInstanceDB.AddToExport(bolt);

            return bolt;
        }







        public string WasherStandard { get; set; }
        public string WasherType { get; set; }


        public double WasherSize { get; set; }
        public int WasherSequentialOrder { get; set; }
        public bool HeadSideWasher { get; set; }



        public void AddProperties(
            BbPropertySet bbPropertySet,
            string washerStandard, string washerType,

            double? washerSize, int? washerSequentialOrder, bool? headSideWasher)
        {
            if (BbPropertySet == null)
                BbPropertySet = bbPropertySet;
            if (!string.IsNullOrWhiteSpace(washerStandard))
            {
                WasherStandard = washerStandard;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WasherStandard", WasherStandard, true));
            }




            if (!string.IsNullOrWhiteSpace(washerType))
            {
                WasherType = washerType;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WasherType", WasherType, true));
            }


            if (washerSize != null)
            {
                WasherSize = washerSize.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WasherSize", WasherSize, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WasherSize = 0.0;
            }

            if (headSideWasher != null)
            {
                HeadSideWasher = headSideWasher.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("HeadSideNut", HeadSideWasher));
            }


            if (washerSequentialOrder != null)
            {
                WasherSequentialOrder = washerSequentialOrder.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WasherSequentialOrder", WasherSequentialOrder, typeof(IfcInteger)));
            }


        }


    }



}

