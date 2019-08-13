using System;

namespace _40SimpleVariabler
{
    class Program
    {
        static void Main(string[] args)
        {                    

            {
                int a = 10;
                a++;       
                Console.WriteLine($"a = {a}");
            }
            {
                int a = 10;
                a--;
                Console.WriteLine(a);
            }
            {
                int a = 10;
                a += 20;
                Console.WriteLine(a);
            }
            {
                double a = 12.5;
                a++;
                Console.WriteLine(a);

            }
            {
                double a = 12.5;
                a--;
                Console.WriteLine(a);

            }
            {
                double a = 12.5;
                a*=2;
                Console.WriteLine(a);

            }
        }
    }
}
