using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SchemaModel
{
    [Serializable]
    public class SAttributeInverse: SAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public SAttribute InversingAttribute { get; set; }

		/// <summary>
		/// temporary name keeping place of inversing attribute's originating attribute name
		/// </summary>
		/// <value>The name of the inversing attribute.</value>
		public string InversingAttributeName { get; set; }

		//public SEntity ReferencingEntity { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public SAttributeInverse(string name, SParameter type) : base(name, type)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public SAttributeInverse(string name) : base(name)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        //public void ToCSharpClass(Stream stream)
        //{
        //    SData.AddText(stream, "\t\tpublic");
        //    Type.ToCSharpClass(stream);
        //    SData.AddText(stream, string.Format(" {0};\n", Name));

        //}

		public override void ToCSharpClass(StreamWriter stream)
		{
            stream.WriteLine("\t\t[InverseAttribute]");
			stream.Write( "\t\tpublic");
			Type.ToCSharpClass(stream);
			stream.WriteLine( string.Format(" {0};", Name));
			stream.WriteLine();
		}


    }
}
