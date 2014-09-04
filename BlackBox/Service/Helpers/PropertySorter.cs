using System;
using System.Collections;
using System.ComponentModel;

namespace BlackBox.Service
{
    public class PropertySorter : ExpandableObjectConverter
    {
        #region Methods
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            var pdc = TypeDescriptor.GetProperties(value, attributes);
            var orderedProperties = new ArrayList();
            foreach (PropertyDescriptor pd in pdc)
            {
                Attribute attribute = pd.Attributes[typeof(PropertyOrderAttribute)];
                if (attribute != null)
                {
                    var poa = (PropertyOrderAttribute)attribute;
                    orderedProperties.Add(new PropertyOrderPair(pd.Name, poa.Order));
                }
                else
                    orderedProperties.Add(new PropertyOrderPair(pd.Name, 0));
            }

            orderedProperties.Sort();

            var propertyNames = new ArrayList();
            foreach (PropertyOrderPair pop in orderedProperties)
                propertyNames.Add(pop.Name);

            return pdc.Sort((string[])propertyNames.ToArray(typeof(string)));
        }
        #endregion
    }
}