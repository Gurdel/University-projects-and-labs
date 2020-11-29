#include <iostream>
#include "cfurry.cpp"

using namespace std;

int main()
{
    FURRY fur;
    fur.setCycle();
    fur.calcAnull();
    for(int i = 0; i < 20; ++i)
    {
        fur.next();
    }
    return 0;
}
