using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        for(int i = 0; i < s.Length; ++i)
        {
            int index_length = index;
            int index_count = 0;
            
            if((char)(s[i] + index_count) == 'z')
            {
                char c = (char)('a' - 1);
                s = s.Remove(i, 1).Insert(i, c.ToString());
                index_length -= index_count;
                ++index_count;
            }
            
            while(index_count <= index_length)
            {
                if(skip.Contains(Convert.ToString((char)(s[i] + index_count))))
                    ++index_length;
                
                if((index_count + 1 <= index_length) && (char)(s[i] + index_count) == 'z')
                {
                    char c = (char)('a' - 1);
                    s = s.Remove(i, 1).Insert(i, c.ToString());
                    index_length -= index_count;
                    index_count = 0;
                    Console.WriteLine(index_length);
                }
                
                ++index_count;
            }
            
            answer += Convert.ToString((char)(s[i] + index_length));
        }
        
        return answer;
    }
}