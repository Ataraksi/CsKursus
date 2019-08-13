using System;

namespace _45DateTimeTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2018,1,23);
            DateTime d3 = new DateTime(2019, 8, 13);

            TimeSpan ddif = d3 - d2;
            Console.WriteLine(ddif.Days);

            TimeSpan t2 = new TimeSpan(16, 00, 00);
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(00,30,00);
            Console.WriteLine(t3);

            TimeSpan t4 = t2 - t3;
            TimeSpan t4a = t2.Subtract(t3);
            Console.WriteLine(t4);

            TimeSpan t5 = t2 + t3;
            TimeSpan t5a = t2.Add(t3);
            Console.WriteLine(t5);




            
            
        }
    }
}
