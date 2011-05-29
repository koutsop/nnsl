enum SymbolConstants : int
{
   /// <c> (EOF) </c>
   SYMBOL_EOF                                             = 0,     
   /// <c> (Error) </c>
   SYMBOL_ERROR                                           = 1,     
   /// <c> (Whitespace) </c>
   SYMBOL_WHITESPACE                                      = 2,     
   /// <c> (Comment End) </c>
   SYMBOL_COMMENTEND                                      = 3,     
   /// <c> (Comment Line) </c>
   SYMBOL_COMMENTLINE                                     = 4,     
   /// <c> (Comment Start) </c>
   SYMBOL_COMMENTSTART                                    = 5,     
   /// <c> DecimalIntegerLiteral </c>
   SYMBOL_DECIMALINTEGERLITERAL                           = 6,     
   /// <c> HexadecimalIntegerLiteral </c>
   SYMBOL_HEXADECIMALINTEGERLITERAL                       = 7,     
   /// <c> Identifier </c>
   SYMBOL_IDENTIFIER                                      = 8,     
   /// <c> 'Keyword_and' </c>
   SYMBOL_KEYWORD_AND                                     = 9,     
   /// <c> 'Keyword_break' </c>
   SYMBOL_KEYWORD_BREAK                                   = 10,     
   /// <c> 'Keyword_continue' </c>
   SYMBOL_KEYWORD_CONTINUE                                = 11,     
   /// <c> 'Keyword_else' </c>
   SYMBOL_KEYWORD_ELSE                                    = 12,     
   /// <c> 'Keyword_false' </c>
   SYMBOL_KEYWORD_FALSE                                   = 13,     
   /// <c> 'Keyword_for' </c>
   SYMBOL_KEYWORD_FOR                                     = 14,     
   /// <c> 'Keyword_function' </c>
   SYMBOL_KEYWORD_FUNCTION                                = 15,     
   /// <c> 'Keyword_if' </c>
   SYMBOL_KEYWORD_IF                                      = 16,     
   /// <c> 'Keyword_local' </c>
   SYMBOL_KEYWORD_LOCAL                                   = 17,     
   /// <c> 'Keyword_nil' </c>
   SYMBOL_KEYWORD_NIL                                     = 18,     
   /// <c> 'Keyword_not' </c>
   SYMBOL_KEYWORD_NOT                                     = 19,     
   /// <c> 'Keyword_or' </c>
   SYMBOL_KEYWORD_OR                                      = 20,     
   /// <c> 'Keyword_return' </c>
   SYMBOL_KEYWORD_RETURN                                  = 21,     
   /// <c> 'Keyword_true' </c>
   SYMBOL_KEYWORD_TRUE                                    = 22,     
   /// <c> 'Keyword_while' </c>
   SYMBOL_KEYWORD_WHILE                                   = 23,     
   /// <c> OctalIntegerLiteral </c>
   SYMBOL_OCTALINTEGERLITERAL                             = 24,     
   /// <c> 'Punc_assign' </c>
   SYMBOL_PUNC_ASSIGN                                     = 25,     
   /// <c> 'Punc_colon' </c>
   SYMBOL_PUNC_COLON                                      = 26,     
   /// <c> 'Punc_coloncolon' </c>
   SYMBOL_PUNC_COLONCOLON                                 = 27,     
   /// <c> 'Punc_comma' </c>
   SYMBOL_PUNC_COMMA                                      = 28,     
   /// <c> 'Punc_dot' </c>
   SYMBOL_PUNC_DOT                                        = 29,     
   /// <c> 'Punc_dotdot' </c>
   SYMBOL_PUNC_DOTDOT                                     = 30,     
   /// <c> 'Punc_equal' </c>
   SYMBOL_PUNC_EQUAL                                      = 31,     
   /// <c> 'Punc_ge' </c>
   SYMBOL_PUNC_GE                                         = 32,     
   /// <c> 'Punc_gt' </c>
   SYMBOL_PUNC_GT                                         = 33,     
   /// <c> 'Punc_lbrace' </c>
   SYMBOL_PUNC_LBRACE                                     = 34,     
   /// <c> 'Punc_lbracket' </c>
   SYMBOL_PUNC_LBRACKET                                   = 35,     
   /// <c> 'Punc_le' </c>
   SYMBOL_PUNC_LE                                         = 36,     
   /// <c> 'Punc_lparenthesis' </c>
   SYMBOL_PUNC_LPARENTHESIS                               = 37,     
   /// <c> 'Punc_lt' </c>
   SYMBOL_PUNC_LT                                         = 38,     
   /// <c> 'Punc_minus' </c>
   SYMBOL_PUNC_MINUS                                      = 39,     
   /// <c> 'Punc_minusminus' </c>
   SYMBOL_PUNC_MINUSMINUS                                 = 40,     
   /// <c> 'Punc_not_equal' </c>
   SYMBOL_PUNC_NOT_EQUAL                                  = 41,     
   /// <c> 'Punc_percent' </c>
   SYMBOL_PUNC_PERCENT                                    = 42,     
   /// <c> 'Punc_plus' </c>
   SYMBOL_PUNC_PLUS                                       = 43,     
   /// <c> 'Punc_plusplus' </c>
   SYMBOL_PUNC_PLUSPLUS                                   = 44,     
   /// <c> 'Punc_rbrace' </c>
   SYMBOL_PUNC_RBRACE                                     = 45,     
   /// <c> 'Punc_rbracket' </c>
   SYMBOL_PUNC_RBRACKET                                   = 46,     
   /// <c> 'Punc_rparenthesis' </c>
   SYMBOL_PUNC_RPARENTHESIS                               = 47,     
   /// <c> 'Punc_semicolon' </c>
   SYMBOL_PUNC_SEMICOLON                                  = 48,     
   /// <c> 'Punc_slash' </c>
   SYMBOL_PUNC_SLASH                                      = 49,     
   /// <c> 'Punc_star' </c>
   SYMBOL_PUNC_STAR                                       = 50,     
   /// <c> StringLiteral </c>
   SYMBOL_STRINGLITERAL                                   = 51,     
   /// <c> &lt;ArithmExpressionPrec0&gt; </c>
   SYMBOL_ARITHMEXPRESSIONPREC0                           = 52,     
   /// <c> &lt;ArithmExpressionPrec1&gt; </c>
   SYMBOL_ARITHMEXPRESSIONPREC1                           = 53,     
   /// <c> &lt;ArithmExpressionPrec2&gt; </c>
   SYMBOL_ARITHMEXPRESSIONPREC2                           = 54,     
   /// <c> &lt;AssignmentExpressionPrec7&gt; </c>
   SYMBOL_ASSIGNMENTEXPRESSIONPREC7                       = 55,     
   /// <c> &lt;Block&gt; </c>
   SYMBOL_BLOCK                                           = 56,     
   /// <c> &lt;BooleanConstant&gt; </c>
   SYMBOL_BOOLEANCONSTANT                                 = 57,     
   /// <c> &lt;Call&gt; </c>
   SYMBOL_CALL                                            = 58,     
   /// <c> &lt;Constant&gt; </c>
   SYMBOL_CONSTANT                                        = 59,     
   /// <c> &lt;Expression&gt; </c>
   SYMBOL_EXPRESSION                                      = 60,     
   /// <c> &lt;ExpressionList&gt; </c>
   SYMBOL_EXPRESSIONLIST                                  = 61,     
   /// <c> &lt;ExpressionList2&gt; </c>
   SYMBOL_EXPRESSIONLIST2                                 = 62,     
   /// <c> &lt;ExpressionWithStatementsClosingWedge&gt; </c>
   SYMBOL_EXPRESSIONWITHSTATEMENTSCLOSINGWEDGE            = 63,     
   /// <c> &lt;ExpressionWithStatementsOpeningWedge&gt; </c>
   SYMBOL_EXPRESSIONWITHSTATEMENTSOPENINGWEDGE            = 64,     
   /// <c> &lt;ForStatement&gt; </c>
   SYMBOL_FORSTATEMENT                                    = 65,     
   /// <c> &lt;FunctionDefinition&gt; </c>
   SYMBOL_FUNCTIONDEFINITION                              = 66,     
   /// <c> &lt;FunctionExpression&gt; </c>
   SYMBOL_FUNCTIONEXPRESSION                              = 67,     
   /// <c> &lt;FunctionExpressionClosing&gt; </c>
   SYMBOL_FUNCTIONEXPRESSIONCLOSING                       = 68,     
   /// <c> &lt;FunctionExpressionOpening&gt; </c>
   SYMBOL_FUNCTIONEXPRESSIONOPENING                       = 69,     
   /// <c> &lt;FunctionStatementOpening&gt; </c>
   SYMBOL_FUNCTIONSTATEMENTOPENING                        = 70,     
   /// <c> &lt;IdentifierList&gt; </c>
   SYMBOL_IDENTIFIERLIST                                  = 71,     
   /// <c> &lt;IfElseStatement&gt; </c>
   SYMBOL_IFELSESTATEMENT                                 = 72,     
   /// <c> &lt;IndexedObjectElement&gt; </c>
   SYMBOL_INDEXEDOBJECTELEMENT                            = 73,     
   /// <c> &lt;IndexedObjectElementList&gt; </c>
   SYMBOL_INDEXEDOBJECTELEMENTLIST                        = 74,     
   /// <c> &lt;LeftAssociativityBinaryOperatorPrec1&gt; </c>
   SYMBOL_LEFTASSOCIATIVITYBINARYOPERATORPREC1            = 75,     
   /// <c> &lt;LeftAssociativityBinaryOperatorPrec2&gt; </c>
   SYMBOL_LEFTASSOCIATIVITYBINARYOPERATORPREC2            = 76,     
   /// <c> &lt;LeftAssociativityLogicalBinaryOperatorPrec5&gt; </c>
   SYMBOL_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC5     = 77,     
   /// <c> &lt;LeftAssociativityLogicalBinaryOperatorPrec6&gt; </c>
   SYMBOL_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC6     = 78,     
   /// <c> &lt;LogicalExpressionPrec5&gt; </c>
   SYMBOL_LOGICALEXPRESSIONPREC5                          = 79,     
   /// <c> &lt;LogicalExpressionPrec5Prefix&gt; </c>
   SYMBOL_LOGICALEXPRESSIONPREC5PREFIX                    = 80,     
   /// <c> &lt;LogicalExpressionPrec6&gt; </c>
   SYMBOL_LOGICALEXPRESSIONPREC6                          = 81,     
   /// <c> &lt;LogicalExpressionPrec6Prefix&gt; </c>
   SYMBOL_LOGICALEXPRESSIONPREC6PREFIX                    = 82,     
   /// <c> &lt;Lvalue&gt; </c>
   SYMBOL_LVALUE                                          = 83,     
   /// <c> &lt;Member&gt; </c>
   SYMBOL_MEMBER                                          = 84,     
   /// <c> &lt;NilConstant&gt; </c>
   SYMBOL_NILCONSTANT                                     = 85,     
   /// <c> &lt;NumberConstant&gt; </c>
   SYMBOL_NUMBERCONSTANT                                  = 86,     
   /// <c> &lt;ObjectDefinition&gt; </c>
   SYMBOL_OBJECTDEFINITION                                = 87,     
   /// <c> &lt;Primary&gt; </c>
   SYMBOL_PRIMARY                                         = 88,     
   /// <c> &lt;Program&gt; </c>
   SYMBOL_PROGRAM                                         = 89,     
   /// <c> &lt;RelationalBinaryOperatorPrec3&gt; </c>
   SYMBOL_RELATIONALBINARYOPERATORPREC3                   = 90,     
   /// <c> &lt;RelationalBinaryOperatorPrec4&gt; </c>
   SYMBOL_RELATIONALBINARYOPERATORPREC4                   = 91,     
   /// <c> &lt;RelationalExpressionPrec3&gt; </c>
   SYMBOL_RELATIONALEXPRESSIONPREC3                       = 92,     
   /// <c> &lt;RelationalExpressionPrec4&gt; </c>
   SYMBOL_RELATIONALEXPRESSIONPREC4                       = 93,     
   /// <c> &lt;ReturnStatement&gt; </c>
   SYMBOL_RETURNSTATEMENT                                 = 94,     
   /// <c> &lt;RightAssociativityAssignmentBinaryOperatorPrec7&gt; </c>
   SYMBOL_RIGHTASSOCIATIVITYASSIGNMENTBINARYOPERATORPREC7 = 95,     
   /// <c> &lt;Statement&gt; </c>
   SYMBOL_STATEMENT                                       = 96,     
   /// <c> &lt;StatementList&gt; </c>
   SYMBOL_STATEMENTLIST                                   = 97,     
   /// <c> &lt;StringConstant&gt; </c>
   SYMBOL_STRINGCONSTANT                                  = 98,     
   /// <c> &lt;Term&gt; </c>
   SYMBOL_TERM                                            = 99,     
   /// <c> &lt;UnaryModifier&gt; </c>
   SYMBOL_UNARYMODIFIER                                   = 100,     
   /// <c> &lt;UnaryOperator&gt; </c>
   SYMBOL_UNARYOPERATOR                                   = 101,     
   /// <c> &lt;WhileStatement&gt; </c>
   SYMBOL_WHILESTATEMENT                                  = 102      
};

