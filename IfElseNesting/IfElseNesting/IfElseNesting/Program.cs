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
                Console.WriteLine("Oled alaealine! Kas käid ikka koolis?");
                string vastus = (Console.ReadLine());
                if (vastus == "jah" || vastus == "Jah" || vastus == "JAH")
                {
                    Console.WriteLine("Tubli! Nii peabki!");
                }
                else
                {
                    Console.WriteLine("Mõtle ikka järele.");
                }
            }
            else
            {
                Console.WriteLine("Oled täisealine!");
            }

        }
    }
}
