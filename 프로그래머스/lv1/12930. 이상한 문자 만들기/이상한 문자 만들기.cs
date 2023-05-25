public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] words = s.Split(' ');
        
        foreach(string word in words)
        {
            for(int i = 0; i < word.Length; ++i)
            {
                string c = (i % 2 == 0) ? word[i].ToString().ToUpper() : word[i].ToString().ToLower();
                answer += c;
            }
            answer += ' ';
        }
        return answer.Remove(answer.Length - 1);
    }
}