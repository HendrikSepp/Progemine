namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta palun vanus");
            int vanus = int.Parse(Console.ReadLine());

            if (vanus <= 17)
            {
                Console.WriteLine("Oled alaealine!");
            }
            else if (vanus >= 18 && vanus <= 64)
            {
                Console.WriteLine("Oled täisealine!");
            }
            else
            {
                Console.WriteLine("Oled pensionär!");
            }
        }
    }
}
