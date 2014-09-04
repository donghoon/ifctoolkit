/*
 * 
 *  < IFC - ISO 10303 (STEP) Part 21 instance file reader >
 *	Copyright (C) <2012>  <Donghoon Yang>
 *
 * 	This program is free software: you can redistribute it and/or modify
 *	it under the terms of the GNU General Public License as published by
 *	the Free Software Foundation, either version 3 of the License, or
 *	(at your option) any later version.
 *
 *	This program is distributed in the hope that it will be useful,
 *	but WITHOUT ANY WARRANTY; without even the implied warranty of
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *	GNU General Public License for more details.
 *
 *	You should have received a copy of the GNU General Public License
 *	along with this program.  If not, see <http://www.gnu.org/licenses/>. 
 * 
 */



using System;
using System.Text;
using System.IO;


namespace SchemaModel
{
    [Serializable]
    public class SLexer
    {
        static long p_CurrentRow = 1;
        public static long CurrentRow
        {
            get { return p_CurrentRow; }
            set { p_CurrentRow = value; }
        }
        public static int CurrentColumn { get; set; }

        public static void AddCurrentRow(int oneChar, StreamReader DataStream)
        {
            if (oneChar == 10 && DataStream.Peek() == 13) { DataStream.Read(); }
            else if (oneChar == 13 && DataStream.Peek() == 10) { DataStream.Read(); }
            CurrentRow += 1;
            CurrentColumn = 0;
        }

