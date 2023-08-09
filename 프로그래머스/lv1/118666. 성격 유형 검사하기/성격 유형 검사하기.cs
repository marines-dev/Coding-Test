using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        Dictionary<char, int> dic = new Dictionary<char, int>()
        {
            {'R', 0}, {'T', 0}, {'C', 0}, {'F', 0}, {'J', 0}, {'M', 0}, {'A', 0}, {'N', 0}
        };
        int[] scores = new int[]{0, 3, 2, 1, 0, 1, 2, 3};
        
        for(int i = 0; i < survey.Length; ++i)
        {
            string s = survey[i];
            int index = (choices[i] <= 3) ? 0 : 1;
            dic[s[index]] += scores[choices[i]];
        }
        
        List<char> keys = new List<char>(dic.Keys);
        List<int> values = new List<int>(dic.Values);
        int index_count = 0;
        for(int i = 0; i < 4; ++i)
        {
            answer+= (values[index_count] >= values[index_count + 1]) ? keys[index_count] : keys[index_count + 1];
            
            index_count += 2;
        }
        
        return answer;
    }
}