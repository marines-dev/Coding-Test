using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        Stack<int> stack = new Stack<int>();
        int[] answer = Enumerable.Repeat(-1, numbers.Length).ToArray();
        for (int i = 0; i < numbers.Length; i++) 
        {
            while (stack.Count > 0 && numbers[i] > numbers[stack.Peek()]) 
            {
                answer[stack.Pop()] = numbers[i];
            }

            stack.Push(i);
        }

        return answer;
    }
}