#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// numbers_len은 배열 numbers의 길이입니다.
int solution(int numbers[], size_t numbers_len) {
    int answer = 0;
    bool t = true;
    for(int i = 0; i <= 9; ++i)
    {  
        t = true;
        for(size_t k = 0; k < numbers_len; ++k)
        {
            if(i == numbers[k])
            {
                t = false;
                break;
            }
        }
        if(t)
            answer += i;
    } 
  
    return answer;
}