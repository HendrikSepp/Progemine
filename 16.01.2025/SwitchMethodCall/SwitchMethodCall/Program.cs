namespace SwitchMethodCall
{
    internal class Program
    {
        static void Puuvili()
        {
            Console.WriteLine("Valisid puuvilja!");
        }
        static void Juurvili()
        {
            Console.WriteLine("Valisid juurvilja!");
        }
        static void Liha()
        {
            Console.WriteLine("Valisid liha!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Palun vali toit!");
            Console.WriteLine("Menüüs on:");
            Console.WriteLine("Kartul, Kaalikas, Õun, Pirn, Kana, Siga");
            Console.WriteLine("Sisesta oma valik nüüd:");
            string valik = (Console.ReadLine());
            switch (valik)
            {
                case "Kartul":
                case "Kaalikas":
                    Juurvili();
                    break;

                case "Õun":
                case "Pirn":
                    Puuvili();
                    break;

                case "Kana":
                case "Siga":
                    Liha();
                    break;

                default:
                    Console.WriteLine("ERROR! tee kindlaks, et alustad valikut suurtähega");
                    break;
            }

            }
    }
}
