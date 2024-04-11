using System;
using System.Collections.Generic;

namespace 일반_수학1
{
    internal class Program
    {
        /// <summary>
        /// 진법 변환 (2745)
        /// </summary>
        static void BaseConversion()
        {
            string[] inputStr_arr = Console.ReadLine().Split(' ');
            List<int> number_list = new List<int>();    
            for (int i = 0; i < inputStr_arr[0].Length; ++i)
            {
                int N = 0;
                if (inputStr_arr[0][i] >= 'A')
                {
                    N = inputStr_arr[0][i] - 'A' + 10;
                }
                else
                {
                    N = int.Parse(inputStr_arr[0][i].ToString());
                }

                number_list.Add(N);
            }

            int B = int.Parse(inputStr_arr[1]);

            int base10 = 0;
            number_list.Reverse();
            for (int i = 0; i < number_list.Count; ++i)
            {
                int pow = (int)Math.Pow(B, i);
                base10 += number_list[i] * pow;
            }

            Console.WriteLine(base10);
        }

        static void Main(string[] args)
        {
            BaseConversion();
        }
    }
}
