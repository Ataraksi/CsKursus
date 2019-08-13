using System;

namespace _50BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 19; i = i+3) //Min egen løsning
            {
                if (i == 18) break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 20; i++)
            {
                if (i % 3 != 0) //modulus tager brøk resten og tjekker her om den er forskellig fra nul, hvis ja så start forfra, ellers print
                    continue;

                if (i > 15)
                    break;

                Console.WriteLine(i);
            }
        }   
    }
}
