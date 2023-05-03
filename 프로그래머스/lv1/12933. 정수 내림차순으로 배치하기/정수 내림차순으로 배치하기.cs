using System.Collections.Generic;
using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        List<long> list = new List<long>();
        while(n > 0)
        {
            list.Add(n % 10);
            n /= 10;
        }
        list.Sort();
        
        long digit = 1;
        for(int i = 0; i < list.Count; i++)
        {
            answer += list[i] * digit;
            digit *= 10;
        }
        return answer;
    }
}