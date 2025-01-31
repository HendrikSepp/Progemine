namespace ForeachArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] myArray = { "H", "e", "l", "l", "o" };

            foreach (string element in myArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
