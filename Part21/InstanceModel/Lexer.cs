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

namespace InstanceModel
{

    public class Lexer
    {

        public static Token Tokenizer(StreamReader DataStream)
        {
            int oneChar;

            try
            {
                while ((oneChar = DataStream.Read()) != -1)
                {
                    if (oneChar == 32) // space
                    {
                        while (DataStream.Peek() == 32)
                        {
                            oneChar = DataStream.Read();
                        }
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
                    else if (oneChar == 35) // #
                    {
                        return new Token(ProcessNumberSign(DataStream));
                    }
                    else if (oneChar == 36) // $
                    {
                        return new Token(TokenType.DOLLAR);
                    }
                    //else if (oneChar == 37) // %
                    //{
                    //    prevCharType = currCharType;
                    //    currCharType = CharType.PERCENT;
                    //}
                    else if (oneChar == 39) // '
                    {
                        return new Token(TokenType.STRING, ProcessString(DataStream));
                    }
                    else if (oneChar == 40) // (
                    {
                        return new Token(TokenType.LEFTPARENTHESIS);
                    }
                    else if (oneChar == 41) // )
                    {
                        return new Token(TokenType.RIGHTPARENTHESIS);
                    }
                    else if (oneChar == 42) // *
                    {
                        return new Token(TokenType.OMITTED);
                    }
                    else if (oneChar == 43) // +
                    {
                        return new Token(ProcessSignedDigit(oneChar, DataStream));
                    }
                    else if (oneChar == 44) // ,
                    {
                        return new Token(TokenType.COMMA);
                    }
                    else if (oneChar == 45) // -
                    {
                        return new Token(ProcessSignedDigit(oneChar, DataStream));
                    }
                    else if (oneChar == 46) // .
                    {
                        string cString = ProcessEnum(DataStream);

                        if (cString.CompareTo(@"T") == 0)
                        { return new Token(TokenType.TRUE); }
                        else if (cString.CompareTo(@"F") == 0)
                        { return new Token(TokenType.FALSE); }
                        else if (cString.CompareTo(@"U") == 0)
                        { return new Token(TokenType.UNKNOWN); }
                        else
                        { return new Token(TokenType.ENUMERATION, cString); }
                    }
                    else if (oneChar == 47) // /
                    {
                        if (DataStream.Peek() == 42)
                            ProcessComment(oneChar, DataStream);

                    }
                    else if (oneChar >= 48 && oneChar <= 57) // 0-9
                    {
                        return new Token(ProcessDigit(oneChar, DataStream));
                    }
                    //else if (oneChar == 58) // :
                    //{
                    //}
                    else if (oneChar == 59) // ;
                    {
                        return new Token(TokenType.SEMICOLON);
                    }
                    //else if (oneChar == 60) // <
                    //{
                    //}
                    else if (oneChar == 61) // =
                    {
                        return new Token(TokenType.EQUAL);
                    }
                    //else if (oneChar == 62) // >
                    //{
                    //  return new Token(CharType.RIGHTANGLE);
                    //}
                    //else if (oneChar == 63) // ?
                    //{
                    //    return new Token(TokenType.QUESTIONMARK);
                    //}
                    //else if (oneChar == 64) // @
                    //{
                    //    return new Token(TokenType.AT);
                    //}
                    else if (oneChar >= 65 && oneChar <= 90)
                    {

                        String upperToken = ProcessUpper(oneChar, DataStream);
                        TokenType toReturn = TokenType.NOT_DEFINED;
                        if (upperToken.CompareTo(@"ISO-10303-21") == 0)
                        {
                            toReturn = TokenType.ISO1030321;
                        }
                        else if (upperToken.CompareTo(@"END-ISO-10303-21") == 0)
                        {
                            toReturn = TokenType.ISO1030321END;
                        }
                        else if (upperToken.CompareTo(@"HEADER") == 0)
                        {
                            toReturn = TokenType.HEADER;
                        }
                        else if (upperToken.CompareTo(@"DATA") == 0)
                        {
                            toReturn = TokenType.DATA;
                        }
                        else if (upperToken.CompareTo(@"ENDSEC") == 0)
                        {
                            toReturn = TokenType.ENDSEC;
                        }
                        else
                        {
                            toReturn = TokenType.KEYWORD;
                        }
                        return new Token(toReturn, upperToken);
                    }
                    //else if (oneChar == 91) // [
                    //{
                    //    return new Token(CharType.LEFTBRACKET);
                    //}
                    //else if (oneChar == 92) // \
                    //{
                    //    return new Token(CharType.REVERSE_SOLIDUS);
                    //}
                    //else if (oneChar == 93) // ]
                    //{
                    //    return new Token(CharType.RIGHTBRACKET);
                    //}
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
                    //else if (oneChar >= 97 && oneChar <= 122) // '
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

                //DataStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Tokenizer :");
                Console.WriteLine(e.Message);
            }
            //finally
            //{
            //    DataStream.Close();
            //}
            return new Token(TokenType.EOF);
        }

        public static String ProcessString(StreamReader DataStream)
        {
            int oneChar;
            int prevChar = 39;
            StringBuilder theString = new StringBuilder();
            try
            {
                if (DataStream.Peek() == 39)
                {
                    oneChar = DataStream.Read();
                    if (DataStream.Peek() == 39)
                    {
                        oneChar = DataStream.Read();
                        theString.Append("''");
                    }
                }
                else
                {
                    while ((oneChar = DataStream.Read()) != -1)
                    {
                        if (prevChar != 39 && oneChar == 39 && DataStream.Peek() != 39)
                        {
                            break;
                        }
                        else
                        {
                            theString.Append((char)oneChar);
                        }
                        prevChar = oneChar;
                    }
                }
                //Console.WriteLine(theString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Comment :");
                Console.WriteLine(e.Message);
            }

            return theString.ToString();
        }

        public static String ProcessUpper(int FirstCharactor, StreamReader DataStream)
        {
            StringBuilder theString = new StringBuilder();
            theString.Append((char)FirstCharactor);

            int peekedChar;
            while (((peekedChar = DataStream.Peek()) >= 65 && peekedChar <= 90)
                || (peekedChar >= 48 && peekedChar <= 57) || peekedChar == 45 || peekedChar == 95)
            {
                theString.Append((char)DataStream.Read());
            }
            //Console.WriteLine(theString);
            //AddKeywordToken(theString.ToString());
            return theString.ToString();
        }

        public static String ProcessDigit(int FirstCharactor, StreamReader DataStream)
        {
            StringBuilder theNumber = new StringBuilder();
            theNumber.Append((char)FirstCharactor);
            int peekedChar;
            //43 + 45 - 46 .
            while (((peekedChar = DataStream.Peek()) >= 48 && peekedChar <= 57)
                || peekedChar == 46)
            {
                theNumber.Append((char)DataStream.Read());
            }

            if (peekedChar == 69) // E
            {
                theNumber.Append((char)DataStream.Read());
                if ((peekedChar = DataStream.Peek()) == 43 || peekedChar == 45)
                {
                    theNumber.Append((char)DataStream.Read());
                }
                while ((peekedChar = DataStream.Peek()) >= 48 && peekedChar <= 57)
                {
                    theNumber.Append((char)DataStream.Read());
                }
            }
            return theNumber.ToString();
            //Console.WriteLine(theNumber);
        }

        public static String ProcessSignedDigit(int DigitSign, StreamReader DataStream)
        {
            return ProcessDigit(DigitSign, DataStream);
        }

        public static String ProcessNumberSign(StreamReader DataStream)
        {
            StringBuilder theNumberSign = new StringBuilder(@"#");
            //StringBuilder theNumberSign = new StringBuilder();
            int peekedChar;
            while ((peekedChar = DataStream.Peek()) >= 48 && peekedChar <= 57)
            {
                theNumberSign.Append((char)DataStream.Read());
            }
            return theNumberSign.ToString();
        }

        public static void ProcessComment(int SolidusSign, StreamReader DataStream)
        {
            int currChar;
            int prevChar = SolidusSign;
            StringBuilder forConsole = new StringBuilder();
            // 47 / 42 *
            prevChar = SolidusSign;
            while (!((currChar = DataStream.Read()) == 47 && prevChar == 42))
            {
                forConsole.Append((char)currChar);
                prevChar = currChar;
            }
            //Console.WriteLine(forConsole);
        }

        public static String ProcessEnum(StreamReader DataStream)
        {
            int CurrChar = DataStream.Peek();
            if (CurrChar >= 48 && CurrChar <= 57)
            {
                Console.WriteLine("Syntax Error in Enum Value: Starts with Number");
                return @"";
            }

            StringBuilder EnumString = new StringBuilder();


            while ((CurrChar = DataStream.Read()) != 46) // 46 .
            {
                if ((CurrChar >= 65 && CurrChar <= 90)
                || (CurrChar >= 48 && CurrChar <= 57) || CurrChar == 95)
                {
                    EnumString.Append((char)CurrChar);
                }
                else
                {
                    Console.WriteLine("Syntax Error in Enum Value");
                }
            }


            return EnumString.ToString();
            //Console.WriteLine(EnumString);
        }

    }
}
