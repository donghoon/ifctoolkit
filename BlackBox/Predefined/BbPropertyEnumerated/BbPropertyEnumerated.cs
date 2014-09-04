using System;
using System.Collections.Generic;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{
    public partial class BbPropertyEnumerated : BbSimpleProperty
    {
        [EarlyBindingInstance]
        public override IfcProperty IfcProperty
        {
            get
            {
                return _ifcPropertyEnumeratedValue;
            }
            set
            {
                base.IfcProperty = _ifcPropertyEnumeratedValue = value as IfcPropertyEnumeratedValue;
            }
        }

        private IfcPropertyEnumeratedValue _ifcPropertyEnumeratedValue;



        //private IfcValue _ifcValue;
        //private IfcUnit _ifcUnit;

        protected BbPropertyEnumerated(string name, string value, Type ifcType)
        {
            Name = name;
            // _ifcValue = new IfcValue();
            var iValue = Activator.CreateInstance(ifcType) as STRING;
            if(iValue == null) throw new InvalidOperationException();
            iValue.Value = value;

            _ifcPropertyEnumeratedValue = new IfcPropertyEnumeratedValue
            {
                Name = name,
                EnumerationValues = new List<IfcValue> { new IfcValue { Value = iValue  } },
                
            };

            
            
        }

        protected BbPropertyEnumerated(string name, double value, Type ifcType)
        {
            Name = name;
            //_ifcValue = new IfcValue();
            var iValue = Activator.CreateInstance(ifcType) as REAL;
            if (iValue == null) throw new InvalidOperationException();
            iValue.Value = value;
            _ifcPropertyEnumeratedValue = new IfcPropertyEnumeratedValue
            {
                Name = name,
                EnumerationValues = new List<IfcValue>(){new IfcValue(){Value =  iValue}},
            };
        }

        protected BbPropertyEnumerated(string name, bool value)
        {
            Name = name;
            var iValue = new IfcBoolean();
            iValue.Value = value;
            _ifcPropertyEnumeratedValue = new IfcPropertyEnumeratedValue
            {
                Name = this.Name,
                EnumerationValues = new List<IfcValue>() { new IfcValue() { Value = iValue } },
            };
        }

        protected BbPropertyEnumerated()
        { }


        public static BbPropertyEnumerated Create(string name, string value, bool isLabel)
        {
            var sp = isLabel 
                ? new BbPropertyEnumerated(name, value, typeof(IfcLabel)) 
                : new BbPropertyEnumerated(name, value, typeof(IfcText));
            BbInstanceDB.AddToExport(sp);
            return sp;

        }

        public static BbPropertyEnumerated Create(string name, double value, Type type)
        {
            var sp = new BbPropertyEnumerated(name, value, type);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }

        public static BbPropertyEnumerated Create(string name, bool value)
        {
            var sp = new BbPropertyEnumerated(name, value);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }




    }
}