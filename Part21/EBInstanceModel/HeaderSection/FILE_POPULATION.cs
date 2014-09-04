using System;
using System.Collections.Generic;
using System.IO;

namespace EbInstanceModel
{
    public partial class FILE_POPULATION : HeaderInstance
    {
        public SECTION_NAME GOVERNING_SCHEMA;
        public EXCHANGE_STRUCTURE_IDENTIFIER DETERMINATION_METHOD;
        public List<SECTION_NAME> GOVERNED_SECTIONS;

        public override void WriteToP21(StreamWriter p21File)
        {
            throw new NotImplementedException();
        }
    }
}