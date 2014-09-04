using System.Collections.Generic;
using System.IO;

namespace EbInstanceModel
{
    public partial class FILE_SCHEMA : HeaderInstance
    {
        public List<SCHEMA_NAME> SCHEMA_IDENTIFIERS;

        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(GetType().Name);

            p21File.Write(EbConstants.LParentheses);

            SCHEMA_IDENTIFIERS.WriteToP21(p21File);

            p21File.Write(EbConstants.RParentheses);
        }
    }
}