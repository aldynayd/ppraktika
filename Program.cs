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


