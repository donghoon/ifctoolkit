using System;
using System.IO;

namespace EbInstanceModel
{
    public class LOGICAL : BaseType
    {
        // The three possible LOGICAL values:
        public static readonly LOGICAL dbUnknown = new LOGICAL(0);
        public static readonly LOGICAL dbFalse = new LOGICAL(-1);
        public static readonly LOGICAL dbTrue = new LOGICAL(1);
        // Private field that stores -1, 0, 1 for dbFalse, dbNull, dbTrue:
        public int Value;

        public LOGICAL()
            : this(0)
        {
        }

        // constructor. The value parameter must be -1, 0, or 1:
        public LOGICAL(int value)
        {
            if (value > 0)
                Value = 1;
            else if (value < 0)
                Value = -1;
            else
            { Value = 0; }
        }

        //// Implicit conversion from bool to LOGICAL. Maps true to 
        //// LOGICAL.dbTrue and false to LOGICAL.dbFalse:
        //public static implicit operator LOGICAL(bool x)
        //{
        //    return x ? dbTrue : dbFalse;
        //}

        //// Explicit conversion from LOGICAL to bool. Throws an 
        //// exception if the given LOGICAL is dbNull, otherwise returns
        //// true or false:
        //public static explicit operator bool(LOGICAL x)
        //{
        //    if (x.Value == 0) throw new InvalidOperationException();
        //    return x.Value > 0;
        //}

        //// Equality operator. Returns dbNull if either operand is dbNull, 
        //// otherwise returns dbTrue or dbFalse:
        //public static LOGICAL operator ==(LOGICAL x, LOGICAL y)
        //{
        //    if (x.Value == 0 || y.Value == 0) return dbUnknown;
        //    return x.Value == y.Value ? dbTrue : dbFalse;
        //}

        //// Inequality operator. Returns dbNull if either operand is
        //// dbNull, otherwise returns dbTrue or dbFalse:
        //public static LOGICAL operator !=(LOGICAL x, LOGICAL y)
        //{
        //    if (x.Value == 0 || y.Value == 0) return dbUnknown;
        //    return x.Value != y.Value ? dbTrue : dbFalse;
        //}

        //// Logical negation operator. Returns dbTrue if the operand is 
        //// dbFalse, dbNull if the operand is dbNull, or dbFalse if the
        //// operand is dbTrue:
        //public static LOGICAL operator !(LOGICAL x)
        //{
        //    return new LOGICAL(-x.Value);
        //}

        //// Logical AND operator. Returns dbFalse if either operand is 
        //// dbFalse, dbNull if either operand is dbNull, otherwise dbTrue:
        //public static LOGICAL operator &(LOGICAL x, LOGICAL y)
        //{
        //    return new LOGICAL(x.Value < y.Value ? x.Value : y.Value);
        //}

        //// Logical OR operator. Returns dbTrue if either operand is 
        //// dbTrue, dbNull if either operand is dbNull, otherwise dbFalse:
        //public static LOGICAL operator |(LOGICAL x, LOGICAL y)
        //{
        //    return new LOGICAL(x.Value > y.Value ? x.Value : y.Value);
        //}

        //// Definitely true operator. Returns true if the operand is 
        //// dbTrue, false otherwise:
        //public static bool operator true(LOGICAL x)
        //{
        //    return x.Value > 0;
        //}

        //// Definitely false operator. Returns true if the operand is 
        //// dbFalse, false otherwise:
        //public static bool operator false(LOGICAL x)
        //{
        //    return x.Value < 0;
        //}

        //// Overload the conversion from LOGICAL to string:
        //public static implicit operator string(LOGICAL x)
        //{
        //    return x.ToString();
        //}

        //// Override the Object.Equals(object o) method:
        //public override bool Equals(object o)
        //{
        //    try
        //    {
        //        return (bool)(this == (LOGICAL)o);
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //// Override the Object.GetHashCode() method:
        //public override int GetHashCode()
        //{
        //    return Value;
        //}

        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(ToString());
        }

        // Override the ToString method to convert LOGICAL to a string:
        public override string ToString()
        {
            switch (Value)
            {
                case -1:
                    return ".F.";
                case 0:
                    return ".U.";
                case 1:
                    return ".T.";
                default:
                    throw new InvalidOperationException();
            }
        }

    }
}