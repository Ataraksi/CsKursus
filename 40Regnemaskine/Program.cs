using System;

namespace _40Regnemaskine
{
    class Program

    
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();

            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            Console.WriteLine("Vil du +-*/?");
            string funk = Console.ReadLine();

            double t1 = Convert.ToDouble(tal1);
            double t2 = Convert.ToDouble(tal2);

            double res1 = 0;

            if (funk == "+")
            {
                res1 = t1 + t2;
            }
            
            else if (funk == "-")
            {
                res1 = t1 - t2;
            }


            else if (funk == "*")
            {
                res1 = t1 * t2;
            }

            else if (funk == "/")
            {
                res1 = t1 / t2;
            }

                  
            Console.WriteLine($"Resultatet er {res1.ToString("N2")}");




        }
    }
}
