using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int square = 1;
        List<int> list = new List<int>();
        
        while(n >= 3)
        {
            list.Add(n % 3);
            n /= 3;
        }
        list.Add(n);
        
        for(int i = list.Count - 1; i >= 0 ; --i)
        {
            answer = answer + (list[i] * square);
            square *= 3;
        }
        
        return answer;
    }
}