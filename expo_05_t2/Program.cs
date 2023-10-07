using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expo_05_t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string espacio = " ";
            
            Console.Write("{0,0}","precio");
            Console.Write("{0,24}","demanda");
            for ( int p = 5; p <= 150; p += 5)
            {
                Console.Write("\n");
                Console.Write("{0}{1}", espacio.PadRight(0, ' '), p.ToString().PadLeft(4, ' ')); 
                double demanda = Math.Pow(p,2) - (100 * p) + 2500;
                Console.Write("{0}{1}", espacio.PadRight(20, ' '), demanda.ToString().PadLeft(4, ' '));
               
            }
            Console.ReadKey();
        }
    }
}
