namespace gr.uoc.csd.Alpha.Compilation.Quads {

    
    class Quad {
        private readonly TokenValue result;
        private readonly TokenValue arg1;
        private readonly TokenValue arg2;
        private readonly int?       label;
        private readonly int        line;

        protected Quad (TokenValue result, TokenValue arg1, TokenValue arg2, int? label, int line) {
            this.result = result;
            this.arg1   = arg1;
            this.arg2   = arg2;
            this.label  = label;
            this.line   = line;
        }
    }


}
