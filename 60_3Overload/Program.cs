﻿using System;

namespace _60_3Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 3, 4));
        }
        public static int Beregn(int a, int b)
            {
                return a + b;
            }

        public static int Beregn(int a, int b, int c)
            {
                return Beregn(a, b) + c;

            }
        public static int Beregn(int a, int b, int c, int d)
            {
                return Beregn(a, b, c) + d;

            }
        
    }
}
