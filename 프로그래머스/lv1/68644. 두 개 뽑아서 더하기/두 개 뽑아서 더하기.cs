using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> answer = new List<int>();
        for(int i = 0; i < numbers.Length; ++i)
        {
            int count = i + 1;
            while(count < numbers.Length)
            {
                int num = numbers[i] + numbers[count];
                if(!answer.Contains(num))
                    answer.Add(num);
                ++count;
            }
        }
        answer.Sort();
        return answer.ToArray();
    }
}