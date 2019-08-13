using System;

namespace _45Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = ("Allan");
            string efternavn = ("Løwe");

            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);

            Console.WriteLine($"{samletNavn.ToUpper()}");

            Console.WriteLine($"{samletNavn.ToLower()}");

            string navn4 = samletNavn.Substring(6, 4);
            Console.WriteLine(navn4);

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);

            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);
        }
    }
}
