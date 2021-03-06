//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Russian.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IRussianListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class RussianBaseListener : IRussianListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="RussianParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] RussianParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RussianParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] RussianParser.ProgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="RussianParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssign([NotNull] RussianParser.AssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="RussianParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssign([NotNull] RussianParser.AssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="RussianParser.stat1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintExpr([NotNull] RussianParser.PrintExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="RussianParser.stat1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintExpr([NotNull] RussianParser.PrintExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Tan</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTan([NotNull] RussianParser.TanContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Tan</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTan([NotNull] RussianParser.TanContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Add</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd([NotNull] RussianParser.AddContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Add</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd([NotNull] RussianParser.AddContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Sub</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSub([NotNull] RussianParser.SubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Sub</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSub([NotNull] RussianParser.SubContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Ln</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLn([NotNull] RussianParser.LnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Ln</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLn([NotNull] RussianParser.LnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>unaryplus</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryplus([NotNull] RussianParser.UnaryplusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryplus</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryplus([NotNull] RussianParser.UnaryplusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Mod</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMod([NotNull] RussianParser.ModContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Mod</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMod([NotNull] RussianParser.ModContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Mul</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMul([NotNull] RussianParser.MulContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Mul</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMul([NotNull] RussianParser.MulContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Cos</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCos([NotNull] RussianParser.CosContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Cos</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCos([NotNull] RussianParser.CosContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Sqrt</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSqrt([NotNull] RussianParser.SqrtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Sqrt</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSqrt([NotNull] RussianParser.SqrtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Lt</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLt([NotNull] RussianParser.LtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Lt</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLt([NotNull] RussianParser.LtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Gt</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGt([NotNull] RussianParser.GtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Gt</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGt([NotNull] RussianParser.GtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>call</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCall([NotNull] RussianParser.CallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>call</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCall([NotNull] RussianParser.CallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Div</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDiv([NotNull] RussianParser.DivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Div</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDiv([NotNull] RussianParser.DivContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>prim</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrim([NotNull] RussianParser.PrimContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>prim</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrim([NotNull] RussianParser.PrimContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Gta</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGta([NotNull] RussianParser.GtaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Gta</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGta([NotNull] RussianParser.GtaContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Lta</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLta([NotNull] RussianParser.LtaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Lta</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLta([NotNull] RussianParser.LtaContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Sin</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSin([NotNull] RussianParser.SinContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Sin</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSin([NotNull] RussianParser.SinContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Pow</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPow([NotNull] RussianParser.PowContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Pow</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPow([NotNull] RussianParser.PowContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>unaryminus</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryminus([NotNull] RussianParser.UnaryminusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryminus</c>
	/// labeled alternative in <see cref="RussianParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryminus([NotNull] RussianParser.UnaryminusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>num</c>
	/// labeled alternative in <see cref="RussianParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNum([NotNull] RussianParser.NumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>num</c>
	/// labeled alternative in <see cref="RussianParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNum([NotNull] RussianParser.NumContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="RussianParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId([NotNull] RussianParser.IdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="RussianParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId([NotNull] RussianParser.IdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="RussianParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParens([NotNull] RussianParser.ParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="RussianParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParens([NotNull] RussianParser.ParensContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
