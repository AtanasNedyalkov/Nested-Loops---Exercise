using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool flag = false;
            int current = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (current > n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();

                if (flag)
                {
                    break;
                }
            }

        }
    }
}
