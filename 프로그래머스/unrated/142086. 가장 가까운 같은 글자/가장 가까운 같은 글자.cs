using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        for(int i = 0; i < s.Length; ++i)
        {
            int count = i - 1;
            while(count >= 0)
            {
                if(s[i] == s[count])
                    break;
                
                --count;
            }
            answer[i] = (count == -1) ? -1 : (i - count);
        }
        return answer;
    }
}