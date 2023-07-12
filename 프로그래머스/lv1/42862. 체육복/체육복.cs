using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        
        Array.Sort(reserve);
        for(int i = 0; i < reserve.Length; ++i)
        {
            if(Array.Find(lost, x => x == reserve[i]) != 0)
                lost = lost.Except(new int[] { reserve[i] }).ToArray();
            else if(Array.Find(lost, x => x == reserve[i] - 1) != 0)
            {
                lost = lost.Except(new int[] { reserve[i] - 1 }).ToArray();
                reserve = reserve.Except(new int[] { reserve[i] - 1 }).ToArray();
            }
            else if(Array.Find(lost, x => x == reserve[i] + 1) != 0)
            {
                lost = lost.Except(new int[] { reserve[i] + 1 }).ToArray();   
                reserve = reserve.Except(new int[] { reserve[i] + 1 }).ToArray();   
            }
        }
        return n - lost.Length;
    }
}