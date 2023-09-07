public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] words = s.Split(" ");
        for(int i = 0; i < words.Length; ++i)
        {
            if(words[i].Length > 0)
                answer += words[i].Substring(0, 1).ToUpper();
            
            if(words[i].Length > 1)
                answer += words[i].Substring(1, words[i].Length - 1).ToLower();
            
            answer += " ";
        }
        
        return answer.Remove(answer.Length - 1);
    }
}