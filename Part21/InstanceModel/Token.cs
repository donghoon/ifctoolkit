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
using System.Text.RegularExpressions;


namespace InstanceModel
{
    //enum CharType
    //{
    //    NOT_DEFINED,

    //    SPECIAL,                // for special character
    //    CHARACTER,
    //    /*
    //     * 
    //     * SPECIAL =  "!" | """" | "*" | "$" | "%" | "&" | "." | "#"
    //     *          | "+" | "," | "-" | "(" | ")" | "?" | "/" | ":"
    //     *          | ";" | "<" | "=" | ">" | "@" | "[" | "]" | "{"
    //     *          | "|" | "}" | "^" | "`" | "~" .
    //     * 
    //     */
    //    SPACE,                  //          32 space
    //    EXCLAMATION,            // !        33
    //    QUOTE,                  // "        34
    //    NUMBERSIGN,				// #        35
    //    DOLLARSIGN,				// $		36
    //    PERCENT,                // %        37
    //    AMPERSAND,              // &        38
    //    APOSTROPHE,				// '        39
    //    LEFTPARENTHESIS,		// (        40
    //    RIGHTPARENTHESIS,		// )        41
    //    ASTERISK,				// *        42
    //    PLUS,                   // +        43
    //    COMMA,                  // ,        44
    //    HYPHEN,					// -        45
    //    PERIOD,			    	// .        46
    //    SOLIDUS,				// /        47
    //    DIGIT,					// 0-9      48-57
    //    COLON,                  // :        58
    //    SEMICOLON,				// ;        59
    //    LEFTANGLE,              // <        60
    //    EQUAL,					// =        61
    //    RIGHTANGLE,             // >        62
    //    QUESTIONMARK,           // ?        63
    //    AT,                     // @        64
    //    UPPER,					// A-Z      65-90
    //    LEFTBRACKET,            // [        91
    //    REVERSE_SOLIDUS,		// \        92
    //    RIGHTBRACKET,           // ]        93
    //    CIRCUMFLEX,             // ^        94
    //    UNDERSCORE,				// _        95
    //    GRAVE,                  // `        96
    //    LOWER,					// a-z      97-122
    //    LEFTCURLY,              // {        123
    //    OR,                     // |        124
    //    RIGHTCURLY,             // }        125
    //    TILD,                    // ~        126
    //    EOF                     // End of File
    //    /*
    //     * CHARACTER = SPACE | DIGIT | LOWER | UPPER | SPECIAL
    //     *                   | REVERSE_SOLIDUS | APOSTROPHE
    //     * 
    //    */
    //}

    public enum TokenType
    {
        NOT_DEFINED,
        ISO1030321,
        ISO1030321END,
        HEADER,
        ENDSEC,
        KEYWORD, // entity name and etc in instance
        LEFTPARENTHESIS,
        RIGHTPARENTHESIS,
        SEMICOLON,
        COMMA,
        EQUAL,
        DOLLAR,
        INTEGER,
        REAL,
        STRING,// string value in instance
        ENTITYINSTANCENAME,
        ENUMERATION,
        BINARY,
        LIST,
        OMITTED,
        DATA,
        EOF,
        TRUE,
        FALSE,
        UNKNOWN,
        
    }

    public class Token
    {
        //public CharType CharTypeValue;
        //public ParameterType ParameterTypeValue;
        public TokenType TokenTypeValue { get; set; }
        public String StringValue { get; set; }
        public int IntegerValue;
        public double RealValue;

        public Token()
        {
            TokenTypeValue = TokenType.NOT_DEFINED;
        }


        public Token(TokenType aType)
        {
            TokenTypeValue = aType;
        }

        public Token(TokenType aType, String aStringValue)
            :this(aType)
        {
            StringValue = aStringValue;
        }

        public Token(String parameterValue)
            : this()
        {

            if (Regex.IsMatch(parameterValue, "^#\\d+$"))
            {
                // matches entity instance name #10
                TokenTypeValue = TokenType.ENTITYINSTANCENAME;
                IntegerValue = int.Parse(parameterValue.Remove(0, 1));
            }
            else if (Regex.IsMatch(parameterValue, "^[+-]?\\d+$"))
            {
                // matches integer
                TokenTypeValue = TokenType.INTEGER;
                IntegerValue = int.Parse(parameterValue);
            }
            else if (Regex.IsMatch(parameterValue, "^[-+]?\\d+.\\d*((E[-+]?\\d+)?)$"))
            {
                // matches 0.1, 1.0, 2.
                TokenTypeValue = TokenType.REAL;
                RealValue = double.Parse(parameterValue);
            }
            else
            {
                Console.Write("Parameter value cannot be processed : " + parameterValue);
            }
        }
    }
}
