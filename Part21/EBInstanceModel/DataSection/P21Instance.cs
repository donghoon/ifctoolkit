using System.Globalization;
using System.IO;

namespace EbInstanceModel
{
    /// <summary>
    /// Simple Record
    /// assigned to simple instance
    /// </summary>
    public abstract class P21Instance : P21Base
    {
        public uint EIN;

        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(GetP21String());
        }

        public override string GetP21String()
        {
            return EbConstants.Sharp + EIN.ToString(CultureInfo.InvariantCulture);
        }
    }
}