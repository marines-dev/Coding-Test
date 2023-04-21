using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] babbling) {        
        List<string> words = new List<string> {"aya", "ye", "woo", "ma"};
        int answer = 0;
        string str = String.Empty;
        for(int i = 0; i < babbling.Length; i++)
        {
            str = babbling[i];
            int count = 0;
            for(int j = 0; j < words.Count; j++)
            {        
                int startIndex = str.IndexOf(words[j]);
                if(startIndex != -1)
                {
                    count += words[j].Length;                   
                    if(str.Length == count)
                    {
                        answer++;
                        break;
                    }
                }
            }
        }
            
        return answer;
    }
}