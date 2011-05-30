namespace gr.uoc.csd.Alpha.Compilation.Parsing {

    using System.Collections.Generic;
    using E = System.Linq.Enumerable;
    using D = System.Diagnostics.Debug;

    public abstract class AbstractParsingManager {

        private class SpecialScopeManager {
            public class LoopScopeSpace { }
            public class ForLoopScopeSpace : LoopScopeSpace { }
            public class WhileLoopScopeSpace : LoopScopeSpace { }

            public class FunctionScopeSpace {
                public static readonly int InvalidAvril = -1;

                private readonly string name;
                private readonly int line;
                private readonly int lastAvrilInContainingExpression;
                private bool inBody = false;
                private int loopsDepth = 0;

                public string Name { get { return name; } }
                public int Line { get { return line; } }
                public bool InBody { get { return inBody; } }
                public int LoopsDepth { get { return loopsDepth; } }
                public bool IsExpressionFunction { get { return lastAvrilInContainingExpression >= 0; } }
                public int LastAvril { get { D.Assert(IsExpressionFunction); return lastAvrilInContainingExpression; } }
                

                public FunctionScopeSpace (string name, int line, int lastAvrilInContainingExpression) {
                    this.name = name;
                    this.line = line;
                    this.lastAvrilInContainingExpression = lastAvrilInContainingExpression;
                }

                public void EnteringBody () {
                    D.Assert(!inBody);
                    inBody = true;
                }

                public void EnteringLoop () {
                    ++loopsDepth;
                }

                public void ExitingLoop () {
                    --loopsDepth;
                }
            }

            private readonly LinkedList<object> stack = new LinkedList<object>();
            private FunctionScopeSpace topFunction;
            private LoopScopeSpace topLoop;
            private FunctionScopeSpace containingFunction;

            private bool Invariants {
                get {
                    return true
                        && (stack.Count != 0 || topFunction == null && topLoop == null)
                        && (!(topFunction == null && topLoop == null) || stack.Count == 0)

                        && (topFunction == null || stack.Count > 0 && stack.Last.Value is FunctionScopeSpace)
                        && (topLoop == null || stack.Count > 0 && stack.Last.Value is LoopScopeSpace)
                        && (!(stack.Count > 0 && stack.Last.Value is FunctionScopeSpace) || topFunction != null && topLoop == null)
                        && (!(stack.Count > 0 && stack.Last.Value is LoopScopeSpace) || topFunction == null && topLoop != null)

                        && (!(topFunction != null && topLoop != null))

                        && (topFunction == null || containingFunction == topFunction)
                        && (containingFunction == null || stack.Count > 0 && E.Last(stack, o => o is FunctionScopeSpace) == containingFunction)
                        && (containingFunction != null || stack.Count == 0 || !E.Any(stack, o => o is FunctionScopeSpace))
                        && (containingFunction != null || topFunction == null)
                        ;
                }
            }

            private void PopStack () {
                stack.RemoveLast();

                if (stack.Count > 0) {
                    object last = stack.Last.Value;
                    topFunction = last as FunctionScopeSpace;
                    if (topFunction == null)
                        topLoop = last as LoopScopeSpace;
                    else
                        containingFunction = topFunction;
                }
                else {
                    containingFunction = null;
                    topFunction = null;
                    topLoop = null;
                }
            }

            private void EnteringLoop () {
                D.Assert(Invariants);
                D.Assert(stack.Count == 0 || topLoop != null || topFunction != null && topFunction.InBody);

                if (containingFunction != null)
                    containingFunction.EnteringLoop();

                topLoop = new LoopScopeSpace();
                topFunction = null;
                stack.AddLast(topLoop);

                D.Assert(Invariants);
            }
            
            private void EnteringFunction (string name, int line, int lastAvril) {
                D.Assert(Invariants);
                D.Assert(stack.Count == 0 || topLoop != null || topFunction != null && topFunction.InBody);

                containingFunction = new FunctionScopeSpace(name, line, lastAvril);
                topFunction = containingFunction;
                topLoop = null;
                stack.AddLast(topFunction);

                D.Assert(Invariants);
            }

            public bool InFunction { get { D.Assert(Invariants); return containingFunction != null; } }

            public void EnteringStatementFunction (string name, int line) {
                EnteringFunction(name, line, FunctionScopeSpace.InvalidAvril);
            }

            public void EnteringExpressionFunction (string name, int line, int lastAvrilInContainingExpression) {
                EnteringFunction(name, line, lastAvrilInContainingExpression);
            }

            public void EnteringFunctionBody () {
                D.Assert(Invariants);
                D.Assert(topFunction != null && !topFunction.InBody);

                topFunction.EnteringBody();

                D.Assert(Invariants);
            }

            public void ExitingFunction () {
                D.Assert(Invariants);
                D.Assert(topFunction != null && topFunction.InBody);

                PopStack();

                D.Assert(Invariants);
            }

            public void EnteringForLoop () {
                EnteringLoop();
            }

            public void EnteringWhileLoop () {
                EnteringLoop();
            }

            public void ExitingLoop () {
                D.Assert(Invariants);
                D.Assert(topLoop != null);

                if (containingFunction != null)
                    containingFunction.ExitingLoop();

                PopStack();

                D.Assert(Invariants);
            }

        }

        private class AvrilVariableManager {
            private readonly string prefix;
            private int nextId = 0;

            public AvrilVariableManager (string prefix) {
                this.prefix = prefix;
            }

            public string NextId { get { return prefix + nextId++.ToString(); } }

            public void Reset () {
                nextId = 0;
            }
        }

        private readonly SpecialScopeManager specialScopesManager;
        private readonly AvrilVariableManager avril;

        protected AbstractParsingManager (string avrilPrefix) {
            specialScopesManager = new SpecialScopeManager();
            avril = new AvrilVariableManager(avrilPrefix);
        }

        protected bool InFunction { get { return specialScopesManager.InFunction; } }

        // Teminals
        public abstract int DecimalIntegerLiteral (out TokenValue result, string lexeme);
        public abstract int HexadecimalIntegerLiteral (out TokenValue result, string lexeme);
        public abstract int Identifier (out TokenValue result, string lexeme);
        public abstract int OctalIntegerLiteral (out TokenValue result, string lexeme);
        public abstract int StringLiteral (out TokenValue result, string lexeme);

        // Rules
        public abstract int NumberConstant___OctalIntegerLiteral (out TokenValue result, TokenValue[] rhs);
        public abstract int NumberConstant___DecimalIntegerLiteral (out TokenValue result, TokenValue[] rhs);
        public abstract int NumberConstant___HexadecimalIntegerLiteral (out TokenValue result, TokenValue[] rhs);
        public abstract int StringConstant___StringLiteral (out TokenValue result, TokenValue[] rhs);
        public abstract int BooleanConstant___Keyword_true (out TokenValue result, TokenValue[] rhs);
        public abstract int BooleanConstant___Keyword_false (out TokenValue result, TokenValue[] rhs);
        public abstract int NilConstant___Keyword_nil (out TokenValue result, TokenValue[] rhs);
        public abstract int UnaryOperator___Punc_plus (out TokenValue result, TokenValue[] rhs);
        public abstract int UnaryOperator___Punc_minus (out TokenValue result, TokenValue[] rhs);
        public abstract int UnaryOperator___Keyword_not (out TokenValue result, TokenValue[] rhs);
        public abstract int UnaryModifier___Punc_plusplus (out TokenValue result, TokenValue[] rhs);
        public abstract int UnaryModifier___Punc_minusminus (out TokenValue result, TokenValue[] rhs);
        public abstract int LeftAssociativityBinaryOperatorPrec1___Punc_star (out TokenValue result, TokenValue[] rhs);
        public abstract int LeftAssociativityBinaryOperatorPrec1___Punc_slash (out TokenValue result, TokenValue[] rhs);
        public abstract int LeftAssociativityBinaryOperatorPrec1___Punc_percent (out TokenValue result, TokenValue[] rhs);
        public abstract int LeftAssociativityBinaryOperatorPrec2___Punc_plus (out TokenValue result, TokenValue[] rhs);
        public abstract int LeftAssociativityBinaryOperatorPrec2___Punc_minus (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalBinaryOperatorPrec3___Punc_gt (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalBinaryOperatorPrec3___Punc_ge (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalBinaryOperatorPrec3___Punc_lt (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalBinaryOperatorPrec3___Punc_le (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalBinaryOperatorPrec4___Punc_equal (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalBinaryOperatorPrec4___Punc_not_equal (out TokenValue result, TokenValue[] rhs);
        public abstract int LeftAssociativityLogicalBinaryOperatorPrec5___Keyword_and (out TokenValue result, TokenValue[] rhs);
        public abstract int LeftAssociativityLogicalBinaryOperatorPrec6___Keyword_or (out TokenValue result, TokenValue[] rhs);
        public abstract int RightAssociativityAssignmentBinaryOperatorPrec7___Punc_assign (out TokenValue result, TokenValue[] rhs);
        public abstract int ExpressionWithStatementsOpeningWedge (out TokenValue result, TokenValue[] rhs);
        public abstract int ExpressionWithStatementsClosingWedge (out TokenValue result, TokenValue[] rhs);
        public abstract int Constant___NumberConstant (out TokenValue result, TokenValue[] rhs);
        public abstract int Constant___StringConstant (out TokenValue result, TokenValue[] rhs);
        public abstract int Constant___BooleanConstant (out TokenValue result, TokenValue[] rhs);
        public abstract int Constant___NilConstant (out TokenValue result, TokenValue[] rhs);
        public abstract int IdentifierList___Identifier (out TokenValue result, TokenValue[] rhs);
        public abstract int IdentifierList___Identifier__Punc_comma__IdentifierList (out TokenValue result, TokenValue[] rhs);
        public abstract int IdentifierList (out TokenValue result, TokenValue[] rhs);
        public abstract int FunctionStatementOpening___Keyword_function__Punc_lparenthesis__IdentifierList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs);
        public abstract int FunctionStatementOpening___Keyword_function__Identifier__Punc_lparenthesis__IdentifierList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs);
        public abstract int FunctionDefinition___FunctionStatementOpening__Block (out TokenValue result, TokenValue[] rhs);
        public abstract int FunctionExpression___FunctionExpressionOpening__FunctionDefinition__FunctionExpressionClosing (out TokenValue result, TokenValue[] rhs);
        public abstract int FunctionExpressionOpening___Punc_lparenthesis__ExpressionWithStatementsOpeningWedge (out TokenValue result, TokenValue[] rhs);
        public abstract int FunctionExpressionClosing___ExpressionWithStatementsClosingWedge__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs);
        public abstract int Lvalue___Identifier (out TokenValue result, TokenValue[] rhs);
        public abstract int Lvalue___Punc_coloncolon__Identifier (out TokenValue result, TokenValue[] rhs);
        public abstract int Lvalue___Keyword_local__Identifier (out TokenValue result, TokenValue[] rhs);
        public abstract int Lvalue___Member (out TokenValue result, TokenValue[] rhs);
        public abstract int Member___Lvalue__Punc_dot__Identifier (out TokenValue result, TokenValue[] rhs);
        public abstract int Member___Lvalue__Punc_lbracket__Expression__Punc_rbracket (out TokenValue result, TokenValue[] rhs);
        public abstract int Member___Call__Punc_dot__Identifier (out TokenValue result, TokenValue[] rhs);
        public abstract int Member___Call__Punc_lbracket__Expression__Punc_rbracket (out TokenValue result, TokenValue[] rhs);
        public abstract int ExpressionList___Expression__ExpressionList2 (out TokenValue result, TokenValue[] rhs);
        public abstract int ExpressionList (out TokenValue result, TokenValue[] rhs);
        public abstract int ExpressionList2___Punc_comma__Expression__ExpressionList2 (out TokenValue result, TokenValue[] rhs);
        public abstract int ExpressionList2 (out TokenValue result, TokenValue[] rhs);
        public abstract int Call___Call__Punc_lparenthesis__ExpressionList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs);
        public abstract int Call___Lvalue__Punc_lparenthesis__ExpressionList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs);
        public abstract int Call___Lvalue__Punc_dotdot__Identifier__Punc_lparenthesis__ExpressionList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs);
        public abstract int Call___FunctionExpression__Punc_lparenthesis__ExpressionList__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs);
        public abstract int IndexedObjectElement___Punc_lbrace__Expression__Punc_colon__Expression__Punc_rbrace (out TokenValue result, TokenValue[] rhs);
        public abstract int IndexedObjectElementList___IndexedObjectElement__Punc_comma__IndexedObjectElementList (out TokenValue result, TokenValue[] rhs);
        public abstract int IndexedObjectElementList___IndexedObjectElement (out TokenValue result, TokenValue[] rhs);
        public abstract int ObjectDefinition___Punc_lbracket__ExpressionList__Punc_rbracket (out TokenValue result, TokenValue[] rhs);
        public abstract int ObjectDefinition___Punc_lbracket__IndexedObjectElementList__Punc_rbracket (out TokenValue result, TokenValue[] rhs);
        public abstract int Primary___Constant (out TokenValue result, TokenValue[] rhs);
        public abstract int Primary___Lvalue (out TokenValue result, TokenValue[] rhs);
        public abstract int Primary___FunctionExpression (out TokenValue result, TokenValue[] rhs);
        public abstract int Primary___Call (out TokenValue result, TokenValue[] rhs);
        public abstract int Primary___ObjectDefinition (out TokenValue result, TokenValue[] rhs);
        public abstract int Term___Primary (out TokenValue result, TokenValue[] rhs);
        public abstract int Term___Punc_lparenthesis__Expression__Punc_rparenthesis (out TokenValue result, TokenValue[] rhs);
        public abstract int Term___UnaryModifier__Lvalue (out TokenValue result, TokenValue[] rhs);
        public abstract int Term___Lvalue__UnaryModifier (out TokenValue result, TokenValue[] rhs);
        public abstract int ArithmExpressionPrec0___Term (out TokenValue result, TokenValue[] rhs);
        public abstract int ArithmExpressionPrec0___UnaryOperator__ArithmExpressionPrec0 (out TokenValue result, TokenValue[] rhs);
        public abstract int ArithmExpressionPrec1___ArithmExpressionPrec0 (out TokenValue result, TokenValue[] rhs);
        public abstract int ArithmExpressionPrec1___ArithmExpressionPrec1__LeftAssociativityBinaryOperatorPrec1__Term (out TokenValue result, TokenValue[] rhs);
        public abstract int ArithmExpressionPrec2___ArithmExpressionPrec1 (out TokenValue result, TokenValue[] rhs);
        public abstract int ArithmExpressionPrec2___ArithmExpressionPrec2__LeftAssociativityBinaryOperatorPrec2__ArithmExpressionPrec1 (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalExpressionPrec3___ArithmExpressionPrec2 (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalExpressionPrec3___ArithmExpressionPrec2__RelationalBinaryOperatorPrec3__ArithmExpressionPrec2 (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalExpressionPrec4___RelationalExpressionPrec3 (out TokenValue result, TokenValue[] rhs);
        public abstract int RelationalExpressionPrec4___RelationalExpressionPrec3__RelationalBinaryOperatorPrec4__RelationalExpressionPrec3 (out TokenValue result, TokenValue[] rhs);
        public abstract int LogicalExpressionPrec5___RelationalExpressionPrec4 (out TokenValue result, TokenValue[] rhs);
        public abstract int LogicalExpressionPrec5___LogicalExpressionPrec5Prefix__RelationalExpressionPrec4 (out TokenValue result, TokenValue[] rhs);
        public abstract int LogicalExpressionPrec5Prefix___LogicalExpressionPrec5__LeftAssociativityLogicalBinaryOperatorPrec5 (out TokenValue result, TokenValue[] rhs);
        public abstract int LogicalExpressionPrec6___LogicalExpressionPrec5 (out TokenValue result, TokenValue[] rhs);
        public abstract int LogicalExpressionPrec6___LogicalExpressionPrec6Prefix__LogicalExpressionPrec5 (out TokenValue result, TokenValue[] rhs);
        public abstract int LogicalExpressionPrec6Prefix___LogicalExpressionPrec6__LeftAssociativityLogicalBinaryOperatorPrec6 (out TokenValue result, TokenValue[] rhs);
        public abstract int AssignmentExpressionPrec7___LogicalExpressionPrec6 (out TokenValue result, TokenValue[] rhs);
        public abstract int AssignmentExpressionPrec7___Lvalue__RightAssociativityAssignmentBinaryOperatorPrec7__AssignmentExpressionPrec7 (out TokenValue result, TokenValue[] rhs);
        public abstract int Expression___AssignmentExpressionPrec7 (out TokenValue result, TokenValue[] rhs);
        public abstract int Block___Punc_lbrace__StatementList__Punc_rbrace (out TokenValue result, TokenValue[] rhs);
        public abstract int ReturnStatement___Keyword_return__Punc_semicolon (out TokenValue result, TokenValue[] rhs);
        public abstract int ReturnStatement___Keyword_return__Expression__Punc_semicolon (out TokenValue result, TokenValue[] rhs);
        public abstract int WhileStatement___Keyword_while__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement (out TokenValue result, TokenValue[] rhs);
        public abstract int ForStatement___Keyword_for__Punc_lparenthesis__ExpressionList__Punc_semicolon__Expression__Punc_semicolon__ExpressionList__Punc_rparenthesis__Statement (out TokenValue result, TokenValue[] rhs);
        public abstract int IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement (out TokenValue result, TokenValue[] rhs);
        public abstract int IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement__Keyword_else__Statement (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___Punc_semicolon (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___Keyword_break__Punc_semicolon (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___Keyword_continue__Punc_semicolon (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___Expression__Punc_semicolon (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___Block (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___ReturnStatement (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___WhileStatement (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___ForStatement (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___IfElseStatement (out TokenValue result, TokenValue[] rhs);
        public abstract int Statement___FunctionDefinition (out TokenValue result, TokenValue[] rhs);
        public abstract int StatementList___Statement__StatementList (out TokenValue result, TokenValue[] rhs);
        public abstract int StatementList (out TokenValue result, TokenValue[] rhs);
        public abstract int Program___StatementList (out TokenValue result, TokenValue[] rhs);

    }

}
