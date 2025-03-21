namespace skipWhileLINQ
{
    public class Numbers
    {
        public int Id { get; set; }
        public int Number { get; set; }
    }


    public class NumbersList
    {
        public static readonly List<Numbers> numbrid= new List<Numbers>
        {
            new Numbers()
            {
                Id = 1,
                Number = 489,
            },
            new Numbers()
            {
                Id = 2,
                Number = 267,
            },
            new Numbers()
            {
                Id = 3,
                Number = 251,
            },
            new Numbers()
            {
                Id = 4,
                Number = 249,
            },
            new Numbers()
            {
                Id = 5,
                Number = 849,
            },
            new Numbers()
            {
                Id = 6,
                Number = 493,
            },
            new Numbers()
            {
                Id = 7,
                Number = 512,
            },
            new Numbers()
            {
                Id = 8,
                Number = 256,
            },
            new Numbers()
            {
                Id = 9,
                Number = 128,
            },
        };
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SkipWhile number > 250");
            var skip = NumbersList.numbrid.SkipWhile(x => x.Number > 250);

            foreach (var x in skip)
            {
                Console.WriteLine(x.Id + ". " + x.Number);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("See LINQ võrdleb nimekirjas olevate numbrite väärtust");
            Console.WriteLine("ja jätab vahele kõik mille väärtus on üle 250.");
            Console.WriteLine("Niipea, kui esimene väärtus on alla 250, lõpetab vahele jätmise");
            Console.WriteLine("ja trükib kogu ülejäänud nimekirja hoolimata edasistest väärtustest.");
        }
    }
}
