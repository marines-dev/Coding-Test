using System;

namespace _1차원_배열
{
    internal class Program
    {
        struct Paper
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            // 입력
            int blackPaper_num = Int32.Parse(Console.ReadLine());
            Paper[] blackPaper_arr = new Paper[blackPaper_num];
            for (int i = 0; i < blackPaper_num; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                blackPaper_arr[i].x = Int32.Parse(s[0]);
                blackPaper_arr[i].y = Int32.Parse(s[1]);
            }

            bool[,] paper = new bool[100, 100];
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    paper[i, j] = false;
                }
            }

            for (int i = 0; i < blackPaper_num; i++)
            {
                int x = blackPaper_arr[i].x;
                for (int k = 0; k < 10; k++)
                {
                    int y = 100 - blackPaper_arr[i].y;
                    for (int j = 0; j < 10; j++)
                    {
                        paper[x, y] = true;
                        y--;
                    }
                    x++;
                }
            }

            int blackPaper_cnt = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (paper[i, j] == true)
                        blackPaper_cnt++;
                }
            }

            Console.WriteLine(blackPaper_cnt);
        }
    }
}
