using System;

public class Solution {
    public int solution(int hp) {
        int power = 5;
        int answer = 0;

        while(hp > 0)
        {
            answer += hp / power;
            hp %= power;
            power -= 2;
            Console.WriteLine(answer);
        }

        return answer;
    }
}