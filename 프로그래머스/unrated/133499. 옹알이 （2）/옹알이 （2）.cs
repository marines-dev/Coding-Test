using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] words = { "aya", "ye", "woo", "ma"};
        for(int i = 0; i < babbling.Length; ++i)
        {
            for(int j = 0; j < words.Length; ++j)
            {
                babbling[i] = babbling[i].Replace(words[j], j.ToString());
                if(babbling[i].Contains($"{j.ToString()}{j.ToString()}"))
                    break;
                
                babbling[i] = babbling[i].Replace(j.ToString(), " ");
            }
            
            babbling[i] = babbling[i].Replace(" ", "");
            if(babbling[i] == "")
                ++answer;
        }
        return answer;
    }
}