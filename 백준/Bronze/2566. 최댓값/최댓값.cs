using System;
using System.Collections.Generic;

namespace _1차원_배열
{
    // 최댓값
    internal class Q2566
    {
        static void Main(string[] args)
        {
            int[,] board = new int[9, 9];
            int max = 0;
            int cal = 0;
            int row = 0;
            for (int i = 0; i < 9; ++i )
            {
                string[] input_arr = Console.ReadLine().Split(' ');

                for (int j = 0; j < 9; ++j)
                {
                    board[i, j] = Int32.Parse(input_arr[j]);
                    //Console.WriteLine(board[i, j]);
                    if(max <= board[i, j])
                    {
                        max = board[i, j];
                        cal = i + 1;
                        row = j + 1;
                    }
                }
            }

            //출력
            Console.WriteLine(max);
            Console.WriteLine($"{cal} {row}");
        }
    }
}
