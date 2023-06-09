using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            for(int j = i + 1; j < nums.Length; ++j)
            {
                for(int k = j + 1; k < nums.Length; ++k)
                {
                    int total = nums[i] + nums[j] + nums[k];
                    int m;
                    for(m = 2; m < total; ++m)
                    {
                        if(total % m == 0)
                            break;
                    }
                    if(m >= total)
                        ++answer;
                }
            }
        }
        return answer;
    }
}