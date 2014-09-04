using System;
using IfcBase;

namespace IFC2X3
{
    public partial class IfcAxis2Placement3D
    {
        public IfcDirection Y
        {
            get
            {
                return RefDirection.Cross(Axis);
            }
        }

        public IfcAxis2Placement3D(IfcCartesianPoint location)
        {
            if (location == null) throw new ArgumentNullException("location");
            Location = location;
        }

        public IfcAxis2Placement3D(IfcCartesianPoint location, IfcDirection axis, IfcDirection refAxis)
        {
            if (location == null) throw new ArgumentNullException("location");
            if (refAxis == null) throw new ArgumentNullException("refAxis");
            if (axis == null) throw new ArgumentNullException("axis");
            this.Location = location;
            this.Axis = axis;
            this.RefDirection = refAxis;
        }

        public static Matrix4 Axis2Placement3DToMatrix(IfcAxis2Placement3D axis2Placement3)
        {
            if (axis2Placement3.Axis == null)
            {
                axis2Placement3.Axis = new IfcDirection(0, 0, 1);
            }

            if (axis2Placement3.RefDirection == null)
            {
                axis2Placement3.RefDirection = new IfcDirection(1, 0, 0);
            }

            // Y direction is Z x ref direction
            // Caution
            // X direction is YxZ, not ZxY, which is reverse direction

            IfcDirection yDirection = IfcDirection.GetCrossProduct(axis2Placement3.Axis, axis2Placement3.RefDirection);
            IfcDirection xDirection = IfcDirection.GetCrossProduct(yDirection, axis2Placement3.Axis);
            IfcDirection zDirection = axis2Placement3.Axis;


            return new Matrix4(
                xDirection.DirectionRatios[0], yDirection.DirectionRatios[0], zDirection.DirectionRatios[0],
                axis2Placement3.Location.Coordinates[0],
                xDirection.DirectionRatios[1], yDirection.DirectionRatios[1], zDirection.DirectionRatios[1],
                axis2Placement3.Location.Coordinates[1],
                xDirection.DirectionRatios[2], yDirection.DirectionRatios[2], zDirection.DirectionRatios[2],
                axis2Placement3.Location.Coordinates[2],
                0, 0, 0, 1
                );
        }

    }
}