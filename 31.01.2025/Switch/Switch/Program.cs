namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esimene lahendus, ilma switchita

            Console.WriteLine("Sisesta sentides väljastamiseks soovitud rahasumma:");
            int summa = int.Parse(Console.ReadLine());
            int kogusumma = summa;
            int yks, kaks, viis, kymme, kakskymmend, viiskymmend;

            for (viiskymmend = 0; summa >= 50; viiskymmend++)
            {
                summa -= 50;
            }
            for (kakskymmend = 0; summa >= 20; kakskymmend++)
            {
                summa -= 20;

            }
            for (kymme = 0; summa >= 10; kymme++)
            {
                summa -= 10;
            }
            for (viis = 0; summa >= 5; viis++)
            {
                summa -= 5;
            }
            for (kaks = 0; summa >= 2; kaks++)
            {
                summa -= 2;
            }
            for (yks = 0; summa >= 1; yks++)
            {
                summa -= 1;
            }



            if (yks > 0)
            {
                Console.WriteLine("1-sendiseid münte on: " + yks);
            }
            if (kaks > 0)
            {
                Console.WriteLine("2-sendiseid münte on: " + kaks);
            }
            if (viis > 0)
            {
                Console.WriteLine("5-sendiseid münte on: " + viis);
            }
            if (kymme > 0)
            {
                Console.WriteLine("10-sendiseid münte on: " + kymme);
            }
            if (kakskymmend > 0)
            {
                Console.WriteLine("20-sendiseid münte on: " + kakskymmend);
            }
            if (viiskymmend > 0)
            {
                Console.WriteLine("50-sendiseid münte on: " + viiskymmend);
            }
            Console.WriteLine("Väljastatud rahasumma kokku on {0} senti", kogusumma);
        }
        
    }
}
