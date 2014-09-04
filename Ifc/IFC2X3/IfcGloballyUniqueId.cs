using System;
using IfcBase;

namespace IFC2X3
{
    public partial class IfcGloballyUniqueId 
    {
        //public string value { get; protected set; }

        public static IfcGloballyUniqueId NewGuid()
        {
            return IfcGloballyUniqueId.ConvertToIfcGuid(Guid.NewGuid());
        }

        public IfcGloballyUniqueId(string inVal)
        {
            Value = inVal;
        }

        public override bool Equals(object o)
        {
            return o is IfcGloballyUniqueId && Value == ((IfcGloballyUniqueId)o).Value;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        //public static bool operator ==(IfcGloballyUniqueId l, IfcGloballyUniqueId r)
        //{
        //    return (l == null && r == null) || (l != null && r != null && l.Value == r.Value);
        //}

        //public static bool operator !=(IfcGloballyUniqueId l, IfcGloballyUniqueId r)
        //{
        //    return (l != null || r != null) && (l == null || r == null || l.Value != r.Value);
        //}

//        public static implicit operator IfcGloballyUniqueId(string o)
//        {
//            return new IfcGloballyUniqueId(o);
//        }

        private static readonly char[] ConversionTable
            = new char[]
                {'0','1','2','3','4','5','6','7','8','9',
                    'A','B','C','D','E','F','G','H','I','J','K','L','M',
                    'N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                    'a','b','c','d','e','f','g','h','i','j','k','l','m',
                    'n','o','p','q','r','s','t','u','v','w','x','y','z',
                    '_','$'};


        public static IfcGloballyUniqueId ConvertToIfcGuid(Guid inGuid)
        {
            byte[] array = inGuid.ToByteArray();
            byte[] array2 = new byte[4];
            array2[0] = array[15];
            array2[1] = array[14];
            array2[2] = array[13];
            byte[] value = array2;
            byte[] array3 = new byte[4];
            array3[0] = array[12];
            array3[1] = array[11];
            array3[2] = array[10];
            byte[] value2 = array3;
            byte[] array4 = new byte[4];
            array4[0] = array[9];
            array4[1] = array[8];
            array4[2] = array[6];
            byte[] value3 = array4;
            byte[] array5 = new byte[4];
            array5[0] = array[7];
            array5[1] = array[4];
            array5[2] = array[5];
            byte[] value4 = array5;
            byte[] array6 = new byte[4];
            array6[0] = array[0];
            array6[1] = array[1];
            array6[2] = array[2];
            byte[] value5 = array6;
            byte[] array7 = new byte[4];
            array7[0] = array[3];
            byte[] value6 = array7;
            uint base10Bit = BitConverter.ToUInt32(value, 0);
            uint base10Bit2 = BitConverter.ToUInt32(value2, 0);
            uint base10Bit3 = BitConverter.ToUInt32(value3, 0);
            uint base10Bit4 = BitConverter.ToUInt32(value4, 0);
            uint base10Bit5 = BitConverter.ToUInt32(value5, 0);
            uint base10Bit6 = BitConverter.ToUInt32(value6, 0);
            string inVal = String.Concat(new string[]
                {
                    ToBase64(base10Bit6, 8),
                    ToBase64(base10Bit5, 24),
                    ToBase64(base10Bit4, 24),
                    ToBase64(base10Bit3, 24),
                    ToBase64(base10Bit2, 24),
                    ToBase64(base10Bit, 24)
                });
            return new IfcGloballyUniqueId(inVal);
        }


        public static IfcGloballyUniqueId ConvertToIfcGuid(string guid)
        {
            var a = Guid.Parse(guid);
            return ConvertToIfcGuid(a);
        }


        /// <summary>
        /// Reconstruction of the GUID 
        /// from an IFC GUID string (base64)
        /// </summary>
        /// <param name="guid">The GUID string to convert. Must be 22 characters long</param>
        /// <returns>GUID correspondig to the string</returns>
        public static Guid ConvertToGuid(string ifcGuid)
        {
            //Debug.Assert(ifcGuid.Length == 22, "Input string must not be longer that 22 chars");
            var num = new uint[6];
            char[] str = ifcGuid.ToCharArray();
            int n = 2, pos = 0, i;
            for (i = 0; i < 6; i++)
            {
                num[i] = cv_from_64(str, pos, n);
                pos += n;
                n = 4;
            }

            var b = new byte[16];

            b[3] = Convert.ToByte(num[0]%256);

            b[2] = Convert.ToByte(num[1]/65536);
            b[1] = Convert.ToByte((num[1]%65536)/256);
            b[0] = Convert.ToByte(num[1]%256);

            b[5] = Convert.ToByte(num[2]/65536);
            b[4] = Convert.ToByte((num[2]%65536)/256);
            b[7] = Convert.ToByte(num[2]%256);

            b[6] = Convert.ToByte(num[3]/65536);
            b[8] = Convert.ToByte((num[3]%65536)/256);
            b[9] = Convert.ToByte(num[3]%256);

            b[10] = Convert.ToByte(num[4]/65536);
            b[11] = Convert.ToByte((num[4]%65536)/256);
            b[12] = Convert.ToByte(num[4]%256);

            b[13] = Convert.ToByte(num[5]/65536);
            b[14] = Convert.ToByte((num[5]%65536)/256);
            b[15] = Convert.ToByte(num[5]%256);

            return new Guid(b);


            //int a = (int)((num[0] * 16777216 + num[1]));
            //short b = (short)(num[2] / 256);
            //short c = (short)((num[2] % 256) * 256 + num[3] / 65536);
            //byte[] d = new byte[8];
            //d[0] = Convert.ToByte((num[3] / 256) % 256);
            //d[1] = Convert.ToByte(num[3] % 256);
            //d[2] = Convert.ToByte(num[4] / 65536);
            //d[3] = Convert.ToByte((num[4] / 256) % 256);
            //d[4] = Convert.ToByte(num[4] % 256);
            //d[5] = Convert.ToByte(num[5] / 65536);
            //d[6] = Convert.ToByte((num[5] / 256) % 256);
            //d[7] = Convert.ToByte(num[5] % 256);

            //return new Guid(a, b, c, d);
        }


        public static string ConvertToGuidString(string ifcGuid)
        {
            return ConvertToGuid(ifcGuid).ToString();
        }

        private static string ToBase64(uint base10Bit24, int bitsLeft)
        {
            string text = String.Empty;
            if (bitsLeft > 0)
            {
                uint num = base10Bit24 & 63u;
                text += ConversionTable[(int)((UIntPtr)num)];
                text = ToBase64(base10Bit24 >> 6, bitsLeft - 6) + text;
            }
            return text;
        }

        /// <summary>
        /// The reverse function to calculate 
        /// the number from the characters
        /// </summary>
        /// <param name="str">The char array to convert from</param>
        /// <param name="start">Position in array to start read</param>
        /// <param name="len">The length to read</param>
        /// <returns>The calculated nuber</returns>
        private static uint cv_from_64(char[] str, int start, int len)
        {
            int i, j, index;
            uint res = 0;
            //Debug.Assert(len <= 4);

            for (i = 0; i < len; i++)
            {
                index = -1;
                for (j = 0; j < 64; j++)
                {
                    if (ConversionTable[j] == str[start + i])
                    {
                        index = j;
                        break;
                    }
                }
                //Debug.Assert(index >= 0);
                res = res*64 + ((uint) index);
            }
            return res;
        }

    }
}