using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Unesite poruku: ");
            string poruka = Console.ReadLine();
            Console.WriteLine("Unesite broj kojim zelite da sifrujete: ");
            int brojSifrovanja = int.Parse(Console.ReadLine());
            int[] sifrovanje= new int[poruka.Length];
            int brojac = 0;
            foreach (char z in poruka)
            {
                if ((int)z >= (int)'a')
                {
                    if ((int)z + brojSifrovanja > (int)'z')
                    {
                        sifrovanje[brojac] = z - 26 + (char)brojSifrovanja;
                        Console.Write((char)sifrovanje[brojac]);
                    }
                    else
                    {
                        sifrovanje[brojac] = z + (char)brojSifrovanja;
                        Console.Write((char)sifrovanje[brojac]);
                    }
                }
                else if ((int)z >= (int)'A')
                {
                    if ((int)z + brojSifrovanja > (int)'Z')
                    {
                        sifrovanje[brojac] = z - 26 + (char)brojSifrovanja;
                        Console.Write((char)sifrovanje[brojac]);
                    }
                    else
                    {
                        sifrovanje[brojac] = z + (char)brojSifrovanja;
                        Console.Write((char)sifrovanje[brojac]);
                    }
                }
                else
                {
                    Console.Write(z);
                }
                Console.WriteLine();
                brojac++;
            }
            Console.WriteLine("Zelite li da desifrujete tekst? (y/n)");
            char desifrovanje = char.Parse(Console.ReadLine());
            string desifrovanaPoruka="";
            foreach(int br in sifrovanje)
            {
                desifrovanaPoruka = desifrovanaPoruka + (char)br;
            }
            switch (char.ToLower(desifrovanje)) 
            {
                case 'y':
                    foreach(char z in desifrovanaPoruka) 
                    {
                        if (char.IsLetter(z))
                        {
                            Console.WriteLine((char)(z - brojSifrovanja));
                        }
                        else if(char.IsNumber(z))
                        {
                            Console.WriteLine(z);
                        }
                        else
                        {
                            Console.WriteLine(z);
                        }
                    
                    }
                   /* int i = 0;

                    while (i<sifrovanje.Length)
                    {
                        if ((int)sifrovanje[i] >= (int)'a' && (int)sifrovanje[i] <= (int)'z')
                        {
                                sifrovanje[i] = sifrovanje[i] - (char)brojSifrovanja;
                                Console.Write((char)sifrovanje[i]);
                          
                        }
                        else if ((int)sifrovanje[i] >= (int)'A' && (int)sifrovanje[i] <= (int)'Z')
                        {                 
                                sifrovanje[i] = sifrovanje[i] -(char)brojSifrovanja;
                                Console.Write((char)sifrovanje[i]);
                        }
                        else
                        {
                                Console.Write((char)sifrovanje[i]);
                        }
                        i++;
                    }*/
                    //NE PREPOZNAJE BROJEVE KAKO TREBA.
                    break;
                case 'n':
                    Console.WriteLine("Program ce se ugasiti.");
                    
                    break;
                default:
                    Console.WriteLine("Niste uneli odgovarajuci karakter.\n Program ce se ugasiti.");
                    break;
            }

            Console.ReadKey();
        } 
        
    }
}
