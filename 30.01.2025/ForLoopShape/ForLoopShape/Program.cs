namespace ForLoopShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbritest püramiid!");
            Console.WriteLine("--------------------");
            Console.WriteLine("Sisesta ridade arv:");
            Console.WriteLine("--------------------");

            int i, j, n, k = 1;

            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
        }
    }
}
