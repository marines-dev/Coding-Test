#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

char* solution(int n) {
    // 리턴할 값은 메모리를 동적 할당해주세요.
    char* answer = malloc(sizeof(char) * (100000 + 1));
    strcpy(answer, "");
    char *c = "수"; 
    int index = 0;
    while(index < n)
    {
        answer = strcat(answer, c);
        if(strcmp(c, "수") == 0)
            c = "박";
        else
            c = "수";
        ++index;
    }
    //answer = strcat(answer, "");
    //char* s; 
    //s = strdup(answer);
    //free(answer);
    return answer;
}