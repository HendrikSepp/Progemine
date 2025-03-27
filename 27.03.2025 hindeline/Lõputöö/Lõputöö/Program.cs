namespace Lõputöö
{
    public class Muutujad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Andmed
    {
        public static readonly List<Muutujad> andmed = new List<Muutujad>
        {
            new Muutujad()
            {
                Id = 1,
                Name = "Samuel",
                Age = 24
            },
            new Muutujad()
            {
                Id = 2,
                Name = "Kaspar",
                Age = 32
            },
            new Muutujad()
            {
                Id = 3,
                Name = "Julia",
                Age = 44
            },
            new Muutujad()
            {
                Id = 4,
                Name = "Mari",
                Age = 31
            },
            new Muutujad()
            {
                Id = 5,
                Name = "Jüri",
                Age = 18
            },
            new Muutujad()
            {
                Id = 6,
                Name = "Ron",
                Age = 22
            }
        };

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik:");
            Console.WriteLine("1: Skipwhile LINQ");
            Console.WriteLine("2: Take LINQ");
            Console.WriteLine("3: IfAndElse");
            Console.WriteLine("4: ForLoop");

            Console.WriteLine("valiku tegemiseks sisesta number");
            int valik = int.Parse(Console.ReadLine());
            switch(valik)
            {
                case 1:
                    SkipWhile();
                    break;
                
                case 2:
                    Take();
                    break;

                case 3:
                    IfAndElse();
                    break;

                case 4:
                    ForLoop();
                    break;

                default:
                    Console.WriteLine("Error, alusta uuesti");
                    break;
            }

            

        }

        public static void SkipWhile()
        {
            Console.WriteLine();
            Console.WriteLine("----------SkipWhile---------");
            Console.WriteLine();
            var skipwhile = Andmed.andmed.SkipWhile(x => x.Age < 40);

            foreach (var x in skipwhile)
            {
                Console.WriteLine(x.Id + " " + x.Name);
            }
        }

        public static void Take()
        {
            Console.WriteLine();
            Console.WriteLine("----------Take---------");
            var take = Andmed.andmed.Take(3);

            foreach (var x in take)
            {
                Console.WriteLine(x.Id + " " + x.Name);
            }
        }

        public static void IfAndElse()
        {
            Console.WriteLine();
            Console.WriteLine("----------IfAndElse-----------");
            Console.WriteLine();
            Console.WriteLine("kirjuta vähemalt kümnest tähemärgist koosnev rida, mis salvestatakse C:\\Users\\opilane\\source\\repos\\uusfail.txt");

            string rida = Console.ReadLine();

            if (rida.Length > 10)
            {
                using (StreamWriter write = new StreamWriter("C:\\Users\\opilane\\source\\repos\\uusfail.txt", true))
                {
                    write.WriteLine(rida);
                }
            }
            else
            {
                try
                {
                    using (StreamWriter write = new StreamWriter("X:\\uusfail.txt", true))
                    {
                        write.WriteLine(rida);
                    }
                }
                catch
                {
                    Console.WriteLine("Rida liiga lühike, proovi uuesti");
                }
            }
        }

        public static void ForLoop()
        {
            Console.WriteLine();
            Console.WriteLine("---------ForLoop------");
            Console.WriteLine();
            int i, j, rows;
            Console.WriteLine("Sisesta püramiidi kõrgus");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.Write("\n");
            }

        }

    }
}
