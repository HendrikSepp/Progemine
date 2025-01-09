namespace MethodCall2
{
    internal class Program
    {
        static void Paaritu()
        {
            Console.WriteLine("Arv on paaritu!");
        }
        static void Paaris()
        {
            Console.WriteLine("Arv on paaris!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta arv");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 1)
            {
                Paaritu();
            }
            else
            {
                Paaris();
            }
        }
        
    }
}
