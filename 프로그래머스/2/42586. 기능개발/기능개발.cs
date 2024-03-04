using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> answer = new List<int>();

        int[] date_arr = progresses.Select((x, y) => (((100 - x) % speeds[y]) == 0 )? 0 : 1)
            .Select((x, y) => ((100 - progresses[y]) / speeds[y]) + x).ToArray();
        
        int date = date_arr[0];
        int count = 1;
        for(int i = 1; i < date_arr.Length; ++i)
        {
            if(date >= date_arr[i])
            {
                count++;
                continue;
            }
            answer.Add(count);
            date = date_arr[i];
            count = 1;  
        }
        
        answer.Add(count);
        return answer.ToArray();
    }
}