
namespace gr.uoc.csd.Alpha.Compilation.ParserConstants {

    enum Symbols {
        EOF                                             =   0, // (EOF)
        ERROR                                           =   1, // (ErrorCallback)
        WHITESPACE                                      =   2, // (Whitespace)
        COMMENTEND                                      =   3, // (Comment End)
        COMMENTLINE                                     =   4, // (Comment Line)
        COMMENTSTART                                    =   5, // (Comment Start)
        DecimalIntegerLiteral                           =   6, // DecimalIntegerLiteral
        HexadecimalIntegerLiteral                       =   7, // HexadecimalIntegerLiteral
        Identifier                                      =   8, // Identifier
        Keyword_and                                     =   9, // 'Keyword_and'
        Keyword_break                                   =  10, // 'Keyword_break'
        Keyword_continue                                =  11, // 'Keyword_continue'
        Keyword_else                                    =  12, // 'Keyword_else'
        Keyword_false                                   =  13, // 'Keyword_false'
        Keyword_for                                     =  14, // 'Keyword_for'
        Keyword_function                                =  15, // 'Keyword_function'
        Keyword_if                                      =  16, // 'Keyword_if'
        Keyword_local                                   =  17, // 'Keyword_local'
        Keyword_nil                                     =  18, // 'Keyword_nil'
        Keyword_not                                     =  19, // 'Keyword_not'
        Keyword_or                                      =  20, // 'Keyword_or'
        Keyword_return                                  =  21, // 'Keyword_return'
        Keyword_true                                    =  22, // 'Keyword_true'
        Keyword_while                                   =  23, // 'Keyword_while'
        OctalIntegerLiteral                             =  24, // OctalIntegerLiteral
        Punc_assign                                     =  25, // 'Punc_assign'
        Punc_colon                                      =  26, // 'Punc_colon'
        Punc_coloncolon                                 =  27, // 'Punc_coloncolon'
        Punc_comma                                      =  28, // 'Punc_comma'
        Punc_dot                                        =  29, // 'Punc_dot'
        Punc_dotdot                                     =  30, // 'Punc_dotdot'
        Punc_equal                                      =  31, // 'Punc_equal'
        Punc_ge                                         =  32, // 'Punc_ge'
        Punc_gt                                         =  33, // 'Punc_gt'
        Punc_lbrace                                     =  34, // 'Punc_lbrace'
        Punc_lbracket                                   =  35, // 'Punc_lbracket'
        Punc_le                                         =  36, // 'Punc_le'
        Punc_lparenthesis                               =  37, // 'Punc_lparenthesis'
        Punc_lt                                         =  38, // 'Punc_lt'
        Punc_minus                                      =  39, // 'Punc_minus'
        Punc_minusminus                                 =  40, // 'Punc_minusminus'
        Punc_not_equal                                  =  41, // 'Punc_not_equal'
        Punc_percent                                    =  42, // 'Punc_percent'
        Punc_plus                                       =  43, // 'Punc_plus'
        Punc_plusplus                                   =  44, // 'Punc_plusplus'
        Punc_rbrace                                     =  45, // 'Punc_rbrace'
        Punc_rbracket                                   =  46, // 'Punc_rbracket'
        Punc_rparenthesis                               =  47, // 'Punc_rparenthesis'
        Punc_semicolon                                  =  48, // 'Punc_semicolon'
        Punc_slash                                      =  49, // 'Punc_slash'
        Punc_star                                       =  50, // 'Punc_star'
        StringLiteral                                   =  51, // StringLiteral
        ArithmExpressionPrec0                           =  52, // <ArithmExpressionPrec0>
        ArithmExpressionPrec1                           =  53, // <ArithmExpressionPrec1>
        ArithmExpressionPrec2                           =  54, // <ArithmExpressionPrec2>
        AssignmentExpressionPrec7                       =  55, // <AssignmentExpressionPrec7>
        Block                                           =  56, // <Block>
        BooleanConstant                                 =  57, // <BooleanConstant>
        Call                                            =  58, // <Call>
        Constant                                        =  59, // <Constant>
        Expression                                      =  60, // <Expression>
        ExpressionList                                  =  61, // <ExpressionList>
        ExpressionList2                                 =  62, // <ExpressionList2>
        ExpressionWithStatementsClosingWedge            =  63, // <ExpressionWithStatementsClosingWedge>
        ExpressionWithStatementsOpeningWedge            =  64, // <ExpressionWithStatementsOpeningWedge>
        ForStatement                                    =  65, // <ForStatement>
        FunctionDefinition                              =  66, // <FunctionDefinition>
        FunctionExpression                              =  67, // <FunctionExpression>
        FunctionExpressionClosing                       =  68, // <FunctionExpressionClosing>
        FunctionExpressionOpening                       =  69, // <FunctionExpressionOpening>
        FunctionStatementOpening                        =  70, // <FunctionStatementOpening>
        IdentifierList                                  =  71, // <IdentifierList>
        IfElseStatement                                 =  72, // <IfElseStatement>
        IndexedObjectElement                            =  73, // <IndexedObjectElement>
        IndexedObjectElementList                        =  74, // <IndexedObjectElementList>
        LeftAssociativityBinaryOperatorPrec1            =  75, // <LeftAssociativityBinaryOperatorPrec1>
        LeftAssociativityBinaryOperatorPrec2            =  76, // <LeftAssociativityBinaryOperatorPrec2>
        LeftAssociativityLogicalBinaryOperatorPrec5     =  77, // <LeftAssociativityLogicalBinaryOperatorPrec5>
        LeftAssociativityLogicalBinaryOperatorPrec6     =  78, // <LeftAssociativityLogicalBinaryOperatorPrec6>
        LogicalExpressionPrec5                          =  79, // <LogicalExpressionPrec5>
        LogicalExpressionPrec6                          =  80, // <LogicalExpressionPrec6>
        Lvalue                                          =  81, // <Lvalue>
        Member                                          =  82, // <Member>
        NilConstant                                     =  83, // <NilConstant>
        NumberConstant                                  =  84, // <NumberConstant>
        ObjectDefinition                                =  85, // <ObjectDefinition>
        Primary                                         =  86, // <Primary>
        Program                                         =  87, // <Program>
        RelationalBinaryOperatorPrec3                   =  88, // <RelationalBinaryOperatorPrec3>
        RelationalBinaryOperatorPrec4                   =  89, // <RelationalBinaryOperatorPrec4>
        RelationalExpressionPrec3                       =  90, // <RelationalExpressionPrec3>
        RelationalExpressionPrec4                       =  91, // <RelationalExpressionPrec4>
        ReturnStatement                                 =  92, // <ReturnStatement>
        RightAssociativityAssignmentBinaryOperatorPrec7 =  93, // <RightAssociativityAssignmentBinaryOperatorPrec7>
        Statement                                       =  94, // <Statement>
        StatementList                                   =  95, // <StatementList>
        StringConstant                                  =  96, // <StringConstant>
        Term                                            =  97, // <Term>
        UnaryModifier                                   =  98, // <UnaryModifier>
        UnaryOperator                                   =  99, // <UnaryOperator>
        WhileStatement                                  = 100, // <WhileStatement>
        SIZE                                            = 101
    }
    

