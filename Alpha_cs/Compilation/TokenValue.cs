namespace gr.uoc.csd.Alpha.Compilation {


    using System.Diagnostics;
    using System.Collections.Generic;

    public class TokenValue {
        enum Type {
            NumberConstant,
            StringConstant,
            IdList,
            ExpressionList,

            // Expressions
            VariableExpression,
            AssignmentExpression
        }

        public static TokenValue CreateNumber (int numval) {
            return new TokenValue(
                    type: Type.NumberConstant,
                    numval: numval,
                    strval: null,
                    symbol: null);
        }

        public static TokenValue CreateString (string strval) {
            return new TokenValue(
                    type : Type.StringConstant,
                    numval : null,
                    strval : strval,
                    symbol : null);
        }

        public static TokenValue CreateIdList (TokenValue firstval) {
            TokenValue result = new TokenValue(
                    type : Type.IdList,
                    numval : null,
                    strval : null,
                    symbol : null);

            if (firstval != null)
                result.AddId(firstval);

            return result;
        }

        public static TokenValue CreateVariable (SymbolTable.Symbol symbol) {
            return new TokenValue(
                    type : Type.VariableExpression,
                    numval : null,
                    strval : null,
                    symbol: symbol);
        }

        public static TokenValue CreateExpressionList (TokenValue firstval) {
            TokenValue result = new TokenValue(
                    type : Type.ExpressionList,
                    numval : null,
                    strval : null,
                    symbol : null);

            if (firstval != null)
                result.AddExpression(firstval);

            return result;
        }

        public static TokenValue CreateAssignmentExpression (SymbolTable.Symbol resultVariable) {
            return new TokenValue(
                    type : Type.AssignmentExpression,
                    numval : null,
                    strval : null,
                    symbol: resultVariable);
        }
        
        private readonly Type type;

        private readonly int? numval;
        private readonly string strval;
        private readonly LinkedList<TokenValue> idlist;
        private readonly LinkedList<TokenValue> exprlist;
        private readonly SymbolTable.Symbol symbol;

        public int? NumberValue {
            get {
                Debug.Assert(type == Type.NumberConstant);
                Debug.Assert(numval != null);
                return numval;
            }
        }
        public string StringValue {
            get {
                Debug.Assert(type == Type.StringConstant);
                Debug.Assert(strval != null);
                return strval;
            }
        }
        public SymbolTable.Symbol VariableValue {
            get {
                Debug.Assert(type == Type.VariableExpression);
                Debug.Assert(symbol != null);
                return symbol;
            }
        }
        public SymbolTable.Symbol AssignemtnExpressionValue {
            get {
                Debug.Assert(type == Type.AssignmentExpression);
                Debug.Assert(symbol != null);
                return symbol;
            }
        }

        public void AddId (TokenValue id) {
            Debug.Assert(type == Type.IdList);
            Debug.Assert(id.type == Type.VariableExpression);
            idlist.AddFirst(id);
        }

        public void AddExpression (TokenValue expr) {
            Debug.Assert(type == Type.ExpressionList);
            exprlist.AddFirst(expr);
        }


        public bool IsNumber () {
            return type == Type.NumberConstant;
        }
        public bool IsString () {
            return type == Type.StringConstant;
        }
        public bool IsVariable () {
            return type == Type.VariableExpression;
        }
        public bool IsAssignemtnExpression () {
            return type == Type.AssignmentExpression;
        }
        public bool IsVariableExpression () {
            return type == Type.VariableExpression;
        }
        public bool IsIdList () {
            return type == Type.IdList;
        }
        public bool IsExpressionlist () {
            return type == Type.ExpressionList;
        }


        private TokenValue (Type type, int? numval, string strval, SymbolTable.Symbol symbol) {
            this.type = type;
            this.numval = numval;
            this.strval = strval;
            this.symbol = symbol;

            if (type == Type.IdList)
                idlist = new LinkedList<TokenValue>();

            if (type == Type.ExpressionList)
                exprlist = new LinkedList<TokenValue>();
        }

        ////////////////////////////////////////
    }


}
