namespace StringLengthCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kellel on kõige pikem nimi?\n");
            string[] animalName = { "Koer", "Kass", "Jänes", "Sipelgasiil", "Lendorav" };

            string longestName = "";
            int longestLength = 0;

            foreach (string animal in animalName)
            {
                Console.WriteLine("{0} on {1} tähemärki pikk\n", animal, animal.Length);

                if (animal.Length > longestLength)
                {
                    longestName = animal;
                    longestLength = animal.Length;
                }
            }


            Console.WriteLine("Kõige pikem nimi on {0}, {1} tähemärki pikk!", longestName, longestLength);
        }
    }
}
