using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfcBase
{

    public class MathService
    {

        /// <summary>
        /// This is the min precision value of a double floating number. Any double number that is smaller then this is considered 0.
        /// </summary>
        public static double Epsilon = Constants.ConstDoubleGeometricRepresentationContextPrecision;

        /// <summary>
        /// Cast a double number to 0.0 if it is larger then the epsilon setting
        /// </summary>
        /// <param name="value">value of the double to cast</param>
        /// <returns>cast double value</returns>
        public static double ToZero(double value)
        {
            return Math.Abs(value) < Epsilon ? 0.0 : value;
        }



        
        public static double[] Normalize(double[] value)
        {
            if (value.Length < 2 || value.Length > 3)
            {
                throw new ArgumentException();
            }

            if (value.Length == 2)
            {
                double div = Math.Sqrt(value[0] * value[0] + value[1] * value[1]);
                div = ToZero(div);
                if (div == 0.0)
                    throw new DivideByZeroException();

                value[0] = value[0] / div;
                value[1] = value[1] / div;
            }
            else
            {
                double div = Math.Sqrt(value[0] * value[0] + value[1] * value[1] + value[2] * value[2]);
                div = ToZero(div);
                if (div == 0)
                    throw new DivideByZeroException();
                value[0] = value[0] / div;
                value[1] = value[1] / div;
                value[2] = value[2] / div;
            }

            return value;
        }

        public static bool IsEqual(double a, double b)
        {
            throw new NotImplementedException();
        }

        public static bool IsZero(double a)
        {
            throw new NotImplementedException();
        }
    }


    public class Matrix4
    {
        
        
        
        public double A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, D1, D2, D3, D4;

        public Matrix4(
            double m_a1, double m_a2, double m_a3, double m_a4,
            double m_b1, double m_b2, double m_b3, double m_b4,
            double m_c1, double m_c2, double m_c3, double m_c4,
            double m_d1, double m_d2, double m_d3, double m_d4)
        {
            A1 = m_a1;
            A2 = m_a2;
            A3 = m_a3;
            A4 = m_a4;
            B1 = m_b1;
            B2 = m_b2;
            B3 = m_b3;
            B4 = m_b4;
            C1 = m_c1;
            C2 = m_c2;
            C3 = m_c3;
            C4 = m_c4;
            D1 = m_d1;
            D2 = m_d2;
            D3 = m_d3;
            D4 = m_d4;
        }

        public Matrix4(double dX, double dY, double dZ)
        {
            A1 = 1;
            A2 = 0;
            A3 = 0;
            A4 = dX;
            B1 = 0;
            B2 = 1;
            B3 = 0;
            B4 = dY;
            C1 = 0;
            C2 = 0;
            C3 = 1;
            C4 = dZ;
            D1 = 0;
            D2 = 0;
            D3 = 0;
            D4 = 1;
        }

        public Matrix4()
        {
            A1 = 1;
            A2 = 0;
            A3 = 0;
            A4 = 0;

            B1 = 0;
            B2 = 1;
            B3 = 0;
            B4 = 0;

            C1 = 0;
            C2 = 0;
            C3 = 1;
            C4 = 0;

            D1 = 0;
            D2 = 0;
            D3 = 0;
            D4 = 1;
        }

        public void Multiply(Matrix4 sM)
        {
            double n_a1,
                   n_a2,
                   n_a3,
                   n_a4,
                   n_b1,
                   n_b2,
                   n_b3,
                   n_b4,
                   n_c1,
                   n_c2,
                   n_c3,
                   n_c4,
                   n_d1,
                   n_d2,
                   n_d3,
                   n_d4;
            n_a1 = A1 * sM.A1 + A2 * sM.B1 + A3 * sM.C1 + A4 * sM.D1;
            n_a2 = A1 * sM.A2 + A2 * sM.B2 + A3 * sM.C2 + A4 * sM.D2;
            n_a3 = A1 * sM.A3 + A2 * sM.B3 + A3 * sM.C3 + A4 * sM.D3;
            n_a4 = A1 * sM.A4 + A2 * sM.B4 + A3 * sM.C4 + A4 * sM.D4;

            n_b1 = B1 * sM.A1 + B2 * sM.B1 + B3 * sM.C1 + B4 * sM.D1;
            n_b2 = B1 * sM.A2 + B2 * sM.B2 + B3 * sM.C2 + B4 * sM.D2;
            n_b3 = B1 * sM.A3 + B2 * sM.B3 + B3 * sM.C3 + B4 * sM.D3;
            n_b4 = B1 * sM.A4 + B2 * sM.B4 + B3 * sM.C4 + B4 * sM.D4;

            n_c1 = C1 * sM.A1 + C2 * sM.B1 + C3 * sM.C1 + C4 * sM.D1;
            n_c2 = C1 * sM.A2 + C2 * sM.B2 + C3 * sM.C2 + C4 * sM.D2;
            n_c3 = C1 * sM.A3 + C2 * sM.B3 + C3 * sM.C3 + C4 * sM.D3;
            n_c4 = C1 * sM.A4 + C2 * sM.B4 + C3 * sM.C4 + C4 * sM.D4;

            n_d1 = D1 * sM.A1 + D2 * sM.B1 + D3 * sM.C1 + D4 * sM.D1;
            n_d2 = D1 * sM.A2 + D2 * sM.B2 + D3 * sM.C2 + D4 * sM.D2;
            n_d3 = D1 * sM.A3 + D2 * sM.B3 + D3 * sM.C3 + D4 * sM.D3;
            n_d4 = D1 * sM.A4 + D2 * sM.B4 + D3 * sM.C4 + D4 * sM.D4;

            A1 = n_a1;
            A2 = n_a2;
            A3 = n_a3;
            A4 = n_a4;

            B1 = n_b1;
            B2 = n_b2;
            B3 = n_b3;
            B4 = n_b4;

            C1 = n_c1;
            C2 = n_c2;
            C3 = n_c3;
            C4 = n_c4;

            D1 = n_d1;
            D2 = n_d2;
            D3 = n_d3;
            D4 = n_d4;
        }

        public void MultiplyRev(Matrix4 firstMatrix)
        {
            double n_a1,
                   n_a2,
                   n_a3,
                   n_a4,
                   n_b1,
                   n_b2,
                   n_b3,
                   n_b4,
                   n_c1,
                   n_c2,
                   n_c3,
                   n_c4,
                   n_d1,
                   n_d2,
                   n_d3,
                   n_d4;
            n_a1 = firstMatrix.A1 * A1 + firstMatrix.A2 * B1 + firstMatrix.A3 * C1 + firstMatrix.A4 * D1;
            n_a2 = firstMatrix.A1 * A2 + firstMatrix.A2 * B2 + firstMatrix.A3 * C2 + firstMatrix.A4 * D2;
            n_a3 = firstMatrix.A1 * A3 + firstMatrix.A2 * B3 + firstMatrix.A3 * C3 + firstMatrix.A4 * D3;
            n_a4 = firstMatrix.A1 * A4 + firstMatrix.A2 * B4 + firstMatrix.A3 * C4 + firstMatrix.A4 * D4;

            n_b1 = firstMatrix.B1 * A1 + firstMatrix.B2 * B1 + firstMatrix.B3 * C1 + firstMatrix.B4 * D1;
            n_b2 = firstMatrix.B1 * A2 + firstMatrix.B2 * B2 + firstMatrix.B3 * C2 + firstMatrix.B4 * D2;
            n_b3 = firstMatrix.B1 * A3 + firstMatrix.B2 * B3 + firstMatrix.B3 * C3 + firstMatrix.B4 * D3;
            n_b4 = firstMatrix.B1 * A4 + firstMatrix.B2 * B4 + firstMatrix.B3 * C4 + firstMatrix.B4 * D4;

            n_c1 = firstMatrix.C1 * A1 + firstMatrix.C2 * B1 + firstMatrix.C3 * C1 + firstMatrix.C4 * D1;
            n_c2 = firstMatrix.C1 * A2 + firstMatrix.C2 * B2 + firstMatrix.C3 * C2 + firstMatrix.C4 * D2;
            n_c3 = firstMatrix.C1 * A3 + firstMatrix.C2 * B3 + firstMatrix.C3 * C3 + firstMatrix.C4 * D3;
            n_c4 = firstMatrix.C1 * A4 + firstMatrix.C2 * B4 + firstMatrix.C3 * C4 + firstMatrix.C4 * D4;

            n_d1 = firstMatrix.D1 * A1 + firstMatrix.D2 * B1 + firstMatrix.D3 * C1 + firstMatrix.D4 * D1;
            n_d2 = firstMatrix.D1 * A2 + firstMatrix.D2 * B2 + firstMatrix.D3 * C2 + firstMatrix.D4 * D2;
            n_d3 = firstMatrix.D1 * A3 + firstMatrix.D2 * B3 + firstMatrix.D3 * C3 + firstMatrix.D4 * D3;
            n_d4 = firstMatrix.D1 * A4 + firstMatrix.D2 * B4 + firstMatrix.D3 * C4 + firstMatrix.D4 * D4;

            A1 = n_a1;
            A2 = n_a2;
            A3 = n_a3;
            A4 = n_a4;

            B1 = n_b1;
            B2 = n_b2;
            B3 = n_b3;
            B4 = n_b4;

            C1 = n_c1;
            C2 = n_c2;
            C3 = n_c3;
            C4 = n_c4;

            D1 = n_d1;
            D2 = n_d2;
            D3 = n_d3;
            D4 = n_d4;
        }

        public double[] Multiply(double xValue, double yValue, double zValue)
        {
            var rValue = new double[3];

            rValue[0] = A1 * xValue + A2 * yValue + A3 * zValue + A4;
            rValue[1] = B1 * xValue + B2 * yValue + B3 * zValue + B4;
            rValue[2] = C1 * xValue + C2 * yValue + C3 * zValue + C4;
            return rValue;
        }

        // apply addition values to Matrix using multiply
        // addition to the "this" matrix
        // "this matrix" = addtion matrix + "this" matrix 
        public void Add(double dX, double dY, double dZ)
        {
            var addMatrix = new Matrix4(dX, dY, dZ);
            addMatrix.Multiply(this);
            A1 = addMatrix.A1;
            A2 = addMatrix.A2;
            A3 = addMatrix.A3;
            A4 = addMatrix.A4;
            B1 = addMatrix.B1;
            B2 = addMatrix.B2;
            B3 = addMatrix.B3;
            B4 = addMatrix.B4;
            C1 = addMatrix.C1;
            C2 = addMatrix.C2;
            C3 = addMatrix.C3;
            C4 = addMatrix.C4;
            D1 = addMatrix.D1;
            D2 = addMatrix.D2;
            D3 = addMatrix.D3;
            D4 = addMatrix.D4;
        }

        public void CopyValueFrom(Matrix4 source)
        {
            A1 = source.A1;
            A2 = source.A2;
            A3 = source.A3;
            A4 = source.A4;
            B1 = source.B1;
            B2 = source.B2;
            B3 = source.B3;
            B4 = source.B4;
            C1 = source.C1;
            C2 = source.C2;
            C3 = source.C3;
            C4 = source.C4;
            D1 = source.D1;
            D2 = source.D2;
            D3 = source.D3;
            D4 = source.D4;
        }

        public static Matrix4 Rotate(double cosx, double sinx, double cosy, double siny, double cosz, double sinz)
        {
            var xRotate = new Matrix4(
                1, 0, 0, 0,
                0, cosx, -sinx, 0,
                0, sinx, cosx, 0,
                0, 0, 0, 1
                );
            var yRotate = new Matrix4(
                cosy, 0, siny, 0,
                0, 1, 0, 0,
                -siny, 0, cosy, 0,
                0, 0, 0, 1);

            var zRotate = new Matrix4(
                cosz, -sinz, 0, 0,
                sinz, cosz, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);

            xRotate.Multiply(yRotate);
            xRotate.Multiply(zRotate);
            return xRotate;
        }
    }


    public class Constants
    {
        #region Const Strings

        internal const string StringApplicationDeveloper = "unknown";
        internal const string StringApplicationIdentifier = "unknown";
        internal const string StringApplicationVersion = "1.0";
        internal const string StringApplicationFullName = "IFC SEM Exporter";
        internal const string StringGeometricRepresentationContextIdentifier = "ContextIdentifier";
        internal const string StringGeometricRepresentationContextType = "NotDefined";
        internal const int ConstIntGeometricRepresentationContextDimension = 3;
        internal const double ConstDoubleGeometricRepresentationContextPrecision = 1e-7;

        #endregion Const Strings
    }

}
