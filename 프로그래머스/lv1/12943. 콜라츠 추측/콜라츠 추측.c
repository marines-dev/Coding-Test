#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int num) {
    int answer = 0;
    while(num > 1)
    {
        if(num % 2 == 0) //짝수
            num = num / 2;
        else
            num = num * 3 + 1;
        
        ++answer;
        if(answer == 500)
            break;
    }

    return (num == 1) ? answer : -1;
}