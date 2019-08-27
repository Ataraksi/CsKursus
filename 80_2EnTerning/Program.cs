using System;

namespace _80_2EnTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            //Terning t2 = new Terning(true);
            //t2.Skriv();
            //t2.Ryst();
            //t2.Skriv();
        }
    }
    public class Terning
    {
        private static Random rnd = new Random();
        public int værdi;
        private bool snyd;

        public Terning()
        {
            this.værdi = 1;
            this.snyd = true;
        }

        public Terning(bool snyd)
        {
            this.snyd = snyd;
        }   
        
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            if (snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);
        }
    }
}
