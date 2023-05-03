using System;
public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int index = Array.IndexOf(seoul, "Kim");
        answer = string.Format("김서방은 {0}에 있다", index);
        return answer;
    }
}