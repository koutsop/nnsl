namespace gr.uoc.csd.Alpha.Compilation.SymbolTable {

    using System.Collections.Generic;
    using System.Diagnostics;

    public class SymbolTable {
        private static readonly int GlobalScopeId = 0;

        private class Scope {
            private readonly Dictionary<string, Symbol> symbols = new Dictionary<string, Symbol>();
            private readonly int id;
            private bool hidden = false;

            public Scope (int id) {
                this.id = id;
            }

            public int Id {
                get { return id; }
            }

            public bool Hidden {
                get { return hidden; }
            }

            public bool Global {
                get { return id == GlobalScopeId; }
            }

            public void Hide () {
                Debug.Assert(!hidden);
                foreach (Symbol symbol in symbols.Values)
                    symbol.Deactivate();
            }

            public bool AddUnique (Symbol symbol, out string failureMessage) {
                bool result = false;
                if (!symbols.ContainsKey(symbol.Name)) {
                    symbols.Add(symbol.Name, symbol);
                    result = true;
                    failureMessage = null;
                }
                else {
                    Symbol active = symbols[symbol.Name];
                    failureMessage = active.ToString() + " already in scope " + ToString();
                }
                return result;
            }

            public override System.String ToString () {
                return "scope " + id;
            }

            public bool TryFind (string name, out Symbol result) {
                return symbols.TryGetValue(name, out result);
            }

            public bool Contains (string name) {
                return symbols.ContainsKey(name);
            }

        } // class Scope

        public struct VariableResidenceSpaceOffsets {
            private int program;
            private int local;
            private int formal;

            public int Program {
                get { return program++; }
            }

            public int Local {
                get { return local++; }
            }

            public int Formal {
                get { return formal++; }
            }

            public void ResetLocal () {
                local = 0;
            }

            public void ResetFormal () {
                formal = 0;
            }

            public VariableResidenceSpaceOffsets (int program, int local, int formal) {
                this.program = program;
                this.local = local;
                this.formal = formal;
            }
        } // struct VariableResidenceSpaceOffsets

        public enum ErrorTypeEnumeration: byte {
            Non_existent_global_variable_introduced_in_non_global_scope,
            Formal_argument_redeclared,
            Function_shadows_variable_with_the_same_name_in_scope,
            Symbol_shadows_library_function,
            Library_function_shadows_library_function_with_the_same_name
        }

        public delegate void ErrorCallback (ErrorTypeEnumeration errorType, string symbolName, int line);

        private readonly Scope global = new Scope(0);
        private readonly LinkedList<Scope> scopes = new LinkedList<Scope>();
        private readonly List<LinkedList<Scope>> deadScopes = new List<LinkedList<Scope>>();
        private string failureMessage = "";
        private readonly VariableResidenceSpaceOffsets offsets;
        private int nextScopeId = 1;
        private readonly ErrorCallback errorCallback;

        public SymbolTable (ErrorCallback errorCallback) {
            scopes.AddFirst(global);
            this.errorCallback = errorCallback;
        }

        public string FailureMessage {
            get { return failureMessage; }
        }

        public void IncreaseScope () {
            Debug.Assert(nextScopeId == scopes.First.Value.Id + 1);
            scopes.AddFirst(new Scope(nextScopeId++));
        }

        public void HideScope () {
            --nextScopeId;
            Scope lastScope = scopes.First.Value;
            Debug.Assert(lastScope.Id == nextScopeId);
            scopes.RemoveFirst();

            lastScope.Hide();

            GetDeadScopes(nextScopeId).AddLast(lastScope);
        }

        public void ResetUserFunctionOffsets () {
            offsets.ResetFormal();
            offsets.ResetLocal();
        }

        // ---------------------
        private LinkedList<Scope> GetDeadScopes (int scopeId) {
            LinkedList<Scope> result;
            if (scopeId >= deadScopes.Count) {
                Debug.Assert(scopeId == deadScopes.Count);
                result = new LinkedList<Scope>();
                deadScopes.Add(result);
            }
            else
                result = deadScopes[scopeId];

            return result;
        }

        private Scope CurrentScope {
            get { return scopes.First.Value; }
        }

        private bool CurrentScopeIsGlobal {
            get {
                Scope currentScope = CurrentScope;
                bool isGlobal = currentScope.Global;
                Debug.Assert(!isGlobal || currentScope == global);
                return isGlobal;
            }
        }

        //----------------------------------------------------\\

        private Symbol Lookup (string name) {
            Symbol result = null;
            foreach (Scope scope in scopes)
                if (scope.TryFind(name, out result))
                    break;
            return result;
        }

        private Symbol GlobalLookup (string name) {
            Symbol result = null;
            global.TryFind(name, out result);
            return result;
        }

        private Symbol LocalLookup (string name) {
            Symbol result = null;
            CurrentScope.TryFind(name, out result);
            return result;
        }

        private void Insert (Symbol symbol) {
            Debug.Assert(!CurrentScope.Contains(symbol.Name));
            CurrentScope.AddUnique(symbol, out failureMessage);
        }

        // ---------------------

        private bool IsNotLibraryFunction (string name, int line) {
            Symbol symbol = GlobalLookup(name);
            bool isNotLibraryFunction = symbol == null || symbol.SymbolType != Symbol.SymbolTypeEnumeration.LibraryFunction;
            if (!isNotLibraryFunction)
                errorCallback(ErrorTypeEnumeration.Symbol_shadows_library_function, name, line);
            return isNotLibraryFunction;
        }

        private delegate Symbol Lookupper (string name);
        private delegate bool IsErrorDelegate ();
        private bool LookupOrInsert (
                Lookupper lookup,
                IsErrorDelegate isInsertionError,
                ErrorTypeEnumeration? insertionErrorType,
                IsErrorDelegate isLookupError,
                ErrorTypeEnumeration? lookupErrorType,
                Symbol.VariableResidenceSpaceEnumeration? residenceSpace,
                int offset,
                Symbol.SymbolTypeEnumeration symbolType,
                Symbol.SymbolCharacteriationEnumeration characterisation,
                out Symbol result,
                string name,
                int line) {
            result = lookup(name);
            bool inserted = result == null;
            if (inserted)
                if (isInsertionError()) {
                    errorCallback(insertionErrorType.Value, name, line);
                    inserted = false;
                }
                else
                    Insert(result = new Symbol(residenceSpace, name, offset, line, symbolType, characterisation));

            Debug.Assert(result == null || result.Name.Equals(name) && result.Line.Equals(line));
            return inserted;
        }
        // Error conditions
        private bool Never () { return false; }
        private bool Always () { return true; }
        private bool WhenCurrentScopeIsNotGlobal () { return !CurrentScopeIsGlobal; }

        // ---------------------

        /// <summary>
        /// 
        /// </summary>
        /// <param name="programVariable"></param>
        /// <param name="name"></param>
        /// <param name="line"></param>
        /// <returns>Inserted? (as opposed to look-up-ed)</returns>
        public bool LookupOrInsertProgramVariable (out Symbol programVariable, string name, int line) {
            return LookupOrInsert(
                    lookup : Lookup,
                    isInsertionError : Never,
                    insertionErrorType : null,
                    isLookupError: Never,
                    lookupErrorType: null,
                    residenceSpace : Symbol.VariableResidenceSpaceEnumeration.Program,
                    offset : offsets.Program,
                    symbolType : Symbol.SymbolTypeEnumeration.Variable,
                    characterisation : CurrentScopeIsGlobal ? Symbol.SymbolCharacteriationEnumeration.GlobalVariable : Symbol.SymbolCharacteriationEnumeration.LocalVariable,
                    result: out programVariable,
                    name: name,
                    line: line);
        }

        public bool GlobalLookupOrInsertProgramVariable (out Symbol programVariable, string name, int line) {
            return LookupOrInsert(
                    lookup : GlobalLookup,
                    isInsertionError : WhenCurrentScopeIsNotGlobal,
                    insertionErrorType : ErrorTypeEnumeration.Non_existent_global_variable_introduced_in_non_global_scope,
                    isLookupError: Never,
                    lookupErrorType: null,
                    residenceSpace : Symbol.VariableResidenceSpaceEnumeration.Program,
                    offset : offsets.Program,
                    symbolType : Symbol.SymbolTypeEnumeration.Variable,
                    characterisation : Symbol.SymbolCharacteriationEnumeration.GlobalVariable,
                    result : out programVariable,
                    name : name,
                    line : line);
        }

        public bool LocalLookupOrInsertProgramVariable (out Symbol programVariable, string name, int line) {
            return (IsNotLibraryFunction(name, line) || (programVariable = null) != null) && LookupOrInsert(
                    lookup : LocalLookup,
                    isInsertionError : Never,
                    insertionErrorType : null,
                    isLookupError: Never,
                    lookupErrorType: null,
                    residenceSpace : Symbol.VariableResidenceSpaceEnumeration.Program,
                    offset : offsets.Program,
                    symbolType : Symbol.SymbolTypeEnumeration.Variable,
                    characterisation : CurrentScopeIsGlobal ? Symbol.SymbolCharacteriationEnumeration.GlobalVariable : Symbol.SymbolCharacteriationEnumeration.LocalVariable,
                    result : out programVariable,
                    name : name,
                    line : line);
        }

        // ---------------------

        public bool LookupOrInsertLocalVariable (out Symbol localVariable, string name, int line) {
            Debug.Assert(!CurrentScopeIsGlobal);
            return LookupOrInsert(
                    lookup : Lookup,
                    isInsertionError : Never,
                    insertionErrorType : null,
                    isLookupError: Never,
                    lookupErrorType: null,
                    residenceSpace : Symbol.VariableResidenceSpaceEnumeration.Local,
                    offset : offsets.Local,
                    symbolType : Symbol.SymbolTypeEnumeration.Variable,
                    characterisation : Symbol.SymbolCharacteriationEnumeration.LocalVariable,
                    result : out localVariable,
                    name : name,
                    line : line);
        }

        public bool LocalLookupOrInsertLocalVariable (out Symbol localVariable, string name, int line) {
            Debug.Assert(!CurrentScopeIsGlobal);
            return (IsNotLibraryFunction(name, line) || (localVariable = null) != null) && LookupOrInsert(
                    lookup : LocalLookup,
                    isInsertionError : Never,
                    insertionErrorType : null,
                    isLookupError: Never,
                    lookupErrorType: null,
                    residenceSpace : Symbol.VariableResidenceSpaceEnumeration.Local,
                    offset : offsets.Local,
                    symbolType : Symbol.SymbolTypeEnumeration.Variable,
                    characterisation : Symbol.SymbolCharacteriationEnumeration.LocalVariable,
                    result : out localVariable,
                    name : name,
                    line : line);
        }

        // ---------------------

        public bool InsertFormalArgument (out Symbol formalArgument, string name, int line) {
            Debug.Assert(!CurrentScopeIsGlobal);
            return LookupOrInsert(
                    lookup : LocalLookup,
                    isInsertionError : Never,
                    insertionErrorType : null,
                    isLookupError: Always,
                    lookupErrorType: ErrorTypeEnumeration.Formal_argument_redeclared,
                    residenceSpace : Symbol.VariableResidenceSpaceEnumeration.Formal,
                    offset : offsets.Formal,
                    symbolType : Symbol.SymbolTypeEnumeration.Variable,
                    characterisation : Symbol.SymbolCharacteriationEnumeration.FormalArgument,
                    result : out formalArgument,
                    name : name,
                    line : line);
        }

        // ---------------------

        public bool InsertUserFunction (out Symbol userFunction, string name, int line) {
            return (IsNotLibraryFunction(name, line) || (userFunction = null) != null) && LookupOrInsert(
                    lookup : LocalLookup,
                    isInsertionError : Never,
                    insertionErrorType : null,
                    isLookupError : Always,
                    lookupErrorType : ErrorTypeEnumeration.Function_shadows_variable_with_the_same_name_in_scope,
                    residenceSpace : null,
                    offset : Symbol.InvalidOffset,
                    symbolType : Symbol.SymbolTypeEnumeration.UserFunction,
                    characterisation : CurrentScopeIsGlobal? Symbol.SymbolCharacteriationEnumeration.GlobalUserFunction : Symbol.SymbolCharacteriationEnumeration.LocalUserFunction,
                    result : out userFunction,
                    name : name,
                    line : line);
        }

        // ---------------------

        public bool InsertLibraryFunction (out Symbol libraryFunction, string name) {
            Debug.Assert(CurrentScopeIsGlobal);
            return LookupOrInsert(
                    lookup : Lookup,
                    isInsertionError : Never,
                    insertionErrorType : null,
                    isLookupError : Always,
                    lookupErrorType : ErrorTypeEnumeration.Library_function_shadows_library_function_with_the_same_name,
                    residenceSpace : null,
                    offset : Symbol.InvalidOffset,
                    symbolType : Symbol.SymbolTypeEnumeration.LibraryFunction,
                    characterisation : Symbol.SymbolCharacteriationEnumeration.LibraryFunction,
                    result : out libraryFunction,
                    name : name,
                    line : Symbol.DefaultLibraryFunctionLine);
        }


    }

}

