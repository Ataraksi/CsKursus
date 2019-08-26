using System;

namespace _60_1SimpleMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal 1");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast tal 2");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int res = LægSammen(tal1, tal2);
            Console.WriteLine("Summen er beregnet til: " + res);

            double res2 = BeregnAreal(tal1);
            Console.WriteLine("Arealet er beregnet til: " + res2);

            double res3 = BeregnMoms(tal1);
            //int t = "0,25";
            //double momsPct = 0.25;
            Console.WriteLine("Momsen er beregnet til: " + res3);

            Udskriv("Dette er en test");
                      
        }
        static double BeregnMoms(double tal1, double momsPct = 0.25)
        {
            return tal1 * momsPct;
        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(double radius)
        {
            return (radius * radius) * Math.PI;
        }

        static void Udskriv(string text)
        {
            Console.WriteLine(text);
        }
    }
}
