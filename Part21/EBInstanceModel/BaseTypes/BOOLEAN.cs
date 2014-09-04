using System.IO;

namespace EbInstanceModel
{
    public class BOOLEAN : BaseType
    {
        public bool Value { get; set; }

        public static implicit operator BOOLEAN(bool value)
        {
            return new BOOLEAN { Value = value };
        }

        public static implicit operator bool(BOOLEAN cpdValueBool)
        {
            return cpdValueBool.Value;
        }

        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(ToString());
        }

        public override string ToString()
        {
            return Value ? ".T." : ".F.";
        }

        #region commented out
        //public BOOLEAN()
        //    :this(false)
        //{
        //}

        //public BOOLEAN(bool value)
        //{
        //    Value = value;
        //}

        //public BOOLEAN(int value)
        //{
        //    switch (value)
        //    {
        //        case 1:
        //            Value = 1;
        //            break;
        //        default:
        //            Value = 0;
        //            break;
        //    }
        //}

        //public static bool operator ==(BOOLEAN one, BOOLEAN two)
        //{
        //    return one != null && (two != null && (one.Value == two.Value));
        //}

        //public static bool operator !=(BOOLEAN one, BOOLEAN two)
        //{
        //    if (one == null || two == null)
        //        return false;
        //    if (one.Value == two.Value)
        //        return false;
        //    return true;
        //}

        //public override string ToString()
        //{
        //    string ret;
        //    switch (Value)
        //    {
        //        case 1:
        //            ret = "true";
        //            break;
        //        default:
        //            ret = "false";
        //            break;
        //    }
        //    return ret;
        //}


        //public void StreamXML(System.Xml.XmlWriter xmlStream)
        //{

        //    xmlStream.WriteValue(Value);
        //}

        //public bool Equals(BOOLEAN other)
        //{
        //    if (ReferenceEquals(null, other)) return false;
        //    if (ReferenceEquals(this, other)) return true;
        //    return other.Value == Value;
        //}

        //public override bool Equals(object obj)
        //{
        //    if (ReferenceEquals(null, obj)) return false;
        //    if (ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != typeof(BOOLEAN)) return false;
        //    return Equals((BOOLEAN)obj);
        //}

        //public override int GetHashCode()
        //{
        //    return Value.GetHashCode();
        //}

        //public override int CompareTo(object obj)
        //{
        //    if (obj == null) return 1;

        //    var rea = obj as BOOLEAN;
        //    return rea == null ? 1 : Value.CompareTo(rea.Value);
        //}
        #endregion
    }
}