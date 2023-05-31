using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        Stack<int> stack = new Stack<int>();
        for(int i = 1; i < food.Length; ++i)
        {
            int n = food[i] / 2;
            if(n > 0)
            {
                int count = 1;
                while(count <= n)
                {
                    answer += i.ToString();
                    stack.Push(i);
                    ++count;
                }
            }
        }
        
        stack.Push(0);  
        foreach(int n in stack)
        {
             answer += n.ToString();
        }
        
        return answer;
    }
}