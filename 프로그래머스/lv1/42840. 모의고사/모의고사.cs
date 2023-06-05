using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
    int[][] numbers = new int[][]
    {
        new int[]{1, 2, 3, 4, 5},
        new int[]{2, 1, 2, 3, 2, 4, 2, 5}, 
        new int[]{3, 3, 1, 1, 2, 2, 4, 4, 5, 5}
    };

    Dictionary<int, int> numberDic = new Dictionary<int, int>();
    numberDic.Add(1, 0);
    numberDic.Add(2, 0);
    numberDic.Add(3, 0);
    
    int[] count = new int[] {0, 0, 0};
        
    for(int i = 0; i < answers.Length; ++i)
    {
        for(int j = 0; j < 3; ++j)
        {
            if(numbers[j][count[j]] == answers[i])
                ++numberDic[j + 1];
                        
            ++count[j];
            if(count[j] >= numbers[j].Length)
                count[j] = 0;
        }
    }
        numberDic = numberDic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x=> x.Value);
        numberDic = numberDic.Where(x => x.Value == numberDic.Values.ToList()[0]).ToDictionary(x => x.Key, x => x.Value);
        
        return numberDic.Keys.ToList().ToArray();
    }
}