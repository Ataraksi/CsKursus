﻿using System;
using System.Collections.Generic; //Denne var vigtig for at "List" ville virke!

namespace _120_5BrugAfLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            Console.WriteLine();
            Console.WriteLine(a.FindIndex(FindVærdi));
            Console.WriteLine(a.FindIndex((i) => { return i == 51; }));
            Console.WriteLine(a.FindIndex(i => i == 51));

            Console.WriteLine();
            a.ForEach(ListVærdi);
            Console.WriteLine();
            a.ForEach(i => { Console.WriteLine(i); });

        }
        static bool FindVærdi(int i)
        {
            return i == 51;
        }
        static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }
    }
}
