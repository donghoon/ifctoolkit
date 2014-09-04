using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EbInstanceModel;
using IfcBase;

namespace IFC2X3
{
    public partial class IfcDirection
    {
       
        public void MakeUnitVector()
        {
            if (DirectionRatios == null) return;
            if (DirectionRatios.Count < 2 || DirectionRatios.Count > 3) throw new ArgumentException();

            DirectionRatios[0] = MathService.ToZero(DirectionRatios[0]);
            DirectionRatios[1] = MathService.ToZero(DirectionRatios[1]);
            if (DirectionRatios.Count == 3)
            {
                DirectionRatios[2] = MathService.ToZero(DirectionRatios[2]);
            }

            if (DirectionRatios.Count == 3)
            {
                if (DirectionRatios[0] == 0 &&
                    DirectionRatios[1] == 0 &&
                    DirectionRatios[2] == 0) throw new InvalidDataException();

                double unit = Math.Sqrt(
                    Math.Pow(DirectionRatios[0], 2) +
                    Math.Pow(DirectionRatios[1], 2) +
                    Math.Pow(DirectionRatios[2], 2));

                DirectionRatios[0] = MathService.ToZero(DirectionRatios[0] / unit);
                DirectionRatios[1] = MathService.ToZero(DirectionRatios[1] / unit);
                DirectionRatios[2] = MathService.ToZero(DirectionRatios[2] / unit);
            }
            else
            {
                if (DirectionRatios[0] == 0 &&
                    DirectionRatios[1] == 0) throw new InvalidDataException();

                double unit = Math.Sqrt(
                    Math.Pow(DirectionRatios[0], 2) +
                    Math.Pow(DirectionRatios[1], 2));

                DirectionRatios[0] = MathService.ToZero(DirectionRatios[0] / unit);
                DirectionRatios[1] = MathService.ToZero(DirectionRatios[1] / unit);
            }

        }

        /// <summary>
        /// Instantiates a new IfcDirection with given IfcDirection, and normalizes
        /// </summary>
        /// <param name="dir">The dir to be used.</param>
        public IfcDirection(IfcDirection dir)
        {
            if (dir.DirectionRatios.Count == 3)
            {
                DirectionRatios = new List<REAL>
                    {
                        dir.DirectionRatios[0],
                        dir.DirectionRatios[1],
                        dir.DirectionRatios[2]
                    };
            }
            else
            {
                DirectionRatios = new List<REAL>
                    {
                        dir.DirectionRatios[0],
                        dir.DirectionRatios[1]
                    };
            }
            MakeUnitVector();
        }

        public IfcDirection(double x, double y, double z)
        {
            DirectionRatios = new List<REAL> { x, y, z };
            MakeUnitVector();
        }

        public IfcDirection(double x, double y)
        {
            DirectionRatios = new List<REAL> { x, y };
            MakeUnitVector();
        }


