using System;
using System.Linq;
public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        int max = arr.Max();
        int multiple = 1;
        int count = 0;
        while(count != arr.Length)
        {
            answer = max * multiple;
            count = arr.Count(x => answer % x == 0);
            multiple++;
        }
        return answer;
    }
}