namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuple");

            var humans = System.Tuple.Create(1, "Jaan", "Tallinn");

            Console.WriteLine(humans);
            Console.WriteLine(humans.Item1);
            Console.WriteLine(humans.Item2);
            Console.WriteLine(humans.Item3);

            Console.WriteLine("------------------------------------------------");
            var numbers = System.Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);

            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item2);
            Console.WriteLine(numbers.Item3);
            Console.WriteLine(numbers.Item4);
            Console.WriteLine(numbers.Item5);
            Console.WriteLine(numbers.Item6);
            Console.WriteLine(numbers.Item7);
            Console.WriteLine(numbers.Rest);
            Console.WriteLine(numbers.Rest.Item1);

            Console.WriteLine("------------------------------------------------");

            var numbrid = System.Tuple.Create(1, 2, 3, 4, 5, 6, 7,
                System.Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine(numbrid.Item1);
            Console.WriteLine(numbrid.Item2);
            Console.WriteLine(numbrid.Item3);
            Console.WriteLine(numbrid.Item4);
            Console.WriteLine(numbrid.Item5);
            Console.WriteLine(numbrid.Item6);
            Console.WriteLine(numbrid.Item7);
            Console.WriteLine(numbrid.Rest.Item1.Item1);            
            Console.WriteLine(numbrid.Rest.Item1.Item2);
            Console.WriteLine(numbrid.Rest.Item1.Item3);
            Console.WriteLine(numbrid.Rest.Item1.Item4);
            Console.WriteLine(numbrid.Rest.Item1.Item5);
            Console.WriteLine(numbrid.Rest.Item1.Item6);

            Console.WriteLine("------------------------------------------------");


            for (int i = 0; i < numbrid.Rest.Item1.Item6; i++)
            {
                Console.WriteLine(numbrid.Item1 + i);
            }
        }
    }
}
