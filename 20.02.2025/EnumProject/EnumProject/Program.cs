namespace EnumProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum!");
            Console.WriteLine(Weekdays.Monday);
            Console.WriteLine((int) Weekdays.Monday);

            var weekDay = (Weekdays)0;
            Console.WriteLine(weekDay);

            int color = (int)Colors.Yellow;
            Console.WriteLine(color);

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

        enum Colors
        {
            Red = 3,
            Green = 10,
            Blue = 13,
            Yellow = 5,
            Black = 1
        }
    }
}
