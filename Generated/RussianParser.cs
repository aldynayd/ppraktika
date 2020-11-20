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

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class RussianParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, MOD=3, MUL=4, DIV=5, ADD=6, SUB=7, ASSIGN=8, POW=9, SIN=10, 
		COS=11, TAN=12, LN=13, LOG=14, SQRT=15, GT=16, LT=17, GTA=18, LTA=19, 
		LL=20, RL=21, ID=22, NUM=23, INT=24, FLT=25, NL=26, WS=27;
	public const int
		RULE_prog = 0, RULE_stat = 1, RULE_stat1 = 2, RULE_expr = 3, RULE_primary = 4;
	public static readonly string[] ruleNames = {
		"prog", "stat", "stat1", "expr", "primary"
	};

	private static readonly string[] _LiteralNames = {
		null, "'+'", "'-'", null, null, null, null, null, "'\u0440\u0430\u0432\u043D\u043E'", 
		null, "'\u0441\u0438\u043D\u0443\u0441'", "'\u043A\u043E\u0441\u0438\u043D\u0443\u0441'", 
		"'\u0442\u0430\u043D\u0433\u0435\u043D\u0441'", "'\u043D\u0430\u0442\u0443\u0440\u0430\u043B\u044C\u043D\u044B\u0439\u0020\u043B\u043E\u0433\u0430\u0440\u0438\u0444\u043C'", 
		"'\u043B\u043E\u0433\u0430\u0440\u0438\u0444\u043C'", null, "'\u0431\u043E\u043B\u044C\u0448\u0435'", 
		"'\u043C\u0435\u043D\u044C\u0448\u0435'", "'\u0431\u043E\u043B\u044C\u0448\u0435\u0020\u0438\u043B\u0438\u0020\u0440\u0430\u0432\u043D\u043E'", 
		"'\u043C\u0435\u043D\u044C\u0448\u0435\u0020\u0438\u043B\u0438\u0020\u0440\u0430\u0432\u043D\u043E'", 
		"'\u043B\u0435\u0432\u0430\u044F\u0020\u0441\u043A\u043E\u0431\u043A\u0430'", 
		"'\u043F\u0440\u0430\u0432\u0430\u044F\u0020\u0441\u043A\u043E\u0431\u043A\u0430'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "MOD", "MUL", "DIV", "ADD", "SUB", "ASSIGN", "POW", 
		"SIN", "COS", "TAN", "LN", "LOG", "SQRT", "GT", "LT", "GTA", "LTA", "LL", 
		"RL", "ID", "NUM", "INT", "FLT", "NL", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Russian.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static RussianParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public RussianParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public RussianParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgContext : ParserRuleContext {
		public StatContext[] stat() {
			return GetRuleContexts<StatContext>();
		}
		public StatContext stat(int i) {
			return GetRuleContext<StatContext>(i);
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(Context, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 11;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 10; stat();
				}
				}
				State = 13;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << ASSIGN) | (1L << SIN) | (1L << COS) | (1L << TAN) | (1L << LN) | (1L << LOG) | (1L << SQRT) | (1L << LL) | (1L << ID) | (1L << NUM) | (1L << NL))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatContext : ParserRuleContext {
		public StatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stat; } }
	 
		public StatContext() { }
		public virtual void CopyFrom(StatContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class AssignContext : StatContext {
		public IToken op;
		public ITerminalNode NL() { return GetToken(RussianParser.NL, 0); }
		public Stat1Context[] stat1() {
			return GetRuleContexts<Stat1Context>();
		}
		public Stat1Context stat1(int i) {
			return GetRuleContext<Stat1Context>(i);
		}
		public ITerminalNode ASSIGN() { return GetToken(RussianParser.ASSIGN, 0); }
		public AssignContext(StatContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterAssign(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitAssign(this);
		}
	}

	[RuleVersion(0)]
	public StatContext stat() {
		StatContext _localctx = new StatContext(Context, State);
		EnterRule(_localctx, 2, RULE_stat);
		int _la;
		try {
			int _alt;
			_localctx = new AssignContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 18;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 15; stat1();
					}
					} 
				}
				State = 20;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			}
			State = 22;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ASSIGN) {
				{
				State = 21; ((AssignContext)_localctx).op = Match(ASSIGN);
				}
			}

			State = 27;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << SIN) | (1L << COS) | (1L << TAN) | (1L << LN) | (1L << LOG) | (1L << SQRT) | (1L << LL) | (1L << ID) | (1L << NUM))) != 0)) {
				{
				{
				State = 24; stat1();
				}
				}
				State = 29;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 30; Match(NL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Stat1Context : ParserRuleContext {
		public Stat1Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stat1; } }
	 
		public Stat1Context() { }
		public virtual void CopyFrom(Stat1Context context) {
			base.CopyFrom(context);
		}
	}
	public partial class PrintExprContext : Stat1Context {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public PrintExprContext(Stat1Context context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterPrintExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitPrintExpr(this);
		}
	}

	[RuleVersion(0)]
	public Stat1Context stat1() {
		Stat1Context _localctx = new Stat1Context(Context, State);
		EnterRule(_localctx, 4, RULE_stat1);
		try {
			_localctx = new PrintExprContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 32; expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class CallContext : ExprContext {
		public ITerminalNode ID() { return GetToken(RussianParser.ID, 0); }
		public ITerminalNode LL() { return GetToken(RussianParser.LL, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode RL() { return GetToken(RussianParser.RL, 0); }
		public CallContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterCall(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitCall(this);
		}
	}
	public partial class PrimContext : ExprContext {
		public PrimaryContext primary() {
			return GetRuleContext<PrimaryContext>(0);
		}
		public PrimContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterPrim(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitPrim(this);
		}
	}
	public partial class SinCosTanLnSqrtContext : ExprContext {
		public IToken op;
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode SIN() { return GetToken(RussianParser.SIN, 0); }
		public ITerminalNode COS() { return GetToken(RussianParser.COS, 0); }
		public ITerminalNode TAN() { return GetToken(RussianParser.TAN, 0); }
		public ITerminalNode LN() { return GetToken(RussianParser.LN, 0); }
		public ITerminalNode LOG() { return GetToken(RussianParser.LOG, 0); }
		public ITerminalNode SQRT() { return GetToken(RussianParser.SQRT, 0); }
		public SinCosTanLnSqrtContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterSinCosTanLnSqrt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitSinCosTanLnSqrt(this);
		}
	}
	public partial class ModMulDivGtLtContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ITerminalNode MOD() { return GetToken(RussianParser.MOD, 0); }
		public ITerminalNode MUL() { return GetToken(RussianParser.MUL, 0); }
		public ITerminalNode DIV() { return GetToken(RussianParser.DIV, 0); }
		public ITerminalNode GT() { return GetToken(RussianParser.GT, 0); }
		public ITerminalNode LT() { return GetToken(RussianParser.LT, 0); }
		public ITerminalNode GTA() { return GetToken(RussianParser.GTA, 0); }
		public ITerminalNode LTA() { return GetToken(RussianParser.LTA, 0); }
		public ModMulDivGtLtContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterModMulDivGtLt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitModMulDivGtLt(this);
		}
	}
	public partial class UnaryContext : ExprContext {
		public IToken sign;
		public PrimaryContext primary() {
			return GetRuleContext<PrimaryContext>(0);
		}
		public UnaryContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterUnary(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitUnary(this);
		}
	}
	public partial class AddSubPowContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ITerminalNode ADD() { return GetToken(RussianParser.ADD, 0); }
		public ITerminalNode SUB() { return GetToken(RussianParser.SUB, 0); }
		public ITerminalNode POW() { return GetToken(RussianParser.POW, 0); }
		public AddSubPowContext(ExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterAddSubPow(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitAddSubPow(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 6;
		EnterRecursionRule(_localctx, 6, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 45;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				{
				_localctx = new SinCosTanLnSqrtContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 35;
				((SinCosTanLnSqrtContext)_localctx).op = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << SIN) | (1L << COS) | (1L << TAN) | (1L << LN) | (1L << LOG) | (1L << SQRT))) != 0)) ) {
					((SinCosTanLnSqrtContext)_localctx).op = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 36; expr(4);
				}
				break;
			case 2:
				{
				_localctx = new CallContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 37; Match(ID);
				State = 38; Match(LL);
				State = 39; expr(0);
				State = 40; Match(RL);
				}
				break;
			case 3:
				{
				_localctx = new UnaryContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 42;
				((UnaryContext)_localctx).sign = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !(_la==T__0 || _la==T__1) ) {
					((UnaryContext)_localctx).sign = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 43; primary();
				}
				break;
			case 4:
				{
				_localctx = new PrimContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 44; primary();
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 55;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 53;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
					case 1:
						{
						_localctx = new ModMulDivGtLtContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 47;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 48;
						((ModMulDivGtLtContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MOD) | (1L << MUL) | (1L << DIV) | (1L << GT) | (1L << LT) | (1L << GTA) | (1L << LTA))) != 0)) ) {
							((ModMulDivGtLtContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 49; expr(7);
						}
						break;
					case 2:
						{
						_localctx = new AddSubPowContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 50;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 51;
						((AddSubPowContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << SUB) | (1L << POW))) != 0)) ) {
							((AddSubPowContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 52; expr(6);
						}
						break;
					}
					} 
				}
				State = 57;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class PrimaryContext : ParserRuleContext {
		public PrimaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primary; } }
	 
		public PrimaryContext() { }
		public virtual void CopyFrom(PrimaryContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ParensContext : PrimaryContext {
		public ITerminalNode LL() { return GetToken(RussianParser.LL, 0); }
		public ITerminalNode RL() { return GetToken(RussianParser.RL, 0); }
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ParensContext(PrimaryContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterParens(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitParens(this);
		}
	}
	public partial class NumContext : PrimaryContext {
		public ITerminalNode NUM() { return GetToken(RussianParser.NUM, 0); }
		public NumContext(PrimaryContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterNum(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitNum(this);
		}
	}
	public partial class IdContext : PrimaryContext {
		public ITerminalNode ID() { return GetToken(RussianParser.ID, 0); }
		public IdContext(PrimaryContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.EnterId(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IRussianListener typedListener = listener as IRussianListener;
			if (typedListener != null) typedListener.ExitId(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryContext primary() {
		PrimaryContext _localctx = new PrimaryContext(Context, State);
		EnterRule(_localctx, 8, RULE_primary);
		int _la;
		try {
			State = 68;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NUM:
				_localctx = new NumContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 58; Match(NUM);
				}
				break;
			case ID:
				_localctx = new IdContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 59; Match(ID);
				}
				break;
			case LL:
				_localctx = new ParensContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 60; Match(LL);
				State = 62;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 61; expr(0);
					}
					}
					State = 64;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << SIN) | (1L << COS) | (1L << TAN) | (1L << LN) | (1L << LOG) | (1L << SQRT) | (1L << LL) | (1L << ID) | (1L << NUM))) != 0) );
				State = 66; Match(RL);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 3: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 6);
		case 1: return Precpred(Context, 5);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x1D', 'I', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x3', '\x2', '\x6', '\x2', '\xE', '\n', '\x2', '\r', 
		'\x2', '\xE', '\x2', '\xF', '\x3', '\x3', '\a', '\x3', '\x13', '\n', '\x3', 
		'\f', '\x3', '\xE', '\x3', '\x16', '\v', '\x3', '\x3', '\x3', '\x5', '\x3', 
		'\x19', '\n', '\x3', '\x3', '\x3', '\a', '\x3', '\x1C', '\n', '\x3', '\f', 
		'\x3', '\xE', '\x3', '\x1F', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '\x30', '\n', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\a', '\x5', '\x38', '\n', '\x5', '\f', '\x5', '\xE', 
		'\x5', ';', '\v', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x6', '\x6', '\x41', '\n', '\x6', '\r', '\x6', '\xE', '\x6', '\x42', 
		'\x3', '\x6', '\x3', '\x6', '\x5', '\x6', 'G', '\n', '\x6', '\x3', '\x6', 
		'\x2', '\x3', '\b', '\a', '\x2', '\x4', '\x6', '\b', '\n', '\x2', '\x6', 
		'\x3', '\x2', '\f', '\x11', '\x3', '\x2', '\x3', '\x4', '\x4', '\x2', 
		'\x5', '\a', '\x12', '\x15', '\x4', '\x2', '\b', '\t', '\v', '\v', '\x2', 
		'O', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x4', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '\"', '\x3', '\x2', '\x2', '\x2', '\b', '/', '\x3', 
		'\x2', '\x2', '\x2', '\n', '\x46', '\x3', '\x2', '\x2', '\x2', '\f', '\xE', 
		'\x5', '\x4', '\x3', '\x2', '\r', '\f', '\x3', '\x2', '\x2', '\x2', '\xE', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\xF', '\r', '\x3', '\x2', '\x2', '\x2', 
		'\xF', '\x10', '\x3', '\x2', '\x2', '\x2', '\x10', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x11', '\x13', '\x5', '\x6', '\x4', '\x2', '\x12', '\x11', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'\x14', '\x12', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\x18', '\x3', '\x2', '\x2', '\x2', '\x16', '\x14', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\x19', '\a', '\n', '\x2', '\x2', 
		'\x18', '\x17', '\x3', '\x2', '\x2', '\x2', '\x18', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x19', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1C', 
		'\x5', '\x6', '\x4', '\x2', '\x1B', '\x1A', '\x3', '\x2', '\x2', '\x2', 
		'\x1C', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1B', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x1E', ' ', 
		'\x3', '\x2', '\x2', '\x2', '\x1F', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		' ', '!', '\a', '\x1C', '\x2', '\x2', '!', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\"', '#', '\x5', '\b', '\x5', '\x2', '#', '\a', '\x3', '\x2', 
		'\x2', '\x2', '$', '%', '\b', '\x5', '\x1', '\x2', '%', '&', '\t', '\x2', 
		'\x2', '\x2', '&', '\x30', '\x5', '\b', '\x5', '\x6', '\'', '(', '\a', 
		'\x18', '\x2', '\x2', '(', ')', '\a', '\x16', '\x2', '\x2', ')', '*', 
		'\x5', '\b', '\x5', '\x2', '*', '+', '\a', '\x17', '\x2', '\x2', '+', 
		'\x30', '\x3', '\x2', '\x2', '\x2', ',', '-', '\t', '\x3', '\x2', '\x2', 
		'-', '\x30', '\x5', '\n', '\x6', '\x2', '.', '\x30', '\x5', '\n', '\x6', 
		'\x2', '/', '$', '\x3', '\x2', '\x2', '\x2', '/', '\'', '\x3', '\x2', 
		'\x2', '\x2', '/', ',', '\x3', '\x2', '\x2', '\x2', '/', '.', '\x3', '\x2', 
		'\x2', '\x2', '\x30', '\x39', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', 
		'\f', '\b', '\x2', '\x2', '\x32', '\x33', '\t', '\x4', '\x2', '\x2', '\x33', 
		'\x38', '\x5', '\b', '\x5', '\t', '\x34', '\x35', '\f', '\a', '\x2', '\x2', 
		'\x35', '\x36', '\t', '\x5', '\x2', '\x2', '\x36', '\x38', '\x5', '\b', 
		'\x5', '\b', '\x37', '\x31', '\x3', '\x2', '\x2', '\x2', '\x37', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\x38', ';', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x39', ':', '\x3', '\x2', '\x2', 
		'\x2', ':', '\t', '\x3', '\x2', '\x2', '\x2', ';', '\x39', '\x3', '\x2', 
		'\x2', '\x2', '<', 'G', '\a', '\x19', '\x2', '\x2', '=', 'G', '\a', '\x18', 
		'\x2', '\x2', '>', '@', '\a', '\x16', '\x2', '\x2', '?', '\x41', '\x5', 
		'\b', '\x5', '\x2', '@', '?', '\x3', '\x2', '\x2', '\x2', '\x41', '\x42', 
		'\x3', '\x2', '\x2', '\x2', '\x42', '@', '\x3', '\x2', '\x2', '\x2', '\x42', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\x3', '\x2', '\x2', 
		'\x2', '\x44', '\x45', '\a', '\x17', '\x2', '\x2', '\x45', 'G', '\x3', 
		'\x2', '\x2', '\x2', '\x46', '<', '\x3', '\x2', '\x2', '\x2', '\x46', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x46', '>', '\x3', '\x2', '\x2', '\x2', 
		'G', '\v', '\x3', '\x2', '\x2', '\x2', '\v', '\xF', '\x14', '\x18', '\x1D', 
		'/', '\x37', '\x39', '\x42', '\x46',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
