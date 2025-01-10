using System.Security.Cryptography.X509Certificates;

namespace SwitchLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta vokaal");
            string sisend = Console.ReadLine();

            

            switch (sisend)
            {
                case "A":
                    Console.WriteLine("Sisestasid tähe A!");
                    break;
                case "E":
                    Console.WriteLine("Sisestasid tähe E!");
                    break;
                case "I":
                    Console.WriteLine("Sisestasid tähe I!");
                    break;
                case "O":
                    Console.WriteLine("Sisestasid tähe O!");
                    break;
                case "U":
                    Console.WriteLine("Sisestasid tähe U!");
                    break;
            }

        }
     

    }
}
