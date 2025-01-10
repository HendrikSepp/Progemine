using System.Drawing;

namespace SwitchColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Colour");



       

            for (int i = 0; i < 130; i++)
            {
                Colour c = (Colour)(new Random()).Next(0, 6);

                switch (c)
                {
                       
                    case Colour.Red:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("The colour is Red");
                        break;
                    case Colour.Green:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        Console.WriteLine("The colour is Green");
                        break;
                    case Colour.Blue:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("The colour is Blue");
                        break;
                    case Colour.Brown:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        Console.WriteLine("The colour is Brown");
                        break;
                    case Colour.Purple:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.WriteLine("The colour is Purple");
                        break;
                    case Colour.White:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("The colour is White");
                        break;
                    default:
                        break;
                }


                Colour colour = (Colour)(new Random()).Next(0, 6);
                Console.WriteLine("The colour is {0}", colour);
                           }
        }
    }
    public enum Colour
    {
        Red,
        Green,
        Blue,
        Brown,
        Purple,
        White
    }
}
