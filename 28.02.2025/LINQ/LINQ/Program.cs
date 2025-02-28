namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik numbriga");
            Console.WriteLine("1 Sum LINQ");
            Console.WriteLine("2 Max LINQ");
            Console.WriteLine("3 Aggregate LINQ");
            Console.WriteLine("4 Min LINQ");
            Console.WriteLine("5 Skip LINQ");
            Console.WriteLine("6 SkipWhile LINQ");
            Console.WriteLine("7 Take LINQ");
            Console.WriteLine("8 TakeWhile LINQ");
            Console.WriteLine("9 FirstOrDefault LINQ");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SumLINQ();
                    break;

                case "2":
                    MaxLINQ();
                    break;

                case "3":
                    AggregateLINQ();
                    break;

                case "4":
                    MinLINQ();
                    break;

                case "5":
                    SkipLINQ();
                    break;

                case "6":
                    SkipWhileLINQ();
                    break;

                case "7":
                    TakeLINQ();
                    break;

                case "8":
                    TakeWhileLINQ();
                    break;

                case "9":
                    FirstOrDefaultLINQ();
                    break;

                default:
                    Console.WriteLine("Error, proovi uuesti");
                    break;
            }
        }
        
        public static void SumLINQ()
        {
            var sumAge = PeopleList.people.Sum(x => x.Age);

            Console.WriteLine(sumAge);

            Console.WriteLine("Täisealiste isikute koondarv");

            var sumAdults = PeopleList.people.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    return x.Age;
                }
                else
                {
                    return 0;
                }
            });

            Console.WriteLine("Täiskasvanud isikute summa on:" + sumAdults);
        }

        public static void MaxLINQ()
        {
            var oldestPerson = PeopleList.people
                .Max(x => x.Age);

            Console.WriteLine("Kõige vanem inimene on {0} aastane", oldestPerson);
        }

        public static void AggregateLINQ()
        {
            string commaSeparatedPeoplesNames = PeopleList.people
                .Aggregate<People, string>(
                "Peoples names: ",
                (str, y) => str += y.Name + ", "
                );

            Console.WriteLine(commaSeparatedPeoplesNames);
        }

        public static void MinLINQ()
        {
            var youngestPerson = PeopleList.people
                .Min(x => x.Age);

            Console.WriteLine("Kõige noorem inimene on {0} aastane", youngestPerson);
        }

        public static void SkipLINQ()
        {
            var skipThree = PeopleList.people.Skip(3);

            foreach (var person in skipThree)
            {
                Console.WriteLine(person.Name);
            }
        }

        public static void SkipWhileLINQ()
        {
            var SkipWhileId = PeopleList.people.SkipWhile(x => x.Id < 4);

            foreach (var person in  SkipWhileId)
            {
                Console.WriteLine(person.Name);
            }
        }

        public static void TakeLINQ()
        {
            var TakeThree = PeopleList.people.Take(3);

            foreach(var person in TakeThree)
            {
                Console.WriteLine(person.Name); 
            }
        }
        

        public static void TakeWhileLINQ()
        {
            var TakeFirstThree = PeopleList.people.TakeWhile(x => x.Id < 4);
            foreach(var person in TakeFirstThree)
            {
                Console.WriteLine(person.Name);
            }
        }

        public static void FirstOrDefaultLINQ()
        {
            var FOD = PeopleList.people.FirstOrDefault(x => x.Age < 20);

            if (FOD != null)
            {
                Console.WriteLine("Esimene alla 20 aastane on: {0}", FOD.Name);
            }
            else
            {
                Console.WriteLine("Keegi pole alla 20 aastane");
            }
        }
    }
}
