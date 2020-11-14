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
    stat1* op=ASSIGN? stat1* NL             # assign;
stat1
    : expr                               # printExpr
    ;

expr
    : 
     expr op=(MOD|MUL|DIV) expr         # ModMulDiv
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

MUL : '\u0443\u043c\u043d\u043e\u0436\u0438\u0442\u044c' ;

DIV : '\u0440\u0430\u0437\u0434\u0435\u043b\u0438\u0442\u044c' ;

ADD : '\u043f\u043b\u044e\u0441' ;

SUB : '\u043c\u0438\u043d\u0443\u0441' ;

ASSIGN : '\u0440\u0430\u0432\u043d\u043e';

ID  : Letter (Letter|Digit)* ;

NUM : INT
    | FLT
    ;

INT : Digit+ ;

FLT : Digit+ '.' Digit*
    | '.' Digit+
    ;

NL  : '\r'? '\n' ;        // return newline to parser (is end-statement signal)

WS  : (' ' | '\t')+ -> skip ;    // toss out whitespace

fragment
Letter
    : '\u0400'..'\u04FF'
    ;

fragment
Digit
    : [0-9]
    ;