using System;
public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min = Math.Min(n, m);
        int max = Math.Max(n, m);
        int mod = max;
        while(mod > 0)
        {
            mod = max % min;
            max = min;
            min = mod;
        }
        answer[0] = max;
        answer[1] = Math.Max(n, m) * Math.Min(n, m) / max;
        return answer;
    }
}