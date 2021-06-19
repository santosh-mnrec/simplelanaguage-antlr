using System;
using System.Text;

using Antlr4.Runtime;

namespace GrammarDemo
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    args = new String[] { "test.mu" };
                }

               System.Console.WriteLine("parsing: " + args[0]);

                SimpleLanguageLexer lexer = new SimpleLanguageLexer(new AntlrFileStream(args[0]));
                SimpleLanguageParser parser = new SimpleLanguageParser(new CommonTokenStream(lexer));
                var tree = parser.parse();
                EvalVisitor visitor = new EvalVisitor();
                visitor.Visit(tree);
                //System.Console.WriteLine(tree);
            }
            catch (Exception ex)
            {
               Console.WriteLine("Error: " + ex);
            }
        }
    }
}
