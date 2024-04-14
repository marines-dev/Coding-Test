using System;
using System.Linq;

namespace 직사각형과_삼각형
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input_str = Console.ReadLine().Split(' ');
            int x = int.Parse(input_str[0]);
            int y = int.Parse(input_str[1]);
            int w = int.Parse(input_str[2]);
            int h = int.Parse(input_str[3]);

            int[] edge_arr = new int[4];
            edge_arr[0] = x; //left
            edge_arr[1] = w - x; //right
            edge_arr[2] = h - y; //top
            edge_arr[3] = y; //bottom

            Console.WriteLine(edge_arr.Min());
        }
    }
}