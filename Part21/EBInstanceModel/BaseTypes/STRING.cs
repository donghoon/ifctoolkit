using System.IO;

namespace EbInstanceModel
{
    public class STRING : BaseType
    {
        public string Value { get; set; }


        public static implicit operator STRING(string value)
        {
            return new STRING { Value = value };
        }

        public static implicit operator string(STRING cpdValueString)
        {
            return cpdValueString.Value;
        }

        public override string ToString()
        {
            return string.Format("'{0}'", Value);
        }
        
        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(GetP21String());
        }

        public override string GetP21String()
        {
            return string.Format("'{0}'", Value);
        }

        #region commented out
        //public STRING()
        //    : this("")
        //{
        //}

        //public STRING(string value)
        //{
        //    Value = value;
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}

        //public void StreamXML(System.Xml.XmlWriter xmlStream)
        //{
        //    xmlStream.WriteValue(Value);
        //}


        //public static STRING CreateCPDValueString(string value)
        //{
        //    //if (string.IsNullOrWhiteSpace(value))
        //    //    return @"";
        //    return new STRING(value);
        //}

        //public override int CompareTo(object obj)
        //{
        //    if (obj == null) return 1;

        //    var rea = obj as STRING;
        //    return rea == null ? 1 : Value.CompareTo(rea.Value);
        //}
        #endregion
    }
}