namespace EnumProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum!");
            Console.WriteLine(Weekdays.Monday);
            Console.WriteLine((int) Weekdays.Monday);

        }

        enum Weekdays
        {
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
