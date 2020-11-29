#include "mana.hpp"

bool numb(char a) //чи є символ цифрою
{if ((a=='0')||(a=='1')||(a=='2')||(a=='3')||(a=='4')||(a=='5')||(a=='6')||(a=='7')||(a=='8')||(a=='9')) return true; return false;}

bool oper(char a) {if ((a=='*')||(a=='/')||(a=='^')||(a=='%')||(a=='+')||(a=='-')||(a=='&')||(a=='|')||(a=='"')) return true; return false;}
bool number(string s) // чи є рядок числом
{
    int point = 0;
    int size = s.size();
    int i=0;
    if (s[0] == '-') i =1;
    for(;i<size;++i)
    {
        if((s[i] != '.')&&(s[i] != '0')&&(s[i] != '1')&&(s[i] != '2')&&(s[i] != '3')&&(s[i] != '4')&&(s[i] != '5')&&(s[i] != '6')&&(s[i] != '7')&&(s[i] != '8')&&(s[i] != '9')) ++point;
        if(s[i]=='.') ++point;
    }
    if(point>1) return false;
    return true;
}

bool check(string &s) //коректність введеного рядка
{
    if(s=="") return false;
    string s1;
    int var, mi, i;
    if(s[0]=='-' || s[0]=='+') s.insert(0,"0");
    int size = s.size();
//слова заміняє на відповідні символи операцій
    while(s.find("plus")!=string::npos) {var=s.find("plus"); s.erase(var,4); s.insert(var,"+");}
    while(s.find("minus")!=string::npos) {var=s.find("minus"); s.erase(var,5); s.insert(var,"-");}
    while(s.find("star")!=string::npos) {var=s.find("star"); s.erase(var,4); s.insert(var,"*");}
    while(s.find("slesh")!=string::npos) {var=s.find("slesh"); s.erase(var,5); s.insert(var,"/");}
    while(s.find("percent")!=string::npos) {var=s.find("percent"); s.erase(var,7); s.insert(var,"%");}
    while(s.find("power")!=string::npos) {var=s.find("power"); s.erase(var,5); s.insert(var,"^");}
    while(s.find("and")!=string::npos) {var=s.find("and"); s.erase(var,3); s.insert(var,"&");}
    while(s.find("xor")!=string::npos) {var=s.find("xor"); s.erase(var,3); s.insert(var,"\"");}
    while(s.find("or")!=string::npos) {var=s.find("or"); s.erase(var,2); s.insert(var,"|");}
    while(s.find("not")!=string::npos) {var=s.find("not"); s.erase(var,3); s.insert(var,"!");}

    //видаляє непотрібні операції
    for(i = 0; i<size; ++i)
    {
        if(s[i]=='*' || s[i]=='/' || s[i]=='^' || s[i]=='%')
        {
            for(var = i+1;(s[var]=='*' || s[var]=='/' || s[var]=='^' || s[var]=='%') && var<size; ++var);
            if(var>i+1)
            {
                s.erase(i+1, var-i-1);
                size = s.size();
            }
        }
    }

    //мінуси всередині виразу
    for(i=0; i<size; ++i)
    {
        mi = 0;
        var = i;
        while(s[var]=='+'||s[var]=='-') {if(s[var]=='-') ++mi; ++var;}
        if(i!=var) {
        s.erase(i,var-i);
        if((mi%2)==1) s.insert(i,"-");
            else s.insert(i,"+");
        size = s.size();
        }
    }

    //зайву ) заміняє на пробіл
    var = mi = 0;
    for(i=0;i<size; ++i)
    {
        if(s[i]=='(') ++var;
        if(s[i]==')') ++mi;
        if(var<mi)
        {
            s[i]=' ';
            var = mi = 0;
        }
    }

    //дужка на число
    for(i = 0; i<size-1;++i)
        if(((numb(s[i]))&&s[i+1]=='(')||((s[i]==')')&&numb(s[i+1])))
    {
        s.insert(i+1,"*");
        size=s.size();
    }

    //пробіли
    while(s.find(" ")!=string::npos)
    {
        var = s.find(" ");
        s1 = s.substr(0,var);
        s.erase(0,var+1);
        size = s.size();
        if(calc(s1)) cout<<s1<<endl;
        else
        {

        }
    }

    //дивиться, чи вираз дописаний
    mi = var = 0;
    for(i=0; i<size; ++i)
    {
        if(s[i]=='(') ++mi;
        if(s[i]==')') ++var;
    }
    if(mi>var) return false;
    if(s[size-1]=='+' || s[size-1]=='-' || s[size-1]=='*' || s[size-1]=='/' || s[size-1]=='%' || s[size-1]=='^' || s[size-1]=='&' || s[size-1]=='|' || s[size-1]=='!' || s[size-1]=='"')
        return false;

    //рахує вирази у дужках
    if(s.find(")")!=string::npos)
    {
        var = s.find(")");
        for(i=var-1; i>-1; --i)
            if(s[i]=='(') break;

        if(i > -1)
        {
            s1=s.substr(i+1,var-i-1);
                if(s1!="")
            {
                calc(s1);
                s.erase(i,var-i+1);
                s.insert(i,s1);
            }
            else {s.erase(i,2); calc(s);}
        }
    }

return true;
}

