using System;
using System.Globalization;

namespace _45_2Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();
            double d1 = Convert.ToDouble(tal1);
          
            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();
            double d2 = Convert.ToDouble(tal2);

            (double sum, double gns) resultat = FindSumOgGns(d1, d2);
            Console.WriteLine($"Sum: {resultat.sum:n2}");
            Console.WriteLine($"Gns: {resultat.gns:n2}");

            //// eller

            //var resultat2 = FindSumOgGns(5.4, 10.5);
            //Console.WriteLine($"Sum: {resultat2.sum:n2}");
            //Console.WriteLine($"Gns: {resultat2.gns:n2}");

            //var (s, g) = FindSumOgGns(5.4, 10.5);
            //Console.WriteLine($"Sum: {s:n2}");
            //Console.WriteLine($"Gns: {g:n2}");

        }

        static (double sum, double gns) FindSumOgGns(double a, double b)
        {
            double s = a + b;
            double g = s / 2;
            return (s, g);
        }
    }
}
