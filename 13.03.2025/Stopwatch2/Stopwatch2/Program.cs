using System.Diagnostics;

namespace Stopwatch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch!");

            Stopwatch stopwatch
                = new Stopwatch();

            stopwatch.Start();
            for (int i = 1; i < 1001; i++)
            {
                Console.WriteLine(i + ". tsükkel");
                Thread.Sleep(10);
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Runtime " + elapsedTime);
        }
    }
}
