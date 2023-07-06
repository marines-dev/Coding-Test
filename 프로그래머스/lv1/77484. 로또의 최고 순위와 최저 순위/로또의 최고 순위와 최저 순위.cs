using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int win_count = 0;
        int zero_count = 0;
        
        foreach(int lotto in lottos)
        {
            if(lotto == 0)
                ++zero_count;
            else if(Array.Exists(win_nums, x => x == lotto))
                ++win_count;
        }
        
        answer[0] = (win_count == 0 && zero_count == 0) ? 6 : 7 - (win_count + zero_count);
        answer[1] = (win_count != 0) ? 7 - win_count : 6;
        
        return answer;
    }
}