using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> hamburger = new List<int>();
        
        foreach(int i in ingredient)
        {
            hamburger.Add(i);
            
            if(hamburger.Count >= 4)
            {           
                if(hamburger[hamburger.Count - 4] == 1 && hamburger[hamburger.Count - 3] == 2 
                   && hamburger[hamburger.Count - 2] == 3 && hamburger[hamburger.Count - 1] == 1)
                {
                    answer++;
                    hamburger.RemoveRange(hamburger.Count - 4, 4);
                }
            }
        }

        return answer;
    }
}