using System;

namespace _125_1FileSystemWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt"); //Alt dette handler om metadata på filen, hvis man skal have indhold så skal der kodes mere relateret til åbning, sammenligning etc.
            w.EnableRaisingEvents = true;
            w.Changed += W_Changed;
            w.Renamed += W_Renamed;
            w.Created += (s, e) => Console.WriteLine("Oprettet " + e.FullPath);
            do { } while (true);
        }

        private static void W_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            Console.WriteLine("Rettet filnavn til " + e.Name);
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine ("Rettet indhold på filen " + e.Name);
        }
    }
}
