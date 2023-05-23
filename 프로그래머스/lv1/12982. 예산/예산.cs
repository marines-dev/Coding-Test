using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int total = 0;
        Array.Sort(d);
        while(answer < d.Length)
        {
            total += d[answer];
              if(total > budget)
                break;
            
            ++answer;
        }
        return answer;
    }
}