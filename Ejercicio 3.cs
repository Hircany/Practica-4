Crear un programa que muestre los primeros 10 números pares a partir del producto de (10 x 10)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 100;
            while (x <= 120)
            {
                Console.WriteLine($"{x}");
                x += 2; ;
            }
            Console.ReadKey();
        }
    }
}

    