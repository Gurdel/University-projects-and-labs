#include <iostream>
#include <math.h>

const int N = 1000;
const int M = 200;
const int DIV = 128;

using namespace std;

class Corelation
{
private:
    float denom = 0;
    float avg1 = 0, avg2;
    unsigned short seq[N] = {};
    float corel[N] = {};

public:
    void fibonachi()
    {
        unsigned f1 = 0, f2 = 1, bufer;

        for(int i = 0; i < N; ++i)
        {
            seq[i] = f1 % DIV;
            bufer = f2;
            f2 += f1;
            f1 = bufer;
        }
    }

    /* avg1, avg2 - сер знач ф-ції на відрізках, які досліджуються
    s1, s2 - суми квадратів із знаменника
    sum - сума із чисельника*/
    void setCorelation()
    {
        for(int i = 0; i < M; ++i)
        avg1 += seq[i];
        avg1 /= M;

        float s1 = 0, s2;
        for(int i = 0; i < M; ++i)
        s1 = s1 + (seq[i] - avg1)*(seq[i] - avg1);

        float sum;
        for(int i = 0; i < N-M; ++i)
        {
            avg2 = 0;
            for(int j = 0; j < M; ++j)
            avg2 += seq[j+i];
            avg2 /= M;

            s2 = 0;
            for(int j = 0; j < M; ++j)
            s2 = s2 + (seq[j+i] - avg2)*(seq[j+i] - avg2);

            sum = 0;
            for(int j = 0; j < M; ++j)
            sum += (seq[j] - avg1)*(seq[j+i] - avg2);
            corel[i] = sum / (sqrt(s1*s2));
        }
    }
    void result()
    {
        for(int i = 0; i < N-M; ++i)
            cout << i << ") " << corel[i] << "\n";
    }
};
