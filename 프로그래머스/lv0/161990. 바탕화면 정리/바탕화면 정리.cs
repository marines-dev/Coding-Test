using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[] {wallpaper.Length - 1, wallpaper[0].Length , 0, -1};
        
        for(int i = 0; i < wallpaper.Length; ++i)
        {
            char[] c_arr = wallpaper[i].ToCharArray();
            for(int j = 0; j < c_arr.Length; ++j)
            {
               if(c_arr[j] == '#')
               {
                   answer[0] = (i < answer[0]) ? i : answer[0];
                   answer[2] = (i + 1);
                   
                   answer[1] = (j < answer[1]) ? j : answer[1];
                   answer[3] = (j >= answer[3]) ? (j + 1) : answer[3];
               }
            }
        }
        
        return answer;
    }
}