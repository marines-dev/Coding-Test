using System.Collections.Generic;
using System;

public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[] {};
        List<long> list = new List<long>();
        long count = 1;
        while(count <= n)
        {
            list.Add(x * count);
            ++count;
        }
        answer = list.ToArray();
        return answer;
    }
}