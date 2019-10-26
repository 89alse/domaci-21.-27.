using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_za_21._27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            int Broj1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < Broj1; i++)
            {

                if (i % 15 == 0 && i != 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i != 0)
                 {
                    Console.WriteLine("Fizz");
                 }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
       


        
    }
}
