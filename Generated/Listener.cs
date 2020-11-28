using System;
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

class Listener : IRussianListener
{
    public static void Main(string[] args)
    {
        void ExitProg([NotNull] RussianParser.ProgContext context)
        {
            object a;                                                      //?????
            a = MyStack.Pop();
            MyStack.Push(a);
        }
        void ExitAssign([NotNull] RussianParser.AssignContext context)
        {
            object a, b, assign;
            a = MyStack.Pop();
            b = MyStack.Pop();
            assign = a + " = " + b;
            MyStack.Push(assign);
        }
        void ExitPrintExpr([NotNull] RussianParser.PrintExprContext context)
        {
            object expr;
            expr = MyStack.Pop();
            MyStack.Push(expr);
        }
        void ExitTan([NotNull] RussianParser.TanContext context)
        {
            object tan, a;
            a = MyStack.Pop();
            tan = " \tan " + a;
            MyStack.Push(tan);
        }
        void ExitAdd([NotNull] RussianParser.AddContext context)
        {
            object add, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            add = a + " + " + b;
            MyStack.Push(add);
        }
        void ExitSub([NotNull] RussianParser.SubContext context)
        {
            object add, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            add = a + " - " + b;
            MyStack.Push(add);
        }
        void ExitLn([NotNull] RussianParser.LnContext context)
        {
            object ln, a;
            a = MyStack.Pop();
            ln = " \ln " + a;
            MyStack.Push(ln);
        }
        void ExitUnaryplus([NotNull] RussianParser.UnaryplusContext context)
        {
            object Unaryplus, a;
            a = MyStack.Pop();
            Unaryplus = " + " + a;
            MyStack.push(Unaryplus);
        }
        void ExitMod([NotNull] RussianParser.ModContext context)
        {
            object mod, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            mod = a + " \bmod " + b;
            MyStack.Push(mod);
        }
        void ExitMul([NotNull] RussianParser.MulContext context)
        {
            object mul, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            mul = a + " * " + b;
            MyStack.Push(mul);
        }
        void ExitCos([NotNull] RussianParser.CosContext context)
        {
            object cos, a;
            a = MyStack.Pop();
            cos = " \cos (" + a + ")";
            MyStack.Push(cos);
        }
        void ExitSqrt([NotNull] RussianParser.SqrtContext context)
        {
            object sqrt, a;
            a = MyStack.Pop();
            sqrt = " \sqrt{" + a + "} ";
            MyStack.Push(sqrt);
        }
        void ExitLt([NotNull] RussianParser.LtContext context)
        {
            object lt, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            lt = a + " < " + b;
            MyStack.Push(lt);
        }
        void ExitGt([NotNull] RussianParser.GtContext context)
        {
            object gt, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            gt = a + " > " + b;
            MyStack.Push(gt);
        }
        void ExitCall([NotNull] RussianParser.CallContext context)
        {
                                                                        //?????
        }
        void ExitDiv([NotNull] RussianParser.DivContext context)
        {
            object div, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            div = a + " / " + b;
            MyStack.Push(div);
        }
        void ExitPrim([NotNull] RussianParser.PrimContext context)
        {
                                                                            //??????
        }
        void ExitGta([NotNull] RussianParser.GtaContext context)
        {
            object gta, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            gta = a + " => " + b;
            MyStack.Push(gta);
        }
        void ExitLta([NotNull] RussianParser.LtaContext context)
        {
            object lta, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            lta = a + " <= " + b;
            MyStack.Push(lta);
        }
        void ExitSin([NotNull] RussianParser.SinContext context)
        {
            object sin, a;
            a = MyStack.Pop();
            sin = " \sin (" + a + ") ";
            MyStack.Push(sin);
        }
        void ExitPow([NotNull] RussianParser.PowContext context)
        {
            object pow, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();
            pow = a + "^" + b;
            MyStack.Push(pow);
        }
        void ExitUnaryminus([NotNull] RussianParser.UnaryminusContext context)
        {
            object UnaryMinus, a;
            a = MyStack.Pop();
            UnaryMinus = " - " + a;
            MyStack.push(UnaryMinus);
        }
        void ExitNum([NotNull] RussianParser.NumContext context)
        {
            char Num;
            ITokenStream tokens = parser.getITokenStream();
            Num = tokens.getText(context.Num());
            MyStack.push(Num);
        }
        
        void ExitId([NotNull] RussianParser.IdContext context)
        {
            string Id;
            ITokenStream tokens = parser.getITokenStream();
            Id = tokens.getText(context.Id());
            MyStack.push(Id);
        }
        void ExitParens([NotNull] RussianParser.ParensContext context)
        {
            object parens, a, b;
            a = MyStack.Pop();
            b = MyStack.Pop();                                                  //??? +
            parens = " ( " + a + " ) ";
            MyStack.Push(parens);
        }
    }
}