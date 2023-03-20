using System.IO;

namespace Aufgabe1
{
    class Aufgabe1
    {
        public static void Main(string[] args)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string sFile = Path.GetFullPath(Path.Combine(sCurrentDirectory, @"..\..\..\beispiel.txt"));

            Console.WriteLine(sFile);
            Console.ReadLine();

            string zeile = File.ReadAllText(sFile);

            Console.WriteLine(zeile);

           
            Console.ReadLine();
        }

    }

}