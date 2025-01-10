namespace SwitchCoffeePrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fantaasia kohvik!");
            Console.WriteLine("\n\nMenüü (kohvi valik)\n\n");
            Console.WriteLine("1. Väike tass");
            Console.WriteLine("2. Keskmine tass");
            Console.WriteLine("3. Suur tass");
            Console.WriteLine("\n\nPalun tee valik numbriga:");

            byte CoffeeSize = byte.Parse(Console.ReadLine());

            double price = 0;

            
            switch (CoffeeSize)
            {
                case 1:
                    price = price + 1.5;
                    break;
                case 2:
                    price += 2.5;
                    break;
                case 3:
                    price = price + 3;
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }

            if (price != 0)
            {
                Console.WriteLine("Tuleb maksta {0:f2}", price);
                Console.ReadKey();
            }
        }
    }
}
