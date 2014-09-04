using System;

namespace IFC2X3
{
    public partial class IfcTimeStamp
    {
        public static IfcTimeStamp GetTimeStamp()
        {
            return new IfcTimeStamp((int)Math.Floor((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds));
        }

        public static IfcTimeStamp GetTimeStamp(DateTime dateTime)
        {
            var a = new DateTime(1970, 1, 1, 0, 0, 0);
            var b = dateTime - a;

            var c = b.TotalSeconds;
            var d = Math.Floor(c);
            var e = Convert.ToInt32(d);

            return new IfcTimeStamp(e);
        }

        //protected int m_value;

        //public int value
        //{
        //    get
        //    {
        //        return this.m_value;
        //    }
        //}

        public IfcTimeStamp(int inVal)
        {
            this.Value = inVal;
        }

        //public override bool Equals(object o)
        //{
        //    return o is IfcTimeStamp && this.m_value == ((IfcTimeStamp)o).value;
        //}

        //public override int GetHashCode()
        //{
        //    return this.m_value.GetHashCode();
        //}

        //public static bool operator ==(IfcTimeStamp l, IfcTimeStamp r)
        //{
        //    return (l == null && r == null) || (l != null && r != null && l.value == r.value);
        //}

        //public static bool operator !=(IfcTimeStamp l, IfcTimeStamp r)
        //{
        //    return (l != null || r != null) && (l == null || r == null || l.value != r.value);
        //}
    }
}