        public static SToken Tokenizer(StreamReader DataStream)
        {
            int oneChar;

            try
            {
                while ((oneChar = DataStream.Read()) != -1)
                {
                    CurrentColumn += 1;
                    if (oneChar == 32) // space
                    {
                        while (DataStream.Peek() == 32)
                        {
                            oneChar = DataStream.Read();
                            CurrentColumn += 1;
                        }
                    }
                    else if (oneChar == 10) // LF
                    {
                        AddCurrentRow(oneChar, DataStream);
                    }
                    else if (oneChar == 13) // CR
                    {
                        AddCurrentRow(oneChar, DataStream);
                    }
                    //else if (oneChar == 33) // !
                    //{
                    //    prevCharType = currCharType;
                    //    currCharType = CharType.EXCLAMATION;
                    //}
                    //else if (oneChar == 34) // "
                    //{
                    //    prevCharType = currCharType;
                    //    currCharType = CharType.QUOTE;
                    //}
                    //else if (oneChar == 35) // #
                    //{
                    //    return new SchemaToken(ProcessNumberSign(DataStream));
                    //}
                    //else if (oneChar == 36) // $
                    //{
                    //    return new SchemaToken(TokenType.DOLLAR);
                    //}
                    //else if (oneChar == 37) // %
                    //{
                    //    prevCharType = currCharType;
                    //    currCharType = CharType.PERCENT;
                    //}
                    //else if (oneChar == 39) // '
                    //{
                    //    return new Token(TokenType.STRING, ProcessString(DataStream));
                    //}
                    else if (oneChar == 40) // (
                    {
                        if (DataStream.Peek() == 42)
                        {
                            StringBuilder comment = new StringBuilder();

                            while (!(oneChar == 42 && DataStream.Peek() == 41))
                            {
                                comment.Append((char)oneChar);
                                oneChar = DataStream.Read();
                                CurrentColumn += 1;
                                if (oneChar == 10 || oneChar == 13)
                                {
                                    AddCurrentRow(oneChar, DataStream);
                                    // can make issue as it moves forward one tick
                                }
                            }
                            comment.Append((char)oneChar);
                            comment.Append((char)DataStream.Read());
                            CurrentColumn += 1;
                        }
                        else
                        {
                            return new SToken(STokenType.LEFTPARENTHESIS);
                        }
                    }
                    else if (oneChar == 41) // )
                    {
                        return new SToken(STokenType.RIGHTPARENTHESIS);
                    }
                    //else if (oneChar == 42) // *
                    //{
                    //    return new Token(TokenType.OMITTED);
                    //}
                    //else if (oneChar == 43) // +
                    //{
                    //    return new Token(ProcessSignedDigit(oneChar, DataStream));
                    //}
                    else if (oneChar == 44) // ,
                    {
                        return new SToken(STokenType.COMMA);
                    }
                    //else if (oneChar == 45) // -
                    //{
                    //    return new Token(ProcessSignedDigit(oneChar, DataStream));
                    //}
                    else if (oneChar == 46) // .
                    {
                        return new SToken(STokenType.COMMA);
                    }
                    //else if (oneChar == 47) // /
                    //{
                    //    if (DataStream.Peek() == 42)
                    //        ProcessComment(oneChar, DataStream);

                    //}
                    else if (oneChar >= 48 && oneChar <= 57) // 0-9
                    {
                        return new SToken(ProcessDigit(oneChar, DataStream));
                    }
                    else if (oneChar == 58) // :
                    {
                        return new SToken(STokenType.COLON);
                    }
                    else if (oneChar == 59) // ;
                    {
                        return new SToken(STokenType.SEMICOLON);
                    }
                    //else if (oneChar == 60) // <
                    //{
                    //}
                    //else if (oneChar == 61) // =
                    //{
                    //    return new Token(TokenType.EQUAL);
                    //}
                    //else if (oneChar == 62) // >
                    //{
                    //  return new Token(CharType.RIGHTANGLE);
                    //}
                    else if (oneChar == 63) // ?
                    {
                        return new SToken(STokenType.QUESTIONMARK);
                    }
                    //else if (oneChar == 64) // @
                    //{
                    //    return new Token(TokenType.AT);
                    //}

                    else if (oneChar >= 65 && oneChar <= 90)
                    {
                        return ProcessUpper(oneChar, DataStream);
                    }
                    else if (oneChar == 91) // [
                    {
                        return new SToken(STokenType.LEFTBRACKET);
                    }
                    else if (oneChar == 92) // \
                    {
                        return new SToken(STokenType.REVERSE_SOLIDUS);
                    }
                    else if (oneChar == 93) // ]
                    {
                        return new SToken(STokenType.RIGHTBRACKET);
                    }
                    //else if (oneChar == 94) // ^
                    //{
                    //    return new Token(CharType.CIRCUMFLEX);
                    //}
                    //else if (oneChar == 95) // _
                    //{
                    //    return new Token(CharType.UNDERSCORE);
                    //}
                    //else if (oneChar == 96) // `
                    //{
                    //    return new Token(CharType.GRAVE);
                    //}
                    //else if (oneChar >= 97 && oneChar <= 122) // a-z
                    //{
                    //    return new Token(CharType.LOWER);
                    //}
                    //else if (oneChar == 123) // {
                    //{
                    //    return new Token(CharType.LEFTCURLY);
                    //}
                    //else if (oneChar == 124) // |
                    //{
                    //    return new Token(CharType.OR);
                    //}
                    //else if (oneChar == 125) // }
                    //{
                    //    return new Token(CharType.RIGHTCURLY);
                    //}
                    //else if (oneChar == 126) // ~
                    //{
                    //    return new Token(CharType.TILD);
                    //}
                    //else if (oneChar == 10 || oneChar == 13 || oneChar == 0)
                    //{
                    //    // skipping control characters 10, 13
                    //}
                    else
                    {
                        //Console.WriteLine("new Character code : " + oneChar.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error in tokenizer :");
                Console.WriteLine(e.Message);
            }
            return new SToken(STokenType.EOF);
        }

        public static SToken ProcessUpper(int FirstCharactor, StreamReader DataStream)
        {
            StringBuilder theString = new StringBuilder();
            SToken aToken;
            theString.Append((char)FirstCharactor);

            int peekedChar;
            while (((peekedChar = DataStream.Peek()) >= 65 && peekedChar <= 90)
                || (peekedChar >= 48 && peekedChar <= 57) || peekedChar == 45 || peekedChar == 95
                || (peekedChar >= 97 && peekedChar <= 122))
            {
                theString.Append((char)DataStream.Read());
                CurrentColumn += 1;
            }
            //Console.WriteLine(theString);
            //AddKeywordToken(theString.ToString());


            switch (theString.ToString())
            {
                case @"SCHEMA":
                    aToken = new SToken(STokenType.SCHEMA);
                    break;
                case @"ENTITY":
                    aToken = new SToken(STokenType.ENTITY);
                    break;
                case @"END_ENTITY":
                    aToken = new SToken(STokenType.END_ENTITY);
                    break;
                case @"TYPE":
                    aToken = new SToken(STokenType.TYPE);
                    break;
                case @"END_TYPE":
                    aToken = new SToken(STokenType.END_TYPE);
                    break;
                case @"ABSTRACT":
                    aToken = new SToken(STokenType.ABSTRACT);
                    break;
                case @"SUPERTYPE":
                    aToken = new SToken(STokenType.SUPERTYPE);
                    break;
                case @"SUBTYPE":
                    aToken = new SToken(STokenType.SUBTYPE);
                    break;
                case @"OF":
                    aToken = new SToken(STokenType.OF);
                    break;
                case @"ONEOF":
                    aToken = new SToken(STokenType.ONEOF);
                    break;
                case @"OPTIONAL":
                    aToken = new SToken(STokenType.OPTIONAL);
                    break;
                case @"INTEGER":
                    aToken = new SToken(STokenType.INTEGER);
                    break;
                case @"REAL":
                    aToken = new SToken(STokenType.REAL);
                    break;
                case @"STRING":
                    aToken = new SToken(STokenType.STRING);
                    break;
                case @"BOOLEAN":
                    aToken = new SToken(STokenType.BOOLEAN);
                    break;
                case @"LOGICAL":
                    aToken = new SToken(STokenType.LOGICAL);
                    break;
                case @"NUMBER":
                    aToken = new SToken(STokenType.NUMBER);
                    break;
                case @"ENUMERATION":
                    aToken = new SToken(STokenType.ENUMERATION);
                    break;
                case @"SELECT":
                    aToken = new SToken(STokenType.SELECT);
                    break;
                case @"ARRAY":
                    aToken = new SToken(STokenType.ARRAY);
                    break;
                case @"LIST":
                    aToken = new SToken(STokenType.LIST);
                    break;
                case @"SET":
                    aToken = new SToken(STokenType.SET);
                    break;
                case @"BAG":
                    aToken = new SToken(STokenType.BAG);
                    break;
                case @"WHERE":
                    aToken = new SToken(STokenType.WHERE);
                    break;
                case @"DERIVE":
                    aToken = new SToken(STokenType.DERIVE);
                    break;
                case @"INVERSE":
                    aToken = new SToken(STokenType.INVERSE);
                    break;
                case @"FIXED":
                    aToken = new SToken(STokenType.FIXED);
                    break;
                case @"SELF":
                    aToken = new SToken(STokenType.SELF);
                    break;
                case @"UNIQUE":
                    aToken = new SToken(STokenType.UNIQUE);
                    break;
                case @"FUNCTION":
                    aToken = new SToken(STokenType.FUNCTION);
                    break;
                case @"END_FUNCTION":
                    aToken = new SToken(STokenType.END_FUNCTION);
                    break;
                case @"RULE":
                    aToken = new SToken(STokenType.RULE);
                    break;
                case @"END_RULE":
                    aToken = new SToken(STokenType.END_RULE);
                    break;
                case @"END_SCHEMA":
                    aToken = new SToken(STokenType.END_SCHEMA);
                    break;
                default:
                    aToken = new SToken(theString.ToString());
                    break;
            }
            return aToken;


        }

        public static int ProcessDigit(int FirstCharactor, StreamReader DataStream)
        {
            StringBuilder theNumber = new StringBuilder();
            theNumber.Append((char)FirstCharactor);
            int peekedChar;
            //43 + 45 - 46 .
            while ((peekedChar = DataStream.Peek()) >= 48 && peekedChar <= 57)
            {
                theNumber.Append((char)DataStream.Read());
            }

            int numVal = -1;

            // ToInt32 can throw FormatException or OverflowException.
            try
            {
                numVal = Convert.ToInt32(theNumber.ToString());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input string is not a sequence of digits. : {0}", e.ToString());
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number cannot fit in an Int32. : {0}", e.ToString());
            }
            finally
            {
                //if (numVal < Int16.MaxValue)
                //{
                //    Console.WriteLine("The new value is {0}", numVal + 1);
                //}
                //else
                //{
                //    Console.WriteLine("numVal cannot be incremented beyond its current value");
                //}
            }

            return numVal;

        }

        //public static String ProcessTitle(int FirstCharacter, StreamReader DataStream)
        //{
        //    StringBuilder theString = new StringBuilder();
        //    theString.Append((char)FirstCharacter);
        //    int peekedChar;

        //    while (((peekedChar = DataStream.Peek()) >= 65 && peekedChar <= 90)
        //        || (peekedChar >= 48 && peekedChar <= 57)
        //        || (peekedChar >= 97 && peekedChar <= 122))
        //    {
        //        theString.Append((char)DataStream.Read());
        //    }

        //    //Console.WriteLine(theString);
        //    return theString.ToString();
        //}
    }
}
