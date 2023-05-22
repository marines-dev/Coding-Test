using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        for(int i = 0; i < s.Length; ++i)
        {
            char c = s[i];
            if(c == ' ')
            {
                answer += ' ';
                continue;
            }
            
            if(c < 'a') //대문자
            {
                c = Convert.ToChar(c + n);
               if(c <= 'Z')
                   answer += c;
                else
                {
                    c = Convert.ToChar('A' + (c - 'Z') - 1);
                    answer += c;
                }
            }
            else //소문자
            {
                c = Convert.ToChar(c + n);
               if(c <= 'z')
                   answer += c;
                else
                {
                    c = Convert.ToChar('a' + (c - 'z') - 1);
                    answer += c;
                }
            }
        }
        return answer;
    }
}