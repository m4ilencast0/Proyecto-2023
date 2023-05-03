using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*– Escribir un programa que calcule el cuadrado de los 9 primeros números naturales e imprima por 
pantalla el número seguido de su cuadrado. Ejemplo: “2 elevado al cuadrado es igual a 4”, y así 
sucesivamente.*/

namespace ejercicio1_TP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cuadrado;

            for (int i = 1; i < 10; i++) 
            {
                cuadrado = i*i;
                Console.WriteLine("el numero "+i+ " elevado al cuadrado es igual a "+cuadrado);
            }
            Console.ReadKey();



        }
    }
}
