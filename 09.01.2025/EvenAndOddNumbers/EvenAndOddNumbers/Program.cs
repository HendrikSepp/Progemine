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
                Console.WriteLine("{0} on paaritu!", number);
            }
            else
            {
                Console.WriteLine("{0} on paaris!", number);
            }
        }
    }
}
