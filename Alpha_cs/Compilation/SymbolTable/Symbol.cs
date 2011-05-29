namespace gr.uoc.csd.Alpha.Compilation.SymbolTable {

    using System.Diagnostics;

    public class Symbol {

        public enum VariableResidenceSpaceEnumeration {
            Program, Formal, Local
        }
        public enum SymbolTypeEnumeration {
            Variable, UserFunction, LibraryFunction
        }
        public enum SymbolCharacteriationEnumeration {
            LocalVariable, GlobalVariable, LocalUserFunction, GlobalUserFunction, LibraryFunction, FormalArgument
        }

        public static readonly int InvalidOffset = -1;
        public static readonly int DefaultLibraryFunctionLine = -20422;
        public static readonly VariableResidenceSpaceEnumeration? InvalidVariableResidenceSpace = null;

        private bool active = true;
        private readonly VariableResidenceSpaceEnumeration? variableResidence;
        private readonly string name;
        private readonly int offset;
        private readonly int line;
        private readonly SymbolTypeEnumeration symbolType;
        private readonly SymbolCharacteriationEnumeration characterisation;
        private bool initialised = false;
        public Symbol (VariableResidenceSpaceEnumeration? variableResidenceSpace, string name, int offset, int line, SymbolTypeEnumeration symbolType, SymbolCharacteriationEnumeration characterisation) {
            Debug.Assert(characterisation != SymbolCharacteriationEnumeration.FormalArgument ||
                    symbolType == SymbolTypeEnumeration.Variable
                    && variableResidence == VariableResidenceSpaceEnumeration.Formal
                    && offset >= 0
                    && line > 0
                    );
            Debug.Assert(characterisation != SymbolCharacteriationEnumeration.GlobalUserFunction ||
                    symbolType == SymbolTypeEnumeration.UserFunction
                    && variableResidenceSpace == null
                    && offset == InvalidOffset
                    && line > 0
                    );
            Debug.Assert(characterisation != SymbolCharacteriationEnumeration.GlobalVariable ||
                    symbolType == SymbolTypeEnumeration.Variable
                    && variableResidence == VariableResidenceSpaceEnumeration.Program
                    && offset >= 0
                    && line > 0);
            Debug.Assert(characterisation != SymbolCharacteriationEnumeration.LibraryFunction ||
                    symbolType == SymbolTypeEnumeration.LibraryFunction
                    && variableResidence == null
                    && offset == InvalidOffset
                    && line == DefaultLibraryFunctionLine);
            Debug.Assert(characterisation != SymbolCharacteriationEnumeration.LocalUserFunction ||
                    symbolType == SymbolTypeEnumeration.UserFunction
                    && variableResidence == null
                    && offset == InvalidOffset
                    && line > 0
                    );
            Debug.Assert(characterisation != SymbolCharacteriationEnumeration.LocalVariable ||
                    symbolType == SymbolTypeEnumeration.Variable
                    && variableResidence == VariableResidenceSpaceEnumeration.Local
                    && offset >= 0
                    && line > 0
                    );
            this.variableResidence = variableResidenceSpace;
            this.name = name;
            this.offset = offset;
            this.line = line;
            this.symbolType = symbolType;
            this.characterisation = characterisation;
        }

        public VariableResidenceSpaceEnumeration? VariableResidenceSpace {
            get { return variableResidence; }
        }
        public string Name {
            get { return name; }
        }
        public int Offset {
            get { return offset; }
        }
        public int Line {
            get { return line; }
        }
        public SymbolTypeEnumeration SymbolType {
            get { return symbolType; }
        }
        public bool Active {
            get { return active; }
        }
        public SymbolCharacteriationEnumeration Characterisation {
            get { return characterisation; }
        }
        public bool Initialised {
            get { return initialised; }
        }

        public void Deactivate () {
            active = false;
        }

        public void Initialise () {
            initialised = true;
        }

        public override string ToString () {
            return name + ":" + characterisation.ToString() + ":" + line + (active? "": " (hiden)");
        }
    }

}
