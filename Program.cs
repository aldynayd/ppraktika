using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Russian
{
    public class Program
    {
        public static void Main(string[] args) {
        try {
 // в зависимости от наличия параметров
 // командной строки разбираем
 // либо файл с именем, переданным первым параметром,
 // либо стандартный ввод
            ICharStream input =
                 args.Length == 1 ?
            (IcharStream) new ANTLRFileStream(args[0])
          : (IcharStream) new ANTLRReaderStream(Console.In);
            RussianLexer lexer = new RussianLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            RussianParser parser = new RussianParser(tokens);
            ITree program = (ITree)parser.execute().Tree;
    //AstNodePrinter.Print(program);
            Console.WriteLine();
            RussianIntepreter.Execute(program);
        }
        catch (Exception e) {
        Console.WriteLine("Error: {0}", e);
    }
    Console.ReadLine();
 }
 }
}
/*namespace Russian
{
    public static class Russian
    {
        public static double Evaluate(string expression)
        {
            var lexer = new RussianLexer(new AntlrInputStream(expression));
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowExceptionErrorListener());

            var tokens = new CommonTokenStream(lexer);

            var parser = new RussianParser(tokens);
            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ThrowExceptionErrorListener());

            var tree = parser.compileUnit();

            var visitor = new RussianVisitor();

            return visitor.Visit(tree);
        }
    }
}*/

/*
namespace russian
{
  public class launch{
public static void main(String[] args) {

    CharStream cs = fromFileName("test.txt");  //load the file
    RussianLexer lexer = new RussianLexer(cs);  //instantiate a lexer
    CommonTokenStream tokens = new CommonTokenStream(lexer); //scan stream for tokens
    RussianParser parser = new RussianParser(tokens);  //parse the tokens

    ParseTree tree = parser.start(); // parse the content and get the tree
    RussianListener listener = new RussianListener();

    ParseTreeWalker walker = new ParseTreeWalker();
    walker.walk(listener,tree);
}}
}
}*/

