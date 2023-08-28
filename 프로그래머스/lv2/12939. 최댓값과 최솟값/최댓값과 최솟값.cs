using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] str_arr = s.Split(' ');
        Array.Sort(str_arr, (a, b) => int.Parse(a) < int.Parse(b) ? -1 : 1);
        answer = $"{int.Parse(str_arr[0])} {int.Parse(str_arr[str_arr.Length - 1])}";

        return answer;
    }
}