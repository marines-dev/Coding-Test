using System;
using System.Linq;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = {0, 0};
        int i = 0;
        int index = 0;
        bool equals = false;
        for(i = 1; i < words.Length; ++i)
        {
            string str1 = words[i - 1];
            string str2 = words[i];
            if(str1[str1.Length - 1] != str2[0])
            {
                    equals = true;
                    index = i + 1;
            }

            for(int j = 0; j < i; ++j)
            {
                if(words[j] == words[i])
                {
                    equals = true;
                    index = i + 1;
                    break;
                }
            }
            
              if(equals)
                break;
        }

        if(equals)
        {
            Console.WriteLine(index);
            answer[0] = (index % n != 0) ? index % n : n;
            answer[1] = (index % n == 0) ? index / n : ((index / n) + 1);
        }
        
        return answer;
    }
}