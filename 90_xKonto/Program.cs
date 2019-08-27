﻿using System;

namespace _90_xKonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k = new Konto();
            k.TilføjTransaktion(new Transaktion(new DateTime(2019, 1, 1), "Indsat", 100));
            k.TilføjTransaktion(new Transaktion(new DateTime(2019, 2, 1), "Indsat", 100));
            k.TilføjTransaktion(new Transaktion(new DateTime(2019, 3, 1), "Indsat", -75));
            Console.WriteLine(k.Saldo());

          
        }
    }
}
