using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IfcBase;

namespace IFC2X3
{
    public partial class IfcLocalPlacement
    {
        public static Matrix4 LocalTransform(IfcLocalPlacement localPlacement)
        {
            Matrix4 rMatrix = null;
            if (localPlacement.RelativePlacement.Value is IfcAxis2Placement3D)
            {
                var relPlacement = localPlacement.RelativePlacement.Value as IfcAxis2Placement3D;

                rMatrix = IfcAxis2Placement3D.Axis2Placement3DToMatrix(relPlacement);


                // Check the nodes found.
                if (localPlacement.PlacementRelTo != null)
                {
                    var ifcLocalPlacement = localPlacement.PlacementRelTo as IfcLocalPlacement;
                    if (ifcLocalPlacement != null)
                    {
                        rMatrix.MultiplyRev(LocalTransform(ifcLocalPlacement));
                    }
                }
            }
            return rMatrix;
        }

    }
}
