using System;

public class Solution {
    public int solution(string s) {
        char[] chars = s.ToCharArray();
        int answer = 0;
        int same_count = 0;
        int other_count = 0;
        int i = 0;
        
        while(i < chars.Length)
        {
            int first_index = i;
            for(; i < chars.Length; ++i)
            {
                if(s[first_index] == s[i])
                    ++same_count;
                else
                    ++other_count;
                
                if(same_count == other_count)
                    break;
            }
            
            answer++;
            ++i;
            same_count = 0;
            other_count = 0;
        }
        
        return answer;
    }
}