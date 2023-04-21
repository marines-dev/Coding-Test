using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        char[] charArray = my_string.ToCharArray();
        charArray = charArray.Distinct().ToArray();
        string answer = string.Join("", charArray);
        return answer;
    }
}