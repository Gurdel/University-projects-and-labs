#include <iostream>
#include <cmath>
const int DIV = 128;
const int L = 192;

using namespace std;

class FURRY
{
private:
    float c[L], Anull = 0, aNext, bNext, a, b, cn;
    unsigned f1 = 0, f2 = 1, buf;
    unsigned n = 0;


public:
    void setCycle()
    {
        for(int i = 0; i < L; ++i)
        {
            c[i] = f1 % DIV;
            buf = f2;
            f2 += f1;
            f1 = buf;
        }
    }

    void calcAnull()
    {
         for(int i = 1; i < L; ++i)
         {
             Anull += ((c[i] + c[i-1]) / 2);
         }
         Anull /= L;
         cout<<Anull;
    }

    void next()
    {
        aNext = bNext = 0;
        ++n;
        cn = n*M_PI/L;

         for(int i = 0; i < L-1; ++i)
         {
             a = c[i+1] - c[i];
             b = c[i] - a*i;

             aNext += (((a*(i+1)+b)*sin(cn*(i+1))-(a*i+b)*sin(cn*i)+(a*(i+1-L)+b)*sin(cn*(i+1-L))-(a*(i-L)+b)*sin(cn*(i-L)))/cn+
                            (cos(cn*(i+1))-cos(cn*i)+cos(cn*(i+1-L))-cos(cn*(i-L))*a/cn/cn));

            bNext += (((a*(i+1)+b)*cos(cn*(i+1))-(a*i+b)*cos(cn*i)+(a*(i+1-L)+b)*cos(cn*(i+1-L))-(a*(i-L)+b)*cos(cn*(i-L)))/cn+
                            (sin(cn*(i+1))-sin(cn*i)+sin(cn*(i+1-L))-sin(cn*(i-L))*a/cn/cn));
         }

         aNext /= L;
         bNext /= L;
        cout<<"+"<<aNext<<"*cos("<<n<<"*pi*x/"<<L<<")+"<<bNext<<"*sin("<<n<<"*pi*x/"<<L<<")";
    }
};
