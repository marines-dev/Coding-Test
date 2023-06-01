using System;

public class Solution {
    public string solution(int a, int b) {
        string[] answer = {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};
        int[] month = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int days = b;
        
        for(int i = 0; i < a - 1; ++i)
            days += month[i];
        
        int day = (((days - 1) % 7) + (Array.IndexOf(answer, "FRI"))) % 7;
        //Console.WriteLine(index);
        return answer[day]; 
    }
}