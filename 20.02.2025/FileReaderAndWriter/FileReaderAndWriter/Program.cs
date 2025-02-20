using System.Collections.Immutable;
using System.Xml.Linq;

namespace FileReaderAndWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minu tuttavad!");

            ReaderAndWriter();
        }
        static void ReaderAndWriter()
        {
            try
            {
                using (StreamReader sr = new StreamReader("tuttavad.txt"))
                {
                    string rida = sr.ReadToEnd();
                    string[] nimed = rida.Split('\n');

                    foreach (string name in nimed)
                    {
                        Console.WriteLine(name);
                    }
                    sr.Close();

                    using (StreamWriter write = new StreamWriter("tuttavad1.txt", true))
                    {
                        Array.Sort(nimed);
                        int i = 1;
                        Console.WriteLine("Sorteeritud!");
                        foreach (string name in nimed)
                        {
                            write.WriteLine(i + " " + name);
                            i++;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Mingi error");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
