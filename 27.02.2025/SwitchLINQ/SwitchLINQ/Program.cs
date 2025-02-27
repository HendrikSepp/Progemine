namespace SwitchLINQ
{
    //jäi pooleli
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Guid GenderId { get; set; }

        public People(int id, string name, int age, Guid genderId)
        {
            Id = id;
            Name = name;
            Age = age;
            GenderId = genderId;
        }
    }
    public class PeopleList
    {
        public List<People> PeopleData { get; set; }
        public PeopleList()
        {
            PeopleData = new List<People>()
            {
                new People(1, "Siim", 23, Guid.NewGuid()),
                new People(2, "Tiina", 30, Guid.NewGuid()),
                new People(3, "Taavi", 18, Guid.NewGuid()),
                new People(4, "Meelis", 42, Guid.NewGuid()),
                new People(5, "Siret", 33, Guid.NewGuid()),
                new People(6, "Tanel", 27, Guid.NewGuid())
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PeopleList peopleList = new PeopleList();

            Console.WriteLine("Kuidas soovid andmed sorteerida? \n 1 ThenBy \n 2 ThenByDescending \n 3 Select \n 4 Thenby + Select \n 5 ThenByDescending + Select \n 6 ThenBy + ThenByDescending");
            Console.WriteLine("Sisesta soovitud sorteerimise number");
            int valik = int.Parse(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    SortByAgeThenByName(peopleList);
                    break;
                case 2:
                    SortByageThenByNameDesc(peopleList);
                    break;
                case 3:
                    SelectedNamesAndAges(peopleList);
                    break;
                case 4:
                    //sorteerib thenBy + Select
                case 5:
                    //sorteerib thenByDescending + Select
                case 6:
                    //sorteerib ThenBy + ThenByDescending
                default:
                    Console.WriteLine("error, start again");
                    break;

            }

            static void SortByAgeThenByName(PeopleList peopleList)
            {
                var sortedByAgeThenName = peopleList.PeopleData
                .OrderBy(p => p.Age)
                .ThenBy(p => p.Name);

                Console.WriteLine("Sorteeritud vanuse, siis nime järgi:");
                foreach (var person in sortedByAgeThenName)
                {
                    Console.WriteLine("{0} - vanus: {1}", person.Name, person.Age);
                }
            }

            static void SortByageThenByNameDesc(PeopleList peopleList)
            {
                var sortedByAgeThenNameDesc = peopleList.PeopleData
                        .OrderByDescending(p => p.Age)
                        .ThenBy(p => p.Name);

                Console.WriteLine("Sorteeritud vanuse järgi kahanevalt, siis nime järgi:");
                foreach (var person in sortedByAgeThenNameDesc)
                {
                    Console.WriteLine("{0} - vanus: {1}", person.Name, person.Age);
                }
            }

            static void SelectedNamesAndAges(PeopleList peopleList)
            {
                var selectedNames = peopleList.PeopleData
                .Select(p => new { p.Name, p.Age });

                Console.WriteLine("Nimekiri sisestamise järjekorras:");
                foreach (var person in selectedNames)
                {
                    Console.WriteLine("{0} - vanus: {1}", person.Name, person.Age);
                }
            }
        }
    }



}
