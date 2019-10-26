using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            int a = 0, b = 1, c = 0;
            int unos = int.Parse(Console.ReadLine());




            for (int i = 0; i < unos; i++)
            {
                Console.WriteLine(c);
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
