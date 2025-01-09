namespace EvenAndOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta arv");
            string nr = Console.ReadLine();
            int number = int.Parse(nr);

            if (number % 2 == 1)
            {
                Console.WriteLine("Arv on paaritu!");
            }
            else
            {
                Console.WriteLine("Arv on paaris!");
            }
        }
    }
}
