enum SymbolConstants : int
{
   SYMBOL_EOF                                             =   0, // (EOF)
   SYMBOL_ERROR                                           =   1, // (Error)
   SYMBOL_WHITESPACE                                      =   2, // (Whitespace)
   SYMBOL_COMMENTEND                                      =   3, // (Comment End)
   SYMBOL_COMMENTLINE                                     =   4, // (Comment Line)
   SYMBOL_COMMENTSTART                                    =   5, // (Comment Start)
   SYMBOL_DECIMALINTEGERLITERAL                           =   6, // DecimalIntegerLiteral
   SYMBOL_HEXADECIMALINTEGERLITERAL                       =   7, // HexadecimalIntegerLiteral
   SYMBOL_IDENTIFIER                                      =   8, // Identifier
   SYMBOL_KEYWORD_AND                                     =   9, // 'Keyword_and'
   SYMBOL_KEYWORD_BREAK                                   =  10, // 'Keyword_break'
   SYMBOL_KEYWORD_CONTINUE                                =  11, // 'Keyword_continue'
   SYMBOL_KEYWORD_ELSE                                    =  12, // 'Keyword_else'
   SYMBOL_KEYWORD_FALSE                                   =  13, // 'Keyword_false'
   SYMBOL_KEYWORD_FOR                                     =  14, // 'Keyword_for'
   SYMBOL_KEYWORD_FUNCTION                                =  15, // 'Keyword_function'
   SYMBOL_KEYWORD_IF                                      =  16, // 'Keyword_if'
   SYMBOL_KEYWORD_LOCAL                                   =  17, // 'Keyword_local'
   SYMBOL_KEYWORD_NIL                                     =  18, // 'Keyword_nil'
   SYMBOL_KEYWORD_NOT                                     =  19, // 'Keyword_not'
   SYMBOL_KEYWORD_OR                                      =  20, // 'Keyword_or'
   SYMBOL_KEYWORD_RETURN                                  =  21, // 'Keyword_return'
   SYMBOL_KEYWORD_TRUE                                    =  22, // 'Keyword_true'
   SYMBOL_KEYWORD_WHILE                                   =  23, // 'Keyword_while'
   SYMBOL_OCTALINTEGERLITERAL                             =  24, // OctalIntegerLiteral
   SYMBOL_PUNC_ASSIGN                                     =  25, // 'Punc_assign'
   SYMBOL_PUNC_COLON                                      =  26, // 'Punc_colon'
   SYMBOL_PUNC_COLONCOLON                                 =  27, // 'Punc_coloncolon'
   SYMBOL_PUNC_COMMA                                      =  28, // 'Punc_comma'
   SYMBOL_PUNC_DOT                                        =  29, // 'Punc_dot'
   SYMBOL_PUNC_DOTDOT                                     =  30, // 'Punc_dotdot'
   SYMBOL_PUNC_EQUAL                                      =  31, // 'Punc_equal'
   SYMBOL_PUNC_GE                                         =  32, // 'Punc_ge'
   SYMBOL_PUNC_GT                                         =  33, // 'Punc_gt'
   SYMBOL_PUNC_LBRACE                                     =  34, // 'Punc_lbrace'
   SYMBOL_PUNC_LBRACKET                                   =  35, // 'Punc_lbracket'
   SYMBOL_PUNC_LE                                         =  36, // 'Punc_le'
   SYMBOL_PUNC_LPARENTHESIS                               =  37, // 'Punc_lparenthesis'
   SYMBOL_PUNC_LT                                         =  38, // 'Punc_lt'
   SYMBOL_PUNC_MINUS                                      =  39, // 'Punc_minus'
   SYMBOL_PUNC_MINUSMINUS                                 =  40, // 'Punc_minusminus'
   SYMBOL_PUNC_NOT_EQUAL                                  =  41, // 'Punc_not_equal'
   SYMBOL_PUNC_PERCENT                                    =  42, // 'Punc_percent'
   SYMBOL_PUNC_PLUS                                       =  43, // 'Punc_plus'
   SYMBOL_PUNC_PLUSPLUS                                   =  44, // 'Punc_plusplus'
   SYMBOL_PUNC_RBRACE                                     =  45, // 'Punc_rbrace'
   SYMBOL_PUNC_RBRACKET                                   =  46, // 'Punc_rbracket'
   SYMBOL_PUNC_RPARENTHESIS                               =  47, // 'Punc_rparenthesis'
   SYMBOL_PUNC_SEMICOLON                                  =  48, // 'Punc_semicolon'
   SYMBOL_PUNC_SLASH                                      =  49, // 'Punc_slash'
   SYMBOL_PUNC_STAR                                       =  50, // 'Punc_star'
   SYMBOL_STRINGLITERAL                                   =  51, // StringLiteral
   SYMBOL_ARITHMEXPRESSIONPREC0                           =  52, // <ArithmExpressionPrec0>
   SYMBOL_ARITHMEXPRESSIONPREC1                           =  53, // <ArithmExpressionPrec1>
   SYMBOL_ARITHMEXPRESSIONPREC2                           =  54, // <ArithmExpressionPrec2>
   SYMBOL_ASSIGNMENTEXPRESSIONPREC7                       =  55, // <AssignmentExpressionPrec7>
   SYMBOL_BLOCK                                           =  56, // <Block>
   SYMBOL_BOOLEANCONSTANT                                 =  57, // <BooleanConstant>
   SYMBOL_CALL                                            =  58, // <Call>
   SYMBOL_CONSTANT                                        =  59, // <Constant>
   SYMBOL_EXPRESSION                                      =  60, // <Expression>
   SYMBOL_EXPRESSIONLIST                                  =  61, // <ExpressionList>
   SYMBOL_EXPRESSIONLIST2                                 =  62, // <ExpressionList2>
   SYMBOL_EXPRESSIONWITHSTATEMENTSCLOSINGWEDGE            =  63, // <ExpressionWithStatementsClosingWedge>
   SYMBOL_EXPRESSIONWITHSTATEMENTSOPENINGWEDGE            =  64, // <ExpressionWithStatementsOpeningWedge>
   SYMBOL_FORSTATEMENT                                    =  65, // <ForStatement>
   SYMBOL_FUNCTIONDEFINITION                              =  66, // <FunctionDefinition>
   SYMBOL_FUNCTIONEXPRESSION                              =  67, // <FunctionExpression>
   SYMBOL_FUNCTIONEXPRESSIONCLOSING                       =  68, // <FunctionExpressionClosing>
   SYMBOL_FUNCTIONEXPRESSIONOPENING                       =  69, // <FunctionExpressionOpening>
   SYMBOL_FUNCTIONSTATEMENTOPENING                        =  70, // <FunctionStatementOpening>
   SYMBOL_IDENTIFIERLIST                                  =  71, // <IdentifierList>
   SYMBOL_IFELSESTATEMENT                                 =  72, // <IfElseStatement>
   SYMBOL_INDEXEDOBJECTELEMENT                            =  73, // <IndexedObjectElement>
   SYMBOL_INDEXEDOBJECTELEMENTLIST                        =  74, // <IndexedObjectElementList>
   SYMBOL_LEFTASSOCIATIVITYBINARYOPERATORPREC1            =  75, // <LeftAssociativityBinaryOperatorPrec1>
   SYMBOL_LEFTASSOCIATIVITYBINARYOPERATORPREC2            =  76, // <LeftAssociativityBinaryOperatorPrec2>
   SYMBOL_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC5     =  77, // <LeftAssociativityLogicalBinaryOperatorPrec5>
   SYMBOL_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC6     =  78, // <LeftAssociativityLogicalBinaryOperatorPrec6>
   SYMBOL_LOGICALEXPRESSIONPREC5                          =  79, // <LogicalExpressionPrec5>
   SYMBOL_LOGICALEXPRESSIONPREC5PREFIX                    =  80, // <LogicalExpressionPrec5Prefix>
   SYMBOL_LOGICALEXPRESSIONPREC6                          =  81, // <LogicalExpressionPrec6>
   SYMBOL_LOGICALEXPRESSIONPREC6PREFIX                    =  82, // <LogicalExpressionPrec6Prefix>
   SYMBOL_LVALUE                                          =  83, // <Lvalue>
   SYMBOL_MEMBER                                          =  84, // <Member>
   SYMBOL_NILCONSTANT                                     =  85, // <NilConstant>
   SYMBOL_NUMBERCONSTANT                                  =  86, // <NumberConstant>
   SYMBOL_OBJECTDEFINITION                                =  87, // <ObjectDefinition>
   SYMBOL_PRIMARY                                         =  88, // <Primary>
   SYMBOL_PROGRAM                                         =  89, // <Program>
   SYMBOL_RELATIONALBINARYOPERATORPREC3                   =  90, // <RelationalBinaryOperatorPrec3>
   SYMBOL_RELATIONALBINARYOPERATORPREC4                   =  91, // <RelationalBinaryOperatorPrec4>
   SYMBOL_RELATIONALEXPRESSIONPREC3                       =  92, // <RelationalExpressionPrec3>
   SYMBOL_RELATIONALEXPRESSIONPREC4                       =  93, // <RelationalExpressionPrec4>
   SYMBOL_RETURNSTATEMENT                                 =  94, // <ReturnStatement>
   SYMBOL_RIGHTASSOCIATIVITYASSIGNMENTBINARYOPERATORPREC7 =  95, // <RightAssociativityAssignmentBinaryOperatorPrec7>
   SYMBOL_STATEMENT                                       =  96, // <Statement>
   SYMBOL_STATEMENTLIST                                   =  97, // <StatementList>
   SYMBOL_STRINGCONSTANT                                  =  98, // <StringConstant>
   SYMBOL_TERM                                            =  99, // <Term>
   SYMBOL_UNARYMODIFIER                                   = 100, // <UnaryModifier>
   SYMBOL_UNARYOPERATOR                                   = 101, // <UnaryOperator>
   SYMBOL_WHILESTATEMENT                                  = 102  // <WhileStatement>
};

