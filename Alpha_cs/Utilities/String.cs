
namespace gr.uoc.csd.Alpha.Utilities {

    
    public static class String {

        public static string ParseAlphaString (string original) {
            string[] _tokens = original.Split('\\');
            System.Collections.Generic.LinkedList<string> tokens = new System.Collections.Generic.LinkedList<string>(_tokens);

            System.Text.StringBuilder b = new System.Text.StringBuilder(original.Length);
            b.Append(tokens.First.Value);
            tokens.RemoveFirst();

            foreach (string token in tokens) {
                char? replacement = null;
                switch (token[0]) {
                    case 'n':
                        replacement = '\n';
                        break;
                    case 't':
                        replacement = '\t';
                        break;
                    case 'r':
                        replacement = '\r';
                        break;
                    case '"':
                        replacement = '"';
                        break;
                    case '\'':
                        replacement = '\'';
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        replacement = null;
                        break;
                }

                if (replacement != null)
                    b.Append(replacement);

                if (token.Length > 1)
                    b.Append(token.Substring(1));
            }

            return b.ToString();
        }

    }


}
