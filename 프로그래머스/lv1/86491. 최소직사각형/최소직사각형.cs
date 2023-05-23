using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int x_max = 0;
        int y_max = 0;
        for(int i = 0; i < sizes.GetLength(0); ++i)
        {
            if(sizes[i, 0] < sizes[i, 1])
            {
                int temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }
        }
        
        for(int i = 0; i < sizes.GetLength(0); ++i)
        {
            if(x_max <= sizes[i, 0])
                x_max = sizes[i, 0];
            
            if(y_max <= sizes[i, 1])
                y_max = sizes[i, 1];
        }
        answer = x_max * y_max;
        return answer;
    }
}