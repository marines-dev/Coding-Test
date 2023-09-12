using System;
using System.Linq;

class Solution 
{
    public int solution(int n) 
   {
        int answer = n + 1;
        int one_count = (Convert.ToString(n, 2)).Count(x => x == '1');
        string binary = Convert.ToString(answer, 2);
        while(one_count != binary.Count(x => x == '1'))
        {
            answer++;
            binary = Convert.ToString(answer, 2);
        }

        return answer;
    }
}