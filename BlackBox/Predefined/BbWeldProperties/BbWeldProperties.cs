using System;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    public class BbWeldProperties : BbBase
    {
        public double ThroatThickness { get; set; }
        public double LegLength { get; set; }

        public BbPropertySet BbPropertySet { get; private set; }

        BbWeldProperties(double throatThickness, double legLength)
        {
            ThroatThickness = throatThickness;
            LegLength = legLength;

            BbPropertySet =  BbPropertySet.Create("WeldProperties");
            if (ThroatThickness > 0)
                BbPropertySet.AddProperty(BbSingleProperty.Create("Throat Thickness", ThroatThickness, typeof(IFC2X3.IfcLengthMeasure)));
            if (LegLength > 0)
                BbPropertySet.AddProperty(BbSingleProperty.Create("Leg Length", LegLength, typeof(IFC2X3.IfcLengthMeasure)));
        }

        private BbWeldProperties()
        { }

        public static BbWeldProperties Create(double throatThickness, double legLength)
        {
            var w = new BbWeldProperties(throatThickness, legLength);
            return w;
        }

        public void AssignTo(BbWeld weld)
        {
            BbPropertySet.AssignTo(weld);
        }

        public static BbWeldProperties Retrieve(BbWeld weld)
        {
            var ret = new BbWeldProperties();
            // Retrieving PropertySet
            //if (! EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelDefinesByProperties")) return null;
            var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelDefinesByProperties").Values;
            foreach (var item in collection)
            {
                var theItem = item as IfcRelDefinesByProperties;
                var pSet = theItem.RelatingPropertyDefinition as IfcPropertySet;
                if (theItem == null) continue;
                var relatedObjects = theItem.RelatedObjects;
                foreach (var relatedObject in relatedObjects)
                {
                    if (relatedObject.EIN == weld.IfcObject.EIN)
                    {
                        throw new NotImplementedException();

                        // wrong implementation 
                        //var BbPropertySet = new BbPropertySet { _ifcRelDefinesByProperties = theItem, _ifcPropertySet = pSet };
                        
                        ////Retrieving relevant attributes
                        //BbPropertySet.AssignTo(weld); 
                        //ret.BbPropertySet = BbPropertySet;
                        //BbPropertySet.Name = pSet.Name;
                        //BbPropertySet.Description = pSet.Description;

                        //var properties = BbPropertySet._ifcPropertySet.HasProperties;
                        //foreach (var property in properties)
                        //{
                        //    var sProp = property as IfcPropertySingleValue;
                        //    var semSingleProperty = new BbSingleProperty { _ifcPropertySingleValue = sProp };
                        //    //BbInstanceDB.Add(semSingleProperty);
                        //    var iValue = sProp.NominalValue.Value;
                        //    var value = iValue as IfcLengthMeasure;

                        //    if (sProp.Name == "Throat Thickness")
                        //    { ret.ThroatThickness = value.Value; }
                        //    if (sProp.Name == "Leg Length")
                        //    { ret.LegLength = value.Value; }
                        //    BbPropertySet.Properties.Add(semSingleProperty);
                        //}
                        //// Check if this BbPropertySet already exist before adding to DB, if so add weld to its _assignedElements
                        //BbInstanceDB.AddToExport(BbPropertySet);
                    }
                }
            }
            return ret;
        }
    }
}