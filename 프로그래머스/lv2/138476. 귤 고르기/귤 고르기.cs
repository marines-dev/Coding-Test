using System;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        tangerine = tangerine.GroupBy(x => x)
                .Select(g => g.Count()).OrderByDescending(x => x).ToArray();
        
        for(int i = 0; i < tangerine.Length; ++i)
        {
            k -= tangerine[i];
            if(k <= 0)
            {
                answer = i + 1;
                break;
            }
        }
        return answer;
    }
}