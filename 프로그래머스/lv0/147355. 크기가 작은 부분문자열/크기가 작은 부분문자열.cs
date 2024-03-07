using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int index = 0;
        while((index + (p.Length)) <= t.Length)
        {
            if(Int64.Parse(t.Substring(index, p.Length)) <= Int64.Parse(p))
                ++answer;
            
            ++index;
        }
        
        return answer;
    }
}