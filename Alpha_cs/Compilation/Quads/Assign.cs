namespace gr.uoc.csd.Alpha.Compilation.Quads {

    class Assign: Quad {

        internal Assign (TokenValue result, TokenValue arg1, TokenValue arg2, int? label, int line)
            : base(result, arg1, arg2, label, line) {
            
        }
    }

}