    enum Rules {
        NumberConstant___OctalIntegerLiteral                                                                                                                   =   0, // <NumberConstant> ::= OctalIntegerLiteral
        NumberConstant___DecimalIntegerLiteral                                                                                                                 =   1, // <NumberConstant> ::= DecimalIntegerLiteral
        NumberConstant___HexadecimalIntegerLiteral                                                                                                             =   2, // <NumberConstant> ::= HexadecimalIntegerLiteral
        StringConstant___StringLiteral                                                                                                                         =   3, // <StringConstant> ::= StringLiteral
        BooleanConstant___Keyword_true                                                                                                                         =   4, // <BooleanConstant> ::= 'Keyword_true'
        BooleanConstant___Keyword_false                                                                                                                        =   5, // <BooleanConstant> ::= 'Keyword_false'
        NilConstant___Keyword_nil                                                                                                                              =   6, // <NilConstant> ::= 'Keyword_nil'
        UnaryOperator___Punc_plus                                                                                                                              =   7, // <UnaryOperator> ::= 'Punc_plus'
        UnaryOperator___Punc_minus                                                                                                                             =   8, // <UnaryOperator> ::= 'Punc_minus'
        UnaryOperator___Keyword_not                                                                                                                            =   9, // <UnaryOperator> ::= 'Keyword_not'
        UnaryModifier___Punc_plusplus                                                                                                                          =  10, // <UnaryModifier> ::= 'Punc_plusplus'
        UnaryModifier___Punc_minusminus                                                                                                                        =  11, // <UnaryModifier> ::= 'Punc_minusminus'
        LeftAssociativityBinaryOperatorPrec1___Punc_star                                                                                                       =  12, // <LeftAssociativityBinaryOperatorPrec1> ::= 'Punc_star'
        LeftAssociativityBinaryOperatorPrec1___Punc_slash                                                                                                      =  13, // <LeftAssociativityBinaryOperatorPrec1> ::= 'Punc_slash'
        LeftAssociativityBinaryOperatorPrec1___Punc_percent                                                                                                    =  14, // <LeftAssociativityBinaryOperatorPrec1> ::= 'Punc_percent'
        LeftAssociativityBinaryOperatorPrec2___Punc_plus                                                                                                       =  15, // <LeftAssociativityBinaryOperatorPrec2> ::= 'Punc_plus'
        LeftAssociativityBinaryOperatorPrec2___Punc_minus                                                                                                      =  16, // <LeftAssociativityBinaryOperatorPrec2> ::= 'Punc_minus'
        RelationalBinaryOperatorPrec3___Punc_gt                                                                                                                =  17, // <RelationalBinaryOperatorPrec3> ::= 'Punc_gt'
        RelationalBinaryOperatorPrec3___Punc_ge                                                                                                                =  18, // <RelationalBinaryOperatorPrec3> ::= 'Punc_ge'
        RelationalBinaryOperatorPrec3___Punc_lt                                                                                                                =  19, // <RelationalBinaryOperatorPrec3> ::= 'Punc_lt'
        RelationalBinaryOperatorPrec3___Punc_le                                                                                                                =  20, // <RelationalBinaryOperatorPrec3> ::= 'Punc_le'
        RelationalBinaryOperatorPrec4___Punc_equal                                                                                                             =  21, // <RelationalBinaryOperatorPrec4> ::= 'Punc_equal'
        RelationalBinaryOperatorPrec4___Punc_not_equal                                                                                                         =  22, // <RelationalBinaryOperatorPrec4> ::= 'Punc_not_equal'
        LeftAssociativityLogicalBinaryOperatorPrec5___Keyword_and                                                                                              =  23, // <LeftAssociativityLogicalBinaryOperatorPrec5> ::= 'Keyword_and'
        LeftAssociativityLogicalBinaryOperatorPrec6___Keyword_or                                                                                               =  24, // <LeftAssociativityLogicalBinaryOperatorPrec6> ::= 'Keyword_or'
        RightAssociativityAssignmentBinaryOperatorPrec7___Punc_assign                                                                                          =  25, // <RightAssociativityAssignmentBinaryOperatorPrec7> ::= 'Punc_assign'
        ExpressionWithStatementsOpeningWedge                                                                                                                   =  26, // <ExpressionWithStatementsOpeningWedge> ::= 
        ExpressionWithStatementsClosingWedge                                                                                                                   =  27, // <ExpressionWithStatementsClosingWedge> ::= 
        Constant___NumberConstant                                                                                                                              =  28, // <Constant> ::= <NumberConstant>
        Constant___StringConstant                                                                                                                              =  29, // <Constant> ::= <StringConstant>
        Constant___BooleanConstant                                                                                                                             =  30, // <Constant> ::= <BooleanConstant>
        Constant___NilConstant                                                                                                                                 =  31, // <Constant> ::= <NilConstant>
        IdentifierList___Identifier                                                                                                                            =  32, // <IdentifierList> ::= Identifier
        IdentifierList___Identifier__Punc_comma__IdentifierList                                                                                                =  33, // <IdentifierList> ::= Identifier 'Punc_comma' <IdentifierList>
        IdentifierList                                                                                                                                         =  34, // <IdentifierList> ::= 
        FunctionStatementOpening___Keyword_function__Punc_lparenthesis__IdentifierList__Punc_rparenthesis                                                      =  35, // <FunctionStatementOpening> ::= 'Keyword_function' 'Punc_lparenthesis' <IdentifierList> 'Punc_rparenthesis'
        FunctionStatementOpening___Keyword_function__Identifier__Punc_lparenthesis__IdentifierList__Punc_rparenthesis                                          =  36, // <FunctionStatementOpening> ::= 'Keyword_function' Identifier 'Punc_lparenthesis' <IdentifierList> 'Punc_rparenthesis'
        FunctionDefinition___FunctionStatementOpening__Block                                                                                                   =  37, // <FunctionDefinition> ::= <FunctionStatementOpening> <Block>
        FunctionExpression___FunctionExpressionOpening__FunctionDefinition__FunctionExpressionClosing                                                          =  38, // <FunctionExpression> ::= <FunctionExpressionOpening> <FunctionDefinition> <FunctionExpressionClosing>
        FunctionExpressionOpening___Punc_lparenthesis__ExpressionWithStatementsOpeningWedge                                                                    =  39, // <FunctionExpressionOpening> ::= 'Punc_lparenthesis' <ExpressionWithStatementsOpeningWedge>
        FunctionExpressionClosing___ExpressionWithStatementsClosingWedge__Punc_rparenthesis                                                                    =  40, // <FunctionExpressionClosing> ::= <ExpressionWithStatementsClosingWedge> 'Punc_rparenthesis'
        Lvalue___Identifier                                                                                                                                    =  41, // <Lvalue> ::= Identifier
        Lvalue___Punc_coloncolon__Identifier                                                                                                                   =  42, // <Lvalue> ::= 'Punc_coloncolon' Identifier
        Lvalue___Keyword_local__Identifier                                                                                                                     =  43, // <Lvalue> ::= 'Keyword_local' Identifier
        Lvalue___Member                                                                                                                                        =  44, // <Lvalue> ::= <Member>
        Member___Lvalue__Punc_dot__Identifier                                                                                                                  =  45, // <Member> ::= <Lvalue> 'Punc_dot' Identifier
        Member___Lvalue__Punc_lbracket__Expression__Punc_rbracket                                                                                              =  46, // <Member> ::= <Lvalue> 'Punc_lbracket' <Expression> 'Punc_rbracket'
        Member___Call__Punc_dot__Identifier                                                                                                                    =  47, // <Member> ::= <Call> 'Punc_dot' Identifier
        Member___Call__Punc_lbracket__Expression__Punc_rbracket                                                                                                =  48, // <Member> ::= <Call> 'Punc_lbracket' <Expression> 'Punc_rbracket'
        ExpressionList___Expression__ExpressionList2                                                                                                           =  49, // <ExpressionList> ::= <Expression> <ExpressionList2>
        ExpressionList                                                                                                                                         =  50, // <ExpressionList> ::= 
        ExpressionList2___Punc_comma__Expression__ExpressionList2                                                                                              =  51, // <ExpressionList2> ::= 'Punc_comma' <Expression> <ExpressionList2>
        ExpressionList2                                                                                                                                        =  52, // <ExpressionList2> ::= 
        Call___Call__Punc_lparenthesis__ExpressionList__Punc_rparenthesis                                                                                      =  53, // <Call> ::= <Call> 'Punc_lparenthesis' <ExpressionList> 'Punc_rparenthesis'
        Call___Lvalue__Punc_lparenthesis__ExpressionList__Punc_rparenthesis                                                                                    =  54, // <Call> ::= <Lvalue> 'Punc_lparenthesis' <ExpressionList> 'Punc_rparenthesis'
        Call___Lvalue__Punc_dotdot__Identifier__Punc_lparenthesis__ExpressionList__Punc_rparenthesis                                                           =  55, // <Call> ::= <Lvalue> 'Punc_dotdot' Identifier 'Punc_lparenthesis' <ExpressionList> 'Punc_rparenthesis'
        Call___FunctionExpression__Punc_lparenthesis__ExpressionList__Punc_rparenthesis                                                                        =  56, // <Call> ::= <FunctionExpression> 'Punc_lparenthesis' <ExpressionList> 'Punc_rparenthesis'
        IndexedObjectElement___Punc_lbrace__Expression__Punc_colon__Expression__Punc_rbrace                                                                    =  57, // <IndexedObjectElement> ::= 'Punc_lbrace' <Expression> 'Punc_colon' <Expression> 'Punc_rbrace'
        IndexedObjectElementList___IndexedObjectElement__Punc_comma__IndexedObjectElementList                                                                  =  58, // <IndexedObjectElementList> ::= <IndexedObjectElement> 'Punc_comma' <IndexedObjectElementList>
        IndexedObjectElementList___IndexedObjectElement                                                                                                        =  59, // <IndexedObjectElementList> ::= <IndexedObjectElement>
        ObjectDefinition___Punc_lbracket__ExpressionList__Punc_rbracket                                                                                        =  60, // <ObjectDefinition> ::= 'Punc_lbracket' <ExpressionList> 'Punc_rbracket'
        ObjectDefinition___Punc_lbracket__IndexedObjectElementList__Punc_rbracket                                                                              =  61, // <ObjectDefinition> ::= 'Punc_lbracket' <IndexedObjectElementList> 'Punc_rbracket'
        Primary___Constant                                                                                                                                     =  62, // <Primary> ::= <Constant>
        Primary___Lvalue                                                                                                                                       =  63, // <Primary> ::= <Lvalue>
        Primary___FunctionExpression                                                                                                                           =  64, // <Primary> ::= <FunctionExpression>
        Primary___Call                                                                                                                                         =  65, // <Primary> ::= <Call>
        Primary___ObjectDefinition                                                                                                                             =  66, // <Primary> ::= <ObjectDefinition>
        Term___Primary                                                                                                                                         =  67, // <Term> ::= <Primary>
        Term___Punc_lparenthesis__Expression__Punc_rparenthesis                                                                                                =  68, // <Term> ::= 'Punc_lparenthesis' <Expression> 'Punc_rparenthesis'
        Term___UnaryModifier__Lvalue                                                                                                                           =  69, // <Term> ::= <UnaryModifier> <Lvalue>
        Term___Lvalue__UnaryModifier                                                                                                                           =  70, // <Term> ::= <Lvalue> <UnaryModifier>
        ArithmExpressionPrec0___Term                                                                                                                           =  71, // <ArithmExpressionPrec0> ::= <Term>
        ArithmExpressionPrec0___UnaryOperator__ArithmExpressionPrec0                                                                                           =  72, // <ArithmExpressionPrec0> ::= <UnaryOperator> <ArithmExpressionPrec0>
        ArithmExpressionPrec1___ArithmExpressionPrec0                                                                                                          =  73, // <ArithmExpressionPrec1> ::= <ArithmExpressionPrec0>
        ArithmExpressionPrec1___ArithmExpressionPrec1__LeftAssociativityBinaryOperatorPrec1__Term                                                              =  74, // <ArithmExpressionPrec1> ::= <ArithmExpressionPrec1> <LeftAssociativityBinaryOperatorPrec1> <Term>
        ArithmExpressionPrec2___ArithmExpressionPrec1                                                                                                          =  75, // <ArithmExpressionPrec2> ::= <ArithmExpressionPrec1>
        ArithmExpressionPrec2___ArithmExpressionPrec2__LeftAssociativityBinaryOperatorPrec2__ArithmExpressionPrec1                                             =  76, // <ArithmExpressionPrec2> ::= <ArithmExpressionPrec2> <LeftAssociativityBinaryOperatorPrec2> <ArithmExpressionPrec1>
        RelationalExpressionPrec3___ArithmExpressionPrec2                                                                                                      =  77, // <RelationalExpressionPrec3> ::= <ArithmExpressionPrec2>
        RelationalExpressionPrec3___ArithmExpressionPrec2__RelationalBinaryOperatorPrec3__ArithmExpressionPrec2                                                =  78, // <RelationalExpressionPrec3> ::= <ArithmExpressionPrec2> <RelationalBinaryOperatorPrec3> <ArithmExpressionPrec2>
        RelationalExpressionPrec4___RelationalExpressionPrec3                                                                                                  =  79, // <RelationalExpressionPrec4> ::= <RelationalExpressionPrec3>
        RelationalExpressionPrec4___RelationalExpressionPrec3__RelationalBinaryOperatorPrec4__RelationalExpressionPrec3                                        =  80, // <RelationalExpressionPrec4> ::= <RelationalExpressionPrec3> <RelationalBinaryOperatorPrec4> <RelationalExpressionPrec3>
        LogicalExpressionPrec5___RelationalExpressionPrec4                                                                                                     =  81, // <LogicalExpressionPrec5> ::= <RelationalExpressionPrec4>
        LogicalExpressionPrec5___LogicalExpressionPrec5Prefix__RelationalExpressionPrec4                                                                       =  82, // <LogicalExpressionPrec5> ::= <LogicalExpressionPrec5Prefix> <RelationalExpressionPrec4>
        LogicalExpressionPrec5Prefix___LogicalExpressionPrec5__LeftAssociativityLogicalBinaryOperatorPrec5                                                     =  83, // <LogicalExpressionPrec5Prefix> ::= <LogicalExpressionPrec5> <LeftAssociativityLogicalBinaryOperatorPrec5>
        LogicalExpressionPrec6___LogicalExpressionPrec5                                                                                                        =  84, // <LogicalExpressionPrec6> ::= <LogicalExpressionPrec5>
        LogicalExpressionPrec6___LogicalExpressionPrec6Prefix__LogicalExpressionPrec5                                                                          =  85, // <LogicalExpressionPrec6> ::= <LogicalExpressionPrec6Prefix> <LogicalExpressionPrec5>
        LogicalExpressionPrec6Prefix___LogicalExpressionPrec6__LeftAssociativityLogicalBinaryOperatorPrec6                                                     =  86, // <LogicalExpressionPrec6Prefix> ::= <LogicalExpressionPrec6> <LeftAssociativityLogicalBinaryOperatorPrec6>
        AssignmentExpressionPrec7___LogicalExpressionPrec6                                                                                                     =  87, // <AssignmentExpressionPrec7> ::= <LogicalExpressionPrec6>
        AssignmentExpressionPrec7___Lvalue__RightAssociativityAssignmentBinaryOperatorPrec7__AssignmentExpressionPrec7                                         =  88, // <AssignmentExpressionPrec7> ::= <Lvalue> <RightAssociativityAssignmentBinaryOperatorPrec7> <AssignmentExpressionPrec7>
        Expression___AssignmentExpressionPrec7                                                                                                                 =  89, // <Expression> ::= <AssignmentExpressionPrec7>
        Block___Punc_lbrace__StatementList__Punc_rbrace                                                                                                        =  90, // <Block> ::= 'Punc_lbrace' <StatementList> 'Punc_rbrace'
        ReturnStatement___Keyword_return__Punc_semicolon                                                                                                       =  91, // <ReturnStatement> ::= 'Keyword_return' 'Punc_semicolon'
        ReturnStatement___Keyword_return__Expression__Punc_semicolon                                                                                           =  92, // <ReturnStatement> ::= 'Keyword_return' <Expression> 'Punc_semicolon'
        WhileStatement___Keyword_while__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement                                                            =  93, // <WhileStatement> ::= 'Keyword_while' 'Punc_lparenthesis' <Expression> 'Punc_rparenthesis' <Statement>
        ForStatement___Keyword_for__Punc_lparenthesis__ExpressionList__Punc_semicolon__Expression__Punc_semicolon__ExpressionList__Punc_rparenthesis__Statement=  94, // <ForStatement> ::= 'Keyword_for' 'Punc_lparenthesis' <ExpressionList> 'Punc_semicolon' <Expression> 'Punc_semicolon' <ExpressionList> 'Punc_rparenthesis' <Statement>
        IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement                                                              =  95, // <IfElseStatement> ::= 'Keyword_if' 'Punc_lparenthesis' <Expression> 'Punc_rparenthesis' <Statement>
        IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement__Keyword_else__Statement                                     =  96, // <IfElseStatement> ::= 'Keyword_if' 'Punc_lparenthesis' <Expression> 'Punc_rparenthesis' <Statement> 'Keyword_else' <Statement>
        Statement___Punc_semicolon                                                                                                                             =  97, // <Statement> ::= 'Punc_semicolon'
        Statement___Keyword_break__Punc_semicolon                                                                                                              =  98, // <Statement> ::= 'Keyword_break' 'Punc_semicolon'
        Statement___Keyword_continue__Punc_semicolon                                                                                                           =  99, // <Statement> ::= 'Keyword_continue' 'Punc_semicolon'
        Statement___Expression__Punc_semicolon                                                                                                                 = 100, // <Statement> ::= <Expression> 'Punc_semicolon'
        Statement___Block                                                                                                                                      = 101, // <Statement> ::= <Block>
        Statement___ReturnStatement                                                                                                                            = 102, // <Statement> ::= <ReturnStatement>
        Statement___WhileStatement                                                                                                                             = 103, // <Statement> ::= <WhileStatement>
        Statement___ForStatement                                                                                                                               = 104, // <Statement> ::= <ForStatement>
        Statement___IfElseStatement                                                                                                                            = 105, // <Statement> ::= <IfElseStatement>
        Statement___FunctionDefinition                                                                                                                         = 106, // <Statement> ::= <FunctionDefinition>
        StatementList___Statement__StatementList                                                                                                               = 107, // <StatementList> ::= <Statement> <StatementList>
        StatementList                                                                                                                                          = 108, // <StatementList> ::= 
        Program___StatementList                                                                                                                                = 109, // <Program> ::= <StatementList>
        SIZE                                                                                                                                                   = 110
    }
}

