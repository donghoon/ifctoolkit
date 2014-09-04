using IFC2X3;
using Sem.Service;


namespace Sem.Predefined
{
	/// <summary>
	/// Assembly name.
	/// 
	/// 
	/// </summary>
    public class SemAssemblyName : SemBase
    {
        private string tag;
        private SemElement assembly;
 
		IfcElementAssembly ifcElementAssembly;


        public SemAssemblyName(SemElement assembly, string tag)
        {
            this.assembly = assembly;
			ifcElementAssembly = this.assembly.IfcObject as IfcElementAssembly;
            this.tag = tag;
            this.assembly.IfcObject.Tag = this.tag;
        }

        public IfcIdentifier ifcIdentifier
        {
            get { return tag;}
            set {tag = value;}
        }


        public static SemAssemblyName Create(SemElement assembly, string tag)
        {
			SemAssemblyName aName = new SemAssemblyName (assembly, tag);
            //SemInstanceDB.Add(aName);
       
            return aName;
        }
    }
}