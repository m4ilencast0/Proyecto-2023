using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* -Diseñe un programa que lea un número de tres cifras y determine si es o no capicúa*/
namespace eje4_tp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("ingrese un numero de tres cifras");
            numero = int.Parse(Console.ReadLine());

            if (numero>=100)
            {
                Console.WriteLine("su numero tiene tres cifras");
            }
            if(numero<1000&&(numero-numero%100)/100==numero%10)
            {
                Console.WriteLine("su numero es capicua");
            }
            else
            {
                Console.WriteLine("su numero no es capicua");
            }

            Console.ReadKey();

        }
    }
}
