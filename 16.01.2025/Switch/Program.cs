using System.ComponentModel.Design;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 annab arvu vahemikus 0 kuni 100");
            Console.WriteLine("2 annab arvu vahemikus 101 kuni 200");
            Console.WriteLine("3 annab arvu vahemikus 201 kuni 300");
            Console.WriteLine("Sisesta number 1, 2 või 3");
            int input = int.Parse(Console.ReadLine());
            int number1 = new Random().Next(0, 100);
            int number2 = new Random().Next(101, 200);
            int number3 = new Random().Next(201, 300);
            switch (input)
            {
                case  1:
                    Console.WriteLine("Sinu number on " + number1);
                    break;
                case 2:
                    Console.WriteLine("Sinu number on " + number2);
                    break;
                case 3:
                    Console.WriteLine("Sinu number on " + number3);
                    break;
                default:
                    Console.WriteLine("Ainult numbrid 1, 2 või 3 palun")
                    break;
            }



            
        }
    }
}
