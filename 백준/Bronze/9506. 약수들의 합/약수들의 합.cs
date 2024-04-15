using System;
using System.Collections.Generic;
using System.Linq;

namespace 약수__배수와_소수
{
    internal class 약수들의_합
    {
        static void Main(string[] args)
        {
            List<int> N_list = new List<int>();
            while(true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == -1)
                    break;

                N_list.Add(input);
            }

            Dictionary<int, List<int>> divisor_dic = new Dictionary<int, List<int>>();
            for(int j = 0; j < N_list.Count; ++j)
            {
                for(int i = 2; i <= N_list[j]; ++i)
                {
                    if(N_list[j] % i == 0)
                    {
                        if (divisor_dic.ContainsKey(N_list[j]))
                        {
                            List<int> divisor_list = divisor_dic[N_list[j]];
                            divisor_list.Add(i);
                        }
                        else
                        {
                            List<int> divisor_list = new List<int>();
                            divisor_list.Add(i);
                            divisor_dic.Add(N_list[j], divisor_list);
                        }

                    }
                }
            }

            foreach (List<int> divisor_list in divisor_dic.Values)
            {
                if (divisor_list != null)
                {
                    int N = divisor_list.Last();
                    int total = 1;
                    string str = string.Empty;
                    str += $"{N} = 1";
                    foreach (int divisor in divisor_list)
                    {
                        if (divisor == N)
                        {
                            break;
                        }
                        else
                        {
                            str += " + ";
                        }


                        total += divisor;
                        str += divisor;
                    }

                    if (total == N)
                    {
                        Console.WriteLine(str);
                    }
                    else
                    {
                        Console.WriteLine($"{N} is NOT perfect.");
                    }

                    total = 0;
                }
            }
        }
    }
}
