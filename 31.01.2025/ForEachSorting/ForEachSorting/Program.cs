namespace ForEachSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] genders = { "m", "f", "m", "m", "m", "f", "f", "m", "f" };
            int m = 0, f = 0;
            foreach (string gender in genders)
            {
                if (gender == "m")
                {
                    m++;
                }
                if (gender == "f")
                {
                    f++;
                }
            }
            Console.WriteLine("Number of male: " + m);
            Console.WriteLine("number of female: " + f);
        }
    }
}
