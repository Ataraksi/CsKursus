using System;

namespace _60_2StatiskeMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool t = System.IO.File.Exists(@"C:\temp\Test_alj.txt");
            Console.WriteLine($"Findes fil: {t}");

            string indhold = System.IO.File.ReadAllText(@"c:\temp\Test_alj.txt");
            Console.WriteLine(indhold);

            var fil = new System.IO.FileInfo(@"c:\temp\Test_alj.txt");
            DateTime d = fil.LastAccessTime;
            Console.WriteLine($"Tid: {d}");

            string ex = fil.Extension;
            Console.WriteLine($"Fil extension: {ex}");
        }
    }
}
