using System.ComponentModel.Design;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta number 0-300");
            int input = int.Parse(Console.ReadLine());
          
            switch (input)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Sinu number on vahemikus 0-100");
                    break;
                case >= 101 and <= 200:
                    Console.WriteLine("Sinu number on vahemikus 101-200");
                    break;
                case >= 201 and <= 300:
                    Console.WriteLine("Sinu number on vahemikus 201-300");
                    break;
                default:
                    Console.WriteLine("Ainult numbrid 0-300");
                    break;
            }



            
        }
    }
}
