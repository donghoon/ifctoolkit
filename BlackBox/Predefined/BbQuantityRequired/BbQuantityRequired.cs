using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
	/// <summary>
	/// Quantity required.
	/// </summary>
    public class BbQuantityRequired : BbBase
    {
        /// <summary>
        /// future update required for 2x4 when element assembly has type
        /// use hasPropertySet in future release
        /// </summary>

        [EarlyBindingInstance]
        public IfcQuantityCount IfcQuantityCount { get; protected set; }

        [EarlyBindingInstance]
        public IfcElementQuantity IfcElementQuantity { get; protected set; }

        [EarlyBindingInstance]
        public IfcRelDefinesByProperties IfcRelDefinesByProperties { get; protected set; }

        public List<BbElement> CountedElement = new List<BbElement>();

        public int Count { get { return IfcQuantityCount.CountValue; }
            protected set { IfcQuantityCount.CountValue = value; }
        }

        BbQuantityRequired()
        {
            
            IfcQuantityCount = new IfcQuantityCount
                                   {
                                       Name = "Quantity",
                                       CountValue = 0,
                                   };
            IfcElementQuantity = new IfcElementQuantity
                                     {
                                         GlobalId = IfcGloballyUniqueId.NewGuid(),
                                         OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                                         Quantities = new List<IfcPhysicalQuantity>{IfcQuantityCount},
                                     };
            IfcRelDefinesByProperties = new IfcRelDefinesByProperties
                                            {
                                                GlobalId = IfcGloballyUniqueId.NewGuid(),
                                                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                                                RelatedObjects = new List<IfcObject>(),
                                                RelatingPropertyDefinition = IfcElementQuantity,
                                            };
        }


        public static BbQuantityRequired Create()
        {
            var c = new BbQuantityRequired();
            BbInstanceDB.AddToExport(c);
            return c;
        }

        public void Add(BbElement element)
        {
            Count++;
            CountedElement.Add(element);
            IfcRelDefinesByProperties.RelatedObjects.Add(element.IfcObject);
        }



    }
}