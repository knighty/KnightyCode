//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4.1.9004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4.1.9004 KnightyCodeParser.g 2012-04-30 14:16:22

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;
using ConditionalAttribute = System.Diagnostics.ConditionalAttribute;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4.1.9004")]
[System.CLSCompliant(false)]
public partial class KnightyCodeParserLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int NUMBER=4;
	public const int PLUS=5;

    // delegates
    // delegators

	public KnightyCodeParserLexer()
	{
		OnCreated();
	}

	public KnightyCodeParserLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public KnightyCodeParserLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "KnightyCodeParser.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];

	[Conditional("ANTLR_TRACE")]
	protected virtual void OnCreated() {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    [Conditional("ANTLR_TRACE")]
    protected virtual void EnterRule_NUMBER() {}
    [Conditional("ANTLR_TRACE")]
    protected virtual void LeaveRule_NUMBER() {}

    // $ANTLR start "NUMBER"
    [GrammarRule("NUMBER")]
    private void mNUMBER()
    {
    	EnterRule_NUMBER();
    	EnterRule("NUMBER", 1);
    	TraceIn("NUMBER", 1);
    		try
    		{
    		int _type = NUMBER;
    		int _channel = DefaultTokenChannel;
    		// KnightyCodeParser.g:9:9: ( ( '0' .. '9' )+ )
    		DebugEnterAlt(1);
    		// KnightyCodeParser.g:9:11: ( '0' .. '9' )+
    		{
    		DebugLocation(9, 11);
    		// KnightyCodeParser.g:9:11: ( '0' .. '9' )+
    		int cnt1=0;
    		try { DebugEnterSubRule(1);
    		while (true)
    		{
    			int alt1=2;
    			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    			int LA1_1 = input.LA(1);

    			if (((LA1_1>='0' && LA1_1<='9')))
    			{
    				alt1 = 1;
    			}


    			} finally { DebugExitDecision(1); }
    			switch (alt1)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// KnightyCodeParser.g:
    				{
    				DebugLocation(9, 11);
    				input.Consume();


    				}
    				break;

    			default:
    				if (cnt1 >= 1)
    					goto loop1;

    				EarlyExitException eee1 = new EarlyExitException( 1, input );
    				DebugRecognitionException(eee1);
    				throw eee1;
    			}
    			cnt1++;
    		}
    		loop1:
    			;

    		} finally { DebugExitSubRule(1); }


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
    		TraceOut("NUMBER", 1);
    		LeaveRule("NUMBER", 1);
    		LeaveRule_NUMBER();
        }
    }
    // $ANTLR end "NUMBER"

    [Conditional("ANTLR_TRACE")]
    protected virtual void EnterRule_PLUS() {}
    [Conditional("ANTLR_TRACE")]
    protected virtual void LeaveRule_PLUS() {}

    // $ANTLR start "PLUS"
    [GrammarRule("PLUS")]
    private void mPLUS()
    {
    	EnterRule_PLUS();
    	EnterRule("PLUS", 2);
    	TraceIn("PLUS", 2);
    		try
    		{
    		int _type = PLUS;
    		int _channel = DefaultTokenChannel;
    		// KnightyCodeParser.g:11:9: ( '+' )
    		DebugEnterAlt(1);
    		// KnightyCodeParser.g:11:11: '+'
    		{
    		DebugLocation(11, 11);
    		Match('+'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
    		TraceOut("PLUS", 2);
    		LeaveRule("PLUS", 2);
    		LeaveRule_PLUS();
        }
    }
    // $ANTLR end "PLUS"

    public override void mTokens()
    {
    	// KnightyCodeParser.g:1:8: ( NUMBER | PLUS )
    	int alt2=2;
    	try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    	int LA2_1 = input.LA(1);

    	if (((LA2_1>='0' && LA2_1<='9')))
    	{
    		alt2 = 1;
    	}
    	else if ((LA2_1=='+'))
    	{
    		alt2 = 2;
    	}
    	else
    	{
    		NoViableAltException nvae = new NoViableAltException("", 2, 0, input, 1);
    		DebugRecognitionException(nvae);
    		throw nvae;
    	}
    	} finally { DebugExitDecision(2); }
    	switch (alt2)
    	{
    	case 1:
    		DebugEnterAlt(1);
    		// KnightyCodeParser.g:1:10: NUMBER
    		{
    		DebugLocation(1, 10);
    		mNUMBER(); 

    		}
    		break;
    	case 2:
    		DebugEnterAlt(2);
    		// KnightyCodeParser.g:1:17: PLUS
    		{
    		DebugLocation(1, 17);
    		mPLUS(); 

    		}
    		break;

    	}

    }


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

 
	#endregion

}
