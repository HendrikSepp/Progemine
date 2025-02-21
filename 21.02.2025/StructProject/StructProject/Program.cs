namespace StructProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");

            Coordinate point = new Coordinate();
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            Console.WriteLine("-------------------");

            Console.WriteLine("sisesta nimi:");
            string minginimi = Console.ReadLine();

            Console.WriteLine("sisesta vanus:");
            int mingivanus = int.Parse(Console.ReadLine());

            IntAndString person = new(minginimi, mingivanus);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
    struct Coordinate
    {
        public int X;
        public int Y;

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    struct IntAndString
    {
        public string Name;
        public int Age;

        public IntAndString(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
