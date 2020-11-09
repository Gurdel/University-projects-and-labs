#include <iostream>
#include <ctime>
#include <cmath>
#include <iomanip>

using namespace std;

float int_p();
float int_m();
float int_u();
float int_d();
float float_p();
float float_m();
float float_u();
float float_d();
float double_p();
float double_m();
float double_u();
float double_d();
float char_p();
float char_m();
float char_u();
float char_d();
void gist();

#define n 10000000
#define max(x,y) ((x) > (y)) ? (x) : (y);
#define MAX_ARR 19

clock_t before, after, before_null, after_null;
float array[19], Time, MAX;
string mas_type[] = {"int   ","long  ","float ","double","char  "};
string mas_znak[] = {"+","-","*","/"};

void gist(){
    int p,i,j,z,a=0;
    MAX= array[0];
    for(i=1;i<MAX_ARR;i++)
        MAX= max(array[i],MAX);
    for(j=0;j<5;j++){
        for(z=a,i=0;z<4+a,i<4;z++,i++){
            cout<<mas_znak[i].c_str()<<" "<<mas_type[j].c_str()<<"  "<<array[z]<<" \t";
            float temp= (float)array[z]/(float)MAX;
            int result= ceil(temp*40);
            for(p=0;p<result;p++)
                cout<<"X";
            for(p=0;p<40-result;p++)
                cout<<" ";
            cout<<" "<<temp*1000/10<<"%"<<endl;
        }
        a+= 4;
        cout<<endl;
    }
}

float null(){
    int x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19;
    before_null= clock();
    for(int i=0;i<n;i++){
        x0= x1;
        x1= x2;
        x2= x3;
        x3= x4;
        x4= x5;
        x5= x6;
        x6= x7;
        x7= x8;
        x8= x9;
        x9= x10;
        x10=x11;
        x11=x12;
        x12=x13;
        x13=x14;
        x14=x15;
        x15=x16;
        x16=x17;
        x17=x18;
        x18=x0;
        x19=x1;
    }
    after_null= clock();
    return after_null-before_null;
}

template <typename T>
float sum(){
    T x0=1.153, x1=1.34, x2=1.1515, x3=1.745, x4=1.45, x5=1.15, x6=1.87, x7=1.54, x8=1.964, x9=1.151, x10=1.7, x11=1.155, x12=1.42, x13=1.54, x14=1.16, x15=1.78, x16=1.87, x17=1.984, x18=1.687, x19=1.1551; //x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19;
    before= clock();
    for(int i=0;i<n;i++){
        x0= x1+x2;
        x1= x2+x3;
        x2= x3+x4;
        x3= x4+x5;
        x4= x5+x6;
        x5= x6+x7;
        x6= x7+x8;
        x7= x8+x9;
        x8= x9+x10;
        x9= x10+x11;
        x10=x11+x12;
        x11=x12+x13;
        x12=x13+x14;
        x13=x14+x15;
        x14=x15+x16;
        x15=x16+x17;
        x16=x17+x18;
        x17=x18+x19;
        x18=x0+x1;
        x19=x1+x2;
    }
    after= clock();
    Time= 20*n/(((after-before)-null())/CLOCKS_PER_SEC);
    return Time;
}

template <typename T1>
float min()
{
    T1 x0=1.153, x1=1.34, x2=1.1515, x3=1.745, x4=1.45, x5=1.15, x6=1.87, x7=1.54, x8=1.964, x9=1.151, x10=1.7, x11=1.155, x12=1.42, x13=1.54, x14=1.16, x15=1.78, x16=1.87, x17=1.984, x18=1.687, x19=1.1551; //x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19;
    before= clock();
    for(int i=0;i<n;i++){
        x0= x1-x2;
        x1= x2-x3;
        x2= x3-x4;
        x3= x4-x5;
        x4= x5-x6;
        x5= x6-x7;
        x6= x7-x8;
        x7= x8-x9;
        x8= x9-x10;
        x9= x10-x11;
        x10=x11-x12;
        x11=x12-x13;
        x12=x13-x14;
        x13=x14-x15;
        x14=x15-x16;
        x15=x16-x17;
        x16=x17-x18;
        x17=x18-x19;
        x18=x0-x1;
        x19=x1-x2;
    }
    after= clock();
    Time= 20*n/(((after-before)-null())/CLOCKS_PER_SEC);
    return Time;
}

template <typename T2>
float mult(){
    T2 x0=1.153, x1=1.34, x2=1.1515, x3=1.745, x4=1.45, x5=1.15, x6=1.87, x7=1.54, x8=1.964, x9=1.151, x10=1.7, x11=1.155, x12=1.42, x13=1.54, x14=1.16, x15=1.78, x16=1.87, x17=1.984, x18=1.687, x19=1.1551;
    before= clock();
    for(int i=0;i<n;i++){
        x0= x1*x2;
        x1= x2*x3;
        x2= x3*x4;
        x3= x4*x5;
        x4= x5*x6;
        x5= x6*x7;
        x6= x7*x8;
        x7= x8*x9;
        x8= x9*x10;
        x9= x10*x11;
        x10=x11*x12;
        x11=x12*x13;
        x12=x13*x14;
        x13=x14*x15;
        x14=x15*x16;
        x15=x16*x17;
        x16=x17*x18;
        x17=x18*x19;
        x18=x0*x1;
        x19=x1*x2;
    }
    after= clock();
    Time= 20*n/(((after-before)-null())/CLOCKS_PER_SEC);
    return Time;
}

template <typename T3>
float divis(){
    T3 x0=1.34534, x1=1.34534, x2=1.23, x3=1.546, x4=1.546, x5=1.456757, x6=1.567, x7=1.657, x8=1.567, x9=1.435, x10=1.324, x11=1.765, x12=1.867, x13=1.65, x14=1.23, x15=1.435, x16=1.645, x17=1.657, x18=1.678, x19=1.34;
    before= clock();
    for(int i=0;i<n;i++){
        x0= x1/x2;
        x1= x2/x3;
        x2= x3/x4;
        x3= x4/x5;
        x4= x5/x6;
        x5= x6/x7;
        x6= x7/x8;
        x7= x8/x9;
        x8= x9/x10;
        x9= x10/x11;
        x10=x11/x12;
        x11=x12/x13;
        x12=x13/x14;
        x13=x14/x15;
        x14=x15/x16;
        x15=x16/x17;
        x16=x17/x18;
        x17=x18/x19;
        x18=x0/x1;
        x19=x1/x2;
    }
    after= clock();
    Time= 20*n/(((after-before)-null())/CLOCKS_PER_SEC);
    return Time;
}

int main(int argc, char* argv[])
{
    array[0]= sum<int>();
    array[1]= min<int>();
    array[2]= mult<int>();
    array[3]= divis<int>();
    array[4]= sum<long>();
    array[5]= min<long>();
    array[6]= mult<long>();
    array[7]= divis<long>();
    array[8]= sum<float>();
    array[9]= min<float>();
    array[10]= mult<float>();
    array[11]= divis<float>();
    array[12]= sum<double>();
    array[13]= min<double>();
    array[14]= mult<double>();
    array[15]= divis<double>();
    array[16]= sum<char>();
    array[17]= min<char>();
    array[18]= mult<char>();
    array[19]= divis<char>();
    gist();
    return 0;
}
