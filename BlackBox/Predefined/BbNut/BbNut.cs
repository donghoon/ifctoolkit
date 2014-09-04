using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;



namespace BlackBox.Predefined
{
    /// <summary>
    /// Weld.
    /// </summary>
    public class BbNut : BbFastener
    {

        IfcMechanicalFastener _ifcElement;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcElement; }
            protected set { base.IfcObject = _ifcElement = value as IfcMechanicalFastener; }
        }



        
        public BbPropertySet BbPropertySet { get; private set; }



        
        protected BbNut()
        {
            _ifcElement = new IfcMechanicalFastener
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,

                ObjectType = "Nut",

            };
        }

        public static BbNut Create(BbProduct bbBoltAssembly)
        {
            var bolt = new BbNut();
            bolt.AddToHostObject(bbBoltAssembly);
            BbInstanceDB.AddToExport(bolt);

            return bolt;
        }



       

       

        public string NutStandard { get; set; }
        public string NutType { get; set; }

        
        public double NutSize { get; set; }
        public int BoltAssemblySequentialOrder { get; set; }
        public bool HeadSideNut { get; set; }



        public void AddProperties(
            BbPropertySet bbPropertySet,
            string nutStandard, string nutType,

            double? nutSize, int? boltAssemblySequentialOrder, bool? headSideNut)
        {
            if (BbPropertySet == null)
                BbPropertySet = bbPropertySet;
            if (!string.IsNullOrWhiteSpace(nutStandard))
            {
                NutStandard = nutStandard;
                bbPropertySet.AddProperty(BbSingleProperty.Create("NutStandard", NutStandard, true));
            }

            


            if (!string.IsNullOrWhiteSpace(nutType))
            {
                NutType = nutType;
                bbPropertySet.AddProperty(BbSingleProperty.Create("NutType", NutType, true));
            }


            if (nutSize != null)
            {
                NutSize = nutSize.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("NutSize", NutSize, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                NutSize = 0.0;
            }

            if (headSideNut != null)
            {
                HeadSideNut = headSideNut.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("HeadSideNut", HeadSideNut));
            }
            

            if (boltAssemblySequentialOrder != null)
            {
                BoltAssemblySequentialOrder = boltAssemblySequentialOrder.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("NutSequentialOrder", BoltAssemblySequentialOrder, typeof(IfcInteger)));
            }
            

        }


    }



}

