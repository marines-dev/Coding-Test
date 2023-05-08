using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        list = arr.ToList();
        Array.Sort(arr);
        list.Remove(arr[0]);
        if(list.Count == 0)
            list.Add(-1);
        answer = list.ToArray();
        return answer;
    }
}