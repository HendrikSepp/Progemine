namespace ForOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i, n, sum = 0;

            Console.WriteLine("Näita summat paaritutest arvudest:\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta number:");

            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Paaritud arvud on: ");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i -1;
            }
            Console.Write("\nPaarituid arve on: {0}, nende kokku liitmisel on summa: {1}", n, sum);
        }
    }
}
