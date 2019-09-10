using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_simpel_beregner
{
    class Program
    {

        //public delegate int BeregnDelegate(int a, int b); //Dette er slette da opgaven gik ud på at erstatte delegates med Func mv.


        static void Main(string[] args)
        {
            // Enten
            int res = 0;
            res = Beregner(1, 1, Plus);
            Console.WriteLine(res);

            // eller
            res = Beregner(1, 1, Minus);
            Console.WriteLine(res);

            // eller
            res = Beregner(1, 1, Gange);
            Console.WriteLine(res);

            // eller
            res = Beregner(1, 1, Divider);
            Console.WriteLine(res);

            // Find tilfældig
            var f = FindTilfældigFunktion();
            res = f(5, 5);
            // eller
            // int res4 = FindTilfældigFunktion()(5,5);
            Console.WriteLine(res);

        }
        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        //public static BeregnDelegate FindTilfældigFunktion()
        public static Func<int, int, int> FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;

            return Divider;

        }

    }

}