enum RuleConstants : int
{
   RULE_NUMBERCONSTANT_OCTALINTEGERLITERAL                                                         =   0, // <NumberConstant> ::= OctalIntegerLiteral
   RULE_NUMBERCONSTANT_DECIMALINTEGERLITERAL                                                       =   1, // <NumberConstant> ::= DecimalIntegerLiteral
   RULE_NUMBERCONSTANT_HEXADECIMALINTEGERLITERAL                                                   =   2, // <NumberConstant> ::= HexadecimalIntegerLiteral
   RULE_STRINGCONSTANT_STRINGLITERAL                                                               =   3, // <StringConstant> ::= StringLiteral
   RULE_BOOLEANCONSTANT_KEYWORD_TRUE                                                               =   4, // <BooleanConstant> ::= 'Keyword_true'
   RULE_BOOLEANCONSTANT_KEYWORD_FALSE                                                              =   5, // <BooleanConstant> ::= 'Keyword_false'
   RULE_NILCONSTANT_KEYWORD_NIL                                                                    =   6, // <NilConstant> ::= 'Keyword_nil'
   RULE_UNARYOPERATOR_PUNC_PLUS                                                                    =   7, // <UnaryOperator> ::= 'Punc_plus'
   RULE_UNARYOPERATOR_PUNC_MINUS                                                                   =   8, // <UnaryOperator> ::= 'Punc_minus'
   RULE_UNARYOPERATOR_KEYWORD_NOT                                                                  =   9, // <UnaryOperator> ::= 'Keyword_not'
   RULE_UNARYMODIFIER_PUNC_PLUSPLUS                                                                =  10, // <UnaryModifier> ::= 'Punc_plusplus'
   RULE_UNARYMODIFIER_PUNC_MINUSMINUS                                                              =  11, // <UnaryModifier> ::= 'Punc_minusminus'
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_PUNC_STAR                                             =  12, // <LeftAssociativityBinaryOperatorPrec1> ::= 'Punc_star'
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_PUNC_SLASH                                            =  13, // <LeftAssociativityBinaryOperatorPrec1> ::= 'Punc_slash'
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC1_PUNC_PERCENT                                          =  14, // <LeftAssociativityBinaryOperatorPrec1> ::= 'Punc_percent'
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC2_PUNC_PLUS                                             =  15, // <LeftAssociativityBinaryOperatorPrec2> ::= 'Punc_plus'
   RULE_LEFTASSOCIATIVITYBINARYOPERATORPREC2_PUNC_MINUS                                            =  16, // <LeftAssociativityBinaryOperatorPrec2> ::= 'Punc_minus'
   RULE_RELATIONALBINARYOPERATORPREC3_PUNC_GT                                                      =  17, // <RelationalBinaryOperatorPrec3> ::= 'Punc_gt'
   RULE_RELATIONALBINARYOPERATORPREC3_PUNC_GE                                                      =  18, // <RelationalBinaryOperatorPrec3> ::= 'Punc_ge'
   RULE_RELATIONALBINARYOPERATORPREC3_PUNC_LT                                                      =  19, // <RelationalBinaryOperatorPrec3> ::= 'Punc_lt'
   RULE_RELATIONALBINARYOPERATORPREC3_PUNC_LE                                                      =  20, // <RelationalBinaryOperatorPrec3> ::= 'Punc_le'
   RULE_RELATIONALBINARYOPERATORPREC4_PUNC_EQUAL                                                   =  21, // <RelationalBinaryOperatorPrec4> ::= 'Punc_equal'
   RULE_RELATIONALBINARYOPERATORPREC4_PUNC_NOT_EQUAL                                               =  22, // <RelationalBinaryOperatorPrec4> ::= 'Punc_not_equal'
   RULE_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC5_KEYWORD_AND                                    =  23, // <LeftAssociativityLogicalBinaryOperatorPrec5> ::= 'Keyword_and'
   RULE_LEFTASSOCIATIVITYLOGICALBINARYOPERATORPREC6_KEYWORD_OR                                     =  24, // <LeftAssociativityLogicalBinaryOperatorPrec6> ::= 'Keyword_or'
   RULE_RIGHTASSOCIATIVITYASSIGNMENTBINARYOPERATORPREC7_PUNC_ASSIGN                                =  25, // <RightAssociativityAssignmentBinaryOperatorPrec7> ::= 'Punc_assign'
   RULE_EXPRESSIONWITHSTATEMENTSOPENINGWEDGE                                                       =  26, // <ExpressionWithStatementsOpeningWedge> ::= 
   RULE_EXPRESSIONWITHSTATEMENTSCLOSINGWEDGE                                                       =  27, // <ExpressionWithStatementsClosingWedge> ::= 
   RULE_CONSTANT                                                                                   =  28, // <Constant> ::= <NumberConstant>
   RULE_CONSTANT2                                                                                  =  29, // <Constant> ::= <StringConstant>
   RULE_CONSTANT3                                                                                  =  30, // <Constant> ::= <BooleanConstant>
   RULE_CONSTANT4                                                                                  =  31, // <Constant> ::= <NilConstant>
   RULE_IDENTIFIERLIST_IDENTIFIER                                                                  =  32, // <IdentifierList> ::= Identifier
   RULE_IDENTIFIERLIST_IDENTIFIER_PUNC_COMMA                                                       =  33, // <IdentifierList> ::= Identifier 'Punc_comma' <IdentifierList>
   RULE_IDENTIFIERLIST                                                                             =  34, // <IdentifierList> ::= 
   RULE_FUNCTIONSTATEMENTOPENING_KEYWORD_FUNCTION_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS              =  35, // <FunctionStatementOpening> ::= 'Keyword_function' 'Punc_lparenthesis' <IdentifierList> 'Punc_rparenthesis'
   RULE_FUNCTIONSTATEMENTOPENING_KEYWORD_FUNCTION_IDENTIFIER_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS   =  36, // <FunctionStatementOpening> ::= 'Keyword_function' Identifier 'Punc_lparenthesis' <IdentifierList> 'Punc_rparenthesis'
   RULE_FUNCTIONDEFINITION                                                                         =  37, // <FunctionDefinition> ::= <FunctionStatementOpening> <Block>
   RULE_FUNCTIONEXPRESSION                                                                         =  38, // <FunctionExpression> ::= <FunctionExpressionOpening> <FunctionDefinition> <FunctionExpressionClosing>
   RULE_FUNCTIONEXPRESSIONOPENING_PUNC_LPARENTHESIS                                                =  39, // <FunctionExpressionOpening> ::= 'Punc_lparenthesis' <ExpressionWithStatementsOpeningWedge>
   RULE_FUNCTIONEXPRESSIONCLOSING_PUNC_RPARENTHESIS                                                =  40, // <FunctionExpressionClosing> ::= <ExpressionWithStatementsClosingWedge> 'Punc_rparenthesis'
   RULE_LVALUE_IDENTIFIER                                                                          =  41, // <Lvalue> ::= Identifier
   RULE_LVALUE_PUNC_COLONCOLON_IDENTIFIER                                                          =  42, // <Lvalue> ::= 'Punc_coloncolon' Identifier
   RULE_LVALUE_KEYWORD_LOCAL_IDENTIFIER                                                            =  43, // <Lvalue> ::= 'Keyword_local' Identifier
   RULE_LVALUE                                                                                     =  44, // <Lvalue> ::= <Member>
   RULE_MEMBER_PUNC_DOT_IDENTIFIER                                                                 =  45, // <Member> ::= <Lvalue> 'Punc_dot' Identifier
   RULE_MEMBER_PUNC_LBRACKET_PUNC_RBRACKET                                                         =  46, // <Member> ::= <Lvalue> 'Punc_lbracket' <Expression> 'Punc_rbracket'
   RULE_MEMBER_PUNC_DOT_IDENTIFIER2                                                                =  47, // <Member> ::= <Call> 'Punc_dot' Identifier
   RULE_MEMBER_PUNC_LBRACKET_PUNC_RBRACKET2                                                        =  48, // <Member> ::= <Call> 'Punc_lbracket' <Expression> 'Punc_rbracket'
   RULE_EXPRESSIONLIST                                                                             =  49, // <ExpressionList> ::= <Expression> <ExpressionList2>
   RULE_EXPRESSIONLIST2                                                                            =  50, // <ExpressionList> ::= 
   RULE_EXPRESSIONLIST2_PUNC_COMMA                                                                 =  51, // <ExpressionList2> ::= 'Punc_comma' <Expression> <ExpressionList2>
   RULE_EXPRESSIONLIST22                                                                           =  52, // <ExpressionList2> ::= 
   RULE_CALL_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                                                   =  53, // <Call> ::= <Call> 'Punc_lparenthesis' <ExpressionList> 'Punc_rparenthesis'
   RULE_CALL_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS2                                                  =  54, // <Call> ::= <Lvalue> 'Punc_lparenthesis' <ExpressionList> 'Punc_rparenthesis'
   RULE_CALL_PUNC_DOTDOT_IDENTIFIER_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                            =  55, // <Call> ::= <Lvalue> 'Punc_dotdot' Identifier 'Punc_lparenthesis' <ExpressionList> 'Punc_rparenthesis'
   RULE_CALL_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS3                                                  =  56, // <Call> ::= <FunctionExpression> 'Punc_lparenthesis' <ExpressionList> 'Punc_rparenthesis'
   RULE_INDEXEDOBJECTELEMENT_PUNC_LBRACE_PUNC_COLON_PUNC_RBRACE                                    =  57, // <IndexedObjectElement> ::= 'Punc_lbrace' <Expression> 'Punc_colon' <Expression> 'Punc_rbrace'
   RULE_INDEXEDOBJECTELEMENTLIST_PUNC_COMMA                                                        =  58, // <IndexedObjectElementList> ::= <IndexedObjectElement> 'Punc_comma' <IndexedObjectElementList>
   RULE_INDEXEDOBJECTELEMENTLIST                                                                   =  59, // <IndexedObjectElementList> ::= <IndexedObjectElement>
   RULE_OBJECTDEFINITION_PUNC_LBRACKET_PUNC_RBRACKET                                               =  60, // <ObjectDefinition> ::= 'Punc_lbracket' <ExpressionList> 'Punc_rbracket'
   RULE_OBJECTDEFINITION_PUNC_LBRACKET_PUNC_RBRACKET2                                              =  61, // <ObjectDefinition> ::= 'Punc_lbracket' <IndexedObjectElementList> 'Punc_rbracket'
   RULE_PRIMARY                                                                                    =  62, // <Primary> ::= <Constant>
   RULE_PRIMARY2                                                                                   =  63, // <Primary> ::= <Lvalue>
   RULE_PRIMARY3                                                                                   =  64, // <Primary> ::= <FunctionExpression>
   RULE_PRIMARY4                                                                                   =  65, // <Primary> ::= <Call>
   RULE_PRIMARY5                                                                                   =  66, // <Primary> ::= <ObjectDefinition>
   RULE_TERM                                                                                       =  67, // <Term> ::= <Primary>
   RULE_TERM_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                                                   =  68, // <Term> ::= 'Punc_lparenthesis' <Expression> 'Punc_rparenthesis'
   RULE_TERM2                                                                                      =  69, // <Term> ::= <UnaryModifier> <Lvalue>
   RULE_TERM3                                                                                      =  70, // <Term> ::= <Lvalue> <UnaryModifier>
   RULE_ARITHMEXPRESSIONPREC0                                                                      =  71, // <ArithmExpressionPrec0> ::= <Term>
   RULE_ARITHMEXPRESSIONPREC02                                                                     =  72, // <ArithmExpressionPrec0> ::= <UnaryOperator> <ArithmExpressionPrec0>
   RULE_ARITHMEXPRESSIONPREC1                                                                      =  73, // <ArithmExpressionPrec1> ::= <ArithmExpressionPrec0>
   RULE_ARITHMEXPRESSIONPREC12                                                                     =  74, // <ArithmExpressionPrec1> ::= <ArithmExpressionPrec1> <LeftAssociativityBinaryOperatorPrec1> <Term>
   RULE_ARITHMEXPRESSIONPREC2                                                                      =  75, // <ArithmExpressionPrec2> ::= <ArithmExpressionPrec1>
   RULE_ARITHMEXPRESSIONPREC22                                                                     =  76, // <ArithmExpressionPrec2> ::= <ArithmExpressionPrec2> <LeftAssociativityBinaryOperatorPrec2> <ArithmExpressionPrec1>
   RULE_RELATIONALEXPRESSIONPREC3                                                                  =  77, // <RelationalExpressionPrec3> ::= <ArithmExpressionPrec2>
   RULE_RELATIONALEXPRESSIONPREC32                                                                 =  78, // <RelationalExpressionPrec3> ::= <ArithmExpressionPrec2> <RelationalBinaryOperatorPrec3> <ArithmExpressionPrec2>
   RULE_RELATIONALEXPRESSIONPREC4                                                                  =  79, // <RelationalExpressionPrec4> ::= <RelationalExpressionPrec3>
   RULE_RELATIONALEXPRESSIONPREC42                                                                 =  80, // <RelationalExpressionPrec4> ::= <RelationalExpressionPrec3> <RelationalBinaryOperatorPrec4> <RelationalExpressionPrec3>
   RULE_LOGICALEXPRESSIONPREC5                                                                     =  81, // <LogicalExpressionPrec5> ::= <RelationalExpressionPrec4>
   RULE_LOGICALEXPRESSIONPREC52                                                                    =  82, // <LogicalExpressionPrec5> ::= <LogicalExpressionPrec5Prefix> <RelationalExpressionPrec4>
   RULE_LOGICALEXPRESSIONPREC5PREFIX                                                               =  83, // <LogicalExpressionPrec5Prefix> ::= <LogicalExpressionPrec5> <LeftAssociativityLogicalBinaryOperatorPrec5>
   RULE_LOGICALEXPRESSIONPREC6                                                                     =  84, // <LogicalExpressionPrec6> ::= <LogicalExpressionPrec5>
   RULE_LOGICALEXPRESSIONPREC62                                                                    =  85, // <LogicalExpressionPrec6> ::= <LogicalExpressionPrec6Prefix> <LogicalExpressionPrec5>
   RULE_LOGICALEXPRESSIONPREC6PREFIX                                                               =  86, // <LogicalExpressionPrec6Prefix> ::= <LogicalExpressionPrec6> <LeftAssociativityLogicalBinaryOperatorPrec6>
   RULE_ASSIGNMENTEXPRESSIONPREC7                                                                  =  87, // <AssignmentExpressionPrec7> ::= <LogicalExpressionPrec6>
   RULE_ASSIGNMENTEXPRESSIONPREC72                                                                 =  88, // <AssignmentExpressionPrec7> ::= <Lvalue> <RightAssociativityAssignmentBinaryOperatorPrec7> <AssignmentExpressionPrec7>
   RULE_EXPRESSION                                                                                 =  89, // <Expression> ::= <AssignmentExpressionPrec7>
   RULE_BLOCK_PUNC_LBRACE_PUNC_RBRACE                                                              =  90, // <Block> ::= 'Punc_lbrace' <StatementList> 'Punc_rbrace'
   RULE_RETURNSTATEMENT_KEYWORD_RETURN_PUNC_SEMICOLON                                              =  91, // <ReturnStatement> ::= 'Keyword_return' 'Punc_semicolon'
   RULE_RETURNSTATEMENT_KEYWORD_RETURN_PUNC_SEMICOLON2                                             =  92, // <ReturnStatement> ::= 'Keyword_return' <Expression> 'Punc_semicolon'
   RULE_WHILESTATEMENT_KEYWORD_WHILE_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                           =  93, // <WhileStatement> ::= 'Keyword_while' 'Punc_lparenthesis' <Expression> 'Punc_rparenthesis' <Statement>
   RULE_FORSTATEMENT_KEYWORD_FOR_PUNC_LPARENTHESIS_PUNC_SEMICOLON_PUNC_SEMICOLON_PUNC_RPARENTHESIS =  94, // <ForStatement> ::= 'Keyword_for' 'Punc_lparenthesis' <ExpressionList> 'Punc_semicolon' <Expression> 'Punc_semicolon' <ExpressionList> 'Punc_rparenthesis' <Statement>
   RULE_IFELSESTATEMENT_KEYWORD_IF_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS                             =  95, // <IfElseStatement> ::= 'Keyword_if' 'Punc_lparenthesis' <Expression> 'Punc_rparenthesis' <Statement>
   RULE_IFELSESTATEMENT_KEYWORD_IF_PUNC_LPARENTHESIS_PUNC_RPARENTHESIS_KEYWORD_ELSE                =  96, // <IfElseStatement> ::= 'Keyword_if' 'Punc_lparenthesis' <Expression> 'Punc_rparenthesis' <Statement> 'Keyword_else' <Statement>
   RULE_STATEMENT_PUNC_SEMICOLON                                                                   =  97, // <Statement> ::= 'Punc_semicolon'
   RULE_STATEMENT_KEYWORD_BREAK_PUNC_SEMICOLON                                                     =  98, // <Statement> ::= 'Keyword_break' 'Punc_semicolon'
   RULE_STATEMENT_KEYWORD_CONTINUE_PUNC_SEMICOLON                                                  =  99, // <Statement> ::= 'Keyword_continue' 'Punc_semicolon'
   RULE_STATEMENT_PUNC_SEMICOLON2                                                                  = 100, // <Statement> ::= <Expression> 'Punc_semicolon'
   RULE_STATEMENT                                                                                  = 101, // <Statement> ::= <Block>
   RULE_STATEMENT2                                                                                 = 102, // <Statement> ::= <ReturnStatement>
   RULE_STATEMENT3                                                                                 = 103, // <Statement> ::= <WhileStatement>
   RULE_STATEMENT4                                                                                 = 104, // <Statement> ::= <ForStatement>
   RULE_STATEMENT5                                                                                 = 105, // <Statement> ::= <IfElseStatement>
   RULE_STATEMENT6                                                                                 = 106, // <Statement> ::= <FunctionDefinition>
   RULE_STATEMENTLIST                                                                              = 107, // <StatementList> ::= <Statement> <StatementList>
   RULE_STATEMENTLIST2                                                                             = 108, // <StatementList> ::= 
   RULE_PROGRAM                                                                                    = 109  // <Program> ::= <StatementList>
};
