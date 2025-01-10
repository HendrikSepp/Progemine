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
                    Console.WriteLine("Väike kohv! {0} eurot palun!", price + 1.5);
                    break;
                case 2:
                    Console.WriteLine("Keskmine kohv! {0} eurot palun!", price + 2.5);
                    break;
                case 3:
                    Console.WriteLine("Suur kohv! {0} eurot palun!", price + 3);
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }

        }
    }
}
