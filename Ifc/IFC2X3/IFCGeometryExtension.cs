using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFC2X3
{
    public partial class IfcProductDefinitionShape
    {
		[Obsolete("Use Create function of ExtrudedGeometry in SEM definition")]
        public static IfcProductDefinitionShape CreateExtruded(IfcRepresentationContext representationContext,
            IfcProfileDef ifcProfileDef, IfcAxis2Placement3D placement3D, IfcDirection direction, double depth)
        {
            var extruded = new IfcExtrudedAreaSolid
                               {
                                   SweptArea = ifcProfileDef,
                                   Position =  placement3D,
                                   ExtrudedDirection = direction ,
                                   Depth = depth,
                               };

            var shaperep = new IfcShapeRepresentation
                               {
                                   ContextOfItems = representationContext,
                                   RepresentationIdentifier = "Body",
                                   RepresentationType = "SweptSolid",
                                   Items = new List<IfcRepresentationItem>(),
                               };
            shaperep.Items.Add(extruded);

            var ifcShape = new IfcProductDefinitionShape
                               {
                                   // Name=
                                   // Description = 
                                   Representations = new List<IfcRepresentation>(),
                               };
            ifcShape.Representations.Add(shaperep);

            return ifcShape;
        }
    }
}
