namespace NumberLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach and for loop");

            int[] oddArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            foreach (int i in oddArray)
            {
                if (i <= 13)
                Console.WriteLine(i);
            }
        }
    }
}
