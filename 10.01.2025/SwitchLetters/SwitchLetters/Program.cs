using System.Security.Cryptography.X509Certificates;

namespace SwitchLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta vokaal");
            string sisend = Console.ReadLine();

            

            switch (sisend.ToLower)
            {
                case "a":
                    Console.WriteLine("Sisestasid tähe A!");
                    break;
                case "e":
                    Console.WriteLine("Sisestasid tähe E!");
                    break;
                case "i":
                    Console.WriteLine("Sisestasid tähe I!");
                    break;
                case "o":
                    Console.WriteLine("Sisestasid tähe O!");
                    break;
                case "u":
                    Console.WriteLine("Sisestasid tähe U!");
                    break;
                case "ä":
                    Console.WriteLine("Sisestasid tähe Ä!");
                    break;
                case "ü":
                    Console.WriteLine("Sisestasid tähe Ü!");
                    break;
                case "õ":
                    Console.WriteLine("Sisestasid tähe Õ!");
                    break;
                case "ö":
                    Console.WriteLine("Sisestasid tähe Ö!");
                    break;
                default:
                    Console.WriteLine("Töötab ainult vokaalidega!");
                    break;
            }

        }
     

    }
}
