using System;

namespace _50_1BrugForIf
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int xx = 1; xx < 11; xx++) //denne loop styre hvor mange rækker der skal være med den indre loop
            {
                for (int yy = 1; yy < 11; yy++) //denne loop styre hvor mange tal der står vandret
                {
                    string tal = (xx * yy).ToString();
                    if ((xx * yy) > 50)
                        Console.ForegroundColor = ConsoleColor.Blue;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }
    }
}
