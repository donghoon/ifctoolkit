using System;
using System.IO;

namespace EbInstanceModel
{
    public partial class SECTION_LANGUAGE : HeaderInstance
    {
        public SECTION_NAME SECTION;
        public LANGUAGE_NAME DEFAULT_LANGUAGE;

        public override void WriteToP21(StreamWriter p21File)
        {
            throw new NotImplementedException();
        }
    }
}