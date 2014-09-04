using System;
using System.Collections.Generic;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{
    public partial class BbListProperty : BbSimpleProperty
    {
        [EarlyBindingInstance]
        public override IfcProperty IfcProperty
        {
            get
            {
                return _ifcPropertyListValue;
            }
            set
            {
                base.IfcProperty = _ifcPropertyListValue = value as IfcPropertyListValue;
            }
        }

        private IfcPropertyListValue _ifcPropertyListValue;

        
        //private IfcUnit _ifcUnit;

        protected BbListProperty(string name, string value, Type type)
        {
            Name = name;
            var _ifcValue = new IfcValue();
            var iValue = Activator.CreateInstance(type) as STRING;
            iValue.Value = value;
            _ifcValue.Value = iValue;
            _ifcPropertyListValue = new IfcPropertyListValue
            {
                Name = this.Name,
                ListValues = new List<IfcValue> { _ifcValue },
            };
        }


        protected BbListProperty(string name, IList<string> values, Type type)
        {
            Name = name;
            _ifcPropertyListValue = new IfcPropertyListValue
            {
                Name = this.Name,
                ListValues = new List<IfcValue>(),
            };

            foreach(var value in values)
            {
                var _ifcValue = new IfcValue();
            var iValue = Activator.CreateInstance(type) as STRING;
            iValue.Value = value;
            _ifcValue.Value = iValue;
            _ifcPropertyListValue.ListValues.Add(_ifcValue);
            }
            
        }


        protected BbListProperty(string name, int value, Type type)
        {
            Name = name;
            var _ifcValue = new IfcValue();
            var iValue = Activator.CreateInstance(type) as INTEGER;
            iValue.Value = value;
            _ifcValue.Value = iValue;
            _ifcPropertyListValue = new IfcPropertyListValue
            {
                Name = this.Name,
                ListValues = new List<IfcValue> { _ifcValue },
            };
        }


        protected BbListProperty(string name, double value, Type type)
        {
            Name = name;
            var _ifcValue = new IfcValue();
            var iValue = Activator.CreateInstance(type) as REAL;
            if (iValue == null) throw new InvalidOperationException();
            iValue.Value = value;

            _ifcValue.Value = iValue;
            _ifcPropertyListValue = new IfcPropertyListValue
            {
                Name = this.Name,
                ListValues = new List<IfcValue> { _ifcValue },
            };
        }

        protected BbListProperty(string name, DateTime value)
        {
            Name = name;
            var _ifcValue = new IfcValue();
            var iValue = IfcTimeStamp.GetTimeStamp(value);
            _ifcValue.Value = iValue;
            _ifcPropertyListValue = new IfcPropertyListValue
            {
                Name = this.Name,
                ListValues = new List<IfcValue> { _ifcValue },
            };
        }

        protected BbListProperty(string name, bool value)
        {
            Name = name;
            var _ifcValue = new IfcValue();
            var iValue = new IfcBoolean { Value = value };
            _ifcValue.Value = iValue;
            _ifcPropertyListValue = new IfcPropertyListValue
                {
                    Name = this.Name,
                    ListValues = new List<IfcValue> { _ifcValue },
                };
        }

        protected BbListProperty()
        { }


        public void AddMoreList(string value)
        {
            if( _ifcPropertyListValue.ListValues.Count < 1) return;

            var _ifcValue = new IfcValue();
            var iValue = Activator.CreateInstance(_ifcPropertyListValue.ListValues[0].GetType()) as STRING;
            iValue.Value = value;
            _ifcValue.Value = iValue;
            _ifcPropertyListValue.ListValues.Add(_ifcValue);
        }


        public static BbListProperty Create(string name, IList<string> values, Type type)
        {
            BbListProperty sp = new BbListProperty(name, values, type);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }


        public static BbListProperty Create(string name, string value, bool IsLabel)
        {

            BbListProperty sp;

            sp = IsLabel ? new BbListProperty(name, value, typeof(IfcLabel)) : new BbListProperty(name, value, typeof(IfcText));
            BbInstanceDB.AddToExport(sp);
            return sp;

        }

        public static BbListProperty Create(string name, double value, Type type)
        {
            BbListProperty sp = new BbListProperty(name, value, type);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }

        public static BbListProperty Create(string name, string value, Type type)
        {
            BbListProperty sp = new BbListProperty(name, value, type);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }

        public static BbListProperty Create(string name, int value, Type type)
        {
            BbListProperty sp = new BbListProperty(name, value, type);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }



        public static BbListProperty Create(string name, DateTime value)
        {
            BbListProperty sp = new BbListProperty(name, value);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }

        public static BbListProperty Create(string name, bool value)
        {
            BbListProperty sp = new BbListProperty(name, value);
            BbInstanceDB.AddToExport(sp);
            return sp;
        }


    }
}