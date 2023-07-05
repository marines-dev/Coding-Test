using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int num = 1;
        int count = 0;
        
        while(num <= number)
        {
            for(int i = 1; i * i <= num; i++)
            {
                if(i * i == num)
                    count++;
                else if(num % i == 0)
                    count += 2;
            }
            
            answer += (count <= limit) ? count : power;
            count = 0;
            num++;
        }

        return answer;
    }
}