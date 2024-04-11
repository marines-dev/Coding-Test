using System;
using System.Text;

namespace 일반_수학1
{
    internal class 진법_변환2
    {
        /// <summary>
        /// 진법 변환2 (2745)
        /// </summary>
        static void Main(string[] args)
        {
            string[] inputStr_arr = Console.ReadLine().Split(' ');
            int N = int.Parse(inputStr_arr[0]);
            int B = int.Parse(inputStr_arr[1]);


            int num = N;
            StringBuilder num_str = new StringBuilder();
            while (num > 0)
            {
                int remainder = num % B;
                if (remainder >= 10)
                {
                    num_str.Append((char)('A' + (remainder - 10)));
                }
                else
                {
                    num_str.Append(remainder.ToString());
                }
                num /= B;
            }

            for (int i = num_str.Length - 1; i >= 0; i--)
            {
                Console.Write(num_str[i]);
            }
        }
    }
}
