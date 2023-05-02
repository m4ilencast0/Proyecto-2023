using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Construir un programa q permite ingresar un numero, si el numero es mayor a 500,
 se debe calcular y mostrar en pantalla el 18% de este. */

namespace eje2_tp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mult;

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            mult = ((num * 18) / 100);
            Console.WriteLine();
            if (num > 500)
            {
                Console.WriteLine("El 18% del numero es: " + mult);
            }

            Console.ReadKey();
        }
    }
}
