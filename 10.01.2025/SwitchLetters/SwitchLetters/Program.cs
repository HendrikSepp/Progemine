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
                case "A": case "a":
                    Console.WriteLine("Sisestasid tähe A!");
                    break;
                case "E": case "e":
                    Console.WriteLine("Sisestasid tähe E!");
                    break;
                case "I": case "i":
                    Console.WriteLine("Sisestasid tähe I!");
                    break;
                case "O": case "o":
                    Console.WriteLine("Sisestasid tähe O!");
                    break;
                case "U": case "u":
                    Console.WriteLine("Sisestasid tähe U!");
                    break;
                case "Ä": case "ä":
                    Console.WriteLine("Sisestasid tähe Ä!");
                    break;
                case "Ü": case "ü":
                    Console.WriteLine("Sisestasid tähe Ü!");
                    break;
                case "Õ": case "õ":
                    Console.WriteLine("Sisestasid tähe Õ!");
                    break;
                case "Ö": case "ö":
                    Console.WriteLine("Sisestasid tähe Ö!");
                    break;
            }

        }
     

    }
}
