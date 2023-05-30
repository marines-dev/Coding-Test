using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];

            for(int i = 0; i < commands.GetLength(0); ++i)
            {
                int length = (commands[i, 1]) - (commands[i, 0]) + 1;
                int[] results = new int[length];
                Array.Copy(array, commands[i, 0] - 1, results, 0, length);
                Array.Sort(results);
                answer[i] = results[commands[i, 2] - 1];
            }
        
        return answer;
    }
}