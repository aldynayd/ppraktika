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

prog
    : stat+
    ;
stat:
    stat1 op=ASSIGN stat1 NL# assign
    | stat1 NL # printStat1;
stat1
    : expr                               # printExpr
    ;

expr
    : 
     expr op=(MOD|MUL|DIV) expr        # ModMulDiv
    | expr op=(ADD|SUB) expr            # AddSub
    | ID '(' expr ')'                   # call
    | sign=('+'|'-') primary            # unary
    | primary                           # prim
    ;

primary
    : NUM                               # num
    | ID                                # id
    | '(' expr ')'                      # parens
    ;

MOD : '%' ;

MUL : '*' ;

DIV : '/' ;

ADD : '+' ;

SUB : '-' ;

ASSIGN : '=';

ID  : Letter (Letter|Digit)* ;

NUM : INT
    | FLT
    ;

INT : Digit+ ;

FLT : Digit+ '.' Digit*
    | '.' Digit+
    ;

NL  : '\r'? '\n' ;        // return newline to parser (is end-statement signal)

WS  : [ \t]+ -> skip ;    // toss out whitespace

fragment
Letter
    : [a-zA-Z_]
    ;

fragment
Digit
    : [0-9]
    ;