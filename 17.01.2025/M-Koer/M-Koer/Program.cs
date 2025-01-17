namespace M_Koer
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Tere tulemast M-Koer kalkulaatorprogrammi!");
            try
            {
                Console.WriteLine("Sisesta esimene arv:");
                float esimene = float.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta tehtemärk (+ - / *):");
                string tehe = Console.ReadLine();
                Console.WriteLine("Sisesta teine arv:");
                float teine = float.Parse(Console.ReadLine());


                switch (tehe)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", esimene, teine, esimene + teine);
                        break;

                    case "-":
                        Console.WriteLine("{0} - {1} = {2}", esimene, teine, esimene - teine);
                        break;

                    case "/":
                        Console.WriteLine("{0} / {1} = {2}", esimene, teine, esimene / teine);
                        break;

                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", esimene, teine, esimene * teine);
                        break;

                    default:
                        Console.WriteLine("Midagi läks valesti! Kontrolli, kas sisestasid ühe neljast lubatud tehtemärgist");
                        break;
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Ainult numbrid, palun");
            }

            Console.WriteLine("auh auh auh auh auh");
        }
    }
}
