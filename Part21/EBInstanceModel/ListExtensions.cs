using System;
using System.Collections.Generic;
using System.IO;

namespace EbInstanceModel
{
    /// <summary>
    /// Collection of extension function
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// extends generic List to have WriteToP21 function
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">List type</param>
        /// <param name="writer"></param>
        public static void WriteToP21<T>(this List<T> list, StreamWriter writer)
        {
            if (list == null)
            {
                writer.Write(EbConstants.Dollar);
                return;
            }

            writer.Write(EbConstants.LParentheses);

            if (list.Count != 0) // need to check if this is correct syntax
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != 0) writer.Write(EbConstants.Comma);
                    if (typeof(T).IsClass)
                    {
                        var pp = (object)list[i] as P21Instance;
                        if (pp != null) writer.Write(EbConstants.Sharp + pp.EIN.ToString());
                        else writer.Write(list[i].ToString());
                    }
                    else
                    {
                        Type tSelect = typeof(T);

                        var abc = tSelect.GetField("Value").GetValue(list[i]);

                        if (abc is P21Instance)
                        {
                            var pb = abc as P21Instance;
                            writer.Write(EbConstants.Sharp + pb.EIN.ToString());
                        }
                        else if (abc is BaseType)
                        {
                            var am = tSelect.GetMethod("WriteToP21");
                            am.Invoke(list[i], new object[] { writer });
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }


                        //                        else writer.Write(list[i].ToString());



                    }

                    //if(typeof(T) == typeof(P21Base))
                    //{
                    //    if (i != 0) writer.Write(EbConstants.Comma);
                    //    ((P21Base)(object)list[i]).WriteToP21(writer);
                    //}
                    //else if (typeof(T) == typeof(BaseType))
                    //{
                    //    if (i != 0) writer.Write(EbConstants.Comma);
                    //    ((BaseType)(object)list[i]).WriteToP21(writer);
                    //}
                    //else if (typeof(T) == typeof(STRING))
                    //{
                    //    if (i != 0) writer.Write(EbConstants.Comma);
                    //    ((STRING)(object)list[i]).WriteToP21(writer);
                    //}
                    //else
                    //{

                    //}

                }
            }

            writer.Write(EbConstants.RParentheses);

        }
    }
}