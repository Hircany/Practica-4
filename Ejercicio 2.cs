Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            while (x <= 10)
            {
                Console.Write(x);
                Console.Write(" - ");
                x = x + 1;
            }
            Console.ReadKey();


        }
    }
}
