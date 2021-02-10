Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).

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
            char letra;

            for (letra = 'Z'; letra >= 'A'; letra--)
                Console.Write("{0} ", letra);
            Console.ReadKey();
        }
    }
}
