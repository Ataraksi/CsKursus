using System;

namespace _80_1SimpleKlasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "allan";
            p1.Efternavn = "johansen";
            p1.Fødselsår = 1974;

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());

            Person p2 = new Person("Allan", "Johansen", 1974);

            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());


        }
    }

    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        public Person() : this("", "", 0)
           //Default construtor
        {
        }

        public Person(string fornavn, string efternavn, int fødselsår) //Custom constructor
        {
            this.Fornavn = fornavn;    
            this.Efternavn = efternavn;
            this.Fødselsår = fødselsår;
        }
    }
}

