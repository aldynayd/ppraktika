/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

grammar Russian;
options
{
	language = CSharp;
}
@parser::namespace { Russian }
@lexer::namespace  { Russian }

INT: ('0'..'9')+ ('.' ('0'..'9')+)?
;
ID: ( [0x0430-0x044F] | [0x0410-0x042F] | '_' )
 ( [0x0430-0x044F] | [0x0410-0x042F] | '_' | '0'..'9' )*;
ADD: 'плюс' ;
SUB: 'минус' ;
MUL: 'умножить на' ;
DIV: 'разделить на' ;
ASSIGN: 'равно' ;
russian	
	: statement+
	;
statement
	: expr NEWLINE
	| ID ASSIGN expr NEWLINE
	| NEWLINE
	;
NEWLINE : ' ' | '\t' | '\f' | '\r' | '\n'
	;

expr
	: multExpression (ADD multExpression |SUB multExpression)*
	;
multExpression
	: a1=atom (MUL a2=atom | DIV a2=atom)*
	;
	
atom
	: ID
	| INT
	| '(' expr ')'
	;
