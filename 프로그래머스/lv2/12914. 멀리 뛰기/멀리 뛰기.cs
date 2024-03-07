using System;
public class Solution {
    public long solution(int n) {
        long answer = 0;
        long first = 0;
        long second = 1;
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
