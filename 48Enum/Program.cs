using System;

namespace _48Enum
{
    public enum KortKulør
    {
       Hjerter = 10,
       Ruder = 20,
       Spar = 30,
       Klør = 40
    }
    
    class Program
        
    {
        static void Main(string[] args)
        {
            int kort1Værdi = 2;
            KortKulør kort1Kulør = KortKulør.Hjerter;

            Console.WriteLine(kort1Værdi);
            Console.WriteLine(kort1Kulør.ToString());
            Console.WriteLine((int)kort1Kulør);

            int kort2Værdi = 2;
            KortKulør kort2Kulør = KortKulør.Ruder;

            Console.WriteLine(kort2Værdi);
            Console.WriteLine(kort2Kulør.ToString());
            Console.WriteLine((int)kort2Kulør);
        }
    }
}
