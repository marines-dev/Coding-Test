using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int cycle = 1;
        bool b = true;
        StringBuilder sb = new StringBuilder(s);
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dic = new Dictionary<char, char>()
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        while(cycle <= s.Length)
        {
            b = true;
            for(int i = 0; i < sb.Length; ++i)
            {
                if(dic.ContainsKey(sb[i]))
                {
                    if(stack.Count == 0 || dic[sb[i]] != stack.Pop())
                    {
                        b = false;
                        break;
                    }
                }
                else
                {
                    stack.Push(sb[i]);
                }
            }
            
            if(b && stack.Count == 0)
                answer++;
            
            sb.Append(sb[0]);
            sb.Remove(0, 1);
            cycle++;
        }
        return answer;
    }
}