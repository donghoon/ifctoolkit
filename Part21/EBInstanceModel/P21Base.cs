using System.IO;

namespace EbInstanceModel
{
    /// <summary>
    /// Root class of everything
    /// Coverted to Non abstract due to select type Value
    /// </summary>
    public class P21Base
    {
        public virtual void WriteToP21(StreamWriter p21File)
        {
            
        }

        public virtual string GetP21String()
        {
            return "";
        }

        public bool IsDerived;

    }
}