public class Solution {
    public bool solution(string s) {
        bool answer = true;
        foreach(char c in s)
        {
            if((s.Length != 4 && s.Length != 6) || (c < 48 || c > 57))
            {
                answer = false;
                break;
            }
        }
        return answer;
    }
}