#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    int answer = 0;
    int quotient  = n;
    while(quotient != 0)
    {
        answer += (quotient % 10);
        quotient /= 10;
    }
    return answer;
}