using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int Slumptal = slump.Next(101);
            Console.WriteLine("Jag har valt ett slumptal mellan 0 och 100. Gissa vilket jag har valt §)");
            int Gissa = 0;
            int Antal = +1;
            while(Gissa !=Slumptal)
            {
                Console.WriteLine("Skriv on din första gissning");
                Gissa = int.Parse(Console.ReadLine());

                if (Gissa > Slumptal)
                {
                    Console.WriteLine("För högt gissa igen!");
                }

                else if (Gissa < Slumptal)
                {
                    Console.WriteLine("För lågt gissa igen!");
                }
                else
                {
                    Console.WriteLine("Rätt! Hurra!! Du gissade: " + Antal);
                }
                Antal++;
            }
            
        }
    }
}
