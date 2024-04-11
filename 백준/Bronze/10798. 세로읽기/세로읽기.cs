using System;

namespace _1차원_배열
{
    internal class Program
    {
        // 19798 : 세로읽기
        static void Main(string[] args)
        {
            //Input
            char[,] input_arr = new char[5, 15];
            for (int i = 0; i < 5; i++) 
            {
                string input = Console.ReadLine();
                for (int j = 0; j < 15; j++) 
                {
                    input_arr[i, j] = (j < input.Length) ? input[j] : ' ';
                }
            }

            //Print
            string vertical = string.Empty;
            int cal = 0;
            while (cal < 15)
            {
                for (int row = 0; row < 5; row++)
                {
                    if(input_arr[row, cal] != ' ')
                        vertical += input_arr[row, cal];
                }
                cal++;
            }

            Console.WriteLine(vertical);
        }
    }
}
