%{
    #include <string>
    #define YYSTYPE std::string
    #include "senseg.tab.hpp"
    void yyerror(char *s);
    
    char m_invalidEscape[] = "Invalid escape sequence";
    char m_newline[] = "Newline in string literal";
    char m_invalidCharacter[] = "Invalid character";
    
    
    int offset = 0;
    int startOfPunchedCard = 79;
    
%}

%option yylineno
%option noyywrap


%x STR

%%

SENSEG {
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }
    return SENSEG;
    }
NAME {
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }
   return NAME;
}
PARENT {
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }
    return PARENT;
}
PROCOPT {
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }
    return PROCOPT;
}
SSPTR {
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }
    return SSPTR;
}
INDICES {
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }
    return INDICES;
}


[0-9]+          {
    yylval = yytext;
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    } else {
        return NUM;
    }

}
[a-zA-Z_][a-zA-Z0-9_]* {
    yylval = yytext;
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }
    
    return ID;
}
<STR>[^\\\n"]+  {
        
        for (int i = 0; i < yyleng; i++) {
            yytext[i] = ' ';
        }
        BEGIN 0;
        
        yylval += yytext;
}

<STR>\\n        yylval += '\n';
<STR>\\         yyerror(m_invalidEscape);
<STR>\n         {
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }

    for (int i = 0; i < yyleng; i++) {
    yytext[i] = ' ';
    }
    BEGIN 0;
    //yyerror(m_newline);
}
[ \t\r\n]       {
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }
}; // whitespace
[-{};()<>=+*/!,] {
    offset += yyleng;
    if (offset > startOfPunchedCard) {
        BEGIN STR;
    }
    return *yytext;
}
.               yyerror(m_invalidCharacter);

%%
