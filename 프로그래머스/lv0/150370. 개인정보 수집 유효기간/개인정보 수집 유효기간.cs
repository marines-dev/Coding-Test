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
            int years = (int.Parse(today.Substring(0, 4)) - int.Parse(date[0])) * 12;
            int months = int.Parse(today.Substring(5, 2)) - int.Parse(date[1]);
            int days = ((years + months) * 28) + (int.Parse(today.Substring(8, 2)) - int.Parse(date[2]));
            
            if(expiration <= days)
                answer.Add(i + 1);
        }
        
        return answer.ToArray();
    }
}