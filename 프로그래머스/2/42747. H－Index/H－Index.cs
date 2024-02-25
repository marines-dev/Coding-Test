using System;
using System.Linq;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        Array.Sort(citations);
        for (int i = 0; i < citations.Length; ++i)
        {
            int h = citations.Length - i;
            if (citations[i] >= h)
            {
                answer = citations.Count(x => x >= citations[i]);
                if(answer == h)
                    break;
            }
        }
        return answer;
    }
}