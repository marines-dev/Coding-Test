using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        List<int> k_list = new List<int>();
        int[] answer = new int[score.Length];
        
        for(int i = 0; i < score.Length; ++i)
        {
            if(k_list.Count < k)
                k_list.Add(score[i]);
            else
            {
                int index = k_list.FindIndex(x => x < score[i]);
                if(index != -1)
                {
                    k_list.Insert(index, score[i]);
                    k_list.RemoveAt(k_list.Count - 1); 
                }

            }
            k_list.Sort(new Comparison<int>((x1, x2) => x2.CompareTo(x1)));
            answer[i] = k_list[k_list.Count - 1];
        }

        return answer;
    }
}