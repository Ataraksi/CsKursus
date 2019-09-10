using System;
using MCronberg;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace _150_
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = MCronberg.PersonRepositoryStatic.JustGetPeople();
            //foreach (var person in people)
                //Console.WriteLine(person.Name);

                //Console.WriteLine();
                //var res1 = people.Take(7);
                //foreach (var person in res1)
                //Console.WriteLine(person.Name);

                //Console.WriteLine();
                //var res2 = people.OrderBy(i => i.Name);
                ////var res1l = from person in people orderby person.Name select person;
                //foreach (var person in res2)
                //Console.WriteLine(person.Name);

                //Console.WriteLine();
                //var res3 = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
                //foreach (var person in res3)
                //    Console.WriteLine(person.Name);

                Console.WriteLine();
            var res4 = people.Where(i => i.Height < 170);
            foreach (var person in res4)
                Console.WriteLine(person.Name + ", " + person.Gender + " og " + person.Height);





        }
    }
}
