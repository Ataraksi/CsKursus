using System;



namespace _105_3AbstraktKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Kursist k = new Kursist() { Id = 1, Navn = "Allan" };
            k.Skriv1();
            k.Skriv2();

            //Console.WriteLine("Hello World!");
        }
    }
    abstract class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public void Skriv1()
        {
            Console.WriteLine($"Person med id {Id} og navn {Navn}");
        }

        public abstract void Skriv2();
    }

    class Kursist : Person
    {
        public override void Skriv2()
        {
            Console.WriteLine($"Kursist med id {Id} og navn {Navn}");
        }
    }
}
