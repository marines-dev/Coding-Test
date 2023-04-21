using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        List<int> primeList = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                primeList.Add(i);
                n = n / i;
            }
        }
        primeList = primeList.Distinct().ToList();
        int[] answer = primeList.ToArray();
        return answer;
    }
}