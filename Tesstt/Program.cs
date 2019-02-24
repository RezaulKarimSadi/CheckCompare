using System;
using System.Collections.Generic;
using System.Linq;

namespace Tesstt
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<Compar> c = new List<Compar>()
           {

                new Compar(20000, 23, 1),
                new Compar(20000, 23, 0),
                new Compar(20000, 22, 1),
                new Compar(25000, 24, 2),
                new Compar(30000, 25, 3),
                new Compar(25000, 24, 2),
                new Compar(40000, 25, 1)

            };
           


            c.Sort(new Comp());

            c.ForEach(i => Console.WriteLine("salary : " + i.salary + "   experience : " + i.experience + "   age : " + i.age));
                





            Console.ReadKey();

        }
    }
}
