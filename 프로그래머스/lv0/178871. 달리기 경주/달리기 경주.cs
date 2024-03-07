using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> player_dic = new Dictionary<string, int>();
        
        for(int i = 0; i < players.Length; ++i)
        {
            player_dic.Add(players[i], i);
        }
        
        for(int i = 0; i < callings.Length; ++i)
        {
            int rank_index = player_dic[callings[i]];
            
            string front = players[rank_index - 1];
            players[rank_index - 1] = callings[i];
            players[rank_index] = front;
            
            --player_dic[callings[i]];
            ++player_dic[front];
        }

        
        return players;
    }
}