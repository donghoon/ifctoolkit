using System;
using System.Collections.Generic;
using System.IO;

namespace EbInstanceModel
{
    public partial class SECTION_CONTEXT : HeaderInstance
    {
        public SECTION_NAME SECTION;
        public List<CONTEXT_NAME> CONTEXT_IDENTIFIERS;

        public override void WriteToP21(StreamWriter p21File)
        {
            throw new NotImplementedException();
        }
    }
}