bool calc(string &s)
{
    if(s.find("exit")!=string::npos) exit(0);
    int arM = 0, next, size, p = 0;
    double d;
    string s1;
if(s.size()>0 && check(s))
 {
    size = s.size();
if(s.size()!=0)
  {
    string ar[size][3];
    ar[arM][1]=ar[arM][2]="";

    //заповнює масив для підрахунку
    for(int i = 0; i<size; ++i)
    {
                 if(s[i] == '.') {if(p == 0) {ar[arM][1]=ar[arM][1]+"."; ++p;} }
            else if(s[i] == '0') ar[arM][1]=ar[arM][1]+"0";
            else if(s[i] == '1') ar[arM][1]=ar[arM][1]+"1";
            else if(s[i] == '2') ar[arM][1]=ar[arM][1]+"2";
            else if(s[i] == '3') ar[arM][1]=ar[arM][1]+"3";
            else if(s[i] == '4') ar[arM][1]=ar[arM][1]+"4";
            else if(s[i] == '5') ar[arM][1]=ar[arM][1]+"5";
            else if(s[i] == '6') ar[arM][1]=ar[arM][1]+"6";
            else if(s[i] == '7') ar[arM][1]=ar[arM][1]+"7";
            else if(s[i] == '8') ar[arM][1]=ar[arM][1]+"8";
            else if(s[i] == '9') ar[arM][1]=ar[arM][1]+"9";
            else if(s[i] == 'N') ar[arM][1]="N";

        else if(s[i] == '+') {ar[arM][2]="+"; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; p = 0;}
        else if(s[i] == '-') {ar[arM][2]="-"; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; p = 0;}
        else if(s[i] == '*') {ar[arM][2]="*"; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; if(s[i+1] == '+' || s[i+1] == '-') {ar[arM][1]+=s[i+1]; ++i;} p = 0;}
        else if(s[i] == '/') {ar[arM][2]="/"; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; if(s[i+1] == '+' || s[i+1] == '-') {ar[arM][1]+=s[i+1]; ++i;} p = 0;}
        else if(s[i] == '%') {ar[arM][2]="%"; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; if(s[i+1] == '+' || s[i+1] == '-') {ar[arM][1]+=s[i+1]; ++i;} p = 0;}
        else if(s[i] == '^') {ar[arM][2]="^"; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; if(s[i+1] == '+' || s[i+1] == '-') {ar[arM][1]+=s[i+1]; ++i;} p = 0;}
        else if(s[i] == '&') {ar[arM][2]="&"; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; if(s[i+1] == '+' || s[i+1] == '-') {ar[arM][1]+=s[i+1]; ++i;} p = 0;}
        else if(s[i] == '|') {ar[arM][2]="|"; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; if(s[i+1] == '+' || s[i+1] == '-') {ar[arM][1]+=s[i+1]; ++i;} p = 0;}
        else if(s[i] == '"') {ar[arM][2]="\""; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; if(s[i+1] == '+' || s[i+1] == '-') {ar[arM][1]+=s[i+1]; ++i;} p = 0;}
        else if(s[i] == '!') {ar[arM][2]="!"; if(ar[arM][1].find("N")!=string::npos) ar[arM][1]="N"; ++arM; ar[arM][1]=ar[arM][2]=""; if(s[i+1] == '+' || s[i+1] == '-') {ar[arM][1]+=s[i+1]; ++i;} p = 0;}
    }

//заперечення
    for(int i = 0; i<arM; ++i)
    {
        next = i+1;
        while(next<=arM&&ar[next][1]==""&&ar[next][2]=="") ++next;
        if(ar[i][2] == "!") if(ar[next][1]=="0") {ar[next][1]="1"; dbl.str(""); ar[i][1] = ar[i][2] = "";} else {ar[next][1]="0"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
    }

//множення і подібне
    for(int i = 0; i<arM; ++i)
    {
        next = i+1;
        while(next<=arM&&ar[next][1]==""&&ar[next][2]=="") ++next;

        if(ar[i][2] == "*") if(ar[i][1]=="N" || ar[next][1]=="N") {ar[next][1]="N"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
           else {d=atof(ar[i][1].c_str()) * atof(ar[next][1].c_str()); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}

        if(ar[i][2] == "/") if(ar[next][1]=="0"){ar[next][1]="N"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
        else if(ar[i][1]=="N") {ar[next][1]="N"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
         else if(ar[next][1]=="N") {ar[next][1]="0"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
            else {d=atof(ar[i][1].c_str()) / atof(ar[next][1].c_str()); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}

        if(ar[i][2] == "%") if(ar[next][1]=="0") {ar[next][1]=ar[1][1]; dbl.str(""); ar[i][1] = ar[i][2] = "";}
        else if(ar[i][1]=="N") {ar[next][1]="N"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
        else if(ar[next][1]=="N") {ar[next][1]=ar[i][1]; dbl.str(""); ar[i][1] = ar[i][2] = "";}
            else {d=int(atof(ar[i][1].c_str())) % int(atof(ar[next][1].c_str())); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}

        if(ar[i][2] == "^") if(ar[i][1]=="0"){if(atof(ar[next][1].c_str())<0){ar[next][1]="N"; dbl.str(""); ar[i][1] = ar[i][2] = "";} else {ar[next][1]="0"; dbl.str(""); ar[i][1] = ar[i][2] = "";}}
        else if(ar[i][1]=="N" || ar[next][1]=="N") {ar[next][1]="N"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
            else {d=pow(atof(ar[i][1].c_str()),  atof(ar[next][1].c_str())); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}
    }

//додавання/віднімання
    for(int i = 0; i<arM; ++i)
    {
        next = i+1;
        while(next<=arM&&ar[next][1]==""&&ar[next][2]=="") ++next;
        if(ar[i][2] == "+") if(ar[i][1]=="N" || ar[next][1]=="N") {ar[next][1]="N"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
            else {d=atof(ar[i][1].c_str()) + atof(ar[next][1].c_str()); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}

        if(ar[i][2] == "-") if(ar[i][1]=="N" || ar[next][1]=="N") {ar[next][1]="N"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
            else {d=atof(ar[i][1].c_str()) - atof(ar[next][1].c_str()); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}
    }

//логічні операції
    for(int i = 0; i<arM; ++i)
    {
        next = i+1;
        while(next<=arM&&ar[next][1]==""&&ar[next][2]=="") ++next;
        if(ar[i][2] == "&") {if(ar[i][1]=="N") ar[i][1]=="1"; if(ar[next][1]=="N") ar[next][1]=="1";
            if(atof(ar[i][1].c_str()) && atof(ar[next][1].c_str())) ar[next][1]="1"; else ar[next][1]="0"; dbl.str(""); ar[i][1] = ar[i][2] = "";}

        if(ar[i][2] == "|") {if(ar[i][1]=="N") ar[i][1]=="1"; if(ar[next][1]=="N") ar[next][1]=="1";
                if(atof(ar[i][1].c_str()) || atof(ar[next][1].c_str())) ar[next][1]="1"; else ar[next][1]="0"; dbl.str(""); ar[i][1] = ar[i][2] = "";}

        if(ar[i][2] == "\"") {if(ar[i][1]=="N") ar[i][1]=="1"; if(ar[next][1]=="N") ar[next][1]=="1";
        if((atof(ar[i][1].c_str()) && !atof(ar[next][1].c_str()))||(!atof(ar[i][1].c_str()) && atof(ar[next][1].c_str())))
            ar[next][1]="1"; else ar[next][1]="0"; dbl.str(""); ar[i][1] = ar[i][2] = "";}
    }

    s=ar[arM][1];
    return true;
  }
 }
 else
    if(s!="")
 {
    cout<<s<<'>';
    getline(cin, s1);
    s=s+s1;
    calc(s);
 }
    else return false;
  return true;
}

void Make_Magic()
{
    string s,s1="";
cout<<'>';
   getline(cin, s);
while(1)
 {
   if(calc(s))
    {
    cout<<s<<endl;
    cout<<'>';
    getline(cin, s);
    }
 else
   {
       cout<<s<<'>';
       getline(cin, s);
   }
 }
}
