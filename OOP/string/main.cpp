#include <iostream>
#include <string>
#include <sstream>
#include <cmath>
#include <math.h>
using namespace std;
ostringstream dbl;


int main()
{

   string s1,s2;
   double d = 1.22, m = 55.55;
    //getline(cin,s1);
   // getline(cin,s2);
   dbl<<d;
   s1 = dbl.str();
  cout<< s1<<endl;
  dbl.str("");
  dbl << m;
  s1=dbl.str();
   cout<<s1;
    return 0;
}
