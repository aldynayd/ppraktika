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
    stat1* op=ASSIGN? stat1* NL          # assign
    ;
    
stat1
    : expr                               # printExpr
    ;

expr
    : 
      expr MOD expr                 # Mod
    | expr MUL expr                 # Mul
    | expr DIV expr                 # Div
    | expr GT expr                  # Gt
    | expr LT expr                  # Lt
    | expr GTA expr                 # Gta
    | expr LTA expr                 # Lta
    | expr ADD expr                 # Add
    | expr SUB expr                 # Sub
    | expr POW expr                 # Pow
    | SIN expr                      # Sin
    | COS expr                      # Cos
    | TAN expr                      # Tan
    | LN expr                       # Ln
    | SQRT expr                     # Sqrt
    | '+' primary                   # unaryplus
    | '-' primary                   # unaryminus
    | primary                       # prim
    ;
    
primary
    : NUM                               # num
    | ID                                # id
    | LL expr+ RL                       # parens
    ;

MOD : '\u0440\u0430\u0437\u0434\u0435\u043b\u0438\u0442\u044c\u0020\u043f\u043e\u0020\u043c\u043e\u0434\u0443\u043b\u044e'
        // 'разделить по модулю'
    | '\u043f\u043e\u0020\u043c\u043e\u0434\u0443\u043b\u044e' ; // 'по модулю'

MUL : '\u0443\u043c\u043d\u043e\u0436\u0438\u0442\u044c'                       // 'умножить'
    | '\u0443\u043c\u043d\u043e\u0436\u0438\u0442\u044c\u0020\u043d\u0430'      // 'умножить на'
    | '\u043d\u0430' ;                                                          // 'на'

DIV : '\u0440\u0430\u0437\u0434\u0435\u043b\u0438\u0442\u044c'                      // 'разделить'
    | '\u0440\u0430\u0437\u0434\u0435\u043b\u0438\u0442\u044c\u0020\u043d\u0430';   // 'разделить на'

ADD : '\u043f\u043b\u044e\u0441'                                 // 'плюс'
    | '\u043f\u0440\u0438\u0431\u0430\u0432\u0438\u0442\u044c' ; // 'прибавить'

SUB : '\u043c\u0438\u043d\u0443\u0441'                          // 'минус' 
    | '\u043e\u0442\u043d\u044f\u0442\u044c' ;                  // 'отнять'   

ASSIGN : '\u0440\u0430\u0432\u043d\u043e';                       // 'равно'

POW : '\u0432\u043e\u0437\u0432\u0435\u0441\u0442\u0438\u0020\u0432\u0020\u0441\u0442\u0435\u043f\u0435\u043d\u044c'    // 'возвести в степень'
    | '\u0432\u0020\u0441\u0442\u0435\u043f\u0435\u043d\u044c'                                                          // 'в степень'
    | '\u0432\u0020\u0441\u0442\u0435\u043f\u0435\u043d\u0438';                                                         // 'в степени'

SIN: '\u0441\u0438\u043d\u0443\u0441'; // 'синус'
COS: '\u043a\u043e\u0441\u0438\u043d\u0443\u0441'; // 'косинус'
TAN: '\u0442\u0430\u043d\u0433\u0435\u043d\u0441'; // 'тангенс'
LN: '\u043d\u0430\u0442\u0443\u0440\u0430\u043b\u044c\u043d\u044b\u0439\u0020\u043b\u043e\u0433\u0430\u0440\u0438\u0444\u043c';  // 'натуральный логарифм'
LOG: '\u043b\u043e\u0433\u0430\u0440\u0438\u0444\u043c'; // 'логарифм'
SQRT: '\u043a\u0432\u0430\u0434\u0440\u0430\u0442\u043d\u044b\u0439\u0020\u043a\u043e\u0440\u0435\u043d\u044c'
    | '\u043a\u0432\u0430\u0434\u0440\u0430\u0442\u043d\u044b\u0439\u0020\u043a\u043e\u0440\u0435\u043d\u044c\u0020\u0438\u0437'; // 'квадратный корень'

GT : '\u0431\u043e\u043b\u044c\u0448\u0435' ; // 'больше' '>'
LT : '\u043c\u0435\u043d\u044c\u0448\u0435'; // 'меньше' '<'
GTA : '\u0431\u043e\u043b\u044c\u0448\u0435\u0020\u0438\u043b\u0438\u0020\u0440\u0430\u0432\u043d\u043e' ; 
    // 'больше или равно' '=>'
LTA : '\u043c\u0435\u043d\u044c\u0448\u0435\u0020\u0438\u043b\u0438\u0020\u0440\u0430\u0432\u043d\u043e'; 
    // 'меньше или равно' '<='

LL: '\u043b\u0435\u0432\u0430\u044f\u0020\u0441\u043a\u043e\u0431\u043a\u0430'; // 'левая скобка'
RL: '\u043f\u0440\u0430\u0432\u0430\u044f\u0020\u0441\u043a\u043e\u0431\u043a\u0430'; // 'правая скобка'
ID  : Letter (Letter|Digit)* ;

NUM : INT
    | FLT
    ;

INT : Digit+ ;

FLT : Digit+ '.' Digit*
    | '.' Digit+
    ;

NL  : '\r'? '\n' ;               // return newline to parser (is end-statement signal)

WS  : (' ' | '\t')+ -> channel(HIDDEN) ;    // toss out whitespace

fragment
Letter
    : '\u0400'..'\u04FF' 
    | [a-zA-Z_]
    ;

fragment
Digit
    : [0-9]
    ;