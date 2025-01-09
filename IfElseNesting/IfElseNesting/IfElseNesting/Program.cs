namespace IfElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vanus");
            int vanus = int.Parse(Console.ReadLine());

            if (vanus <= 17)
            {
                Console.WriteLine("Oled alaealine!");
                if (vanus < 7)
                {
                    Console.WriteLine("Ja ka koolieelik!");
                }
                else
                {
                    Console.WriteLine("Loodan, et läheb koolis hästi!");
                }
            }
            else
            {
                Console.WriteLine("Oled täisealine!");
            }

        }
    }
}
