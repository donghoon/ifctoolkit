using System;
using System.IO;

namespace EbInstanceModel
{
    public class REAL : BaseType
    {
        public const int Precision = 9;
        public double Value { get; set; }

        public static implicit operator REAL(double value)
        {
            return new REAL { Value = Math.Round(value, Precision) };
            //return new REAL { Value =value };
        }

        public static implicit operator double(REAL cpdValueDouble)
        {
            return cpdValueDouble.Value;
        }

        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(ToString());
        }

        public override string ToString()
        {
            string t = Value.ToString();

            while(t.Contains("E0"))
            {
                t= t.Replace("E0", "E");
            }
            while (t.Contains("E-0"))
            {
                t = t.Replace("E-0", "E-");
            }
			
            if (!t.Contains("."))
            {
                if (t.Contains("E"))
                {
                    t = t.Replace("E", ".E");
                }
                else
                {
                    t = t + ".";
                }
            }
            return t;
        }

        //public override void ReadP21(ICollection<Token> tokens)
        //{
        //    throw new NotImplementedException();
        //}


        #region commented out

        //public REAL()
        //    : this(0.0)
        //{
        //}

        //public REAL(double value)
        //{
        //    Value = System.Math.Round(value, Precision);
        //}

        //public static double operator +(REAL one, REAL two)
        //{
        //    return one.Value + two.Value;
        //}

        //public static REAL operator +(double one, REAL two)
        //{
        //    return new REAL(System.Math.Round(one, Precision) + two.Value);
        //}

        //public static double operator -(REAL one, REAL two)
        //{
        //    return one.Value - two.Value;
        //}

        //public static REAL operator -(double one, REAL two)
        //{
        //    return new REAL(System.Math.Round(one, Precision) - two.Value);
        //}

        //public static bool operator ==(REAL one, REAL two)
        //{

        //    return System.Math.Abs(one.Value - two.Value) < Precision;
        //}

        //public static bool operator ==(REAL two, double one)
        //{
        //    if (System.Math.Abs(one - two.Value) < Precision)
        //        return true;
        //    return false;
        //}

        //public static bool operator ==(double one, REAL two)
        //{


        //    if (System.Math.Abs(one - two.Value) < Precision)
        //        return true;
        //    return false;
        //}

        //public static bool operator !=(REAL one, REAL two)
        //{
        //    return !(one == two);
        //}

        //public static bool operator !=(double one, REAL two)
        //{
        //    return !(one == two);
        //}

        //public static bool operator !=(REAL two, double one)
        //{
        //    return !(two == one);
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    var a = obj as REAL;
        //    if (a == null) return false;
        //    return (System.Math.Abs(a.Value - Value) < Precision);
        //}

        //public override string ToString()
        //{
        //    return Value.ToString(System.Globalization.CultureInfo.InvariantCulture);
        //}

        //public bool Equals(REAL other)
        //{
        //    if (ReferenceEquals(null, other)) return false;
        //    if (ReferenceEquals(this, other)) return true;
        //    return other.Value.Equals(Value);
        //}

        //public override int GetHashCode()
        //{
        //    return Value.GetHashCode();
        //}

        //public override int CompareTo(object obj)
        //{
        //    if (obj == null) return 1;

        //    var rea = obj as REAL;
        //    if (rea == null) return 1;

        //    return Value.CompareTo(rea.Value);
        //}

        //public override int CompareTo(object obj)
        //{
        //    return base.CompareTo(obj);
        //}
        #endregion


    }
}