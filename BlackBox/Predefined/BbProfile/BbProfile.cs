using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;


namespace BlackBox.Predefined
{
    public class BbProfile : BbBase
    {
        [EarlyBindingInstance]
        public virtual IfcProfileDef IfcProfileDef { get; set; }

        public string Name { get; set; }


		public  double Width { get; set; }
		
		public  double Depth { get; set; }

        //public static BbProfile Retrieve(SemEditableGeometry extrudedGeometry)
        //{
        //    var ret = new BbProfile();
        //    var areaSolid = extrudedGeometry.IfcShapeRepresentation.Items;
        //    foreach (var aa in areaSolid)
        //    {
        //        var bb = aa as IfcExtrudedAreaSolid;
        //        //ret = bb.SweptArea.GetSem();



        //        var profileDef = bb.SweptArea;
        //        var semProfile = new BbProfile { IfcProfileDef = profileDef };
        //        if (semProfile != null)
        //        { ret = semProfile; }
        //    }
        //    return ret;
        //}

    }



}