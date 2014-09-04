using System.Collections.Generic;
using System.Linq;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;


namespace BlackBox.Predefined
{
    public partial class BbPropertySet : BbBase
    {
        private IfcPropertySet _ifcPropertySet;
        private IfcRelDefinesByProperties _ifcRelDefinesByProperties;

        [EarlyBindingInstance]
        public IfcPropertySet IfcPropertySet
        {
            get { return _ifcPropertySet; }
            protected set { _ifcPropertySet = value; }
        }

        [EarlyBindingInstance]
        public IfcRelDefinesByProperties IfcRelDefinesByProperties
        {
            get { return _ifcRelDefinesByProperties; }
            protected set { _ifcRelDefinesByProperties = value; }
        }

        //public IEnumerable<BbProperty> Properties ;// Q9
        //public IEnumerable<BbElement> Elements ;// Q9

        private readonly List<BbProperty> _properties = new List<BbProperty>();
        private readonly List<BbProduct> _elements = new List<BbProduct>();



        public IEnumerable<BbProperty> Properties {
            get { return _properties; }
        }

        public IEnumerable<BbProduct> Elements
        {
            get { return _elements; }
        }



        public string Name
        {
            get { return IfcPropertySet.Name; }
        }


        protected BbPropertySet()
        {
        }

        protected BbPropertySet(string name)
        {
            IfcPropertySet = new IfcPropertySet
            {
                Name = name,
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                HasProperties = new List<IfcProperty>(),
            };


            IfcRelDefinesByProperties = new IfcRelDefinesByProperties
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                RelatedObjects = new List<IfcObject>(),
                RelatingPropertyDefinition = IfcPropertySet,
            };

        }

        public static BbPropertySet Create(string name)
        {
            var pset = new BbPropertySet(name);
            BbInstanceDB.AddToExport(pset);
            return pset;
        }

        public void AddProperty(BbProperty bbProperty)
        {
            _ifcPropertySet.HasProperties.Add(bbProperty.IfcProperty);
            _properties.Add(bbProperty);
        }


        public void AddProperty(IEnumerable<BbProperty> properties)
        {
            foreach (var a in properties)
            {
                AddProperty(a);
            }

        }


        public void AssignTo(BbProduct element)
        {
            _ifcRelDefinesByProperties.RelatedObjects.Add(element.IfcObject);
            _elements.Add(element);
        }



        public void AssignTo(IEnumerable<BbProduct> elements)
        {
            foreach (var a in elements)
            {
                AssignTo(a);
            }
        }




    }
}

