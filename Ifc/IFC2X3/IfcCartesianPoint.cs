using System;
using System.Collections.Generic;
using System.Linq;

namespace IFC2X3
{
    public partial class IfcCartesianPoint
    {

        public IfcCartesianPoint(IEnumerable<double> point)
            : this((double[]) point.ToArray())
        {
        }

        public IfcCartesianPoint(double[] point)
        {
            if (point.Length == 2)
            {
                Coordinates = new List<IfcLengthMeasure> { point[0], point[1] };
            }
            else if (point.Length == 3)
            {
                Coordinates = new List<IfcLengthMeasure> { point[0], point[1], point[2] };
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IfcCartesianPoint(double x, double y, double z)
            : this(new double[] { x, y, z })
        {
            //Coordinates = new List<IfcLengthMeasure> { x, y, z };
        }

        public IfcCartesianPoint(double x, double y)
            : this(new double[] { x, y })
        {
            //           Coordinates = new List<IfcLengthMeasure> { x, y };
        }

        public override string ToString()
        {
            return string.Format("({0:0.000}, {1:0.000}, {2:0.000})", Coordinates[0], Coordinates[1], Coordinates[2]);
        }

        public static IfcCartesianPoint operator +(IfcCartesianPoint p1, IfcCartesianPoint p2)
        {
            if (p1.Coordinates.Count == 2 && p2.Coordinates.Count == 2)
            {
                new IfcCartesianPoint(p1.Coordinates[0] + p2.Coordinates[0], p1.Coordinates[1] + p2.Coordinates[1]);
            } 
            if (p1.Coordinates.Count == 3 && p2.Coordinates.Count == 3)
            {
                new IfcCartesianPoint(p1.Coordinates[0] + p2.Coordinates[0], p1.Coordinates[1] + p2.Coordinates[1], p1.Coordinates[2] + p2.Coordinates[2]);
            }
            throw new InvalidOperationException();

        }

        /// <summary>
        /// Returns the difference of the given two points.
        /// </summary>
        /// <param name="p1">The first point to be used.</param>
        /// <param name="p2">The second point to be used.</param>
        /// <returns>The difference of the given two points.</returns>
        public static IfcCartesianPoint operator -(IfcCartesianPoint p1, IfcCartesianPoint p2)
        {
            if (p1.Coordinates.Count == 2 && p2.Coordinates.Count == 2)
            {
                return new IfcCartesianPoint(p1.Coordinates[0] - p2.Coordinates[0], p1.Coordinates[1] - p2.Coordinates[1]);
            }
            if (p1.Coordinates.Count == 3 && p2.Coordinates.Count == 3)
            {
                return new IfcCartesianPoint(p1.Coordinates[0] - p2.Coordinates[0], p1.Coordinates[1] - p2.Coordinates[1], p1.Coordinates[2] - p2.Coordinates[2]);
            }
            
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Compares the given two points for similarity.
        /// </summary>
        /// <param name="p1">The first point to be used.</param>
        /// <param name="p2">The second point to be used.</param>
        /// <returns>True if the given two points are similar. False otherwise.</returns>
        public static bool operator ==(IfcCartesianPoint p1, IfcCartesianPoint p2)
        {

            const double epsilonSquared = 0.0001;
            var point1IsNull = ReferenceEquals(p1, null);
            var point2IsNull = ReferenceEquals(p2, null);

            if (point1IsNull && point2IsNull)
                return true;

            if (point1IsNull || point2IsNull)
                return false;

            if (p1.Coordinates.Count == 2 && p2.Coordinates.Count == 2)
            {
                return (
                           (p1.Coordinates[0] - p2.Coordinates[0]) * 
                           (p1.Coordinates[0] - p2.Coordinates[0]) + 
                           (p1.Coordinates[1] - p2.Coordinates[1]) * 
                           (p1.Coordinates[1] - p2.Coordinates[1])
                           <= epsilonSquared);
            }



            if (p1.Coordinates.Count == 3 && p2.Coordinates.Count == 3)
                return (
                           (p1.Coordinates[0] - p2.Coordinates[0]) * 
                           (p1.Coordinates[0] - p2.Coordinates[0]) + 
                           (p1.Coordinates[1] - p2.Coordinates[1]) * 
                           (p1.Coordinates[1] - p2.Coordinates[1]) + 
                           (p1.Coordinates[2] - p2.Coordinates[2]) * 
                           (p1.Coordinates[2] - p2.Coordinates[2]) 
                           <= epsilonSquared);
            return false;
        }

        /// <summary>
        /// Compares if the two given points are not similar.
        /// </summary>
        /// <param name="p1">The first point to be used.</param>
        /// <param name="p2">The second point to be used.</param>
        /// <returns>True if the given two points are not similar. False otherwise.</returns>
        public static bool operator !=(IfcCartesianPoint p1, IfcCartesianPoint p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            var cp = obj as IfcCartesianPoint;
            if (cp == null) 
                return false;
            return (this == cp);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}