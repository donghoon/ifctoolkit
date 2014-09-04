using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
	public partial class BbProperty:BbBase
	{
		public string Name{get; protected set;}
		public string Description{ get; set; }

		public virtual IfcProperty IfcProperty { get; set; }

	}
}

