using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        int index = 0;
        int point = 0;
        int count = 0;
        int sum = 0;
        int length = 1;
        List<int> sum_list = new List<int>();
        while(length <= elements.Length)
        {
            index = 0;
            while(index < elements.Length)
            {
                point = index;
                count = 0;
                sum = 0;
                while(count < length)
                {
                    point = point % elements.Length;
                    sum += elements[point];
                    point++;
                    count++;
                }
                sum_list.Add(sum);
                index++;
            }
            length++;
        }
        
        return sum_list.Distinct().ToList().Count;
    }
}