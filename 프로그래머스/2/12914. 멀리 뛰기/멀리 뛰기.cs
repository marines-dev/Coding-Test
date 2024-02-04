using System;
public class Solution {
    public ulong solution(int n) {
        ulong answer = 0;
        ulong first = 0;
        ulong second = 1;
        int count = 1;
        while(count <= n)
        {
            answer = (first + second) % 1234567;
            first = second;
            second = answer;
            count++;
        }
        return answer;
    }
}
