using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        
        for(int i = 0; i < targets.Length; ++i)
        {
            int index = 0;
            while(index < targets[i].Length)
            {
                int min_index = 100;
                for(int j = 0; j < keymap.Length; ++j)
                {
                    if(keymap[j].IndexOf(targets[i][index].ToString()) != -1)
                        min_index = Math.Min(min_index, keymap[j].IndexOf(targets[i][index].ToString())); 
                }
                
                if(min_index == 100)
                {
                    answer[i] = -1;
                    break;
                }

                answer[i] += (min_index + 1);
                ++index;
            }    
        }
                                         
        return answer;
    }
}