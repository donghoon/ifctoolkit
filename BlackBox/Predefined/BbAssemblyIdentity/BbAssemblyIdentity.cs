using System;
using BlackBox.Service;
using IFC2X3;


namespace BlackBox.Predefined
{
    public class BbAssemblyIdentity : BbBase
    {
        //public string Name { get; private set; }

        public string AssemblyMark { get; private set; }

        public string ClientMark { get; private set; }

        public string PrelimMark { get; private set; }

        public string ShippingMark { get; private set; }

        public string BarCode { get; private set; }


        public BbPropertySet BbPropertySet { get; private set; }


        BbAssemblyIdentity(
            //string name,
            string assemblyMark,
            string clientMark,
            string prelimMark,
            string shippingMark,
            string barCode)
        {
            //Name = name;
            AssemblyMark = assemblyMark;
            ClientMark = clientMark;
            PrelimMark = prelimMark;
            ShippingMark = shippingMark;
            BarCode = barCode;

            BbPropertySet = BbPropertySet.Create("AssemblyIdentity");
            if(!string.IsNullOrWhiteSpace(assemblyMark)) 
            BbPropertySet.AddProperty(BbSingleProperty.Create("Assembly Mark", assemblyMark, true));
            if (!string.IsNullOrWhiteSpace(clientMark)) 
            BbPropertySet.AddProperty(BbSingleProperty.Create("Client Mark", clientMark, true));
            if (!string.IsNullOrWhiteSpace(prelimMark)) 
            BbPropertySet.AddProperty(BbSingleProperty.Create("Prelim Mark", prelimMark, true));
            if (!string.IsNullOrWhiteSpace(shippingMark)) 
            BbPropertySet.AddProperty(BbSingleProperty.Create("Shipping Mark", shippingMark, true));
            if (!string.IsNullOrWhiteSpace(barCode)) 
            BbPropertySet.AddProperty(BbSingleProperty.Create("Bar Code", barCode, true));
        }

        public static BbAssemblyIdentity Create(
            //string name,
            string assemblyMark,
            string clientMark,
            string prelimMark,
            string shippingMark,
            string barCode)
        {
            var ai = new BbAssemblyIdentity(
					//name,
                 assemblyMark,
                 clientMark,
                 prelimMark,
                 shippingMark,
                 barCode);
            return ai;
        }

        public void AssignTo(BbElement element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

    }


}

