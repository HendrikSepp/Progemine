using System.Drawing;

namespace ForSquare
{
    internal class Program
    {
        static void Draw()
        {
            int i, j, side;
            Console.WriteLine("Sisesta külje pikkus:");
            side = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= side; i++)
            {
                for (j = 1; j <= side; j++)
                {
                    Console.Write("* ");
                }

                Console.Write("\n");
            }
        }
            static void Main(string[] args)
        {

            Console.WriteLine("Kas soovid joonistada ruudu? Y/N");
            string vastus = Console.ReadLine();
            switch (vastus) 
            {
                    case "Y":
                        Draw();
                        break;

                    case "N":
                        Console.WriteLine("Siis ei joonista täna! Head päeva jätku!");
                        break;

                    default:
                        Console.WriteLine("ainult Y/N vastused palun");
                    break;


            }
        }

    }
}
