using System.Collections;
using System.Threading.Channels;

namespace ListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List and LINQ");

            IList<Person> person = new List<Person>()
            {
                new() { Id = 1, Name = "Juku", Age = 10 },
                new() { Id = 2, Name = "Juhan", Age = 11 },
                new() { Id = 3, Name = "Maali", Age = 9 },
                new() { Id = 4, Name = "Aksel", Age = 10 },
            };

            var persons = from s in person
                          select new
                          {
                              Id = s.Id,
                              Name = s.Name,
                              Age = s.Age,
                          };
            foreach (var item in persons)
            {
                Console.WriteLine("ID: " + item.Id + " nimi: " + item.Name + " vanus: " + item.Age);
            }
            Console.WriteLine("\n\n\n");

            Console.WriteLine("LINQ select e teine variant");

            var result = person
                .Where(x => x.Id == 1 || x.Age == 9)
                //.OrderBy(x => x.Name) //järjestab isikud nime järgi
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age,
                });
            foreach (var item in result)
            {
                Console.WriteLine("ID: " + item.Id + " nimi: " + item.Name + " vanus: " + item.Age);
            }

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Kasutame GroupBy sorteerimiseks");

            var groups = person.GroupBy(x => x.Age);

            foreach (var group in groups)
            {
                Console.WriteLine("vanuses " + group.Key + ":");
                foreach (var item in group)
                {
                    Console.WriteLine("- " + item.Name);
                }
            }
        }
    }
}