enum RuleConstants : int
{
   /// <c> &lt;NumberConstant&gt; ::= OctalIntegerLiteral </c>
   RULE_NUMBERCONSTANT_OCTALINTEGERLITERAL                                                         = 0,    
   /// <c> &lt;NumberConstant&gt; ::= DecimalIntegerLiteral </c>
   RULE_NUMBERCONSTANT_DECIMALINTEGERLITERAL                                                       = 1,    
   /// <c> &lt;NumberConstant&gt; ::= HexadecimalIntegerLiteral </c>
   RULE_NUMBERCONSTANT_HEXADECIMALINTEGERLITERAL                                                   = 2,    
   /// <c> &lt;StringConstant&gt; ::= StringLiteral </c>
   RULE_STRINGCONSTANT_STRINGLITERAL                                                               = 3,    
   /// <c> &lt;BooleanConstant&gt; ::= 'Keyword_true' </c>
   RULE_BOOLEANCONSTANT_KEYWORD_TRUE                                                               = 4,    
   /// <c> &lt;BooleanConstant&gt; ::= 'Keyword_false' </c>
   RULE_BOOLEANCONSTANT_KEYWORD_FALSE                                                              = 5,    
   /// <c> &lt;NilConstant&gt; ::= 'Keyword_nil' </c>
   RULE_NILCONSTANT_KEYWORD_NIL                                                                    = 6,    
   /// <c> &lt;UnaryOperator&gt; ::= 'Punc_plus' </c>
   RULE_UNARYOPERATOR_PUNC_PLUS                                                                    = 7,    
   /// <c> &lt;UnaryOperator&gt; ::= 'Punc_minus' </c>
   RULE_UNARYOPERATOR_PUNC_MINUS                                                                   = 8,    
   /// <c> &lt;UnaryOperator&gt; ::= 'Keyword_not' </c>
   RULE_UNARYOPERATOR_KEYWORD_NOT                                                                  = 9,    
   /// <c> &lt;UnaryModifier&gt; ::= 'Punc_plusplus' </c>
   RULE_UNARYMODIFIER_PUNC_PLUSPLUS                                                                = 10,    
   /// <c> &lt;UnaryModifier&gt; ::= 'Punc_minusminus' </c>
   RULE_UNARYMODIFIER_PUNC_MINUSMINUS                                                              = 11,    
   /// <c> &lt;LeftAssociativityBinaryOperatorPrec1&gt; ::= 'Punc_star' </c>
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_PUNC_STAR                                             = 12,    
   /// <c> &lt;LeftAssociativityBinaryOperatorPrec1&gt; ::= 'Punc_slash' </c>
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_PUNC_SLASH                                            = 13,    
   /// <c> &lt;LeftAssociativityBinaryOperatorPrec1&gt; ::= 'Punc_percent' </c>
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_PUNC_PERCENT                                          = 14,    
   /// <c> &lt;LeftAssociativityBinaryOperatorPrec2&gt; ::= 'Punc_plus' </c>
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC2_PUNC_PLUS                                             = 15,    
   /// <c> &lt;LeftAssociativityBinaryOperatorPrec2&gt; ::= 'Punc_minus' </c>
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC2_PUNC_MINUS                                            = 16,    
   /// <c> &lt;RelationalBinaryOperatorPrec3&gt; ::= 'Punc_gt' </c>
   RULE_RELATIONALBINARYOPERATORPREC3_PUNC_GT                                                      = 17,    
   /// <c> &lt;RelationalBinaryOperatorPrec3&gt; ::= 'Punc_ge' </c>
   RULE_RELATIONALBINARYOPERATORPREC3_PUNC_GE                                                      = 18,    
   /// <c> &lt;RelationalBinaryOperatorPrec3&gt; ::= 'Punc_lt' </c>
   RULE_RELATIONALBINARYOPERATORPREC3_PUNC_LT                                                      = 19,    
   /// <c> &lt;RelationalBinaryOperatorPrec3&gt; ::= 'Punc_le' </c>
   RULE_RELATIONALBINARYOPERATORPREC3_PUNC_LE                                                      = 20,    
   /// <c> &lt;RelationalBinaryOperatorPrec4&gt; ::= 'Punc_equal' </c>
   RULE_RELATIONALBINARYOPERATORPREC4_PUNC_EQUAL                                                   = 21,    
   /// <c> &lt;RelationalBinaryOperatorPrec4&gt; ::= 'Punc_not_equal' </c>
   RULE_RELATIONALBINARYOPERATORPREC4_PUNC_NOT_EQUAL                                               = 22,    
   /// <c> &lt;LeftAssociativityLogicalBinaryOperatorPrec5&gt; ::= 'Keyword_and' </c>
   RULE_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC5_KEYWORD_AND                                    = 23,    
   /// <c> &lt;LeftAssociativityLogicalBinaryOperatorPrec6&gt; ::= 'Keyword_or' </c>
   RULE_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC6_KEYWORD_OR                                     = 24,    
   /// <c> &lt;RightAssociativityAssignmentBinaryOperatorPrec7&gt; ::= 'Punc_assign' </c>
   RULE_RIGHTASSOCIATIVITYASSIGNMENTBINARYOPERATORPREC7_PUNC_ASSIGN                                = 25,    
   /// <c> &lt;ExpressionWithStatementsOpeningWedge&gt; ::=  </c>
   RULE_EXPRESSIONWITHSTATEMENTSOPENINGWEDGE                                                       = 26,    
   /// <c> &lt;ExpressionWithStatementsClosingWedge&gt; ::=  </c>
   RULE_EXPRESSIONWITHSTATEMENTSCLOSINGWEDGE                                                       = 27,    
   /// <c> &lt;Constant&gt; ::= &lt;NumberConstant&gt; </c>
   RULE_CONSTANT                                                                                   = 28,    
   /// <c> &lt;Constant&gt; ::= &lt;StringConstant&gt; </c>
   RULE_CONSTANT2                                                                                  = 29,    
   /// <c> &lt;Constant&gt; ::= &lt;BooleanConstant&gt; </c>
   RULE_CONSTANT3                                                                                  = 30,    
   /// <c> &lt;Constant&gt; ::= &lt;NilConstant&gt; </c>
   RULE_CONSTANT4                                                                                  = 31,    
   /// <c> &lt;IdentifierList&gt; ::= Identifier </c>
   RULE_IDENTIFIERLIST_IDENTIFIER                                                                  = 32,    
   /// <c> &lt;IdentifierList&gt; ::= Identifier 'Punc_comma' &lt;IdentifierList&gt; </c>
   RULE_IDENTIFIERLIST_IDENTIFIER_PUNC_COMMA                                                       = 33,    
   /// <c> &lt;IdentifierList&gt; ::=  </c>
   RULE_IDENTIFIERLIST                                                                             = 34,    
   /// <c> &lt;FunctionStatementOpening&gt; ::= 'Keyword_function' 'Punc_lparenthesis' &lt;IdentifierList&gt; 'Punc_rparenthesis' </c>
   RULE_FUNCTIONSTATEMENTOPENING_KEYWORD_FUNCTION_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS              = 35,    
   /// <c> &lt;FunctionStatementOpening&gt; ::= 'Keyword_function' Identifier 'Punc_lparenthesis' &lt;IdentifierList&gt; 'Punc_rparenthesis' </c>
   RULE_FUNCTIONSTATEMENTOPENING_KEYWORD_FUNCTION_IDENTIFIER_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS   = 36,    
   /// <c> &lt;FunctionDefinition&gt; ::= &lt;FunctionStatementOpening&gt; &lt;Block&gt; </c>
   RULE_FUNCTIONDEFINITION                                                                         = 37,    
   /// <c> &lt;FunctionExpression&gt; ::= &lt;FunctionExpressionOpening&gt; &lt;FunctionDefinition&gt; &lt;FunctionExpressionClosing&gt; </c>
   RULE_FUNCTIONEXPRESSION                                                                         = 38,    
   /// <c> &lt;FunctionExpressionOpening&gt; ::= 'Punc_lparenthesis' &lt;ExpressionWithStatementsOpeningWedge&gt; </c>
   RULE_FUNCTIONEXPRESSIONOPENING_PUNC_LPARENTHESIS                                                = 39,    
   /// <c> &lt;FunctionExpressionClosing&gt; ::= &lt;ExpressionWithStatementsClosingWedge&gt; 'Punc_rparenthesis' </c>
   RULE_FUNCTIONEXPRESSIONCLOSING_PUNC_RPARENTHESIS                                                = 40,    
   /// <c> &lt;Lvalue&gt; ::= Identifier </c>
   RULE_LVALUE_IDENTIFIER                                                                          = 41,    
   /// <c> &lt;Lvalue&gt; ::= 'Punc_coloncolon' Identifier </c>
   RULE_LVALUE_PUNC_COLONCOLON_IDENTIFIER                                                          = 42,    
   /// <c> &lt;Lvalue&gt; ::= 'Keyword_local' Identifier </c>
   RULE_LVALUE_KEYWORD_LOCAL_IDENTIFIER                                                            = 43,    
   /// <c> &lt;Lvalue&gt; ::= &lt;Member&gt; </c>
   RULE_LVALUE                                                                                     = 44,    
   /// <c> &lt;Member&gt; ::= &lt;Lvalue&gt; 'Punc_dot' Identifier </c>
   RULE_MEMBER_PUNC_DOT_IDENTIFIER                                                                 = 45,    
   /// <c> &lt;Member&gt; ::= &lt;Lvalue&gt; 'Punc_lbracket' &lt;Expression&gt; 'Punc_rbracket' </c>
   RULE_MEMBER_PUNC_LBRACKET_PUNC_RBRACKET                                                         = 46,    
   /// <c> &lt;Member&gt; ::= &lt;Call&gt; 'Punc_dot' Identifier </c>
   RULE_MEMBER_PUNC_DOT_IDENTIFIER2                                                                = 47,    
   /// <c> &lt;Member&gt; ::= &lt;Call&gt; 'Punc_lbracket' &lt;Expression&gt; 'Punc_rbracket' </c>
   RULE_MEMBER_PUNC_LBRACKET_PUNC_RBRACKET2                                                        = 48,    
   /// <c> &lt;ExpressionList&gt; ::= &lt;Expression&gt; &lt;ExpressionList2&gt; </c>
   RULE_EXPRESSIONLIST                                                                             = 49,    
   /// <c> &lt;ExpressionList&gt; ::=  </c>
   RULE_EXPRESSIONLIST2                                                                            = 50,    
   /// <c> &lt;ExpressionList2&gt; ::= 'Punc_comma' &lt;Expression&gt; &lt;ExpressionList2&gt; </c>
   RULE_EXPRESSIONLIST2_PUNC_COMMA                                                                 = 51,    
   /// <c> &lt;ExpressionList2&gt; ::=  </c>
   RULE_EXPRESSIONLIST22                                                                           = 52,    
   /// <c> &lt;Call&gt; ::= &lt;Call&gt; 'Punc_lparenthesis' &lt;ExpressionList&gt; 'Punc_rparenthesis' </c>
   RULE_CALL_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                                                   = 53,    
   /// <c> &lt;Call&gt; ::= &lt;Lvalue&gt; 'Punc_lparenthesis' &lt;ExpressionList&gt; 'Punc_rparenthesis' </c>
   RULE_CALL_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS2                                                  = 54,    
   /// <c> &lt;Call&gt; ::= &lt;Lvalue&gt; 'Punc_dotdot' Identifier 'Punc_lparenthesis' &lt;ExpressionList&gt; 'Punc_rparenthesis' </c>
   RULE_CALL_PUNC_DOTDOT_IDENTIFIER_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                            = 55,    
   /// <c> &lt;Call&gt; ::= &lt;FunctionExpression&gt; 'Punc_lparenthesis' &lt;ExpressionList&gt; 'Punc_rparenthesis' </c>
   RULE_CALL_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS3                                                  = 56,    
   /// <c> &lt;IndexedObjectElement&gt; ::= 'Punc_lbrace' &lt;Expression&gt; 'Punc_colon' &lt;Expression&gt; 'Punc_rbrace' </c>
   RULE_INDEXEDOBJECTELEMENT_PUNC_LBRACE_PUNC_COLON_PUNC_RBRACE                                    = 57,    
   /// <c> &lt;IndexedObjectElementList&gt; ::= &lt;IndexedObjectElement&gt; 'Punc_comma' &lt;IndexedObjectElementList&gt; </c>
   RULE_INDEXEDOBJECTELEMENTLIST_PUNC_COMMA                                                        = 58,    
   /// <c> &lt;IndexedObjectElementList&gt; ::= &lt;IndexedObjectElement&gt; </c>
   RULE_INDEXEDOBJECTELEMENTLIST                                                                   = 59,    
   /// <c> &lt;ObjectDefinition&gt; ::= 'Punc_lbracket' &lt;ExpressionList&gt; 'Punc_rbracket' </c>
   RULE_OBJECTDEFINITION_PUNC_LBRACKET_PUNC_RBRACKET                                               = 60,    
   /// <c> &lt;ObjectDefinition&gt; ::= 'Punc_lbracket' &lt;IndexedObjectElementList&gt; 'Punc_rbracket' </c>
   RULE_OBJECTDEFINITION_PUNC_LBRACKET_PUNC_RBRACKET2                                              = 61,    
   /// <c> &lt;Primary&gt; ::= &lt;Constant&gt; </c>
   RULE_PRIMARY                                                                                    = 62,    
   /// <c> &lt;Primary&gt; ::= &lt;Lvalue&gt; </c>
   RULE_PRIMARY2                                                                                   = 63,    
   /// <c> &lt;Primary&gt; ::= &lt;FunctionExpression&gt; </c>
   RULE_PRIMARY3                                                                                   = 64,    
   /// <c> &lt;Primary&gt; ::= &lt;Call&gt; </c>
   RULE_PRIMARY4                                                                                   = 65,    
   /// <c> &lt;Primary&gt; ::= &lt;ObjectDefinition&gt; </c>
   RULE_PRIMARY5                                                                                   = 66,    
   /// <c> &lt;Term&gt; ::= &lt;Primary&gt; </c>
   RULE_TERM                                                                                       = 67,    
   /// <c> &lt;Term&gt; ::= 'Punc_lparenthesis' &lt;Expression&gt; 'Punc_rparenthesis' </c>
   RULE_TERM_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                                                   = 68,    
   /// <c> &lt;Term&gt; ::= &lt;UnaryModifier&gt; &lt;Lvalue&gt; </c>
   RULE_TERM2                                                                                      = 69,    
   /// <c> &lt;Term&gt; ::= &lt;Lvalue&gt; &lt;UnaryModifier&gt; </c>
   RULE_TERM3                                                                                      = 70,    
   /// <c> &lt;ArithmExpressionPrec0&gt; ::= &lt;Term&gt; </c>
   RULE_ARITHMEXPRESSIONPREC0                                                                      = 71,    
   /// <c> &lt;ArithmExpressionPrec0&gt; ::= &lt;UnaryOperator&gt; &lt;ArithmExpressionPrec0&gt; </c>
   RULE_ARITHMEXPRESSIONPREC02                                                                     = 72,    
   /// <c> &lt;ArithmExpressionPrec1&gt; ::= &lt;ArithmExpressionPrec0&gt; </c>
   RULE_ARITHMEXPRESSIONPREC1                                                                      = 73,    
   /// <c> &lt;ArithmExpressionPrec1&gt; ::= &lt;ArithmExpressionPrec1&gt; &lt;LeftAssociativityBinaryOperatorPrec1&gt; &lt;Term&gt; </c>
   RULE_ARITHMEXPRESSIONPREC12                                                                     = 74,    
   /// <c> &lt;ArithmExpressionPrec2&gt; ::= &lt;ArithmExpressionPrec1&gt; </c>
   RULE_ARITHMEXPRESSIONPREC2                                                                      = 75,    
   /// <c> &lt;ArithmExpressionPrec2&gt; ::= &lt;ArithmExpressionPrec2&gt; &lt;LeftAssociativityBinaryOperatorPrec2&gt; &lt;ArithmExpressionPrec1&gt; </c>
   RULE_ARITHMEXPRESSIONPREC22                                                                     = 76,    
   /// <c> &lt;RelationalExpressionPrec3&gt; ::= &lt;ArithmExpressionPrec2&gt; </c>
   RULE_RELATIONALEXPRESSIONPREC3                                                                  = 77,    
   /// <c> &lt;RelationalExpressionPrec3&gt; ::= &lt;ArithmExpressionPrec2&gt; &lt;RelationalBinaryOperatorPrec3&gt; &lt;ArithmExpressionPrec2&gt; </c>
   RULE_RELATIONALEXPRESSIONPREC32                                                                 = 78,    
   /// <c> &lt;RelationalExpressionPrec4&gt; ::= &lt;RelationalExpressionPrec3&gt; </c>
   RULE_RELATIONALEXPRESSIONPREC4                                                                  = 79,    
   /// <c> &lt;RelationalExpressionPrec4&gt; ::= &lt;RelationalExpressionPrec3&gt; &lt;RelationalBinaryOperatorPrec4&gt; &lt;RelationalExpressionPrec3&gt; </c>
   RULE_RELATIONALEXPRESSIONPREC42                                                                 = 80,    
   /// <c> &lt;LogicalExpressionPrec5&gt; ::= &lt;RelationalExpressionPrec4&gt; </c>
   RULE_LOGICALEXPRESSIONPREC5                                                                     = 81,    
   /// <c> &lt;LogicalExpressionPrec5&gt; ::= &lt;LogicalExpressionPrec5Prefix&gt; &lt;RelationalExpressionPrec4&gt; </c>
   RULE_LOGICALEXPRESSIONPREC52                                                                    = 82,    
   /// <c> &lt;LogicalExpressionPrec5Prefix&gt; ::= &lt;LogicalExpressionPrec5&gt; &lt;LeftAssociativityLogicalBinaryOperatorPrec5&gt; </c>
   RULE_LOGICALEXPRESSIONPREC5PREFIX                                                               = 83,    
   /// <c> &lt;LogicalExpressionPrec6&gt; ::= &lt;LogicalExpressionPrec5&gt; </c>
   RULE_LOGICALEXPRESSIONPREC6                                                                     = 84,    
   /// <c> &lt;LogicalExpressionPrec6&gt; ::= &lt;LogicalExpressionPrec6Prefix&gt; &lt;LogicalExpressionPrec5&gt; </c>
   RULE_LOGICALEXPRESSIONPREC62                                                                    = 85,    
   /// <c> &lt;LogicalExpressionPrec6Prefix&gt; ::= &lt;LogicalExpressionPrec6&gt; &lt;LeftAssociativityLogicalBinaryOperatorPrec6&gt; </c>
   RULE_LOGICALEXPRESSIONPREC6PREFIX                                                               = 86,    
   /// <c> &lt;AssignmentExpressionPrec7&gt; ::= &lt;LogicalExpressionPrec6&gt; </c>
   RULE_ASSIGNMENTEXPRESSIONPREC7                                                                  = 87,    
   /// <c> &lt;AssignmentExpressionPrec7&gt; ::= &lt;Lvalue&gt; &lt;RightAssociativityAssignmentBinaryOperatorPrec7&gt; &lt;AssignmentExpressionPrec7&gt; </c>
   RULE_ASSIGNMENTEXPRESSIONPREC72                                                                 = 88,    
   /// <c> &lt;Expression&gt; ::= &lt;AssignmentExpressionPrec7&gt; </c>
   RULE_EXPRESSION                                                                                 = 89,    
   /// <c> &lt;Block&gt; ::= 'Punc_lbrace' &lt;StatementList&gt; 'Punc_rbrace' </c>
   RULE_BLOCK_PUNC_LBRACE_PUNC_RBRACE                                                              = 90,    
   /// <c> &lt;ReturnStatement&gt; ::= 'Keyword_return' 'Punc_semicolon' </c>
   RULE_RETURNSTATEMENT_KEYWORD_RETURN_PUNC_SEMICOLON                                              = 91,    
   /// <c> &lt;ReturnStatement&gt; ::= 'Keyword_return' &lt;Expression&gt; 'Punc_semicolon' </c>
   RULE_RETURNSTATEMENT_KEYWORD_RETURN_PUNC_SEMICOLON2                                             = 92,    
   /// <c> &lt;WhileStatement&gt; ::= 'Keyword_while' 'Punc_lparenthesis' &lt;Expression&gt; 'Punc_rparenthesis' &lt;Statement&gt; </c>
   RULE_WHILESTATEMENT_KEYWORD_WHILE_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                           = 93,    
   /// <c> &lt;ForStatement&gt; ::= 'Keyword_for' 'Punc_lparenthesis' &lt;ExpressionList&gt; 'Punc_semicolon' &lt;Expression&gt; 'Punc_semicolon' &lt;ExpressionList&gt; 'Punc_rparenthesis' &lt;Statement&gt; </c>
   RULE_FORSTATEMENT_KEYWORD_FOR_PUNC_LPARENTHESIS_PUNC_SEMICOLON_PUNC_SEMICOLON_PUNC_RPARENTHESIS = 94,    
   /// <c> &lt;IfElseStatement&gt; ::= 'Keyword_if' 'Punc_lparenthesis' &lt;Expression&gt; 'Punc_rparenthesis' &lt;Statement&gt; </c>
   RULE_IFELSESTATEMENT_KEYWORD_IF_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                             = 95,    
   /// <c> &lt;IfElseStatement&gt; ::= 'Keyword_if' 'Punc_lparenthesis' &lt;Expression&gt; 'Punc_rparenthesis' &lt;Statement&gt; 'Keyword_else' &lt;Statement&gt; </c>
   RULE_IFELSESTATEMENT_KEYWORD_IF_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS_KEYWORD_ELSE                = 96,    
   /// <c> &lt;Statement&gt; ::= 'Punc_semicolon' </c>
   RULE_STATEMENT_PUNC_SEMICOLON                                                                   = 97,    
   /// <c> &lt;Statement&gt; ::= 'Keyword_break' 'Punc_semicolon' </c>
   RULE_STATEMENT_KEYWORD_BREAK_PUNC_SEMICOLON                                                     = 98,    
   /// <c> &lt;Statement&gt; ::= 'Keyword_continue' 'Punc_semicolon' </c>
   RULE_STATEMENT_KEYWORD_CONTINUE_PUNC_SEMICOLON                                                  = 99,    
   /// <c> &lt;Statement&gt; ::= &lt;Expression&gt; 'Punc_semicolon' </c>
   RULE_STATEMENT_PUNC_SEMICOLON2                                                                  = 100,    
   /// <c> &lt;Statement&gt; ::= &lt;Block&gt; </c>
   RULE_STATEMENT                                                                                  = 101,    
   /// <c> &lt;Statement&gt; ::= &lt;ReturnStatement&gt; </c>
   RULE_STATEMENT2                                                                                 = 102,    
   /// <c> &lt;Statement&gt; ::= &lt;WhileStatement&gt; </c>
   RULE_STATEMENT3                                                                                 = 103,    
   /// <c> &lt;Statement&gt; ::= &lt;ForStatement&gt; </c>
   RULE_STATEMENT4                                                                                 = 104,    
   /// <c> &lt;Statement&gt; ::= &lt;IfElseStatement&gt; </c>
   RULE_STATEMENT5                                                                                 = 105,    
   /// <c> &lt;Statement&gt; ::= &lt;FunctionDefinition&gt; </c>
   RULE_STATEMENT6                                                                                 = 106,    
   /// <c> &lt;StatementList&gt; ::= &lt;Statement&gt; &lt;StatementList&gt; </c>
   RULE_STATEMENTLIST                                                                              = 107,    
   /// <c> &lt;StatementList&gt; ::=  </c>
   RULE_STATEMENTLIST2                                                                             = 108,    
   /// <c> &lt;Program&gt; ::= &lt;StatementList&gt; </c>
   RULE_PROGRAM                                                                                    = 109     
};
