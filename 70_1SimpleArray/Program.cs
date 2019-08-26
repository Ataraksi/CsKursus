using System;

namespace _70_1SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(string.Join(' ', månedsløn));

            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
                Console.WriteLine(månedsløn[i]);
            }

            double gns = sum / månedsløn.Length;
            Console.WriteLine("Gennemsnit " + gns.ToString("N2"));
        }
    }
}
