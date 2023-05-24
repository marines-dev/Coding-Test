using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        Dictionary<string, string> str_number_dic = new Dictionary<string, string>()
        {
            {"zero", "0"}, {"one", "1"}, {"two", "2"}, {"three", "3"}, {"four", "4"}, {"five", "5"}, {"six", "6"}, {"seven", "7"}, {"eight", "8"}, {"nine", "9"}
        };
        
        for(int i = 0; i < str_number_dic.Count; ++i)
        {
            string str = str_number_dic.Keys.ToList()[i];
            if(s.Contains(str))
                s = s.Replace(str, str_number_dic[str]);
        }
        
        if(Int32.TryParse(s, out int n))
            answer = n;
        return answer;
    }
}