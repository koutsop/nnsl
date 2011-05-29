using com.calitha.goldparser;
using System.Diagnostics;

namespace gr.uoc.csd.Alpha.Compilation {


    public class AlphaParser {

        private delegate int Manage (out TokenValue result, TokenValue[] rhs);
        private delegate int TerminalManage (out TokenValue result, string lexeme);

        private readonly LALRParser parser;
        private readonly Manage[] manages;
        private readonly TerminalManage[] terminalManages;
        
        public AlphaParser (AbstractParsingManager manager) {
            CGTReader reader = new com.calitha.goldparser.CGTReader("../../groimar.cgt");
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            manages = new Manage[(int)ParserConstants.Rules.SIZE];
            InstallManagings(manager);

            terminalManages = new TerminalManage[5];
            InstallTerminalManagings(manager);

            parser.OnTokenRead += new LALRParser.TokenReadHandler(OnTokenRead);
            parser.OnReduce += new LALRParser.ReduceHandler(OnReduce);
            parser.OnParseError += new LALRParser.ParseErrorHandler(OnError);
        }

        public int Parse (string source) {
            NonterminalToken token = parser.Parse(source);
            Debug.Assert(token.Rule.Id == (int)ParserConstants.Rules.Program___StatementList);
            return 0;
        }

        private void OnTokenRead (LALRParser parser, TokenReadEventArgs args) {
            TokenValue result;
            TerminalToken token = args.Token;
            int id = token.Symbol.Id;
            ParserConstants.Symbols symboldId = (ParserConstants.Symbols)id;
            if (false
                    || symboldId == ParserConstants.Symbols.DecimalIntegerLiteral
                    || symboldId == ParserConstants.Symbols.HexadecimalIntegerLiteral
                    || symboldId == ParserConstants.Symbols.Identifier
                    || symboldId == ParserConstants.Symbols.OctalIntegerLiteral
                    || symboldId == ParserConstants.Symbols.StringLiteral
                )
                terminalManages[TerminalToManageIndex(symboldId)](out result, token.Text);
            else
                result = null;

            args.Token.UserObject = result;
        }

        private void OnReduce (LALRParser parser, ReduceEventArgs args) {
            TokenValue              result;

            int                     id      = args.Rule.Id;
            ParserConstants.Rules   rule_id = (ParserConstants.Rules)id;

            NonterminalToken        token   = args.Token;
            Token[]                 tokens  = token.Tokens;
            int                     length  = tokens.Length;
            TokenValue[]            values  = new TokenValue[length];

            for (int i = 0; i < length; ++i)
                values[i] = (TokenValue) tokens[i].UserObject;

            manages[id](out result, values);

            token.UserObject = result;
        }

        private void OnError (LALRParser parser, ParseErrorEventArgs args) {
        }

