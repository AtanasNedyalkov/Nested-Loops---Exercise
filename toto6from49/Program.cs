using System;

namespace toto6from49
{
    class Program
    {
        static void Main(string[] args)
        {
            int countercombinations = 0;
            for (int i = 1; i <= 49; i++)
            {
                for (int j = 1; j <= 49; j++)
                {
                    for (int k = 1; k <=49 ; k++)
                    {
                        for (int l = 1; l <= 49; l++)
                        {
                            for (int m = 1; m <= 49; m++)
                            {
                                for (int q = 1; q <= 49; q++)
                                {
                                    Console.Write($"{i} {j} {k} {l} {m} {q}");
                                    //Console.WriteLine();
                                    countercombinations++;
                                }
                            }
                        }
                    }
                }
            }
                                    Console.WriteLine(countercombinations);
        }
    }
}
