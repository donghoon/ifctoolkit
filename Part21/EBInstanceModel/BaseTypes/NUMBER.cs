using System;
using System.IO;

namespace EbInstanceModel
{
    public class NUMBER : REAL
    {
        //public object Value { get; set; }
//        protected const int Precision = 9;
//        public double Value { get; set; }

        public static implicit operator NUMBER(double value)
        {
            return new NUMBER { Value = Math.Round(value, Precision) };
        }

        public static implicit operator NUMBER(int value)
        {
            return new NUMBER { Value = value };
        }

        public static implicit operator double(NUMBER cpdValueDouble)
        {
            //if (cpdValueDouble.Value is double)
            return (double)cpdValueDouble.Value;

//            throw new Exception();
        }


        public static implicit operator int(NUMBER cpdValueDouble)
        {
            //if (cpdValueDouble.Value is int)
            return (int)cpdValueDouble.Value;

//            throw new Exception();
        }


        public override void WriteToP21(StreamWriter p21File)
        {
            p21File.Write(ToString());
        }

        public override string ToString()
        {
            if (Value % 1 != 0)
                return Value.ToString("E");

            return Value.ToString()+".";

        }
    }
}