        private void InstallManagings (AbstractParsingManager manager) {
            manages[(int)ParserConstants.Rules.NumberConstant___OctalIntegerLiteral] = manager.NumberConstant___OctalIntegerLiteral;
            manages[(int)ParserConstants.Rules.NumberConstant___DecimalIntegerLiteral] = manager.NumberConstant___DecimalIntegerLiteral;
            manages[(int)ParserConstants.Rules.NumberConstant___HexadecimalIntegerLiteral] = manager.NumberConstant___HexadecimalIntegerLiteral;
            manages[(int)ParserConstants.Rules.StringConstant___StringLiteral] = manager.StringConstant___StringLiteral;
            manages[(int)ParserConstants.Rules.BooleanConstant___Keyword_true] = manager.BooleanConstant___Keyword_true;
            manages[(int)ParserConstants.Rules.BooleanConstant___Keyword_false] = manager.BooleanConstant___Keyword_false;
            manages[(int)ParserConstants.Rules.NilConstant___Keyword_nil] = manager.NilConstant___Keyword_nil;
            manages[(int)ParserConstants.Rules.UnaryOperator___Punc_plus] = manager.UnaryOperator___Punc_plus;
            manages[(int)ParserConstants.Rules.UnaryOperator___Punc_minus] = manager.UnaryOperator___Punc_minus;
            manages[(int)ParserConstants.Rules.UnaryOperator___Keyword_not] = manager.UnaryOperator___Keyword_not;
            manages[(int)ParserConstants.Rules.UnaryModifier___Punc_plusplus] = manager.UnaryModifier___Punc_plusplus;
            manages[(int)ParserConstants.Rules.UnaryModifier___Punc_minusminus] = manager.UnaryModifier___Punc_minusminus;
            manages[(int)ParserConstants.Rules.LeftAssociativityBinaryOperatorPrec1___Punc_star] = manager.LeftAssociativityBinaryOperatorPrec1___Punc_star;
            manages[(int)ParserConstants.Rules.LeftAssociativityBinaryOperatorPrec1___Punc_slash] = manager.LeftAssociativityBinaryOperatorPrec1___Punc_slash;
            manages[(int)ParserConstants.Rules.LeftAssociativityBinaryOperatorPrec1___Punc_percent] = manager.LeftAssociativityBinaryOperatorPrec1___Punc_percent;
            manages[(int)ParserConstants.Rules.LeftAssociativityBinaryOperatorPrec2___Punc_plus] = manager.LeftAssociativityBinaryOperatorPrec2___Punc_plus;
            manages[(int)ParserConstants.Rules.LeftAssociativityBinaryOperatorPrec2___Punc_minus] = manager.LeftAssociativityBinaryOperatorPrec2___Punc_minus;
            manages[(int)ParserConstants.Rules.RelationalBinaryOperatorPrec3___Punc_gt] = manager.RelationalBinaryOperatorPrec3___Punc_gt;
            manages[(int)ParserConstants.Rules.RelationalBinaryOperatorPrec3___Punc_ge] = manager.RelationalBinaryOperatorPrec3___Punc_ge;
            manages[(int)ParserConstants.Rules.RelationalBinaryOperatorPrec3___Punc_lt] = manager.RelationalBinaryOperatorPrec3___Punc_lt;
            manages[(int)ParserConstants.Rules.RelationalBinaryOperatorPrec3___Punc_le] = manager.RelationalBinaryOperatorPrec3___Punc_le;
            manages[(int)ParserConstants.Rules.RelationalBinaryOperatorPrec4___Punc_equal] = manager.RelationalBinaryOperatorPrec4___Punc_equal;
            manages[(int)ParserConstants.Rules.RelationalBinaryOperatorPrec4___Punc_not_equal] = manager.RelationalBinaryOperatorPrec4___Punc_not_equal;
            manages[(int)ParserConstants.Rules.LeftAssociativityLogicalBinaryOperatorPrec5___Keyword_and] = manager.LeftAssociativityLogicalBinaryOperatorPrec5___Keyword_and;
            manages[(int)ParserConstants.Rules.LeftAssociativityLogicalBinaryOperatorPrec6___Keyword_or] = manager.LeftAssociativityLogicalBinaryOperatorPrec6___Keyword_or;
            manages[(int)ParserConstants.Rules.RightAssociativityAssignmentBinaryOperatorPrec7___Punc_assign] = manager.RightAssociativityAssignmentBinaryOperatorPrec7___Punc_assign;
            manages[(int)ParserConstants.Rules.ExpressionWithStatementsOpeningWedge] = manager.ExpressionWithStatementsOpeningWedge;
            manages[(int)ParserConstants.Rules.ExpressionWithStatementsClosingWedge] = manager.ExpressionWithStatementsClosingWedge;
            manages[(int)ParserConstants.Rules.Constant___NumberConstant] = manager.Constant___NumberConstant;
            manages[(int)ParserConstants.Rules.Constant___StringConstant] = manager.Constant___StringConstant;
            manages[(int)ParserConstants.Rules.Constant___BooleanConstant] = manager.Constant___BooleanConstant;
            manages[(int)ParserConstants.Rules.Constant___NilConstant] = manager.Constant___NilConstant;
            manages[(int)ParserConstants.Rules.IdentifierList___Identifier] = manager.IdentifierList___Identifier;
            manages[(int)ParserConstants.Rules.IdentifierList___Identifier__Punc_comma__IdentifierList] = manager.IdentifierList___Identifier__Punc_comma__IdentifierList;
            manages[(int)ParserConstants.Rules.IdentifierList] = manager.IdentifierList;
            manages[(int)ParserConstants.Rules.FunctionStatementOpening___Keyword_function__Punc_lparenthesis__IdentifierList__Punc_rparenthesis] = manager.FunctionStatementOpening___Keyword_function__Punc_lparenthesis__IdentifierList__Punc_rparenthesis;
            manages[(int)ParserConstants.Rules.FunctionStatementOpening___Keyword_function__Identifier__Punc_lparenthesis__IdentifierList__Punc_rparenthesis] = manager.FunctionStatementOpening___Keyword_function__Identifier__Punc_lparenthesis__IdentifierList__Punc_rparenthesis;
            manages[(int)ParserConstants.Rules.FunctionDefinition___FunctionStatementOpening__Block] = manager.FunctionDefinition___FunctionStatementOpening__Block;
            manages[(int)ParserConstants.Rules.FunctionExpression___FunctionExpressionOpening__FunctionDefinition__FunctionExpressionClosing] = manager.FunctionExpression___FunctionExpressionOpening__FunctionDefinition__FunctionExpressionClosing;
            manages[(int)ParserConstants.Rules.FunctionExpressionOpening___Punc_lparenthesis__ExpressionWithStatementsOpeningWedge] = manager.FunctionExpressionOpening___Punc_lparenthesis__ExpressionWithStatementsOpeningWedge;
            manages[(int)ParserConstants.Rules.FunctionExpressionClosing___ExpressionWithStatementsClosingWedge__Punc_rparenthesis] = manager.FunctionExpressionClosing___ExpressionWithStatementsClosingWedge__Punc_rparenthesis;
            manages[(int)ParserConstants.Rules.Lvalue___Identifier] = manager.Lvalue___Identifier;
            manages[(int)ParserConstants.Rules.Lvalue___Punc_coloncolon__Identifier] = manager.Lvalue___Punc_coloncolon__Identifier;
            manages[(int)ParserConstants.Rules.Lvalue___Keyword_local__Identifier] = manager.Lvalue___Keyword_local__Identifier;
            manages[(int)ParserConstants.Rules.Lvalue___Member] = manager.Lvalue___Member;
            manages[(int)ParserConstants.Rules.Member___Lvalue__Punc_dot__Identifier] = manager.Member___Lvalue__Punc_dot__Identifier;
            manages[(int)ParserConstants.Rules.Member___Lvalue__Punc_lbracket__Expression__Punc_rbracket] = manager.Member___Lvalue__Punc_lbracket__Expression__Punc_rbracket;
            manages[(int)ParserConstants.Rules.Member___Call__Punc_dot__Identifier] = manager.Member___Call__Punc_dot__Identifier;
            manages[(int)ParserConstants.Rules.Member___Call__Punc_lbracket__Expression__Punc_rbracket] = manager.Member___Call__Punc_lbracket__Expression__Punc_rbracket;
            manages[(int)ParserConstants.Rules.ExpressionList___Expression__ExpressionList2] = manager.ExpressionList___Expression__ExpressionList2;
            manages[(int)ParserConstants.Rules.ExpressionList] = manager.ExpressionList;
            manages[(int)ParserConstants.Rules.ExpressionList2___Punc_comma__Expression__ExpressionList2] = manager.ExpressionList2___Punc_comma__Expression__ExpressionList2;
            manages[(int)ParserConstants.Rules.ExpressionList2] = manager.ExpressionList2;
            manages[(int)ParserConstants.Rules.Call___Call__Punc_lparenthesis__ExpressionList__Punc_rparenthesis] = manager.Call___Call__Punc_lparenthesis__ExpressionList__Punc_rparenthesis;
            manages[(int)ParserConstants.Rules.Call___Lvalue__Punc_lparenthesis__ExpressionList__Punc_rparenthesis] = manager.Call___Lvalue__Punc_lparenthesis__ExpressionList__Punc_rparenthesis;
            manages[(int)ParserConstants.Rules.Call___Lvalue__Punc_dotdot__Identifier__Punc_lparenthesis__ExpressionList__Punc_rparenthesis] = manager.Call___Lvalue__Punc_dotdot__Identifier__Punc_lparenthesis__ExpressionList__Punc_rparenthesis;
            manages[(int)ParserConstants.Rules.Call___FunctionExpression__Punc_lparenthesis__ExpressionList__Punc_rparenthesis] = manager.Call___FunctionExpression__Punc_lparenthesis__ExpressionList__Punc_rparenthesis;
            manages[(int)ParserConstants.Rules.IndexedObjectElement___Punc_lbrace__Expression__Punc_colon__Expression__Punc_rbrace] = manager.IndexedObjectElement___Punc_lbrace__Expression__Punc_colon__Expression__Punc_rbrace;
            manages[(int)ParserConstants.Rules.IndexedObjectElementList___IndexedObjectElement__Punc_comma__IndexedObjectElementList] = manager.IndexedObjectElementList___IndexedObjectElement__Punc_comma__IndexedObjectElementList;
            manages[(int)ParserConstants.Rules.IndexedObjectElementList___IndexedObjectElement] = manager.IndexedObjectElementList___IndexedObjectElement;
            manages[(int)ParserConstants.Rules.ObjectDefinition___Punc_lbracket__ExpressionList__Punc_rbracket] = manager.ObjectDefinition___Punc_lbracket__ExpressionList__Punc_rbracket;
            manages[(int)ParserConstants.Rules.ObjectDefinition___Punc_lbracket__IndexedObjectElementList__Punc_rbracket] = manager.ObjectDefinition___Punc_lbracket__IndexedObjectElementList__Punc_rbracket;
            manages[(int)ParserConstants.Rules.Primary___Constant] = manager.Primary___Constant;
            manages[(int)ParserConstants.Rules.Primary___Lvalue] = manager.Primary___Lvalue;
            manages[(int)ParserConstants.Rules.Primary___FunctionExpression] = manager.Primary___FunctionExpression;
            manages[(int)ParserConstants.Rules.Primary___Call] = manager.Primary___Call;
            manages[(int)ParserConstants.Rules.Primary___ObjectDefinition] = manager.Primary___ObjectDefinition;
            manages[(int)ParserConstants.Rules.Term___Primary] = manager.Term___Primary;
            manages[(int)ParserConstants.Rules.Term___Punc_lparenthesis__Expression__Punc_rparenthesis] = manager.Term___Punc_lparenthesis__Expression__Punc_rparenthesis;
            manages[(int)ParserConstants.Rules.Term___UnaryModifier__Lvalue] = manager.Term___UnaryModifier__Lvalue;
            manages[(int)ParserConstants.Rules.Term___Lvalue__UnaryModifier] = manager.Term___Lvalue__UnaryModifier;
            manages[(int)ParserConstants.Rules.ArithmExpressionPrec0___Term] = manager.ArithmExpressionPrec0___Term;
            manages[(int)ParserConstants.Rules.ArithmExpressionPrec0___UnaryOperator__ArithmExpressionPrec0] = manager.ArithmExpressionPrec0___UnaryOperator__ArithmExpressionPrec0;
            manages[(int)ParserConstants.Rules.ArithmExpressionPrec1___ArithmExpressionPrec0] = manager.ArithmExpressionPrec1___ArithmExpressionPrec0;
            manages[(int)ParserConstants.Rules.ArithmExpressionPrec1___ArithmExpressionPrec1__LeftAssociativityBinaryOperatorPrec1__Term] = manager.ArithmExpressionPrec1___ArithmExpressionPrec1__LeftAssociativityBinaryOperatorPrec1__Term;
            manages[(int)ParserConstants.Rules.ArithmExpressionPrec2___ArithmExpressionPrec1] = manager.ArithmExpressionPrec2___ArithmExpressionPrec1;
            manages[(int)ParserConstants.Rules.ArithmExpressionPrec2___ArithmExpressionPrec2__LeftAssociativityBinaryOperatorPrec2__ArithmExpressionPrec1] = manager.ArithmExpressionPrec2___ArithmExpressionPrec2__LeftAssociativityBinaryOperatorPrec2__ArithmExpressionPrec1;
            manages[(int)ParserConstants.Rules.RelationalExpressionPrec3___ArithmExpressionPrec2] = manager.RelationalExpressionPrec3___ArithmExpressionPrec2;
            manages[(int)ParserConstants.Rules.RelationalExpressionPrec3___ArithmExpressionPrec2__RelationalBinaryOperatorPrec3__ArithmExpressionPrec2] = manager.RelationalExpressionPrec3___ArithmExpressionPrec2__RelationalBinaryOperatorPrec3__ArithmExpressionPrec2;
            manages[(int)ParserConstants.Rules.RelationalExpressionPrec4___RelationalExpressionPrec3] = manager.RelationalExpressionPrec4___RelationalExpressionPrec3;
            manages[(int)ParserConstants.Rules.RelationalExpressionPrec4___RelationalExpressionPrec3__RelationalBinaryOperatorPrec4__RelationalExpressionPrec3] = manager.RelationalExpressionPrec4___RelationalExpressionPrec3__RelationalBinaryOperatorPrec4__RelationalExpressionPrec3;
            manages[(int)ParserConstants.Rules.LogicalExpressionPrec5___RelationalExpressionPrec4] = manager.LogicalExpressionPrec5___RelationalExpressionPrec4;
            manages[(int)ParserConstants.Rules.LogicalExpressionPrec5___LogicalExpressionPrec5Prefix__RelationalExpressionPrec4] = manager.LogicalExpressionPrec5___LogicalExpressionPrec5Prefix__RelationalExpressionPrec4;
            manages[(int)ParserConstants.Rules.LogicalExpressionPrec5Prefix___LogicalExpressionPrec5__LeftAssociativityLogicalBinaryOperatorPrec5] = manager.LogicalExpressionPrec5Prefix___LogicalExpressionPrec5__LeftAssociativityLogicalBinaryOperatorPrec5;
            manages[(int)ParserConstants.Rules.LogicalExpressionPrec6___LogicalExpressionPrec5] = manager.LogicalExpressionPrec6___LogicalExpressionPrec5;
            manages[(int)ParserConstants.Rules.LogicalExpressionPrec6___LogicalExpressionPrec6Prefix__LogicalExpressionPrec5] = manager.LogicalExpressionPrec6___LogicalExpressionPrec6Prefix__LogicalExpressionPrec5;
            manages[(int)ParserConstants.Rules.LogicalExpressionPrec6Prefix___LogicalExpressionPrec6__LeftAssociativityLogicalBinaryOperatorPrec6] = manager.LogicalExpressionPrec6Prefix___LogicalExpressionPrec6__LeftAssociativityLogicalBinaryOperatorPrec6;
            manages[(int)ParserConstants.Rules.AssignmentExpressionPrec7___LogicalExpressionPrec6] = manager.AssignmentExpressionPrec7___LogicalExpressionPrec6;
            manages[(int)ParserConstants.Rules.AssignmentExpressionPrec7___Lvalue__RightAssociativityAssignmentBinaryOperatorPrec7__AssignmentExpressionPrec7] = manager.AssignmentExpressionPrec7___Lvalue__RightAssociativityAssignmentBinaryOperatorPrec7__AssignmentExpressionPrec7;
            manages[(int)ParserConstants.Rules.Expression___AssignmentExpressionPrec7] = manager.Expression___AssignmentExpressionPrec7;
            manages[(int)ParserConstants.Rules.Block___Punc_lbrace__StatementList__Punc_rbrace] = manager.Block___Punc_lbrace__StatementList__Punc_rbrace;
            manages[(int)ParserConstants.Rules.ReturnStatement___Keyword_return__Punc_semicolon] = manager.ReturnStatement___Keyword_return__Punc_semicolon;
            manages[(int)ParserConstants.Rules.ReturnStatement___Keyword_return__Expression__Punc_semicolon] = manager.ReturnStatement___Keyword_return__Expression__Punc_semicolon;
            manages[(int)ParserConstants.Rules.WhileStatement___Keyword_while__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement] = manager.WhileStatement___Keyword_while__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement;
            manages[(int)ParserConstants.Rules.ForStatement___Keyword_for__Punc_lparenthesis__ExpressionList__Punc_semicolon__Expression__Punc_semicolon__ExpressionList__Punc_rparenthesis__Statement] = manager.ForStatement___Keyword_for__Punc_lparenthesis__ExpressionList__Punc_semicolon__Expression__Punc_semicolon__ExpressionList__Punc_rparenthesis__Statement;
            manages[(int)ParserConstants.Rules.IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement] = manager.IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement;
            manages[(int)ParserConstants.Rules.IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement__Keyword_else__Statement] = manager.IfElseStatement___Keyword_if__Punc_lparenthesis__Expression__Punc_rparenthesis__Statement__Keyword_else__Statement;
            manages[(int)ParserConstants.Rules.Statement___Punc_semicolon] = manager.Statement___Punc_semicolon;
            manages[(int)ParserConstants.Rules.Statement___Keyword_break__Punc_semicolon] = manager.Statement___Keyword_break__Punc_semicolon;
            manages[(int)ParserConstants.Rules.Statement___Keyword_continue__Punc_semicolon] = manager.Statement___Keyword_continue__Punc_semicolon;
            manages[(int)ParserConstants.Rules.Statement___Expression__Punc_semicolon] = manager.Statement___Expression__Punc_semicolon;
            manages[(int)ParserConstants.Rules.Statement___Block] = manager.Statement___Block;
            manages[(int)ParserConstants.Rules.Statement___ReturnStatement] = manager.Statement___ReturnStatement;
            manages[(int)ParserConstants.Rules.Statement___WhileStatement] = manager.Statement___WhileStatement;
            manages[(int)ParserConstants.Rules.Statement___ForStatement] = manager.Statement___ForStatement;
            manages[(int)ParserConstants.Rules.Statement___IfElseStatement] = manager.Statement___IfElseStatement;
            manages[(int)ParserConstants.Rules.Statement___FunctionDefinition] = manager.Statement___FunctionDefinition;
            manages[(int)ParserConstants.Rules.StatementList___Statement__StatementList] = manager.StatementList___Statement__StatementList;
            manages[(int)ParserConstants.Rules.StatementList] = manager.StatementList;
            manages[(int)ParserConstants.Rules.Program___StatementList] = manager.Program___StatementList;
        }
        private void InstallTerminalManagings (AbstractParsingManager manager) {
            terminalManages[TerminalToManageIndex(ParserConstants.Symbols.DecimalIntegerLiteral)] = manager.DecimalIntegerLiteral;
            terminalManages[TerminalToManageIndex(ParserConstants.Symbols.HexadecimalIntegerLiteral)] = manager.HexadecimalIntegerLiteral;
            terminalManages[TerminalToManageIndex(ParserConstants.Symbols.Identifier)] = manager.Identifier;
            terminalManages[TerminalToManageIndex(ParserConstants.Symbols.OctalIntegerLiteral)] = manager.OctalIntegerLiteral;
            terminalManages[TerminalToManageIndex(ParserConstants.Symbols.StringLiteral)] = manager.StringLiteral;
        }
        private int TerminalToManageIndex (ParserConstants.Symbols terminal) {
            int result = -1;
            switch (terminal) {
                case ParserConstants.Symbols.DecimalIntegerLiteral:
                    result = 0;
                    break;
                case ParserConstants.Symbols.HexadecimalIntegerLiteral:
                    result = 1;
                    break;
                case ParserConstants.Symbols.Identifier:
                    result = 2;
                    break;
                case ParserConstants.Symbols.OctalIntegerLiteral:
                    result = 3;
                    break;
                case ParserConstants.Symbols.StringLiteral:
                    result = 4;
                    break;
            }
            return result;
        }
    }


}
