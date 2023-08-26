using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        Dictionary<string, int> id_dic = new Dictionary<string, int>();
        bool[,] reporters = new bool[id_list.Length, id_list.Length];
        int[] reporte_counts = new int[id_list.Length];
        
        for(int i = 0; i < id_list.Length; ++i)
        {
            id_dic.Add(id_list[i], i);
            for(int j = 0; j < id_list.Length; ++j)
            {
                reporters[i, j] = false;
            }
        }
        
        for(int i = 0; i < report.Length; ++i)
        {
            string[] user = report[i].Split(' ');
            int reporte_id = id_dic[user[1]];
            int reporter_id = id_dic[user[0]];
            
            if(reporters[reporte_id, reporter_id])
                continue;
            
            reporters[reporte_id, reporter_id] = true;
            ++reporte_counts[reporte_id];
        }
        
        for(int i = 0; i < reporte_counts.Length; ++i)
        {
            if(reporte_counts[i] < k)
                continue;
            
            for(int j = 0; j < id_list.Length; ++j)
            {
                if(reporters[i, j])
                    ++answer[j];
            }
        }
        
        return answer;
    }
}