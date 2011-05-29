
using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF                                             =  0, // (EOF)
        SYMBOL_ERROR                                           =  1, // (Error)
        SYMBOL_WHITESPACE                                      =  2, // (Whitespace)
        SYMBOL_COMMENTEND                                      =  3, // (Comment End)
        SYMBOL_COMMENTLINE                                     =  4, // (Comment Line)
        SYMBOL_COMMENTSTART                                    =  5, // (Comment Start)
        SYMBOL_MINUS                                           =  6, // '-'
        SYMBOL_MINUSMINUS                                      =  7, // --
        SYMBOL_EXCLAMEQ                                        =  8, // '!='
        SYMBOL_PERCENT                                         =  9, // '%'
        SYMBOL_LPARAN                                          = 10, // '('
        SYMBOL_RPARAN                                          = 11, // ')'
        SYMBOL_TIMES                                           = 12, // '*'
        SYMBOL_COMMA                                           = 13, // ','
        SYMBOL_DOT                                             = 14, // '.'
        SYMBOL_DOTDOT                                          = 15, // '..'
        SYMBOL_DIV                                             = 16, // '/'
        SYMBOL_COLON                                           = 17, // ':'
        SYMBOL_COLONCOLON                                      = 18, // '::'
        SYMBOL_SEMI                                            = 19, // ';'
        SYMBOL_LBRACKET                                        = 20, // '['
        SYMBOL_RBRACKET                                        = 21, // ']'
        SYMBOL_LBRACE                                          = 22, // '{'
        SYMBOL_RBRACE                                          = 23, // '}'
        SYMBOL_PLUS                                            = 24, // '+'
        SYMBOL_PLUSPLUS                                        = 25, // '++'
        SYMBOL_LT                                              = 26, // '<'
        SYMBOL_LTEQ                                            = 27, // '<='
        SYMBOL_EQ                                              = 28, // '='
        SYMBOL_EQEQ                                            = 29, // '=='
        SYMBOL_GT                                              = 30, // '>'
        SYMBOL_GTEQ                                            = 31, // '>='
        SYMBOL_DECIMALINTEGERLITERAL                           = 32, // DecimalIntegerLiteral
        SYMBOL_HEXADECIMALINTEGERLITERAL                       = 33, // HexadecimalIntegerLiteral
        SYMBOL_IDENTIFIER                                      = 34, // Identifier
        SYMBOL_KEYWORD_AND                                     = 35, // 'Keyword_and'
        SYMBOL_KEYWORD_BREAK                                   = 36, // 'Keyword_break'
        SYMBOL_KEYWORD_CONTINUE                                = 37, // 'Keyword_continue'
        SYMBOL_KEYWORD_ELSE                                    = 38, // 'Keyword_else'
        SYMBOL_KEYWORD_FALSE                                   = 39, // 'Keyword_false'
        SYMBOL_KEYWORD_FOR                                     = 40, // 'Keyword_for'
        SYMBOL_KEYWORD_FUNCTION                                = 41, // 'Keyword_function'
        SYMBOL_KEYWORD_IF                                      = 42, // 'Keyword_if'
        SYMBOL_KEYWORD_LOCAL                                   = 43, // 'Keyword_local'
        SYMBOL_KEYWORD_NIL                                     = 44, // 'Keyword_nil'
        SYMBOL_KEYWORD_NOT                                     = 45, // 'Keyword_not'
        SYMBOL_KEYWORD_OR                                      = 46, // 'Keyword_or'
        SYMBOL_KEYWORD_RETURN                                  = 47, // 'Keyword_return'
        SYMBOL_KEYWORD_TRUE                                    = 48, // 'Keyword_true'
        SYMBOL_KEYWORD_WHILE                                   = 49, // 'Keyword_while'
        SYMBOL_OCTALINTEGERLITERAL                             = 50, // OctalIntegerLiteral
        SYMBOL_STRINGLITERAL                                   = 51, // StringLiteral
        SYMBOL_ARITHMEXPRESSIONPREC0                           = 52, // <ArithmExpressionPrec0>
        SYMBOL_ARITHMEXPRESSIONPREC1                           = 53, // <ArithmExpressionPrec1>
        SYMBOL_ARITHMEXPRESSIONPREC2                           = 54, // <ArithmExpressionPrec2>
        SYMBOL_ASSIGNMENTEXPRESSIONPREC7                       = 55, // <AssignmentExpressionPrec7>
        SYMBOL_BLOCK                                           = 56, // <Block>
        SYMBOL_BOOLEANCONSTANT                                 = 57, // <BooleanConstant>
        SYMBOL_CALL                                            = 58, // <Call>
        SYMBOL_CONSTANT                                        = 59, // <Constant>
        SYMBOL_EXPRESSION                                      = 60, // <Expression>
        SYMBOL_EXPRESSIONLIST                                  = 61, // <ExpressionList>
        SYMBOL_EXPRESSIONLIST2                                 = 62, // <ExpressionList2>
        SYMBOL_FORSTATEMENT                                    = 63, // <ForStatement>
        SYMBOL_FUNCTIONDEFINITION                              = 64, // <FunctionDefinition>
        SYMBOL_IDENTIFIERLIST                                  = 65, // <IdentifierList>
        SYMBOL_IFELSESTATEMENT                                 = 66, // <IfElseStatement>
        SYMBOL_INDEXEDOBJECTELEMENT                            = 67, // <IndexedObjectElement>
        SYMBOL_INDEXEDOBJECTELEMENTLIST                        = 68, // <IndexedObjectElementList>
        SYMBOL_LEFTASSOCIATIVITYBINARYOPERATORPREC1            = 69, // <LeftAssociativityBinaryOperatorPrec1>
        SYMBOL_LEFTASSOCIATIVITYBINARYOPERATORPREC2            = 70, // <LeftAssociativityBinaryOperatorPrec2>
        SYMBOL_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC5     = 71, // <LeftAssociativityLogicalBinaryOperatorPrec5>
        SYMBOL_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC6     = 72, // <LeftAssociativityLogicalBinaryOperatorPrec6>
        SYMBOL_LOGICALEXPRESSIONPREC5                          = 73, // <LogicalExpressionPrec5>
        SYMBOL_LOGICALEXPRESSIONPREC6                          = 74, // <LogicalExpressionPrec6>
        SYMBOL_LVALUE                                          = 75, // <Lvalue>
        SYMBOL_MEMBER                                          = 76, // <Member>
        SYMBOL_NILCONSTANT                                     = 77, // <NilConstant>
        SYMBOL_NUMBERCONSTANT                                  = 78, // <NumberConstant>
        SYMBOL_OBJECTDEFINITION                                = 79, // <ObjectDefinition>
        SYMBOL_PRIMARY                                         = 80, // <Primary>
        SYMBOL_PROGRAM                                         = 81, // <Program>
        SYMBOL_RELATIONALBINARYOPERATORPREC3                   = 82, // <RelationalBinaryOperatorPrec3>
        SYMBOL_RELATIONALBINARYOPERATORPREC4                   = 83, // <RelationalBinaryOperatorPrec4>
        SYMBOL_RELATIONALEXPRESSIONPREC3                       = 84, // <RelationalExpressionPrec3>
        SYMBOL_RELATIONALEXPRESSIONPREC4                       = 85, // <RelationalExpressionPrec4>
        SYMBOL_RETURNSTATEMENT                                 = 86, // <ReturnStatement>
        SYMBOL_RIGHTASSOCIATIVITYASSIGNMENTBINARYOPERATORPREC7 = 87, // <RightAssociativityAssignmentBinaryOperatorPrec7>
        SYMBOL_STATEMENT                                       = 88, // <Statement>
        SYMBOL_STATEMENTLIST                                   = 89, // <StatementList>
        SYMBOL_STRINGCONSTANT                                  = 90, // <StringConstant>
        SYMBOL_TERM                                            = 91, // <Term>
        SYMBOL_UNARYMODIFIER                                   = 92, // <UnaryModifier>
        SYMBOL_UNARYOPERATOR                                   = 93, // <UnaryOperator>
        SYMBOL_WHILESTATEMENT                                  = 94  // <WhileStatement>
    };

    enum RuleConstants : int
    {
        RULE_NUMBERCONSTANT_OCTALINTEGERLITERAL                           =  0, // <NumberConstant> ::= OctalIntegerLiteral
        RULE_NUMBERCONSTANT_DECIMALINTEGERLITERAL                         =  1, // <NumberConstant> ::= DecimalIntegerLiteral
        RULE_NUMBERCONSTANT_HEXADECIMALINTEGERLITERAL                     =  2, // <NumberConstant> ::= HexadecimalIntegerLiteral
        RULE_STRINGCONSTANT_STRINGLITERAL                                 =  3, // <StringConstant> ::= StringLiteral
        RULE_BOOLEANCONSTANT_KEYWORD_TRUE                                 =  4, // <BooleanConstant> ::= 'Keyword_true'
        RULE_BOOLEANCONSTANT_KEYWORD_FALSE                                =  5, // <BooleanConstant> ::= 'Keyword_false'
        RULE_NILCONSTANT_KEYWORD_NIL                                      =  6, // <NilConstant> ::= 'Keyword_nil'
        RULE_UNARYOPERATOR_PLUS                                           =  7, // <UnaryOperator> ::= '+'
        RULE_UNARYOPERATOR_MINUS                                          =  8, // <UnaryOperator> ::= '-'
        RULE_UNARYOPERATOR_KEYWORD_NOT                                    =  9, // <UnaryOperator> ::= 'Keyword_not'
        RULE_UNARYMODIFIER_PLUSPLUS                                       = 10, // <UnaryModifier> ::= '++'
        RULE_UNARYMODIFIER_MINUSMINUS                                     = 11, // <UnaryModifier> ::= --
        RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_TIMES                   = 12, // <LeftAssociativityBinaryOperatorPrec1> ::= '*'
        RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_DIV                     = 13, // <LeftAssociativityBinaryOperatorPrec1> ::= '/'
        RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_PERCENT                 = 14, // <LeftAssociativityBinaryOperatorPrec1> ::= '%'
        RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC2_PLUS                    = 15, // <LeftAssociativityBinaryOperatorPrec2> ::= '+'
        RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC2_MINUS                   = 16, // <LeftAssociativityBinaryOperatorPrec2> ::= '-'
        RULE_RELATIONALBINARYOPERATORPREC3_GT                             = 17, // <RelationalBinaryOperatorPrec3> ::= '>'
        RULE_RELATIONALBINARYOPERATORPREC3_GTEQ                           = 18, // <RelationalBinaryOperatorPrec3> ::= '>='
        RULE_RELATIONALBINARYOPERATORPREC3_LT                             = 19, // <RelationalBinaryOperatorPrec3> ::= '<'
        RULE_RELATIONALBINARYOPERATORPREC3_LTEQ                           = 20, // <RelationalBinaryOperatorPrec3> ::= '<='
        RULE_RELATIONALBINARYOPERATORPREC4_EQEQ                           = 21, // <RelationalBinaryOperatorPrec4> ::= '=='
        RULE_RELATIONALBINARYOPERATORPREC4_EXCLAMEQ                       = 22, // <RelationalBinaryOperatorPrec4> ::= '!='
        RULE_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC5_KEYWORD_AND      = 23, // <LeftAssociativityLogicalBinaryOperatorPrec5> ::= 'Keyword_and'
        RULE_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC6_KEYWORD_OR       = 24, // <LeftAssociativityLogicalBinaryOperatorPrec6> ::= 'Keyword_or'
        RULE_RIGHTASSOCIATIVITYASSIGNMENTBINARYOPERATORPREC7_EQ           = 25, // <RightAssociativityAssignmentBinaryOperatorPrec7> ::= '='
        RULE_CONSTANT                                                     = 26, // <Constant> ::= <NumberConstant>
        RULE_CONSTANT2                                                    = 27, // <Constant> ::= <StringConstant>
        RULE_CONSTANT3                                                    = 28, // <Constant> ::= <BooleanConstant>
        RULE_CONSTANT4                                                    = 29, // <Constant> ::= <NilConstant>
        RULE_IDENTIFIERLIST_IDENTIFIER                                    = 30, // <IdentifierList> ::= Identifier <IdentifierList>
        RULE_IDENTIFIERLIST                                               = 31, // <IdentifierList> ::= 
        RULE_FUNCTIONDEFINITION_KEYWORD_FUNCTION_LPARAN_RPARAN            = 32, // <FunctionDefinition> ::= 'Keyword_function' '(' <IdentifierList> ')' <Block>
        RULE_FUNCTIONDEFINITION_KEYWORD_FUNCTION_IDENTIFIER_LPARAN_RPARAN = 33, // <FunctionDefinition> ::= 'Keyword_function' Identifier '(' <IdentifierList> ')' <Block>
        RULE_LVALUE_IDENTIFIER                                            = 34, // <Lvalue> ::= Identifier
        RULE_LVALUE_COLONCOLON_IDENTIFIER                                 = 35, // <Lvalue> ::= '::' Identifier
        RULE_LVALUE_KEYWORD_LOCAL_IDENTIFIER                              = 36, // <Lvalue> ::= 'Keyword_local' Identifier
        RULE_LVALUE                                                       = 37, // <Lvalue> ::= <Member>
        RULE_MEMBER_DOT_IDENTIFIER                                        = 38, // <Member> ::= <Lvalue> '.' Identifier
        RULE_MEMBER_LBRACKET_RBRACKET                                     = 39, // <Member> ::= <Lvalue> '[' <Expression> ']'
        RULE_MEMBER_DOT_IDENTIFIER2                                       = 40, // <Member> ::= <Call> '.' Identifier
        RULE_MEMBER_LBRACKET_RBRACKET2                                    = 41, // <Member> ::= <Call> '[' <Expression> ']'
        RULE_EXPRESSIONLIST                                               = 42, // <ExpressionList> ::= <Expression> <ExpressionList2>
        RULE_EXPRESSIONLIST2                                              = 43, // <ExpressionList> ::= 
        RULE_EXPRESSIONLIST2_COMMA                                        = 44, // <ExpressionList2> ::= ',' <Expression>
        RULE_EXPRESSIONLIST22                                             = 45, // <ExpressionList2> ::= 
        RULE_CALL_LPARAN_RPARAN                                           = 46, // <Call> ::= <Call> '(' <ExpressionList> ')'
        RULE_CALL_LPARAN_RPARAN2                                          = 47, // <Call> ::= <Lvalue> '(' <ExpressionList> ')'
        RULE_CALL_DOTDOT_IDENTIFIER_LPARAN_RPARAN                         = 48, // <Call> ::= <Lvalue> '..' Identifier '(' <ExpressionList> ')'
        RULE_CALL_LPARAN_RPARAN_LPARAN_RPARAN                             = 49, // <Call> ::= '(' <FunctionDefinition> ')' '(' <ExpressionList> ')'
        RULE_INDEXEDOBJECTELEMENT_LBRACE_COLON_RBRACE                     = 50, // <IndexedObjectElement> ::= '{' <Expression> ':' <Expression> '}'
        RULE_INDEXEDOBJECTELEMENTLIST_COMMA                               = 51, // <IndexedObjectElementList> ::= <IndexedObjectElement> ',' <IndexedObjectElementList>
        RULE_INDEXEDOBJECTELEMENTLIST                                     = 52, // <IndexedObjectElementList> ::= <IndexedObjectElement>
        RULE_OBJECTDEFINITION_LBRACKET_RBRACKET                           = 53, // <ObjectDefinition> ::= '[' <ExpressionList> ']'
        RULE_OBJECTDEFINITION_LBRACKET_RBRACKET2                          = 54, // <ObjectDefinition> ::= '[' <IndexedObjectElementList> ']'
        RULE_PRIMARY                                                      = 55, // <Primary> ::= <Constant>
        RULE_PRIMARY2                                                     = 56, // <Primary> ::= <Lvalue>
        RULE_PRIMARY_LPARAN_RPARAN                                        = 57, // <Primary> ::= '(' <FunctionDefinition> ')'
        RULE_PRIMARY3                                                     = 58, // <Primary> ::= <Call>
        RULE_PRIMARY4                                                     = 59, // <Primary> ::= <ObjectDefinition>
        RULE_TERM                                                         = 60, // <Term> ::= <Primary>
        RULE_TERM_LPARAN_RPARAN                                           = 61, // <Term> ::= '(' <Expression> ')'
        RULE_TERM2                                                        = 62, // <Term> ::= <UnaryModifier> <Lvalue>
        RULE_TERM3                                                        = 63, // <Term> ::= <Lvalue> <UnaryModifier>
        RULE_ARITHMEXPRESSIONPREC0                                        = 64, // <ArithmExpressionPrec0> ::= <Term>
        RULE_ARITHMEXPRESSIONPREC02                                       = 65, // <ArithmExpressionPrec0> ::= <UnaryOperator> <ArithmExpressionPrec0>
        RULE_ARITHMEXPRESSIONPREC1                                        = 66, // <ArithmExpressionPrec1> ::= <ArithmExpressionPrec0>
        RULE_ARITHMEXPRESSIONPREC12                                       = 67, // <ArithmExpressionPrec1> ::= <ArithmExpressionPrec1> <LeftAssociativityBinaryOperatorPrec1> <Term>
        RULE_ARITHMEXPRESSIONPREC2                                        = 68, // <ArithmExpressionPrec2> ::= <ArithmExpressionPrec1>
        RULE_ARITHMEXPRESSIONPREC22                                       = 69, // <ArithmExpressionPrec2> ::= <ArithmExpressionPrec2> <LeftAssociativityBinaryOperatorPrec2> <ArithmExpressionPrec1>
        RULE_RELATIONALEXPRESSIONPREC3                                    = 70, // <RelationalExpressionPrec3> ::= <ArithmExpressionPrec2>
        RULE_RELATIONALEXPRESSIONPREC32                                   = 71, // <RelationalExpressionPrec3> ::= <ArithmExpressionPrec2> <RelationalBinaryOperatorPrec3> <ArithmExpressionPrec2>
        RULE_RELATIONALEXPRESSIONPREC4                                    = 72, // <RelationalExpressionPrec4> ::= <RelationalExpressionPrec3>
        RULE_RELATIONALEXPRESSIONPREC42                                   = 73, // <RelationalExpressionPrec4> ::= <RelationalExpressionPrec3> <RelationalBinaryOperatorPrec4> <RelationalExpressionPrec3>
        RULE_LOGICALEXPRESSIONPREC5                                       = 74, // <LogicalExpressionPrec5> ::= <RelationalExpressionPrec4>
        RULE_LOGICALEXPRESSIONPREC52                                      = 75, // <LogicalExpressionPrec5> ::= <LogicalExpressionPrec5> <LeftAssociativityLogicalBinaryOperatorPrec5> <RelationalExpressionPrec4>
        RULE_LOGICALEXPRESSIONPREC6                                       = 76, // <LogicalExpressionPrec6> ::= <LogicalExpressionPrec5>
        RULE_LOGICALEXPRESSIONPREC62                                      = 77, // <LogicalExpressionPrec6> ::= <LogicalExpressionPrec6> <LeftAssociativityLogicalBinaryOperatorPrec6> <LogicalExpressionPrec5>
        RULE_ASSIGNMENTEXPRESSIONPREC7                                    = 78, // <AssignmentExpressionPrec7> ::= <LogicalExpressionPrec6>
        RULE_ASSIGNMENTEXPRESSIONPREC72                                   = 79, // <AssignmentExpressionPrec7> ::= <Lvalue> <RightAssociativityAssignmentBinaryOperatorPrec7> <AssignmentExpressionPrec7>
        RULE_EXPRESSION                                                   = 80, // <Expression> ::= <AssignmentExpressionPrec7>
        RULE_BLOCK_LBRACE_RBRACE                                          = 81, // <Block> ::= '{' <StatementList> '}'
        RULE_RETURNSTATEMENT_KEYWORD_RETURN_SEMI                          = 82, // <ReturnStatement> ::= 'Keyword_return' ';'
        RULE_RETURNSTATEMENT_KEYWORD_RETURN_SEMI2                         = 83, // <ReturnStatement> ::= 'Keyword_return' <Expression> ';'
        RULE_WHILESTATEMENT_KEYWORD_WHILE_LPARAN_RPARAN                   = 84, // <WhileStatement> ::= 'Keyword_while' '(' <Expression> ')' <Statement>
        RULE_FORSTATEMENT_KEYWORD_FOR_LPARAN_SEMI_SEMI_RPARAN             = 85, // <ForStatement> ::= 'Keyword_for' '(' <ExpressionList> ';' <Expression> ';' <ExpressionList> ')' <Statement>
        RULE_IFELSESTATEMENT_KEYWORD_IF_LPARAN_RPARAN                     = 86, // <IfElseStatement> ::= 'Keyword_if' '(' <Expression> ')' <Statement>
        RULE_IFELSESTATEMENT_KEYWORD_IF_LPARAN_RPARAN_KEYWORD_ELSE        = 87, // <IfElseStatement> ::= 'Keyword_if' '(' <Expression> ')' <Statement> 'Keyword_else' <Statement>
        RULE_STATEMENT_SEMI                                               = 88, // <Statement> ::= ';'
        RULE_STATEMENT_KEYWORD_BREAK_SEMI                                 = 89, // <Statement> ::= 'Keyword_break' ';'
        RULE_STATEMENT_KEYWORD_CONTINUE_SEMI                              = 90, // <Statement> ::= 'Keyword_continue' ';'
        RULE_STATEMENT_SEMI2                                              = 91, // <Statement> ::= <Expression> ';'
        RULE_STATEMENT                                                    = 92, // <Statement> ::= <Block>
        RULE_STATEMENT2                                                   = 93, // <Statement> ::= <ReturnStatement>
        RULE_STATEMENT3                                                   = 94, // <Statement> ::= <WhileStatement>
        RULE_STATEMENT4                                                   = 95, // <Statement> ::= <ForStatement>
        RULE_STATEMENT5                                                   = 96, // <Statement> ::= <IfElseStatement>
        RULE_STATEMENTLIST                                                = 97, // <StatementList> ::= <Statement> <StatementList>
        RULE_STATEMENTLIST2                                               = 98, // <StatementList> ::= 
        RULE_PROGRAM                                                      = 99  // <Program> ::= <StatementList>
    };

    public class MyParser
    {
        private LALRParser parser;

        public MyParser(string filename)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnReduce += new LALRParser.ReduceHandler(ReduceEvent);
            parser.OnTokenRead += new LALRParser.TokenReadHandler(TokenReadEvent);
            parser.OnAccept += new LALRParser.AcceptHandler(AcceptEvent);
            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            parser.Parse(source);

        }

        private void TokenReadEvent(LALRParser parser, TokenReadEventArgs args)
        {
            try
            {
                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }

        private Object CreateObject(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //(Whitespace)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMENTEND :
                //(Comment End)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMENTLINE :
                //(Comment Line)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMENTSTART :
                //(Comment Start)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUS :
                //'-'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUSMINUS :
                //--
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ :
                //'!='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PERCENT :
                //'%'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPARAN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPARAN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMES :
                //'*'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMA :
                //','
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DOT :
                //'.'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DOTDOT :
                //'..'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIV :
                //'/'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COLON :
                //':'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COLONCOLON :
                //'::'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SEMI :
                //';'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACKET :
                //'['
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACKET :
                //']'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                //'{'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACE :
                //'}'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUS :
                //'+'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUSPLUS :
                //'++'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LT :
                //'<'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTEQ :
                //'<='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQ :
                //'='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQEQ :
                //'=='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GT :
                //'>'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTEQ :
                //'>='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DECIMALINTEGERLITERAL :
                //DecimalIntegerLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_HEXADECIMALINTEGERLITERAL :
                //HexadecimalIntegerLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFIER :
                //Identifier
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_AND :
                //'Keyword_and'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_BREAK :
                //'Keyword_break'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_CONTINUE :
                //'Keyword_continue'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_ELSE :
                //'Keyword_else'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_FALSE :
                //'Keyword_false'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_FOR :
                //'Keyword_for'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_FUNCTION :
                //'Keyword_function'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_IF :
                //'Keyword_if'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_LOCAL :
                //'Keyword_local'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_NIL :
                //'Keyword_nil'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_NOT :
                //'Keyword_not'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_OR :
                //'Keyword_or'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_RETURN :
                //'Keyword_return'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_TRUE :
                //'Keyword_true'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYWORD_WHILE :
                //'Keyword_while'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OCTALINTEGERLITERAL :
                //OctalIntegerLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STRINGLITERAL :
                //StringLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ARITHMEXPRESSIONPREC0 :
                //<ArithmExpressionPrec0>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ARITHMEXPRESSIONPREC1 :
                //<ArithmExpressionPrec1>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ARITHMEXPRESSIONPREC2 :
                //<ArithmExpressionPrec2>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ASSIGNMENTEXPRESSIONPREC7 :
                //<AssignmentExpressionPrec7>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BLOCK :
                //<Block>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BOOLEANCONSTANT :
                //<BooleanConstant>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CALL :
                //<Call>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONSTANT :
                //<Constant>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSION :
                //<Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSIONLIST :
                //<ExpressionList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSIONLIST2 :
                //<ExpressionList2>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FORSTATEMENT :
                //<ForStatement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FUNCTIONDEFINITION :
                //<FunctionDefinition>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFIERLIST :
                //<IdentifierList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IFELSESTATEMENT :
                //<IfElseStatement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INDEXEDOBJECTELEMENT :
                //<IndexedObjectElement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INDEXEDOBJECTELEMENTLIST :
                //<IndexedObjectElementList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LEFTASSOCIATIVITYBINARYOPERATORPREC1 :
                //<LeftAssociativityBinaryOperatorPrec1>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LEFTASSOCIATIVITYBINARYOPERATORPREC2 :
                //<LeftAssociativityBinaryOperatorPrec2>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC5 :
                //<LeftAssociativityLogicalBinaryOperatorPrec5>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC6 :
                //<LeftAssociativityLogicalBinaryOperatorPrec6>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LOGICALEXPRESSIONPREC5 :
                //<LogicalExpressionPrec5>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LOGICALEXPRESSIONPREC6 :
                //<LogicalExpressionPrec6>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LVALUE :
                //<Lvalue>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MEMBER :
                //<Member>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NILCONSTANT :
                //<NilConstant>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NUMBERCONSTANT :
                //<NumberConstant>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OBJECTDEFINITION :
                //<ObjectDefinition>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRIMARY :
                //<Primary>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PROGRAM :
                //<Program>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RELATIONALBINARYOPERATORPREC3 :
                //<RelationalBinaryOperatorPrec3>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RELATIONALBINARYOPERATORPREC4 :
                //<RelationalBinaryOperatorPrec4>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RELATIONALEXPRESSIONPREC3 :
                //<RelationalExpressionPrec3>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RELATIONALEXPRESSIONPREC4 :
                //<RelationalExpressionPrec4>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RETURNSTATEMENT :
                //<ReturnStatement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RIGHTASSOCIATIVITYASSIGNMENTBINARYOPERATORPREC7 :
                //<RightAssociativityAssignmentBinaryOperatorPrec7>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENT :
                //<Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENTLIST :
                //<StatementList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STRINGCONSTANT :
                //<StringConstant>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TERM :
                //<Term>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_UNARYMODIFIER :
                //<UnaryModifier>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_UNARYOPERATOR :
                //<UnaryOperator>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILESTATEMENT :
                //<WhileStatement>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        private void ReduceEvent(LALRParser parser, ReduceEventArgs args)
        {
            try
            {
                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }

        public static Object CreateObject(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_NUMBERCONSTANT_OCTALINTEGERLITERAL :
                //<NumberConstant> ::= OctalIntegerLiteral
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_NUMBERCONSTANT_DECIMALINTEGERLITERAL :
                //<NumberConstant> ::= DecimalIntegerLiteral
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_NUMBERCONSTANT_HEXADECIMALINTEGERLITERAL :
                //<NumberConstant> ::= HexadecimalIntegerLiteral
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STRINGCONSTANT_STRINGLITERAL :
                //<StringConstant> ::= StringLiteral
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BOOLEANCONSTANT_KEYWORD_TRUE :
                //<BooleanConstant> ::= 'Keyword_true'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BOOLEANCONSTANT_KEYWORD_FALSE :
                //<BooleanConstant> ::= 'Keyword_false'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_NILCONSTANT_KEYWORD_NIL :
                //<NilConstant> ::= 'Keyword_nil'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_UNARYOPERATOR_PLUS :
                //<UnaryOperator> ::= '+'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_UNARYOPERATOR_MINUS :
                //<UnaryOperator> ::= '-'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_UNARYOPERATOR_KEYWORD_NOT :
                //<UnaryOperator> ::= 'Keyword_not'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_UNARYMODIFIER_PLUSPLUS :
                //<UnaryModifier> ::= '++'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_UNARYMODIFIER_MINUSMINUS :
                //<UnaryModifier> ::= --
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_TIMES :
                //<LeftAssociativityBinaryOperatorPrec1> ::= '*'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_DIV :
                //<LeftAssociativityBinaryOperatorPrec1> ::= '/'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_PERCENT :
                //<LeftAssociativityBinaryOperatorPrec1> ::= '%'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC2_PLUS :
                //<LeftAssociativityBinaryOperatorPrec2> ::= '+'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC2_MINUS :
                //<LeftAssociativityBinaryOperatorPrec2> ::= '-'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALBINARYOPERATORPREC3_GT :
                //<RelationalBinaryOperatorPrec3> ::= '>'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALBINARYOPERATORPREC3_GTEQ :
                //<RelationalBinaryOperatorPrec3> ::= '>='
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALBINARYOPERATORPREC3_LT :
                //<RelationalBinaryOperatorPrec3> ::= '<'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALBINARYOPERATORPREC3_LTEQ :
                //<RelationalBinaryOperatorPrec3> ::= '<='
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALBINARYOPERATORPREC4_EQEQ :
                //<RelationalBinaryOperatorPrec4> ::= '=='
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALBINARYOPERATORPREC4_EXCLAMEQ :
                //<RelationalBinaryOperatorPrec4> ::= '!='
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC5_KEYWORD_AND :
                //<LeftAssociativityLogicalBinaryOperatorPrec5> ::= 'Keyword_and'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC6_KEYWORD_OR :
                //<LeftAssociativityLogicalBinaryOperatorPrec6> ::= 'Keyword_or'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RIGHTASSOCIATIVITYASSIGNMENTBINARYOPERATORPREC7_EQ :
                //<RightAssociativityAssignmentBinaryOperatorPrec7> ::= '='
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONSTANT :
                //<Constant> ::= <NumberConstant>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONSTANT2 :
                //<Constant> ::= <StringConstant>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONSTANT3 :
                //<Constant> ::= <BooleanConstant>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONSTANT4 :
                //<Constant> ::= <NilConstant>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_IDENTIFIERLIST_IDENTIFIER :
                //<IdentifierList> ::= Identifier <IdentifierList>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_IDENTIFIERLIST :
                //<IdentifierList> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_FUNCTIONDEFINITION_KEYWORD_FUNCTION_LPARAN_RPARAN :
                //<FunctionDefinition> ::= 'Keyword_function' '(' <IdentifierList> ')' <Block>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_FUNCTIONDEFINITION_KEYWORD_FUNCTION_IDENTIFIER_LPARAN_RPARAN :
                //<FunctionDefinition> ::= 'Keyword_function' Identifier '(' <IdentifierList> ')' <Block>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LVALUE_IDENTIFIER :
                //<Lvalue> ::= Identifier
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LVALUE_COLONCOLON_IDENTIFIER :
                //<Lvalue> ::= '::' Identifier
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LVALUE_KEYWORD_LOCAL_IDENTIFIER :
                //<Lvalue> ::= 'Keyword_local' Identifier
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LVALUE :
                //<Lvalue> ::= <Member>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MEMBER_DOT_IDENTIFIER :
                //<Member> ::= <Lvalue> '.' Identifier
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MEMBER_LBRACKET_RBRACKET :
                //<Member> ::= <Lvalue> '[' <Expression> ']'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MEMBER_DOT_IDENTIFIER2 :
                //<Member> ::= <Call> '.' Identifier
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MEMBER_LBRACKET_RBRACKET2 :
                //<Member> ::= <Call> '[' <Expression> ']'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONLIST :
                //<ExpressionList> ::= <Expression> <ExpressionList2>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONLIST2 :
                //<ExpressionList> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONLIST2_COMMA :
                //<ExpressionList2> ::= ',' <Expression>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONLIST22 :
                //<ExpressionList2> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CALL_LPARAN_RPARAN :
                //<Call> ::= <Call> '(' <ExpressionList> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CALL_LPARAN_RPARAN2 :
                //<Call> ::= <Lvalue> '(' <ExpressionList> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CALL_DOTDOT_IDENTIFIER_LPARAN_RPARAN :
                //<Call> ::= <Lvalue> '..' Identifier '(' <ExpressionList> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CALL_LPARAN_RPARAN_LPARAN_RPARAN :
                //<Call> ::= '(' <FunctionDefinition> ')' '(' <ExpressionList> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INDEXEDOBJECTELEMENT_LBRACE_COLON_RBRACE :
                //<IndexedObjectElement> ::= '{' <Expression> ':' <Expression> '}'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INDEXEDOBJECTELEMENTLIST_COMMA :
                //<IndexedObjectElementList> ::= <IndexedObjectElement> ',' <IndexedObjectElementList>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INDEXEDOBJECTELEMENTLIST :
                //<IndexedObjectElementList> ::= <IndexedObjectElement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OBJECTDEFINITION_LBRACKET_RBRACKET :
                //<ObjectDefinition> ::= '[' <ExpressionList> ']'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OBJECTDEFINITION_LBRACKET_RBRACKET2 :
                //<ObjectDefinition> ::= '[' <IndexedObjectElementList> ']'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PRIMARY :
                //<Primary> ::= <Constant>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PRIMARY2 :
                //<Primary> ::= <Lvalue>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PRIMARY_LPARAN_RPARAN :
                //<Primary> ::= '(' <FunctionDefinition> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PRIMARY3 :
                //<Primary> ::= <Call>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PRIMARY4 :
                //<Primary> ::= <ObjectDefinition>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_TERM :
                //<Term> ::= <Primary>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_TERM_LPARAN_RPARAN :
                //<Term> ::= '(' <Expression> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_TERM2 :
                //<Term> ::= <UnaryModifier> <Lvalue>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_TERM3 :
                //<Term> ::= <Lvalue> <UnaryModifier>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ARITHMEXPRESSIONPREC0 :
                //<ArithmExpressionPrec0> ::= <Term>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ARITHMEXPRESSIONPREC02 :
                //<ArithmExpressionPrec0> ::= <UnaryOperator> <ArithmExpressionPrec0>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ARITHMEXPRESSIONPREC1 :
                //<ArithmExpressionPrec1> ::= <ArithmExpressionPrec0>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ARITHMEXPRESSIONPREC12 :
                //<ArithmExpressionPrec1> ::= <ArithmExpressionPrec1> <LeftAssociativityBinaryOperatorPrec1> <Term>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ARITHMEXPRESSIONPREC2 :
                //<ArithmExpressionPrec2> ::= <ArithmExpressionPrec1>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ARITHMEXPRESSIONPREC22 :
                //<ArithmExpressionPrec2> ::= <ArithmExpressionPrec2> <LeftAssociativityBinaryOperatorPrec2> <ArithmExpressionPrec1>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALEXPRESSIONPREC3 :
                //<RelationalExpressionPrec3> ::= <ArithmExpressionPrec2>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALEXPRESSIONPREC32 :
                //<RelationalExpressionPrec3> ::= <ArithmExpressionPrec2> <RelationalBinaryOperatorPrec3> <ArithmExpressionPrec2>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALEXPRESSIONPREC4 :
                //<RelationalExpressionPrec4> ::= <RelationalExpressionPrec3>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RELATIONALEXPRESSIONPREC42 :
                //<RelationalExpressionPrec4> ::= <RelationalExpressionPrec3> <RelationalBinaryOperatorPrec4> <RelationalExpressionPrec3>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LOGICALEXPRESSIONPREC5 :
                //<LogicalExpressionPrec5> ::= <RelationalExpressionPrec4>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LOGICALEXPRESSIONPREC52 :
                //<LogicalExpressionPrec5> ::= <LogicalExpressionPrec5> <LeftAssociativityLogicalBinaryOperatorPrec5> <RelationalExpressionPrec4>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LOGICALEXPRESSIONPREC6 :
                //<LogicalExpressionPrec6> ::= <LogicalExpressionPrec5>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LOGICALEXPRESSIONPREC62 :
                //<LogicalExpressionPrec6> ::= <LogicalExpressionPrec6> <LeftAssociativityLogicalBinaryOperatorPrec6> <LogicalExpressionPrec5>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTEXPRESSIONPREC7 :
                //<AssignmentExpressionPrec7> ::= <LogicalExpressionPrec6>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTEXPRESSIONPREC72 :
                //<AssignmentExpressionPrec7> ::= <Lvalue> <RightAssociativityAssignmentBinaryOperatorPrec7> <AssignmentExpressionPrec7>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION :
                //<Expression> ::= <AssignmentExpressionPrec7>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BLOCK_LBRACE_RBRACE :
                //<Block> ::= '{' <StatementList> '}'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RETURNSTATEMENT_KEYWORD_RETURN_SEMI :
                //<ReturnStatement> ::= 'Keyword_return' ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RETURNSTATEMENT_KEYWORD_RETURN_SEMI2 :
                //<ReturnStatement> ::= 'Keyword_return' <Expression> ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_WHILESTATEMENT_KEYWORD_WHILE_LPARAN_RPARAN :
                //<WhileStatement> ::= 'Keyword_while' '(' <Expression> ')' <Statement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_FORSTATEMENT_KEYWORD_FOR_LPARAN_SEMI_SEMI_RPARAN :
                //<ForStatement> ::= 'Keyword_for' '(' <ExpressionList> ';' <Expression> ';' <ExpressionList> ')' <Statement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_IFELSESTATEMENT_KEYWORD_IF_LPARAN_RPARAN :
                //<IfElseStatement> ::= 'Keyword_if' '(' <Expression> ')' <Statement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_IFELSESTATEMENT_KEYWORD_IF_LPARAN_RPARAN_KEYWORD_ELSE :
                //<IfElseStatement> ::= 'Keyword_if' '(' <Expression> ')' <Statement> 'Keyword_else' <Statement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_SEMI :
                //<Statement> ::= ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_KEYWORD_BREAK_SEMI :
                //<Statement> ::= 'Keyword_break' ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_KEYWORD_CONTINUE_SEMI :
                //<Statement> ::= 'Keyword_continue' ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_SEMI2 :
                //<Statement> ::= <Expression> ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT :
                //<Statement> ::= <Block>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT2 :
                //<Statement> ::= <ReturnStatement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT3 :
                //<Statement> ::= <WhileStatement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT4 :
                //<Statement> ::= <ForStatement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT5 :
                //<Statement> ::= <IfElseStatement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENTLIST :
                //<StatementList> ::= <Statement> <StatementList>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENTLIST2 :
                //<StatementList> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PROGRAM :
                //<Program> ::= <StatementList>
                //todo: Create a new object using the stored user objects.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void AcceptEvent(LALRParser parser, AcceptEventArgs args)
        {
            //todo: Use your fully reduced args.Token.UserObject
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '"+args.UnexpectedToken.ToString()+"'";
            //todo: Report message to UI?
        }


    }
}
