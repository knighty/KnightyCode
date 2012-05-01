//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4.1.9004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4.1.9004 KnightyCode.g 2012-04-30 23:05:35

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System;


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  KnightyCode 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4.1.9004")]
[System.CLSCompliant(false)]
public partial class KnightyCodeParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "Number", "Print", "ROOT", "Space", "UNARY_MIN", "'('", "')'", "'*'", "'+'", "'-'", "'/'"
	};
	public const int EOF=-1;
	public const int Number=4;
	public const int Print=5;
	public const int ROOT=6;
	public const int Space=7;
	public const int UNARY_MIN=8;
	public const int T__9=9;
	public const int T__10=10;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int T__14=14;

	public KnightyCodeParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public KnightyCodeParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = default(ITreeAdaptor);
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();
		OnCreated();
	}
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}

		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return KnightyCodeParser.tokenNames; } }
	public override string GrammarFileName { get { return "KnightyCode.g"; } }


		public static void Run( string code )
		{
			KnightyCodeLexer lex = new KnightyCodeLexer( new ANTLRStringStream( code ));
	        CommonTokenStream tokens = new CommonTokenStream(lex);
	 
	        KnightyCodeParser parser = new KnightyCodeParser(tokens);
	 
	        try {
	            parser.parse().node.Evaluate( null );
	        } catch (RecognitionException e)  {
	            Console.Error.WriteLine(e.StackTrace);
	        }
		}


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	private sealed partial class parse_return : AstParserRuleReturnScope<object, IToken>
	{
		public Node node;
		public parse_return(KnightyCodeParser grammar) {OnCreated(grammar);}
		partial void OnCreated(KnightyCodeParser grammar);
	}

	partial void EnterRule_parse();
	partial void LeaveRule_parse();
	// $ANTLR start "parse"
	// KnightyCode.g:37:1: parse returns [Node node] : exp EOF ;
	[GrammarRule("parse")]
	private KnightyCodeParser.parse_return parse()
	{
		EnterRule_parse();
		EnterRule("parse", 1);
		TraceIn("parse", 1);
		KnightyCodeParser.parse_return retval = new KnightyCodeParser.parse_return(this);
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken EOF2 = default(IToken);
		KnightyCodeParser.exp_return exp1 = default(KnightyCodeParser.exp_return);

		object EOF2_tree = default(object);
		try { DebugEnterRule(GrammarFileName, "parse");
		DebugLocation(37, 2);
		try
		{
			// KnightyCode.g:38:3: ( exp EOF )
			DebugEnterAlt(1);
			// KnightyCode.g:38:6: exp EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(38, 6);
			PushFollow(Follow._exp_in_parse92);
			exp1=exp();
			PopFollow();
			if (state.failed) return retval;
			if (state.backtracking == 0) adaptor.AddChild(root_0, exp1.Tree);
			DebugLocation(38, 10);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_parse94); if (state.failed) return retval;
			if (state.backtracking == 0) {
			EOF2_tree = (object)adaptor.Create(EOF2);
			adaptor.AddChild(root_0, EOF2_tree);
			}
			DebugLocation(38, 14);
			if (state.backtracking == 0)
			{
				 retval.node = (exp1!=null?exp1.node:default(Node)); 
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if (state.backtracking == 0) {
			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("parse", 1);
			LeaveRule("parse", 1);
			LeaveRule_parse();
		}
		DebugLocation(39, 2);
		} finally { DebugExitRule(GrammarFileName, "parse"); }
		return retval;

	}
	// $ANTLR end "parse"

	private sealed partial class exp_return : AstParserRuleReturnScope<object, IToken>
	{
		public Node node;
		public exp_return(KnightyCodeParser grammar) {OnCreated(grammar);}
		partial void OnCreated(KnightyCodeParser grammar);
	}

	partial void EnterRule_exp();
	partial void LeaveRule_exp();
	// $ANTLR start "exp"
	// KnightyCode.g:41:1: exp returns [Node node] : printExp ;
	[GrammarRule("exp")]
	private KnightyCodeParser.exp_return exp()
	{
		EnterRule_exp();
		EnterRule("exp", 2);
		TraceIn("exp", 2);
		KnightyCodeParser.exp_return retval = new KnightyCodeParser.exp_return(this);
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		KnightyCodeParser.printExp_return printExp3 = default(KnightyCodeParser.printExp_return);

		try { DebugEnterRule(GrammarFileName, "exp");
		DebugLocation(41, 2);
		try
		{
			// KnightyCode.g:42:3: ( printExp )
			DebugEnterAlt(1);
			// KnightyCode.g:42:6: printExp
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(42, 6);
			PushFollow(Follow._printExp_in_exp114);
			printExp3=printExp();
			PopFollow();
			if (state.failed) return retval;
			if (state.backtracking == 0) adaptor.AddChild(root_0, printExp3.Tree);
			DebugLocation(42, 15);
			if (state.backtracking == 0)
			{
				 retval.node = (printExp3!=null?printExp3.node:default(Node)); 
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if (state.backtracking == 0) {
			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("exp", 2);
			LeaveRule("exp", 2);
			LeaveRule_exp();
		}
		DebugLocation(43, 2);
		} finally { DebugExitRule(GrammarFileName, "exp"); }
		return retval;

	}
	// $ANTLR end "exp"

	private sealed partial class printExp_return : AstParserRuleReturnScope<object, IToken>
	{
		public Node node;
		public printExp_return(KnightyCodeParser grammar) {OnCreated(grammar);}
		partial void OnCreated(KnightyCodeParser grammar);
	}

	partial void EnterRule_printExp();
	partial void LeaveRule_printExp();
	// $ANTLR start "printExp"
	// KnightyCode.g:45:1: printExp returns [Node node] : ( Print Space addExp | addExp );
	[GrammarRule("printExp")]
	private KnightyCodeParser.printExp_return printExp()
	{
		EnterRule_printExp();
		EnterRule("printExp", 3);
		TraceIn("printExp", 3);
		KnightyCodeParser.printExp_return retval = new KnightyCodeParser.printExp_return(this);
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken Print4 = default(IToken);
		IToken Space5 = default(IToken);
		KnightyCodeParser.addExp_return addExp6 = default(KnightyCodeParser.addExp_return);
		KnightyCodeParser.addExp_return addExp7 = default(KnightyCodeParser.addExp_return);

		object Print4_tree = default(object);
		object Space5_tree = default(object);
		try { DebugEnterRule(GrammarFileName, "printExp");
		DebugLocation(45, 1);
		try
		{
			// KnightyCode.g:46:2: ( Print Space addExp | addExp )
			int alt1=2;
			try { DebugEnterDecision(1, false);
			int LA1_1 = input.LA(1);

			if ((LA1_1==Print))
			{
				alt1 = 1;
			}
			else if ((LA1_1==Number||LA1_1==9))
			{
				alt1 = 2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 1, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// KnightyCode.g:46:4: Print Space addExp
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(46, 4);
				Print4=(IToken)Match(input,Print,Follow._Print_in_printExp132); if (state.failed) return retval;
				if (state.backtracking == 0) {
				Print4_tree = (object)adaptor.Create(Print4);
				adaptor.AddChild(root_0, Print4_tree);
				}
				DebugLocation(46, 10);
				Space5=(IToken)Match(input,Space,Follow._Space_in_printExp134); if (state.failed) return retval;
				if (state.backtracking == 0) {
				Space5_tree = (object)adaptor.Create(Space5);
				adaptor.AddChild(root_0, Space5_tree);
				}
				DebugLocation(46, 16);
				PushFollow(Follow._addExp_in_printExp136);
				addExp6=addExp();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, addExp6.Tree);
				DebugLocation(46, 23);
				if (state.backtracking == 0)
				{
					 retval.node = new PrintNode( (addExp6!=null?addExp6.node:default(Node)) ); 
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// KnightyCode.g:47:4: addExp
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(47, 4);
				PushFollow(Follow._addExp_in_printExp143);
				addExp7=addExp();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, addExp7.Tree);
				DebugLocation(47, 11);
				if (state.backtracking == 0)
				{
					 retval.node = (addExp7!=null?addExp7.node:default(Node)); 
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if (state.backtracking == 0) {
			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("printExp", 3);
			LeaveRule("printExp", 3);
			LeaveRule_printExp();
		}
		DebugLocation(48, 1);
		} finally { DebugExitRule(GrammarFileName, "printExp"); }
		return retval;

	}
	// $ANTLR end "printExp"

	private sealed partial class addExp_return : AstParserRuleReturnScope<object, IToken>
	{
		public Node node;
		public addExp_return(KnightyCodeParser grammar) {OnCreated(grammar);}
		partial void OnCreated(KnightyCodeParser grammar);
	}

	partial void EnterRule_addExp();
	partial void LeaveRule_addExp();
	// $ANTLR start "addExp"
	// KnightyCode.g:50:1: addExp returns [Node node] : (lhs= mulExp op= ( '+' | '-' ) rhs= addExp | mulExp );
	[GrammarRule("addExp")]
	private KnightyCodeParser.addExp_return addExp()
	{
		EnterRule_addExp();
		EnterRule("addExp", 4);
		TraceIn("addExp", 4);
		KnightyCodeParser.addExp_return retval = new KnightyCodeParser.addExp_return(this);
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken op = default(IToken);
		KnightyCodeParser.mulExp_return lhs = default(KnightyCodeParser.mulExp_return);
		KnightyCodeParser.addExp_return rhs = default(KnightyCodeParser.addExp_return);
		KnightyCodeParser.mulExp_return mulExp8 = default(KnightyCodeParser.mulExp_return);

		object op_tree = default(object);
		try { DebugEnterRule(GrammarFileName, "addExp");
		DebugLocation(50, 2);
		try
		{
			// KnightyCode.g:51:3: (lhs= mulExp op= ( '+' | '-' ) rhs= addExp | mulExp )
			int alt2=2;
			try { DebugEnterDecision(2, false);
			int LA2_1 = input.LA(1);

			if ((LA2_1==Number))
			{
				int LA2_2 = input.LA(2);

				if ((EvaluatePredicate(synpred3_KnightyCode_fragment)))
				{
					alt2 = 1;
				}
				else if ((true))
				{
					alt2 = 2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 1, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA2_1==9))
			{
				int LA2_2 = input.LA(2);

				if ((EvaluatePredicate(synpred3_KnightyCode_fragment)))
				{
					alt2 = 1;
				}
				else if ((true))
				{
					alt2 = 2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 2, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 2, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// KnightyCode.g:51:6: lhs= mulExp op= ( '+' | '-' ) rhs= addExp
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(51, 9);
				PushFollow(Follow._mulExp_in_addExp164);
				lhs=mulExp();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, lhs.Tree);
				DebugLocation(51, 19);

				op=(IToken)input.LT(1);
				if ((input.LA(1)>=12 && input.LA(1)<=13))
				{
					input.Consume();
					if (state.backtracking == 0) adaptor.AddChild(root_0, (object)adaptor.Create(op));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(51, 35);
				PushFollow(Follow._addExp_in_addExp178);
				rhs=addExp();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, rhs.Tree);
				DebugLocation(51, 43);
				if (state.backtracking == 0)
				{
					 retval.node = new CalcNode( (op!=null?op.Text:null), (lhs!=null?lhs.node:default(Node)), (rhs!=null?rhs.node:default(Node)) );  
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// KnightyCode.g:52:5: mulExp
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(52, 5);
				PushFollow(Follow._mulExp_in_addExp186);
				mulExp8=mulExp();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, mulExp8.Tree);
				DebugLocation(52, 12);
				if (state.backtracking == 0)
				{
					 retval.node = (mulExp8!=null?mulExp8.node:default(Node)); 
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if (state.backtracking == 0) {
			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("addExp", 4);
			LeaveRule("addExp", 4);
			LeaveRule_addExp();
		}
		DebugLocation(53, 2);
		} finally { DebugExitRule(GrammarFileName, "addExp"); }
		return retval;

	}
	// $ANTLR end "addExp"

	private sealed partial class mulExp_return : AstParserRuleReturnScope<object, IToken>
	{
		public Node node;
		public mulExp_return(KnightyCodeParser grammar) {OnCreated(grammar);}
		partial void OnCreated(KnightyCodeParser grammar);
	}

	partial void EnterRule_mulExp();
	partial void LeaveRule_mulExp();
	// $ANTLR start "mulExp"
	// KnightyCode.g:55:1: mulExp returns [Node node] : (lhs= unaryExp op= ( '*' | '/' ) rhs= mulExp | unaryExp );
	[GrammarRule("mulExp")]
	private KnightyCodeParser.mulExp_return mulExp()
	{
		EnterRule_mulExp();
		EnterRule("mulExp", 5);
		TraceIn("mulExp", 5);
		KnightyCodeParser.mulExp_return retval = new KnightyCodeParser.mulExp_return(this);
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken op = default(IToken);
		KnightyCodeParser.unaryExp_return lhs = default(KnightyCodeParser.unaryExp_return);
		KnightyCodeParser.mulExp_return rhs = default(KnightyCodeParser.mulExp_return);
		KnightyCodeParser.unaryExp_return unaryExp9 = default(KnightyCodeParser.unaryExp_return);

		object op_tree = default(object);
		try { DebugEnterRule(GrammarFileName, "mulExp");
		DebugLocation(55, 2);
		try
		{
			// KnightyCode.g:56:3: (lhs= unaryExp op= ( '*' | '/' ) rhs= mulExp | unaryExp )
			int alt3=2;
			try { DebugEnterDecision(3, false);
			int LA3_1 = input.LA(1);

			if ((LA3_1==Number))
			{
				int LA3_2 = input.LA(2);

				if ((EvaluatePredicate(synpred5_KnightyCode_fragment)))
				{
					alt3 = 1;
				}
				else if ((true))
				{
					alt3 = 2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 1, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA3_1==9))
			{
				int LA3_2 = input.LA(2);

				if ((EvaluatePredicate(synpred5_KnightyCode_fragment)))
				{
					alt3 = 1;
				}
				else if ((true))
				{
					alt3 = 2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 2, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 3, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// KnightyCode.g:56:6: lhs= unaryExp op= ( '*' | '/' ) rhs= mulExp
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(56, 9);
				PushFollow(Follow._unaryExp_in_mulExp208);
				lhs=unaryExp();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, lhs.Tree);
				DebugLocation(56, 21);

				op=(IToken)input.LT(1);
				if (input.LA(1)==11||input.LA(1)==14)
				{
					input.Consume();
					if (state.backtracking == 0) adaptor.AddChild(root_0, (object)adaptor.Create(op));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(56, 37);
				PushFollow(Follow._mulExp_in_mulExp222);
				rhs=mulExp();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, rhs.Tree);
				DebugLocation(56, 45);
				if (state.backtracking == 0)
				{
					 retval.node = new CalcNode( (op!=null?op.Text:null), (lhs!=null?lhs.node:default(Node)), (rhs!=null?rhs.node:default(Node)) );  
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// KnightyCode.g:57:5: unaryExp
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(57, 5);
				PushFollow(Follow._unaryExp_in_mulExp230);
				unaryExp9=unaryExp();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, unaryExp9.Tree);
				DebugLocation(57, 14);
				if (state.backtracking == 0)
				{
					 retval.node = (unaryExp9!=null?unaryExp9.node:default(Node)); 
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if (state.backtracking == 0) {
			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mulExp", 5);
			LeaveRule("mulExp", 5);
			LeaveRule_mulExp();
		}
		DebugLocation(58, 2);
		} finally { DebugExitRule(GrammarFileName, "mulExp"); }
		return retval;

	}
	// $ANTLR end "mulExp"

	private sealed partial class unaryExp_return : AstParserRuleReturnScope<object, IToken>
	{
		public Node node;
		public unaryExp_return(KnightyCodeParser grammar) {OnCreated(grammar);}
		partial void OnCreated(KnightyCodeParser grammar);
	}

	partial void EnterRule_unaryExp();
	partial void LeaveRule_unaryExp();
	// $ANTLR start "unaryExp"
	// KnightyCode.g:60:1: unaryExp returns [Node node] : literal ;
	[GrammarRule("unaryExp")]
	private KnightyCodeParser.unaryExp_return unaryExp()
	{
		EnterRule_unaryExp();
		EnterRule("unaryExp", 6);
		TraceIn("unaryExp", 6);
		KnightyCodeParser.unaryExp_return retval = new KnightyCodeParser.unaryExp_return(this);
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		KnightyCodeParser.literal_return literal10 = default(KnightyCodeParser.literal_return);

		try { DebugEnterRule(GrammarFileName, "unaryExp");
		DebugLocation(60, 2);
		try
		{
			// KnightyCode.g:61:3: ( literal )
			DebugEnterAlt(1);
			// KnightyCode.g:61:6: literal
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(61, 6);
			PushFollow(Follow._literal_in_unaryExp250);
			literal10=literal();
			PopFollow();
			if (state.failed) return retval;
			if (state.backtracking == 0) adaptor.AddChild(root_0, literal10.Tree);
			DebugLocation(61, 14);
			if (state.backtracking == 0)
			{
				 retval.node = new NumberNode( (literal10!=null?input.ToString(literal10.Start,literal10.Stop):null) ); 
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if (state.backtracking == 0) {
			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("unaryExp", 6);
			LeaveRule("unaryExp", 6);
			LeaveRule_unaryExp();
		}
		DebugLocation(62, 2);
		} finally { DebugExitRule(GrammarFileName, "unaryExp"); }
		return retval;

	}
	// $ANTLR end "unaryExp"

	private sealed partial class literal_return : AstParserRuleReturnScope<object, IToken>
	{
		public Node node;
		public literal_return(KnightyCodeParser grammar) {OnCreated(grammar);}
		partial void OnCreated(KnightyCodeParser grammar);
	}

	partial void EnterRule_literal();
	partial void LeaveRule_literal();
	// $ANTLR start "literal"
	// KnightyCode.g:64:1: literal returns [Node node] : ( number | '(' exp ')' );
	[GrammarRule("literal")]
	private KnightyCodeParser.literal_return literal()
	{
		EnterRule_literal();
		EnterRule("literal", 7);
		TraceIn("literal", 7);
		KnightyCodeParser.literal_return retval = new KnightyCodeParser.literal_return(this);
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken char_literal12 = default(IToken);
		IToken char_literal14 = default(IToken);
		KnightyCodeParser.number_return number11 = default(KnightyCodeParser.number_return);
		KnightyCodeParser.exp_return exp13 = default(KnightyCodeParser.exp_return);

		object char_literal12_tree = default(object);
		object char_literal14_tree = default(object);
		try { DebugEnterRule(GrammarFileName, "literal");
		DebugLocation(64, 2);
		try
		{
			// KnightyCode.g:65:3: ( number | '(' exp ')' )
			int alt4=2;
			try { DebugEnterDecision(4, false);
			int LA4_1 = input.LA(1);

			if ((LA4_1==Number))
			{
				alt4 = 1;
			}
			else if ((LA4_1==9))
			{
				alt4 = 2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 4, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// KnightyCode.g:65:6: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 6);
				PushFollow(Follow._number_in_literal270);
				number11=number();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, number11.Tree);
				DebugLocation(65, 13);
				if (state.backtracking == 0)
				{
					 retval.node = (number11!=null?number11.node:default(Node)); 
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// KnightyCode.g:66:6: '(' exp ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(66, 6);
				char_literal12=(IToken)Match(input,9,Follow._9_in_literal279); if (state.failed) return retval;
				if (state.backtracking == 0) {
				char_literal12_tree = (object)adaptor.Create(char_literal12);
				adaptor.AddChild(root_0, char_literal12_tree);
				}
				DebugLocation(66, 10);
				PushFollow(Follow._exp_in_literal281);
				exp13=exp();
				PopFollow();
				if (state.failed) return retval;
				if (state.backtracking == 0) adaptor.AddChild(root_0, exp13.Tree);
				DebugLocation(66, 14);
				char_literal14=(IToken)Match(input,10,Follow._10_in_literal283); if (state.failed) return retval;
				if (state.backtracking == 0) {
				char_literal14_tree = (object)adaptor.Create(char_literal14);
				adaptor.AddChild(root_0, char_literal14_tree);
				}
				DebugLocation(66, 18);
				if (state.backtracking == 0)
				{
					 retval.node = (exp13!=null?exp13.node:default(Node)); 
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if (state.backtracking == 0) {
			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("literal", 7);
			LeaveRule("literal", 7);
			LeaveRule_literal();
		}
		DebugLocation(67, 2);
		} finally { DebugExitRule(GrammarFileName, "literal"); }
		return retval;

	}
	// $ANTLR end "literal"

	private sealed partial class number_return : AstParserRuleReturnScope<object, IToken>
	{
		public Node node;
		public number_return(KnightyCodeParser grammar) {OnCreated(grammar);}
		partial void OnCreated(KnightyCodeParser grammar);
	}

	partial void EnterRule_number();
	partial void LeaveRule_number();
	// $ANTLR start "number"
	// KnightyCode.g:69:1: number returns [Node node] : Number ;
	[GrammarRule("number")]
	private KnightyCodeParser.number_return number()
	{
		EnterRule_number();
		EnterRule("number", 8);
		TraceIn("number", 8);
		KnightyCodeParser.number_return retval = new KnightyCodeParser.number_return(this);
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken Number15 = default(IToken);

		object Number15_tree = default(object);
		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(69, 1);
		try
		{
			// KnightyCode.g:70:2: ( Number )
			DebugEnterAlt(1);
			// KnightyCode.g:70:4: Number
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(70, 4);
			Number15=(IToken)Match(input,Number,Follow._Number_in_number301); if (state.failed) return retval;
			if (state.backtracking == 0) {
			Number15_tree = (object)adaptor.Create(Number15);
			adaptor.AddChild(root_0, Number15_tree);
			}
			DebugLocation(71, 2);
			if (state.backtracking == 0)
			{
				 retval.node = new NumberNode( (Number15!=null?Number15.Text:null) ); 
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if (state.backtracking == 0) {
			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("number", 8);
			LeaveRule("number", 8);
			LeaveRule_number();
		}
		DebugLocation(72, 1);
		} finally { DebugExitRule(GrammarFileName, "number"); }
		return retval;

	}
	// $ANTLR end "number"

	partial void EnterRule_synpred3_KnightyCode_fragment();
	partial void LeaveRule_synpred3_KnightyCode_fragment();

	// $ANTLR start synpred3_KnightyCode
	public void synpred3_KnightyCode_fragment()
	{
		IToken op = default(IToken);
		KnightyCodeParser.mulExp_return lhs = default(KnightyCodeParser.mulExp_return);
		KnightyCodeParser.addExp_return rhs = default(KnightyCodeParser.addExp_return);

		EnterRule_synpred3_KnightyCode_fragment();
		EnterRule("synpred3_KnightyCode_fragment", 11);
		TraceIn("synpred3_KnightyCode_fragment", 11);
		try
		{
			// KnightyCode.g:51:6: (lhs= mulExp op= ( '+' | '-' ) rhs= addExp )
			DebugEnterAlt(1);
			// KnightyCode.g:51:6: lhs= mulExp op= ( '+' | '-' ) rhs= addExp
			{
			DebugLocation(51, 9);
			PushFollow(Follow._mulExp_in_synpred3_KnightyCode164);
			lhs=mulExp();
			PopFollow();
			if (state.failed) return;
			DebugLocation(51, 19);

			op=(IToken)input.LT(1);
			if ((input.LA(1)>=12 && input.LA(1)<=13))
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(51, 35);
			PushFollow(Follow._addExp_in_synpred3_KnightyCode178);
			rhs=addExp();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred3_KnightyCode_fragment", 11);
			LeaveRule("synpred3_KnightyCode_fragment", 11);
			LeaveRule_synpred3_KnightyCode_fragment();
		}
	}
	// $ANTLR end synpred3_KnightyCode

	partial void EnterRule_synpred5_KnightyCode_fragment();
	partial void LeaveRule_synpred5_KnightyCode_fragment();

	// $ANTLR start synpred5_KnightyCode
	public void synpred5_KnightyCode_fragment()
	{
		IToken op = default(IToken);
		KnightyCodeParser.unaryExp_return lhs = default(KnightyCodeParser.unaryExp_return);
		KnightyCodeParser.mulExp_return rhs = default(KnightyCodeParser.mulExp_return);

		EnterRule_synpred5_KnightyCode_fragment();
		EnterRule("synpred5_KnightyCode_fragment", 13);
		TraceIn("synpred5_KnightyCode_fragment", 13);
		try
		{
			// KnightyCode.g:56:6: (lhs= unaryExp op= ( '*' | '/' ) rhs= mulExp )
			DebugEnterAlt(1);
			// KnightyCode.g:56:6: lhs= unaryExp op= ( '*' | '/' ) rhs= mulExp
			{
			DebugLocation(56, 9);
			PushFollow(Follow._unaryExp_in_synpred5_KnightyCode208);
			lhs=unaryExp();
			PopFollow();
			if (state.failed) return;
			DebugLocation(56, 21);

			op=(IToken)input.LT(1);
			if (input.LA(1)==11||input.LA(1)==14)
			{
				input.Consume();
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(56, 37);
			PushFollow(Follow._mulExp_in_synpred5_KnightyCode222);
			rhs=mulExp();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred5_KnightyCode_fragment", 13);
			LeaveRule("synpred5_KnightyCode_fragment", 13);
			LeaveRule_synpred5_KnightyCode_fragment();
		}
	}
	// $ANTLR end synpred5_KnightyCode
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _exp_in_parse92 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_parse94 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _printExp_in_exp114 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Print_in_printExp132 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _Space_in_printExp134 = new BitSet(new ulong[]{0x210UL});
		public static readonly BitSet _addExp_in_printExp136 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _addExp_in_printExp143 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mulExp_in_addExp164 = new BitSet(new ulong[]{0x3000UL});
		public static readonly BitSet _set_in_addExp168 = new BitSet(new ulong[]{0x210UL});
		public static readonly BitSet _addExp_in_addExp178 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mulExp_in_addExp186 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unaryExp_in_mulExp208 = new BitSet(new ulong[]{0x4800UL});
		public static readonly BitSet _set_in_mulExp212 = new BitSet(new ulong[]{0x210UL});
		public static readonly BitSet _mulExp_in_mulExp222 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unaryExp_in_mulExp230 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _literal_in_unaryExp250 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_literal270 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _9_in_literal279 = new BitSet(new ulong[]{0x230UL});
		public static readonly BitSet _exp_in_literal281 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _10_in_literal283 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Number_in_number301 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mulExp_in_synpred3_KnightyCode164 = new BitSet(new ulong[]{0x3000UL});
		public static readonly BitSet _set_in_synpred3_KnightyCode168 = new BitSet(new ulong[]{0x210UL});
		public static readonly BitSet _addExp_in_synpred3_KnightyCode178 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unaryExp_in_synpred5_KnightyCode208 = new BitSet(new ulong[]{0x4800UL});
		public static readonly BitSet _set_in_synpred5_KnightyCode212 = new BitSet(new ulong[]{0x210UL});
		public static readonly BitSet _mulExp_in_synpred5_KnightyCode222 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}

} // namespace  KnightyCode 
