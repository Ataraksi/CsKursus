using System;

namespace _100_2SimpelArvUdvidetRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());
        } 
    }

    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            int t = this.Next(1, 1002);
            return t < 501;

        }

    }
}
