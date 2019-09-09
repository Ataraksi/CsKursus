using System;

namespace _120_1SimpelDelegates
{
    public delegate void MinDelegate1(string t);
    //public delegate void MinDelegate2(string x);
    class Program
    {
        static void Main(string[] args)
        {
            //MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            //f1.Invoke("test");

            MinDelegate1 f1 = MinSkrivTilConsole;
            f1("test");

            MinDelegate1 f2 = MinSkrivTilConsole;
            f2("test2");

            //MinDelegate2 f2 = MinSkrivTilConsole; //Dette virkede også
            //f2("test2");

            MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test3");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;
        }

        static void MinSkrivTilConsole(string txt)
        {

            Console.WriteLine($"**** " + txt + " ****");
        }

    }
}
