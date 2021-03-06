//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\darga\Documents\PP\ppraktika\Russian.g4 by ANTLR 4.8

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
		T__0=1, T__1=2, INT=3, ID=4, ADD=5, SUB=6, MUL=7, DIV=8, ASSIGN=9, NEWLINE=10;
	public const int
		RULE_start = 0, RULE_statement = 1, RULE_expr = 2, RULE_multExpression = 3, 
		RULE_atom = 4;
	public static readonly string[] ruleNames = {
		"start", "statement", "expr", "multExpression", "atom"
	};

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", null, null, "'\u0420\u0457\u0420\u00BB\u0421\u040B\u0421\u0403'", 
		"'\u0420\u0458\u0420\u0451\u0420\u0405\u0421\u0453\u0421\u0403'", "'\u0421\u0453\u0420\u0458\u0420\u0405\u0420\u0455\u0420\u00B6\u0420\u0451\u0421\u201A\u0421\u040A \u0420\u0405\u0420\u00B0'", 
		"'\u0421\u0402\u0420\u00B0\u0420\u00B7\u0420\u0491\u0420\u00B5\u0420\u00BB\u0420\u0451\u0421\u201A\u0421\u040A \u0420\u0405\u0420\u00B0'", 
		"'\u0421\u0402\u0420\u00B0\u0420\u0406\u0420\u0405\u0420\u0455'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "INT", "ID", "ADD", "SUB", "MUL", "DIV", "ASSIGN", "NEWLINE"
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

	public partial class StartContext : ParserRuleContext {
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public StartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_start; } }
	}

	[RuleVersion(0)]
	public StartContext start() {
		StartContext _localctx = new StartContext(Context, State);
		EnterRule(_localctx, 0, RULE_start);
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
				State = 10; statement();
				}
				}
				State = 13;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << INT) | (1L << ID) | (1L << NEWLINE))) != 0) );
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

	public partial class StatementContext : ParserRuleContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode NEWLINE() { return GetToken(RussianParser.NEWLINE, 0); }
		public ITerminalNode ID() { return GetToken(RussianParser.ID, 0); }
		public ITerminalNode ASSIGN() { return GetToken(RussianParser.ASSIGN, 0); }
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 2, RULE_statement);
		try {
			State = 24;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 15; expr();
				State = 16; Match(NEWLINE);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 18; Match(ID);
				State = 19; Match(ASSIGN);
				State = 20; expr();
				State = 21; Match(NEWLINE);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 23; Match(NEWLINE);
				}
				break;
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
		public MultExpressionContext[] multExpression() {
			return GetRuleContexts<MultExpressionContext>();
		}
		public MultExpressionContext multExpression(int i) {
			return GetRuleContext<MultExpressionContext>(i);
		}
		public ITerminalNode[] ADD() { return GetTokens(RussianParser.ADD); }
		public ITerminalNode ADD(int i) {
			return GetToken(RussianParser.ADD, i);
		}
		public ITerminalNode[] SUB() { return GetTokens(RussianParser.SUB); }
		public ITerminalNode SUB(int i) {
			return GetToken(RussianParser.SUB, i);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(Context, State);
		EnterRule(_localctx, 4, RULE_expr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26; multExpression();
			State = 33;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==ADD || _la==SUB) {
				{
				State = 31;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case ADD:
					{
					State = 27; Match(ADD);
					State = 28; multExpression();
					}
					break;
				case SUB:
					{
					State = 29; Match(SUB);
					State = 30; multExpression();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 35;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
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

	public partial class MultExpressionContext : ParserRuleContext {
		public AtomContext a1;
		public AtomContext a2;
		public AtomContext[] atom() {
			return GetRuleContexts<AtomContext>();
		}
		public AtomContext atom(int i) {
			return GetRuleContext<AtomContext>(i);
		}
		public ITerminalNode[] MUL() { return GetTokens(RussianParser.MUL); }
		public ITerminalNode MUL(int i) {
			return GetToken(RussianParser.MUL, i);
		}
		public ITerminalNode[] DIV() { return GetTokens(RussianParser.DIV); }
		public ITerminalNode DIV(int i) {
			return GetToken(RussianParser.DIV, i);
		}
		public MultExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_multExpression; } }
	}

	[RuleVersion(0)]
	public MultExpressionContext multExpression() {
		MultExpressionContext _localctx = new MultExpressionContext(Context, State);
		EnterRule(_localctx, 6, RULE_multExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 36; _localctx.a1 = atom();
			State = 43;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==MUL || _la==DIV) {
				{
				State = 41;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case MUL:
					{
					State = 37; Match(MUL);
					State = 38; _localctx.a2 = atom();
					}
					break;
				case DIV:
					{
					State = 39; Match(DIV);
					State = 40; _localctx.a2 = atom();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 45;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
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

	public partial class AtomContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(RussianParser.ID, 0); }
		public ITerminalNode INT() { return GetToken(RussianParser.INT, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public AtomContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_atom; } }
	}

	[RuleVersion(0)]
	public AtomContext atom() {
		AtomContext _localctx = new AtomContext(Context, State);
		EnterRule(_localctx, 8, RULE_atom);
		try {
			State = 52;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ID:
				EnterOuterAlt(_localctx, 1);
				{
				State = 46; Match(ID);
				}
				break;
			case INT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 47; Match(INT);
				}
				break;
			case T__0:
				EnterOuterAlt(_localctx, 3);
				{
				State = 48; Match(T__0);
				State = 49; expr();
				State = 50; Match(T__1);
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

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\f', '\x39', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x3', '\x2', '\x6', '\x2', '\xE', '\n', '\x2', '\r', 
		'\x2', '\xE', '\x2', '\xF', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x5', '\x3', '\x1B', '\n', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '\"', '\n', 
		'\x4', '\f', '\x4', '\xE', '\x4', '%', '\v', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', ',', '\n', 
		'\x5', '\f', '\x5', '\xE', '\x5', '/', '\v', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', 
		'\x6', '\x37', '\n', '\x6', '\x3', '\x6', '\x2', '\x2', '\a', '\x2', '\x4', 
		'\x6', '\b', '\n', '\x2', '\x2', '\x2', '<', '\x2', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\x4', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x6', '\x1C', 
		'\x3', '\x2', '\x2', '\x2', '\b', '&', '\x3', '\x2', '\x2', '\x2', '\n', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\f', '\xE', '\x5', '\x4', '\x3', 
		'\x2', '\r', '\f', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\r', '\x3', '\x2', '\x2', '\x2', '\xF', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\x10', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x11', '\x12', '\x5', '\x6', '\x4', '\x2', '\x12', '\x13', '\a', '\f', 
		'\x2', '\x2', '\x13', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', 
		'\a', '\x6', '\x2', '\x2', '\x15', '\x16', '\a', '\v', '\x2', '\x2', '\x16', 
		'\x17', '\x5', '\x6', '\x4', '\x2', '\x17', '\x18', '\a', '\f', '\x2', 
		'\x2', '\x18', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1B', '\a', 
		'\f', '\x2', '\x2', '\x1A', '\x11', '\x3', '\x2', '\x2', '\x2', '\x1A', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1C', '#', '\x5', 
		'\b', '\x5', '\x2', '\x1D', '\x1E', '\a', '\a', '\x2', '\x2', '\x1E', 
		'\"', '\x5', '\b', '\x5', '\x2', '\x1F', ' ', '\a', '\b', '\x2', '\x2', 
		' ', '\"', '\x5', '\b', '\x5', '\x2', '!', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '!', '\x1F', '\x3', '\x2', '\x2', '\x2', '\"', '%', '\x3', '\x2', 
		'\x2', '\x2', '#', '!', '\x3', '\x2', '\x2', '\x2', '#', '$', '\x3', '\x2', 
		'\x2', '\x2', '$', '\a', '\x3', '\x2', '\x2', '\x2', '%', '#', '\x3', 
		'\x2', '\x2', '\x2', '&', '-', '\x5', '\n', '\x6', '\x2', '\'', '(', '\a', 
		'\t', '\x2', '\x2', '(', ',', '\x5', '\n', '\x6', '\x2', ')', '*', '\a', 
		'\n', '\x2', '\x2', '*', ',', '\x5', '\n', '\x6', '\x2', '+', '\'', '\x3', 
		'\x2', '\x2', '\x2', '+', ')', '\x3', '\x2', '\x2', '\x2', ',', '/', '\x3', 
		'\x2', '\x2', '\x2', '-', '+', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x3', 
		'\x2', '\x2', '\x2', '.', '\t', '\x3', '\x2', '\x2', '\x2', '/', '-', 
		'\x3', '\x2', '\x2', '\x2', '\x30', '\x37', '\a', '\x6', '\x2', '\x2', 
		'\x31', '\x37', '\a', '\x5', '\x2', '\x2', '\x32', '\x33', '\a', '\x3', 
		'\x2', '\x2', '\x33', '\x34', '\x5', '\x6', '\x4', '\x2', '\x34', '\x35', 
		'\a', '\x4', '\x2', '\x2', '\x35', '\x37', '\x3', '\x2', '\x2', '\x2', 
		'\x36', '\x30', '\x3', '\x2', '\x2', '\x2', '\x36', '\x31', '\x3', '\x2', 
		'\x2', '\x2', '\x36', '\x32', '\x3', '\x2', '\x2', '\x2', '\x37', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\t', '\xF', '\x1A', '!', '#', '+', '-', '\x36',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
