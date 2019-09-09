using System;

namespace _110_1EgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund() { Navn = "hund0"};
            array[1] = new Ubåd() { Nummer = 1 };
            array[2] = new Hund() { Navn = "hund2" };
            array[3] = new Ubåd() { Nummer = 3 };
            foreach(var item in array)
            {
                item.Gem();
            }
        }
    }
    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }


        public void Gem()
        {
            Console.WriteLine($"Gemmer hund..." + Navn);
        }
    }
    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }
        public void Gem()
        {
            Console.WriteLine($"Gemmer ubåd..." + Nummer);
        }
    }
    interface IDbFunktioner
    {
        void Gem();
    }

}
