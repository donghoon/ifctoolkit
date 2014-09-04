using System;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{
    public partial class BbSingleProperty : BbSimpleProperty
    {
        [EarlyBindingInstance]
        public override IfcProperty IfcProperty {
            get {
                return _ifcPropertySingleValue;
            }
            set {
                base.IfcProperty = _ifcPropertySingleValue = value as IfcPropertySingleValue;
            }
        }

        private IfcPropertySingleValue _ifcPropertySingleValue;

        private IfcValue _ifcValue;
        //private IfcUnit _ifcUnit;

        protected BbSingleProperty (string name, string value, Type type)
        {
            Name = name;
            _ifcValue = new IfcValue ();
            var iValue =  Activator.CreateInstance(type) as STRING;
            iValue.Value = value;
            _ifcValue.Value = iValue;
            _ifcPropertySingleValue = new IfcPropertySingleValue{
                Name = this.Name,
                NominalValue = _ifcValue,
            };
        }

        protected BbSingleProperty(string name, int value, Type type)
        {
            Name = name;
            _ifcValue = new IfcValue();
            var iValue = Activator.CreateInstance(type) as INTEGER;
            iValue.Value = value;
            _ifcValue.Value = iValue;
            _ifcPropertySingleValue = new IfcPropertySingleValue
            {
                Name = this.Name,
                NominalValue = _ifcValue,
            };
        }


        protected BbSingleProperty(string name, double value, Type type)
        {
            Name = name;
            _ifcValue = new IfcValue ();
            var iValue =  Activator.CreateInstance(type) as REAL;
            if (iValue == null) throw new InvalidOperationException();
            iValue.Value = value;

            _ifcValue.Value = iValue;
            _ifcPropertySingleValue = new IfcPropertySingleValue{
                Name = this.Name,
                NominalValue = _ifcValue,
            };
        }

        protected BbSingleProperty(string name, DateTime value)
        {
            Name = name;
            _ifcValue = new IfcValue();
            var iValue = IfcTimeStamp.GetTimeStamp(value);
            _ifcValue.Value = iValue;
            _ifcPropertySingleValue = new IfcPropertySingleValue
            {
                Name = this.Name,
                NominalValue = _ifcValue,
            };
        }

        protected BbSingleProperty(string name, bool value)
        {
            Name = name;
            _ifcValue = new IfcValue();
            var iValue = new IfcBoolean {Value = value};
            _ifcValue.Value = iValue;
            _ifcPropertySingleValue = new IfcPropertySingleValue
                {
                    Name = this.Name,
                    NominalValue = _ifcValue,
                };
        }

        protected BbSingleProperty()
        { }


        public static BbSingleProperty Create (string name, string value, bool IsLabel)
        {

            BbSingleProperty sp;

            sp = IsLabel ? new BbSingleProperty (name, value, typeof(IfcLabel)) : new BbSingleProperty (name, value, typeof(IfcText));
            BbInstanceDB.AddToExport(sp);
            return sp;
			
        }

        public static BbSingleProperty Create (string name, double value, Type type)
        {
            BbSingleProperty sp = new BbSingleProperty(name, value, type);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }

        public static BbSingleProperty Create(string name, string value, Type type)
        {
            BbSingleProperty sp = new BbSingleProperty(name, value, type);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }

        public static BbSingleProperty Create(string name, int value, Type type)
        {
            BbSingleProperty sp = new BbSingleProperty(name, value, type);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }



        public static BbSingleProperty Create(string name, DateTime value)
        {
            BbSingleProperty sp = new BbSingleProperty(name, value);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }

        public static BbSingleProperty Create(string name, bool value)
        {
            BbSingleProperty sp = new BbSingleProperty(name, value);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }


    }
}