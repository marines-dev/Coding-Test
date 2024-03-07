using System;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        for(int i = 0; i < discount.Length; ++i)
        {
            if(discount.Length - i < 10)
                break;
            
            string[] dest = new string[10];
            Array.Copy(discount, i, dest, 0, 10);
            int j;
            for(j = 0; j < want.Length; ++j)
            {
                if(number[j] != Array.FindAll(dest, x => x == want[j]).Length)
                    break;
            }
            if(j == want.Length)
                answer++;
        }
        return answer;
    }
}