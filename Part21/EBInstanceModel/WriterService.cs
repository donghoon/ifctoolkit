using System;
using System.Collections.Generic;
using System.Text;

namespace EbInstanceModel
{
    public struct WriterService
    {
        /// <summary>
        /// returns string value that shows up in p21 file
        /// </summary>
        /// <param name="writeThis"></param>
        /// <returns></returns>
        public static string GetP21Rep(P21Base writeThis)
        {


            if (writeThis == null)
            {
                return EbConstants.Dollar;
            }

            var t = writeThis.GetType();

            if (typeof(P21Instance).IsAssignableFrom(t))
            {
                var sb = new StringBuilder();
                var p21Instance = (P21Instance)writeThis;
                sb.Clear();
                sb.Append(EbConstants.Sharp);
                sb.Append(p21Instance.EIN);
            }
            else if (typeof(P21Base).IsAssignableFrom(t))
            {
                return writeThis.GetP21String();
            }
            else
            {
                throw new NotImplementedException();
            }

            return "";
        }

        public static string GetP21Rep<T>(List<T> writeThis)
        {
            if (writeThis == null) return EbConstants.Dollar;
            var sb = new StringBuilder();
            sb.Append(EbConstants.LParentheses);
            if (writeThis.Count == 0) sb.Append(EbConstants.Dollar);
            else
            {
                int counter = 0;
                foreach (var write in writeThis)
                {
                    var p21Base = write as P21Base;
                    if (p21Base == null) continue;
                    if (counter > 0) sb.Append(EbConstants.Comma);
                    sb.Append(p21Base.GetP21String());
                    counter++;
                }
            }
            sb.Append(EbConstants.RParentheses);
            return "";
        }


        public static string GetP21Rep<T>(T value)
        {
            if (value == null)
            {
                return EbConstants.Dollar;
            }

            var t = value.GetType();

            if (typeof(P21Instance).IsAssignableFrom(t))
            {

                var p21Instance = value as P21Instance;

                return string.Format("{0}{1}", EbConstants.Sharp, p21Instance.EIN);
            }
            else if (typeof(P21Base).IsAssignableFrom(t))
            {
                var bs = value as P21Base;

                return bs.GetP21String();
            }
            else
            {
                return "";
                //throw new NotImplementedException();
            }

        }
    }
}