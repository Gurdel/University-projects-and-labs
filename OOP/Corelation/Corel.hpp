#include "Corel.cpp"
const int N = 20;
const int DIV = 11;

using namespace std;

void Corelation :: fibonachi()
{
    unsigned f1 = 0, f2 = 1, bufer;

    for(int i = 1; i < N; ++i)
    {
        seq[i] = f2 % DIV;
        bufer = f2;
        f2 += f1;
        f1 = bufer;
    }
}
