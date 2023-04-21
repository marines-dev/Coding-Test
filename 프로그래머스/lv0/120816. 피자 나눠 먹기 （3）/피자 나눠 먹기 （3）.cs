using System;

public class Solution {
    public int solution(int slice, int n) {
        int m = n;
        int answer = 1;
        while (m >= 0)
        {
            m -= slice;
            if (m > 0) // 남은 수
                answer++;
        }
        return answer;
    }
}