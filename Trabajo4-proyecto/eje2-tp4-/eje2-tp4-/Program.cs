using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realizar un programa que pida un número y determine si ese número es par o impar. Mostrar en pantalla
un mensaje que indique si el número es par o impar. (para que un número sea par, se debe dividir entre dos
y su resto debe ser igual a 0).*/

namespace eje2_tp4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese un numero par");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("su numero es par");
            }
            else
            {
                Console.WriteLine("su numero es impar");
            }
            Console.ReadKey();
        }
    }
}
