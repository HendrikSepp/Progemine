﻿namespace ForTriangleNumbers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbritest kolmnurk!");

            int i, j, rows;

            Console.WriteLine("Sisesta ridade arv:");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }

                Console.Write("\n");
            }
        }
    }
}
