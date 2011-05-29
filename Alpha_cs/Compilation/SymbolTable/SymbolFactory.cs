namespace gr.uoc.csd.Alpha.Compilation.SymbolTable {

    public static class SymbolFactory {
        public static Symbol CreateLibraryFunction (string name) {
            return new Symbol(
                variableResidenceSpace: Symbol.InvalidVariableResidenceSpace,
                name: name,
                offset: Symbol.InvalidOffset,
                line: Symbol.DefaultLibraryFunctionLine,
                symbolType: Symbol.SymbolTypeEnumeration.LibraryFunction,
                characterisation: Symbol.SymbolCharacteriationEnumeration.LibraryFunction);
        }

        public static Symbol CreateGlobalUserFunction (string name, int line) {
            return new Symbol(
                variableResidenceSpace: Symbol.InvalidVariableResidenceSpace,
                name: name,
                offset: Symbol.InvalidOffset,
                line: line,
                symbolType: Symbol.SymbolTypeEnumeration.UserFunction,
                characterisation: Symbol.SymbolCharacteriationEnumeration.GlobalUserFunction);
        }

        public static Symbol CreateLocalUserFunction (string name, int scope, int line) {
            return new Symbol(
                variableResidenceSpace: Symbol.InvalidVariableResidenceSpace,
                name: name,
                offset: Symbol.InvalidOffset,
                line: line,
                symbolType: Symbol.SymbolTypeEnumeration.UserFunction,
                characterisation: Symbol.SymbolCharacteriationEnumeration.LocalUserFunction);
        }

        public static Symbol CreateFormalArgument (string name, int scope, int offset, int line) {
            return new Symbol(
                variableResidenceSpace: Symbol.VariableResidenceSpaceEnumeration.Formal,
                name: name,
                offset: offset,
                line: line,
                symbolType: Symbol.SymbolTypeEnumeration.Variable,
                characterisation: Symbol.SymbolCharacteriationEnumeration.FormalArgument);
        }

        public static Symbol CreateLocalVariable (string name, int scope, int offset, int line) {
            return new Symbol(
                variableResidenceSpace: Symbol.VariableResidenceSpaceEnumeration.Local,
                name: name,
                offset: offset,
                line: line,
                symbolType: Symbol.SymbolTypeEnumeration.Variable,
                characterisation: Symbol.SymbolCharacteriationEnumeration.LocalVariable);
        }

        public static Symbol CreateGlobalVariable (string name, int scope, int offset, int line) {
            return new Symbol(
                variableResidenceSpace: Symbol.VariableResidenceSpaceEnumeration.Program,
                name: name,
                offset: offset,
                line: line,
                symbolType: Symbol.SymbolTypeEnumeration.Variable,
                characterisation: Symbol.SymbolCharacteriationEnumeration.GlobalVariable);
        }
    }

}
