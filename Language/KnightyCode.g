grammar KnightyCode;

options {
    language=CSharp3;
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
	public void Run( string code, Context context )
	{
        try {
            parse().Evaluate( context );
        } catch (RecognitionException e)  {
            Console.Error.WriteLine(e.StackTrace);
        }
	}
}
 
parse returns [Node node]
  :  exp EOF { $node = $exp.node; }
  ;
  
exp returns [Node node]
  : 
  printExp { $node = $printExp.node; }
  | { $node = new CodeBodyNode( ); }
	a=printExp { ( $node as CodeBodyNode ).Nodes.Add( $a.node ); } ';' Space?
  ( b=printExp { ( $node as CodeBodyNode ).Nodes.Add( $b.node ); } ';' )* 
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
  :  literal { $node = $literal.node; }
  ;

literal returns [Node node]
  :  number { $node = $number.node; }
  | ifExp { $node = $ifExp.node; }
  | whileExp { $node = $whileExp.node; }
  |  '(' exp ')' { $node = $exp.node; }
  ;

number returns [Node node]
	: Number
	{ $node = new NumberNode( $Number.text ); }
	;

/*-------------------------------------------*/
// Block expressions
/*-------------------------------------------*/

ifExp returns [IfNode node]
	: If con=exp { $node = new IfNode( $con.node ); }
	'{' true_body=exp '}' { $node.True = $true_body.node; }
	( Else '{' false_body=exp '}' { $node.False = $false_body.node; } )?
	;

whileExp returns [WhileNode node]
	: While con=exp { $node = new WhileNode( $con.node ); }
	'{' body=exp '}' { $node.Body = $body.node; }
	;

/*-------------------------------------------*/
// Lexer
/*-------------------------------------------*/

Number
  :  ('0'..'9')+ ('.' ('0'..'9')+)?
  ;

If
  :  ('if')
  ;

 Else
: ('else')
;

While
  :  ('while')
  ;

Space 
  :  (' ' | '\t' | '\r' | '\n'){Skip();}
  ;

Print
: ('print')
;