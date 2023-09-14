using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int area = brown + yellow;
        
        for(int i = 1; i <= area; i++)
        {
            if(area % i == 0)
            {
                answer[0] = Math.Max(area / i, i);
                answer[1] = Math.Min(area / i, i);
                if((answer[0] - 2) * (answer[1] - 2) == yellow)
                    break;
            }
        }
        
        return answer;
    }
}