using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchemaModel
{
    public enum STokenType
    {
        UNDEFINED = 0,
        SIMPLEID,
        EOF,
        ABSTRACT,
        SEMICOLON, COLON, QUESTIONMARK,
        LEFTPARENTHESIS,
        RIGHTPARENTHESIS,
        LEFTBRACKET,
        RIGHTBRACKET,
        COMMA,
        AS, BINARY,
        CONSTANT, END_ALIAS, END_FUNCTION, END_REPEAT, END_TYPE, EXTENSIBLE, FUNCTION, INTEGER, LOGICAL, OPTIONAL, REAL,
        RETURN, SET, SUBTYPE_CONSTRAINT, TOTAL, OVER, USE, WITH,
        AGGREGATE, BAG, BOOLEAN, DERIVE,
        END_CASE, END_IF, END_RULE, ENTITY, FIXED, GENERIC, INVERSE, NUMBER, OTHERWISE, RENAMED, RULE,
        SKIP, SUPERTYPE, TYPE, VAR,
        ALIAS, BASED_ON, BY, ELSE, END_CONSTANT, END_LOCAL, END_SCHEMA, ENUMERATION, FOR, GENERIC_ENTITY, LIST, OF, PROCEDURE, REFERENCE,
        SCHEMA, STRING, THEN, UNIQUE, WHERE,
        ARRAY, BEGIN, CASE, END, END_ENTITY, END_PROCEDURE, END_SUBTYPE, CONSTRAINT, ESCAPE,
        FROM, IF, LOCAL, ONEOF, QUERY, REPEAT, SELECT, SUBTYPE, TO, UNTIL, WHILE, SELF,
        
        REVERSE_SOLIDUS,
    }
    public class SToken
    {
        public String StringValue { get; set; }
        public int IntegerValue { get; set; }
        public STokenType TokenType { get; set; }
        public SToken(STokenType TokenType)
        {
            this.TokenType = TokenType;
        }
        public SToken(String SimpleID)
        {
            TokenType = STokenType.SIMPLEID;
            StringValue = SimpleID;
        }
        public SToken(int ShortValue)
        {
            TokenType = STokenType.INTEGER;
            IntegerValue = ShortValue;
        }
    }
}
