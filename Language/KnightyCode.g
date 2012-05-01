grammar KnightyCode;

options {
    language=CSharp3;
	output = AST;
	backtrack=true;
}
 
tokens {
  ROOT;
  UNARY_MIN;
}

@parser::namespace { KnightyCode }
@lexer::namespace { KnightyCode }

@header {
using System;
}
 
@members {
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
}
 
parse returns [Node node]
  :  exp EOF { $node = $exp.node; }
  ;

exp returns [Node node]
  :  printExp { $node = $printExp.node; }
  ;

printExp returns [Node node]
	: Print Space addExp { $node = new PrintNode( $addExp.node ); }
	| addExp { $node = $addExp.node; }
	;

addExp returns [Node node]
  :  lhs=mulExp op=('+' | '-') rhs=addExp { $node = new CalcNode( $op.text, $lhs.node, $rhs.node );  }
  | mulExp { $node = $mulExp.node; }
  ;

mulExp returns [Node node]
  :  lhs=unaryExp op=('*' | '/') rhs=mulExp { $node = new CalcNode( $op.text, $lhs.node, $rhs.node );  }
  | unaryExp { $node = $unaryExp.node; }
  ;

unaryExp returns [Node node]
  :  literal { $node = new NumberNode( $literal.text ); }
  ;

literal returns [Node node]
  :  number { $node = $number.node; }
  |  '(' exp ')' { $node = $exp.node; }
  ;

number returns [Node node]
	: Number
	{ $node = new NumberNode( $Number.text ); }
	;

/*-------------------------------------------*/
// Lexer
/*-------------------------------------------*/

Number
  :  ('0'..'9')+ ('.' ('0'..'9')+)?
  ;

Space 
  :  (' ' | '\t' | '\r' | '\n'){Skip();}
  ;

Print
: ('print')
;