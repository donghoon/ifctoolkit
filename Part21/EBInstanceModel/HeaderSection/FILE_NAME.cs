using System.Collections.Generic;
using System.IO;

namespace EbInstanceModel
{
    public partial class FILE_NAME : HeaderInstance
    {
        public STRING NAME;
        public TIME_STAMP_TEXT TIME_STAMP;
        public List<STRING> AUTHOR;
        public List<STRING> ORGANIZATION;
        public STRING PREPROCESSOR_VERSION;
        public STRING ORIGINATING_SYSTEM;
        public STRING AUTHORIZATION;

        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(GetType().Name);
            p21File.Write(EbConstants.LParentheses);

            NAME.WriteToP21(p21File);
            p21File.Write(EbConstants.Comma);
            TIME_STAMP.WriteToP21(p21File);
            p21File.Write(EbConstants.Comma);
            AUTHOR.WriteToP21(p21File);
            p21File.Write(EbConstants.Comma);
            ORGANIZATION.WriteToP21(p21File);
            p21File.Write(EbConstants.Comma);
            PREPROCESSOR_VERSION.WriteToP21(p21File);
            p21File.Write(EbConstants.Comma);
            ORIGINATING_SYSTEM.WriteToP21(p21File);
            p21File.Write(EbConstants.Comma);
            AUTHORIZATION.WriteToP21(p21File);

            p21File.Write(EbConstants.RParentheses);
        }
    }
}