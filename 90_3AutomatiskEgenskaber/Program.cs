using System;

namespace _90_3AutomatiskEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Allan";
            p.Efternavn = "Johansen";
            Console.WriteLine(p.FuldtNavn());
        }
    }
    class Person
    {
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length < 3)
                {
                    efternavn = "";
                }
                else
                {
                    efternavn = value;
                }
            }
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

    }
}
