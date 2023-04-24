#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

bool solution(int x) {

    int x2 = x;
    int n = 0;
    while(x2)
    {
        n += (x2 % 10);
        x2 /= 10;
    }
    bool answer = (x % n) == 0;
    return answer;
}