﻿using System;

namespace _90_1FuldeEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "vare #1";
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());

            Vare v2 = new Vare("vare #2", 200); //giver det samme som ovenfor, bare en anden syntaks
            Console.WriteLine(v2.PrisMedMoms());
        }
    }
    public class Vare
    {
        public Vare()
        {
        }
            public Vare(string navn, double pris)
            {
                this.Pris = pris;
                this.Navn = navn;
            }

        private string navn;
        public string Navn
        {
            get
            {
                Console.WriteLine("Nu aflæses navn");
                return navn;
            }
            set
            {
                Console.WriteLine("Nu tildeles navn");
                navn = value;
            }
        }
        private double pris;
        public double Pris
        {
            get
            {
                Console.WriteLine("Nu aflæses pris");
                return pris;
            }
            set
            {
                Console.WriteLine("Nu tildeles pris");
                pris = value;
            }
        }
        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }

    }
}
