using System;
using System.Collections.Generic;
using System.Linq;

namespace 직사각형과_삼각혀
{
    internal class 네_번째_점
    {
        static void Main(string[] args)
        {
            string[] input_str = new string[3];
            for (int i = 0; i < 3; i++)
            {
                input_str[i] = Console.ReadLine();
            }

            Dictionary<int, int> x_dic = new Dictionary<int, int>();
            Dictionary<int, int> y_dic = new Dictionary<int, int>();    
            int[] y_arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int[] coordinate_arr = input_str[i].Split(' ')
                    .Select(value => int.Parse(value)).ToArray();

                // x
                int x = coordinate_arr[0];
                if(x_dic.ContainsKey(x))
                {
                    x_dic[x]++;
                }
                else
                {
                    x_dic.Add(x, 1);
                }

                // y
                int y = coordinate_arr[1];
                if (y_dic.ContainsKey(y))
                {
                    y_dic[y]++;
                }
                else
                {
                    y_dic.Add(y, 1);
                }
            }

            int x_key = x_dic.FirstOrDefault(value => value.Value == 1).Key;
            int y_key = y_dic.FirstOrDefault(v => v.Value == 1).Key;
            Console.WriteLine($"{x_key} {y_key}");
        }
    }
}
