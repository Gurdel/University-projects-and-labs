#include "Mana.h"

int main()
{
    Make_Magic();
    return 0;
}

bool numb(char a) {if ((a=='0')||(a=='1')||(a=='2')||(a=='3')||(a=='4')||(a=='5')||(a=='6')||(a=='7')||(a=='8')||(a=='9')) return true; return false;}
bool number(string s) // чи є строка числом
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

void check(string &s) //коректність введеної строки
{
    string s1;
    int var, mi, i;
    //дужка на число
    int size = s.size();
    for(i = 0; i<size-1;++i)
        if(((numb(s[i]))&&s[i+1]=='(')||((s[i]==')')&&numb(s[i+1])))
    {
        s.insert(i+1,"*");
        size=s.size();
    }

    //пробіли
    while(s.find(" ")!=string::npos)
    {
        var=s.find(" ");
        s1=s.substr(0,var);
         cout<<"s1=="<<s1<<endl;
        s.erase(0,var+1);
        calc(s1);
        cout<<s1<<endl;
        cout<<"s=="<<s<<endl;
    }

    //
    for(i=0; i<size;)
    {
        mi = 0;
        var = i;
        while(s[var]=='+'||s[var]=='-') {if(s[var]=='-') ++mi; ++var;}
        cout<<"i="<<i<<" var="<<var<<" mi="<<mi<<endl;
        if(i!=var) {
        s.erase(i,var-i);
        if((mi%2)==1) s.insert(i,"-");
            else s.insert(i,"+");
        size = s.size();
        }
        cout<<s<<endl;
        ++i;
    }
}

void calc(string &s)
{
    check(s);
    int arM = 0, next;
    double d;
    int size = s.size();
if(size!=0){
    string ar[size][3];
    ar[arM][1]=ar[arM][2]="";
    for(int i = 0; i<size; ++i)
    {
                 if(s[i] == '.') ar[arM][1]=ar[arM][1]+".";
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

        else if(s[i] == '+') {ar[arM][2]="+"; ++arM; ar[arM][1]=ar[arM][2]="";}
        else if(s[i] == '-') {ar[arM][2]="-"; ++arM; ar[arM][1]=ar[arM][2]="";}
        else if(s[i] == '*') {ar[arM][2]="*"; ++arM; ar[arM][1]=ar[arM][2]="";}
        else if(s[i] == '/') {ar[arM][2]="/"; ++arM; ar[arM][1]=ar[arM][2]="";}
        else if(s[i] == '%') {ar[arM][2]="%"; ++arM; ar[arM][1]=ar[arM][2]="";}
        else if(s[i] == '^') {ar[arM][2]="^"; ++arM; ar[arM][1]=ar[arM][2]="";}
    }
    for(int i = 0; i<arM; ++i)
    {
        next = i+1;
        while(next<=arM&&ar[next][1]==""&&ar[next][2]=="") ++next;
        if(ar[i][2] == "*") {d=atof(ar[i][1].c_str()) * atof(ar[next][1].c_str()); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}
        if(ar[i][2] == "/") {d=atof(ar[i][1].c_str()) / atof(ar[next][1].c_str()); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}
        if(ar[i][2] == "%") {d=int(atof(ar[i][1].c_str())) % int(atof(ar[next][1].c_str())); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}
        if(ar[i][2] == "^") {d=pow(atof(ar[i][1].c_str()),  atof(ar[next][1].c_str())); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}
for(int i = 0; i<=arM; ++i)
cout<<i<<')'<<ar[i][1]<<ar[i][2]<<endl;
    }
    for(int i = 0; i<arM; ++i)
    {
        next = i+1;
        while(next<=arM&&ar[next][1]==""&&ar[next][2]=="") ++next;
        if(ar[i][2] == "+") {d=atof(ar[i][1].c_str()) + atof(ar[next][1].c_str()); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}
        if(ar[i][2] == "-") {d=atof(ar[i][1].c_str()) - atof(ar[next][1].c_str()); dbl<<d; ar[next][1]=dbl.str(); dbl.str(""); ar[i][1] = ar[i][2] = "";}
for(int i = 0; i<=arM; ++i)
cout<<i<<')'<<ar[i][1]<<ar[i][2]<<endl;
    }

    s=ar[arM][1];
}
}

void Make_Magic()
{
    string s,s1="";
cout<<'>';
   getline(cin, s);
   calc(s);
   cout<<s;
while(1)
{
   if(number(s))
    {
    cout<<endl;
    cout<<'>';
    getline(cin, s);
    }
    else
   {
       cout<<'>';
       getline(cin, s1);
       s=s+s1;
   }
   calc(s);
   cout<<s;
}
}
