using System.Globalization;
using System.IO;

namespace EbInstanceModel
{
    public class INTEGER : BaseType
    {
        public int Value { get; set; }

        public static implicit operator INTEGER(int value)
        {
            return new INTEGER { Value = value };
        }

        public static implicit operator int(INTEGER cpdValueInteger)
        {
            return cpdValueInteger.Value;
        }

        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(ToString());
        }

        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }

        #region commented out
        //public INTEGER()
        //    :this(0)
        //{
        //}

        //public INTEGER(int value)
        //{
        //    Value = value;
        //}

        //public static int operator +(INTEGER one, INTEGER two)
        //{
        //    return one.Value + two.Value;
        //}

        //public static INTEGER operator +(int one, INTEGER two)
        //{
        //    return new INTEGER(one + two.Value);
        //}

        //public static int operator -(INTEGER one, INTEGER two)
        //{
        //    return one.Value - two.Value;
        //}

        //public static INTEGER operator -(int one, INTEGER two)
        //{
        //    return new INTEGER(one - two.Value);
        //}

        //public override string ToString()
        //{
        //    return Value.ToString(System.Globalization.CultureInfo.InvariantCulture);
        //}

        //public void StreamXML(System.Xml.XmlWriter xmlStream)
        //{
        //    xmlStream.WriteValue(Value);
        //}

        //public override int CompareTo(object obj)
        //{
        //    if (obj == null) return 1;

        //    var rea = obj as INTEGER;
        //    return rea == null ? 1 : Value.CompareTo(rea.Value);
        //}
        #endregion
    }
}