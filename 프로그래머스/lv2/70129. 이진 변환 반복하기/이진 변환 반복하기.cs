using System;
using System.Linq;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        
        while(!s.Equals("1"))
        {
            answer[1] += s.Count(x => (x == '0'));
            s = s.Replace("0", "");
            int num = s.Length;
            s = String.Empty;
            
            while(num != 1)
            {
                s += Convert.ToString(num % 2);
                num = num / 2;
            }
            
            s += "1";
            char[] reverse = s.ToCharArray();
            Array.Reverse(reverse);
            s = new string(reverse);
            answer[0]++;
        }
        
        return answer;
    }
}