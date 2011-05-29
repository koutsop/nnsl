namespace gr.uoc.csd.Alpha.Compilation {

    
    class AlphaQuadManager: AbstractQuadManager {

        public override void EmitAssign (int line, TokenValue lhs, TokenValue rhs) {
            quads.Add(new Quads.Assign(lhs, rhs, null, null, line));
        }


        public AlphaQuadManager () {
            quads = new System.Collections.Generic.List<Quads.Quad>();
        }
        ///////////////////////////////////////////////////////////////////////
        private readonly System.Collections.Generic.IList<Quads.Quad> quads;
    }


}
