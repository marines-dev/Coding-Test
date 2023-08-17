using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>();
        
        for(int i = 0; i < privacies.Length; ++i)
        {
            string[] date = privacies[i].Split('.');
            string[] str = date[2].Split(" ");
            date[2] = str[0];
            string term = Array.Find(terms, x => x.Contains(str[1]));
            int expiration = int.Parse(term.Split(" ")[1]) * 28;
            int days = int.Parse(today.Substring(5, 2)) - int.Parse(date[1]);
            int days2 = ((int.Parse(today.Substring(0, 4)) - int.Parse(date[0])) * 12) + days;
            int days3 = (days2 * 28) + (int.Parse(today.Substring(8, 2)) - int.Parse(date[2]));
            
            if(expiration <= days3)
                answer.Add(i + 1);
        }
        
        return answer.ToArray();
    }
}