        public IfcDirection(double[] direction)
        {
            if (direction.Length == 2)
            {
                DirectionRatios = new List<REAL> { direction[0], direction[1] };
            }
            else if (direction.Length == 3)
            {
                DirectionRatios = new List<REAL> { direction[0], direction[1], direction[2] };
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            MakeUnitVector();
        }

        public IfcDirection(IEnumerable<double> direction)
            : this((double[]) direction.ToArray())
        {
        }

        public static bool operator ==(IfcDirection p1, IfcDirection p2)
        {
            const double epsilonSquared = 0.0001;
            var point1IsNull = ReferenceEquals(p1, null);
            var point2IsNull = ReferenceEquals(p2, null);

            if (point1IsNull && point2IsNull)
                return true;

            if (point1IsNull || point2IsNull)
                return false;

            if ((p1.DirectionRatios[0] - p2.DirectionRatios[0]) * (p1.DirectionRatios[0] - p2.DirectionRatios[0]) + (p1.DirectionRatios[1] - p2.DirectionRatios[1]) * (p1.DirectionRatios[1] - p2.DirectionRatios[1]) + (p1.DirectionRatios[2] - p2.DirectionRatios[2]) * (p1.DirectionRatios[2] - p2.DirectionRatios[2]) <= epsilonSquared)
                return true;
            return false;
        }

        /// <summary>
        /// Compares if the two given points are not similar.
        /// </summary>
        /// <param name="p1">The first point to be used.</param>
        /// <param name="p2">The second point to be used.</param>
        /// <returns>True if the given two points are not similar. False otherwise.</returns>
        public static bool operator !=(IfcDirection p1, IfcDirection p2)
        {
            return !(p1 == p2);
        }


        protected bool Equals(IfcDirection other)
        {
            return Equals(DirectionRatios, other.DirectionRatios);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((IfcDirection)obj);
        }

        public override int GetHashCode()
        {
            return (DirectionRatios != null ? DirectionRatios.GetHashCode() : 0);
        }


        //public double Normalize()
        //{
        //    return this.Normalize(1.0);
        //}

        /// <summary>
        /// Normalizes the vector using the given length.
        /// </summary>
        /// <param name="newLength">The length to be used.</param>
        /// <returns>The normalized vector's length.</returns>
        //public double Normalize(double newLength)
        //{
        //    var length = Math.Sqrt(DirectionRatios[0] * DirectionRatios[0] + DirectionRatios[1] * DirectionRatios[1] + DirectionRatios[2] * DirectionRatios[2]);
        //    var minLength = MathService.Epsilon;

        //    if (length > minLength)
        //    {
        //        DirectionRatios[0] = DirectionRatios[0] / length * newLength;
        //        DirectionRatios[1] = DirectionRatios[1] / length * newLength;
        //        DirectionRatios[2] = DirectionRatios[2] / length * newLength;

        //        length = newLength;
        //    }
        //    return length;
        //}

        /// <summary>
        /// Gets the angle (in radians) between the current vector and the given vector.
        /// </summary>
        /// <param name="dir">The vector to be used.</param>
        /// <returns>The angle between the vectors in radians.</returns>
        public double GetAngleBetween(IfcDirection dir)
        {
            var from = this;
            var that = dir;

            if (Math.Abs(from.Dot(that) - 1.0) <= MathService.Epsilon)
                return 0.0;
            return Math.Abs(@from.Dot(that) + 1.0) <= MathService.Epsilon ? Math.PI : Math.Acos(@from.Dot(that));
        }

        /// <summary>
        /// Returns a new normalized equivalent of the current vector.
        /// </summary>
        /// <returns>The normalized equivalent of the current vector.</returns>
        //public IfcDirection GetNormal()
        //{
        //    var normal = new IfcDirection(this);
        //    normal.Normalize();

        //    return normal;
        //}

        /// <summary>
        /// Returns a dot product of the current vector and the given vector.
        /// </summary>
        /// <param name="dir">The vector to be used.</param>
        /// <returns>The dot product of the vectors.</returns>
        public double Dot(IfcDirection dir)
        {
            return DirectionRatios[0] * dir.DirectionRatios[0]
                   + DirectionRatios[1] * dir.DirectionRatios[1]
                   + DirectionRatios[2] * dir.DirectionRatios[2];
        }

        /// <summary>
        /// Returns a dot product of the given two vectors.
        /// </summary>
        /// <param name="dir1">The first vector to be used.</param>
        /// <param name="dir2">The second vector to be used.</param>
        /// <returns>The dot product of the vectors.</returns>
        public static double Dot(IfcDirection dir1, IfcDirection dir2)
        {
            return dir1.Dot(dir2);
        }

        /// <summary>
        /// Returns a new cross product vector of the current vector and the given vector.
        /// </summary>
        /// <param name="dir">The vector to be used.</param>
        /// <returns>The new cross product vector.</returns>
        public IfcDirection Cross(IfcDirection dir)
        {
            return new IfcDirection(DirectionRatios[1] * dir.DirectionRatios[2] - DirectionRatios[2] * dir.DirectionRatios[1],
                                    DirectionRatios[2] * dir.DirectionRatios[0] - DirectionRatios[0] * dir.DirectionRatios[2],
                                    DirectionRatios[0] * dir.DirectionRatios[1] - DirectionRatios[1] * dir.DirectionRatios[0]);
        }

        /// <summary>
        /// Returns a new cross product vector of the given two vectors.
        /// </summary>
        /// <param name="dir1">The first vector to be used.</param>
        /// <param name="dir2">The second vector to be used.</param>
        /// <returns>The new cross product vector.</returns>
        public static IfcDirection Cross(IfcDirection dir1, IfcDirection dir2)
        {
            return dir1.Cross(dir2);
        }

        //public override string ToString()
        //{
        //    return string.Format("({0:0.000}, {1:0.000}, {2:0.000})", DirectionRatios[0], DirectionRatios[1], DirectionRatios[2]);
        //}



        public static void AngleToDirection2D(double radian, out IfcDirection xAxisDirection, out IfcDirection yAxisDirection)
        {

            // rotation matrix = | cos -sin |
            //                   | sin  cos |

            xAxisDirection = new IfcDirection(Math.Cos(radian), -Math.Sin(radian));
            yAxisDirection = new IfcDirection(-Math.Sin(radian), Math.Cos(radian));
        }



        public static IfcDirection GetCrossProduct(IfcDirection directionX, IfcDirection directionY)
        {
            double X, Y, Z;
            X = directionX.DirectionRatios[1] * directionY.DirectionRatios[2]
                - directionX.DirectionRatios[2] * directionY.DirectionRatios[1];
            Y = directionX.DirectionRatios[2] * directionY.DirectionRatios[0]
                - directionX.DirectionRatios[0] * directionY.DirectionRatios[2];
            Z = directionX.DirectionRatios[0] * directionY.DirectionRatios[1]
                - directionX.DirectionRatios[1] * directionY.DirectionRatios[0];
            var ret = new IfcDirection(X, Y, Z);
            // ret.MakeUnitVector();
            return ret;
        }

    }
}