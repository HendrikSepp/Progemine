namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta number 1 või 2");
            try
            {
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Number 1! hea valik!");
                        break;
                    case 2:
                        Console.WriteLine("Number 2! hea valik!");
                        break;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ei sisestanud numbri formaati");
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR. Sisestatud number on liiga suur");
            }

        }
    }
}
