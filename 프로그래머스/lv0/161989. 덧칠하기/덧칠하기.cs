using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int point = section[0];
        
        while(point != 0)
        {
            point += (m - 1);
            point = Array.Find(section, x => x > point);
            ++answer;
        }

        return answer;
    }
}