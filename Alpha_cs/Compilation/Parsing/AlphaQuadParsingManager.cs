namespace gr.uoc.csd.Alpha.Compilation.Parsing {

    using D = System.Diagnostics.Debug;

    public class AlphaQuadParsingManager: AbstractParsingManager {

        private readonly Quads.AbstractQuadManager quads;
        private readonly SymbolTable.SymbolTable symbolTable;
        public AlphaQuadParsingManager (Quads.AbstractQuadManager quadManager, SymbolTable.SymbolTable symbolTable) :
            base("$avril_") {
            quads = quadManager;
            this.symbolTable = symbolTable;
        }

        ///////////////////////////////////////////////////////////////////////
        // Managers
        ///////////////////////////////////////////////////////////////////////

        public override int NumberConstant___OctalIntegerLiteral (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int NumberConstant___DecimalIntegerLiteral (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int NumberConstant___HexadecimalIntegerLiteral (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int StringConstant___StringLiteral (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue strliteral = rhs[0];

            result = strliteral;

            return 0;
        }

        public override int BooleanConstant___Keyword_true (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int BooleanConstant___Keyword_false (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int NilConstant___Keyword_nil (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int UnaryOperator___Punc_plus (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int UnaryOperator___Punc_minus (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int UnaryOperator___Keyword_not (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int UnaryModifier___Punc_plusplus (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int UnaryModifier___Punc_minusminus (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int LeftAssociativityBinaryOperatorPrec1___Punc_star (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int LeftAssociativityBinaryOperatorPrec1___Punc_slash (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int LeftAssociativityBinaryOperatorPrec1___Punc_percent (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int LeftAssociativityBinaryOperatorPrec2___Punc_plus (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int LeftAssociativityBinaryOperatorPrec2___Punc_minus (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int RelationalBinaryOperatorPrec3___Punc_gt (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int RelationalBinaryOperatorPrec3___Punc_ge (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int RelationalBinaryOperatorPrec3___Punc_lt (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int RelationalBinaryOperatorPrec3___Punc_le (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int RelationalBinaryOperatorPrec4___Punc_equal (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int RelationalBinaryOperatorPrec4___Punc_not_equal (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int LeftAssociativityLogicalBinaryOperatorPrec5___Keyword_and (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int LeftAssociativityLogicalBinaryOperatorPrec6___Keyword_or (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int RightAssociativityAssignmentBinaryOperatorPrec7___Punc_assign (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);
            result = null;
            return 0;
        }

        public override int Constant___NumberConstant (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Constant___StringConstant (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue strconst = rhs[0];

            result = strconst;

            return 0;
        }

        public override int Constant___BooleanConstant (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Constant___NilConstant (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Lvalue___Identifier (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue id = rhs[0];

            D.Assert(id.IsString());

            SymbolTable.Symbol variable;
            string name = id.StringValue;
            int line = 344; // TODO get line, how??
            if (InFunction)
                symbolTable.LookupOrInsertLocalVariable(out variable, name, line);
            else
                symbolTable.LookupOrInsertProgramVariable(out variable, name, line);

            result = TokenValue.CreateVariable(variable);

            return 0;
        }

        public override int Lvalue___Punc_coloncolon__Identifier (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Lvalue___Keyword_local__Identifier (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 2);

            TokenValue id = rhs[1];

            result = id; // TODO lookup and replace with symbol

            return 0;
        }

        public override int Lvalue___Member (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Member___Lvalue__Punc_dot__Identifier (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Member___Lvalue__Punc_lbracket__Expression__Punc_rbracket (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Member___Call__Punc_dot__Identifier (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Member___Call__Punc_lbracket__Expression__Punc_rbracket (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }



        ///////////////////////////////////////////////////////////////////////



        public override int ExpressionList___Expression__ExpressionList2 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 2);

            TokenValue expr = rhs[0];
            TokenValue exprlist2 = rhs[1];

            exprlist2.AddExpression(expr);

            result = exprlist2;

            return 0;
        }

        public override int ExpressionList (out TokenValue result, TokenValue[] rhs) {
            return ExpressionList2(out result, rhs);
        }

        public override int ExpressionList2___Punc_comma__Expression__ExpressionList2 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 3);

            TokenValue expr = rhs[1];
            TokenValue exprlist2 = rhs[2];

            exprlist2.AddExpression(expr);

            result = exprlist2;

            return 0;
        }

        public override int ExpressionList2 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 0);
            result = TokenValue.CreateExpressionList(null);
            return 0;
        }



        ///////////////////////////////////////////////////////////////////////



        public override int Call___Call__Punc_lparenthesis__ExpressionList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Call___Lvalue__Punc_lparenthesis__ExpressionList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Call___Lvalue__Punc_dotdot__Identifier__Punc_lparenthesis__ExpressionList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int IndexedObjectElement___Punc_lbrace__Expression__Punc_colon__Expression__Punc_rbrace (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int IndexedObjectElementList___IndexedObjectElement__Punc_comma__IndexedObjectElementList (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int IndexedObjectElementList___IndexedObjectElement (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int ObjectDefinition___Punc_lbracket__ExpressionList__Punc_rbracket (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int ObjectDefinition___Punc_lbracket__IndexedObjectElementList__Punc_rbracket (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Primary___Constant (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue constant = rhs[0];

            result = constant;

            return 0;
        }

        public override int Primary___Lvalue (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue lvalue = rhs[0];

            result = lvalue;

            return 0;
        }

        public override int Primary___Call (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Primary___ObjectDefinition (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Term___Primary (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue primary = rhs[0];

            result = primary;

            return 0;
        }

        public override int Term___Punc_lparenthesis__Expression__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Term___UnaryModifier__Lvalue (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Term___Lvalue__UnaryModifier (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int ArithmExpressionPrec0___Term (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue term = rhs[0];

            result = term;

            return 0;
        }

        public override int ArithmExpressionPrec0___UnaryOperator__ArithmExpressionPrec0 (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int ArithmExpressionPrec1___ArithmExpressionPrec0 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expr = rhs[0];

            result = expr;

            return 0;
        }

        public override int ArithmExpressionPrec1___ArithmExpressionPrec1__LeftAssociativityBinaryOperatorPrec1__Term (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int ArithmExpressionPrec2___ArithmExpressionPrec1 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expr = rhs[0];

            result = expr;

            return 0;
        }

        public override int ArithmExpressionPrec2___ArithmExpressionPrec2__LeftAssociativityBinaryOperatorPrec2__ArithmExpressionPrec1 (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int RelationalExpressionPrec3___ArithmExpressionPrec2 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expr = rhs[0];

            result = expr;

            return 0;
        }

        public override int RelationalExpressionPrec3___ArithmExpressionPrec2__RelationalBinaryOperatorPrec3__ArithmExpressionPrec2 (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int RelationalExpressionPrec4___RelationalExpressionPrec3 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expr = rhs[0];

            result = expr;

            return 0;
        }

        public override int RelationalExpressionPrec4___RelationalExpressionPrec3__RelationalBinaryOperatorPrec4__RelationalExpressionPrec3 (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int LogicalExpressionPrec5___RelationalExpressionPrec4 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expr = rhs[0];

            result = expr;

            return 0;
        }

        public override int LogicalExpressionPrec6___LogicalExpressionPrec5 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expr = rhs[0];

            result = expr;

            return 0;
        }

        public override int AssignmentExpressionPrec7___LogicalExpressionPrec6 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expr = rhs[0];

            result = expr;

            return 0;
        }

        public override int AssignmentExpressionPrec7___Lvalue__RightAssociativityAssignmentBinaryOperatorPrec7__AssignmentExpressionPrec7 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 3);

            TokenValue lval = rhs[0];
            D.Assert(lval.IsVariable());

            TokenValue expr = rhs[2];

            quads.EmitAssign(1821, lval, expr);


            throw new System.NotImplementedException(); // TODO
            //result = TokenValue.CreateAssignmentExpression(

        }

        public override int Expression___AssignmentExpressionPrec7 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expression = rhs[0];

            result = expression;

            return 0;
        }

        public override int Block___Punc_lbrace__StatementList__Punc_rbrace (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int ReturnStatement___Keyword_return__Punc_semicolon (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int ReturnStatement___Keyword_return__Expression__Punc_semicolon (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int WhileStatement___Keyword_while__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int ForStatement___Keyword_for__Punc_lparenthesis__ExpressionList__Punc_semicolon__Expression__Punc_semicolon__ExpressionList__Punc_rparenthesis__Statement (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement__Keyword_else__Statement (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Statement___Punc_semicolon (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Statement___Keyword_break__Punc_semicolon (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Statement___Keyword_continue__Punc_semicolon (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Statement___Expression__Punc_semicolon (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 2);

            TokenValue expression = rhs[0];
            D.Assert(rhs[1] == null);

            // TODO make a statement token value
            result = expression;

            return 0;
        }

        public override int Statement___Block (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Statement___ReturnStatement (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Statement___WhileStatement (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Statement___ForStatement (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Statement___IfElseStatement (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int StatementList___Statement__StatementList (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int StatementList (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Program___StatementList (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int DecimalIntegerLiteral (out TokenValue result, string lexeme) {
            throw new System.NotImplementedException();
        }

        public override int HexadecimalIntegerLiteral (out TokenValue result, string lexeme) {
            throw new System.NotImplementedException();
        }

        public override int Identifier (out TokenValue result, string lexeme) {
            result = TokenValue.CreateString(lexeme);
            return 0;
        }

        public override int OctalIntegerLiteral (out TokenValue result, string lexeme) {
            throw new System.NotImplementedException();
        }

        public override int StringLiteral (out TokenValue result, string lexeme) {
            string strval = Utilities.String.ParseAlphaString(lexeme);

            result = TokenValue.CreateString(strval);

            return 0;
        }

        public override int Statement___FunctionDefinition (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }



        ///////////////////////////////////////////////////////////////////////



        public override int IdentifierList___Identifier (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);
            result = TokenValue.CreateIdList(rhs[0]);
            return 0;
        }

        public override int IdentifierList___Identifier__Punc_comma__IdentifierList (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 3);
            (result = rhs[2]).AddId(rhs[0]);
            return 0;
        }

        public override int IdentifierList (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 0);
            result = TokenValue.CreateIdList(null);
            return 0;
        }



        ///////////////////////////////////////////////////////////////////////



        public override int ExpressionWithStatementsOpeningWedge (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int ExpressionWithStatementsClosingWedge (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int FunctionStatementOpening___Keyword_function__Punc_lparenthesis__IdentifierList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int FunctionStatementOpening___Keyword_function__Identifier__Punc_lparenthesis__IdentifierList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int FunctionDefinition___FunctionStatementOpening__Block (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int FunctionExpression___FunctionExpressionOpening__FunctionDefinition__FunctionExpressionClosing (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int FunctionExpressionOpening___Punc_lparenthesis__ExpressionWithStatementsOpeningWedge (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int FunctionExpressionClosing___ExpressionWithStatementsClosingWedge__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Call___FunctionExpression__Punc_lparenthesis__ExpressionList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int Primary___FunctionExpression (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }


        public override int LogicalExpressionPrec5___LogicalExpressionPrec5Prefix__RelationalExpressionPrec4 (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }

        public override int LogicalExpressionPrec5Prefix___LogicalExpressionPrec5__LeftAssociativityLogicalBinaryOperatorPrec5 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expression = rhs[0];

            result = expression;

            return 0;
        }

        public override int LogicalExpressionPrec6___LogicalExpressionPrec6Prefix__LogicalExpressionPrec5 (out TokenValue result, TokenValue[] rhs) {
            D.Assert(rhs.Length == 1);

            TokenValue expression = rhs[0];

            result = expression;

            return 0;
        }

        public override int LogicalExpressionPrec6Prefix___LogicalExpressionPrec6__LeftAssociativityLogicalBinaryOperatorPrec6 (out TokenValue result, TokenValue[] rhs) {
            throw new System.NotImplementedException();
        }
    }
}
