using System.Diagnostics.Tracing;

namespace sortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List!");

            SortedList<int, string> numbrid = new SortedList<int, string>()
            {
                {3, "Three" },
                {5, "Five" },
                {1, "One" },
            };

            Console.WriteLine("Algne key value");
            //sorteerib numbriväärtuste järgi ära
            foreach (KeyValuePair<int, string> kvp in numbrid)
            {
                Console.WriteLine("Key: {0}, value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("---------------------------------------------");
            SortedList<string, string> linnad = new SortedList<string, string>()
            {
                {"Tallinn", "Harjumaa" },
                {"Tartu", "Tartumaa" },
                {"Haapsalu", "Läänemaa" },
                {"Pärnu", "Pärnumaa" },
                {"Valga", "Valgamaa" },
                {"Narva", "Ida-Virumaa" }
            };
            Console.WriteLine("Linnad ja maakonnad:");

            foreach (KeyValuePair<string, string> kvp in linnad)
            {
                Console.WriteLine("Key: {0}, value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ilma SortedList kasutamata");
            linnad.Add("New York", "USA");
            linnad.Add("Brazil", "BRA");

            foreach (KeyValuePair<string, string> kvp in linnad)
            {
                Console.WriteLine("Key: {0}, value: {1}", kvp.Key, kvp.Value);
            }


        }
    }
}
