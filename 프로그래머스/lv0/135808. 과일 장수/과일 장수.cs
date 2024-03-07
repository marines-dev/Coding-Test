using System;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        Array.Sort(score);
        Array.Reverse(score);
        for(int i = 0; i < score.Length / m; i = ++i)
        {
            int[] arr = new int[m];
            Array.Copy(score, i * m, arr, 0, m);
            int max = arr.Min();
            answer += (max * m);
        }
        return answer;
    }
}