using System.Collections.Generic;
using System.IO;

namespace EbInstanceModel
{
    public partial class FILE_DESCRIPTION : HeaderInstance
    {
        public List<STRING> DESCRIPTION;
        public STRING IMPLEMTATION_LEVEL;

        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(GetType().Name);
            p21File.Write(EbConstants.LParentheses);

            DESCRIPTION.WriteToP21(p21File);
            p21File.Write(EbConstants.Comma);
            IMPLEMTATION_LEVEL.WriteToP21(p21File);

            p21File.Write(EbConstants.RParentheses);
        }
    }
}