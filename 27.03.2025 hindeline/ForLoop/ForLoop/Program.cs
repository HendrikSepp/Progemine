using System.Drawing;

namespace ForLoop
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Kujundijoonistaja");
            Console.WriteLine("Millist kujundit soovid?");
            Console.WriteLine("Ruut");
            Console.WriteLine("Teemant");
            Console.WriteLine("Ring");
            Console.WriteLine("Kolmnurk");
            Console.WriteLine("Sisesta enda valik:");
            string valik = Console.ReadLine().ToLower();

            if (valik == "ruut")
            {
                Console.WriteLine("Valisid ruudu!");
                Console.WriteLine("Sisesta külje pikkus: ");
                int side = int.Parse(Console.ReadLine());

                for (int row = 1; row <= side; row++)
                {
                    for (int column = 1; column <= side; column++)
                    {

                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }
                Console.WriteLine("Ruudu pindala on: {0}", side * side);
                Console.WriteLine("Ruudu ümbermõõt on: {0}", side * 4);

            }
            else if (valik == "teemant")
            {
                Console.WriteLine("Valisid teemanti!");
                Console.WriteLine("Sisesta külje pikkus: ");
                int side = int.Parse(Console.ReadLine());
                int i, j;
                for (i = 0; i <= side; i++)
                    {
                        for (j = 1; j <= side - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (j = 1; j <= 2 * i - 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                }
                for (i = 0; i <= side; i++)
                {
                    for (j = side; j >= side - i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (j = side; j >= 2 * i - 1; j--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("Teemanti pindala on: {0}", side * side);
                Console.WriteLine("Teemanti ümbermõõt on: {0}", side * 4);
            }
            else if (valik == "ring")
            {
                Console.WriteLine("Valisid ringi!");
                double thickness = 0.4;
                char symbol = '*';


                Console.Write("Sisesta raadius:");
                double radius = double.Parse(Console.ReadLine());


                Console.WriteLine();
                double rIn = radius - thickness, rOut = radius + thickness;

                for (double y = radius; y >= -radius; --y)
                {
                    for (double x = -radius; x < rOut; x += 0.5)
                    {
                        double value = x * x + y * y;
                        if (value >= rIn * rIn && value <= rOut * rOut)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
                Console.WriteLine("ringi pindala on: {0}", Math.PI * (radius * radius));
                Console.WriteLine("ringi ümbermoot on: {0}", 2 * Math.PI * radius );

            }
            else if (valik == "kolmnurk")
            {
                Console.WriteLine("Valisid kolmnurga!");
                Console.Write("Sisesta külje pikkus:");
                int side = int.Parse(Console.ReadLine());

                for (int i = 1; i <= side; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\n");
                }
                Console.WriteLine("Kolmnurga pindala on: {0}", (side * side) / 2);
                Console.WriteLine("Kolmnurga ümbermõõt on: {0}", side * 3);

            }
            else
            {
                Console.WriteLine("Viga valikul! Proovi uuesti");
            }

            Console.WriteLine("Kas soovid jätkata? Y/N");
            string veel = Console.ReadLine().ToLower();
            if (veel == "y")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Main();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nägemist!");
            }
        }
    }
}
