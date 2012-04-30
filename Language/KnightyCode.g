grammar KnightyCode;

options {
    language=CSharp3;
	output = AST;
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
            parser.parse();
        } catch (RecognitionException e)  {
            Console.Error.WriteLine(e.StackTrace);
        }
	}
}
 
parse
  :  exp EOF -> ^(ROOT exp)
  ;

exp returns [Node node]
  :  addExp { $node = $addExp.node; }
  ;

addExp returns [Node node]
  :  lhs=mulExp operator=('+' | '-') rhs=mulExp { $node = new CalcNode( $operator.text, $lhs.node, $rhs.node );  }
  ;

mulExp returns [Node node]
  :  lhs=unaryExp operator=('+' | '-') rhs=unaryExp { $node = new CalcNode( $operator.text, $lhs.text, $rhs.text );  }
  ;

unaryExp
  :  '-' literal -> ^(UNARY_MIN literal)
  |  literal
  ;

printExp returns [Node node]
	: Print number { new PrintNode( $number.node ); }
	;

literal returns [Node node]
  :  number { $node = $number.node; }
  |  '(' exp ')' -> exp { $node = $exp.node; }
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
: ('print') Number
;