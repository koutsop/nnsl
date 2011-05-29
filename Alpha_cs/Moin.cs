
namespace gr.uoc.csd.Alpha {

    public static class Moin {

        private static void SymbolTableErrorCallback (Alpha.Compilation.SymbolTable.SymbolTable.ErrorTypeEnumeration errorType, string name, int line) {
            throw new System.Exception();
        }

        public static void Main (string[] args) {

            Alpha.Compilation.Quads.AbstractQuadManager quadManager = new Alpha.Compilation.Quads.AlphaQuadManager();
            Alpha.Compilation.SymbolTable.SymbolTable symbolTable = new Compilation.SymbolTable.SymbolTable(SymbolTableErrorCallback);
            Alpha.Compilation.Parsing.AbstractParsingManager
                    quadParsingManager = new Alpha.Compilation.Parsing.AlphaQuadParsingManager(quadManager, symbolTable),
                    astParsingManager = new Alpha.Compilation.Parsing.AlphaASTParsingManager(),
//                    manager = new Alpha.Compilation.AlphaParsingManager(quadParsingManager, astParsingManager);
                    manager = quadParsingManager;
            Alpha.Compilation.AlphaParser parser = new Alpha.Compilation.AlphaParser(manager);

            parser.Parse(AlphaPrograms.autolookup0);

        }

    }

}
