using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escribir un programa que calcule cuántos dígitos tiene un número entero positivo.
(pista: se puede hacer dividiendo varias veces entre 10).*/
namespace eje8_tp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cont = 0;
            Console.WriteLine("escriba un numero positivo");
            num = int.Parse(Console.ReadLine());

            while (num >= 1)
            {
                num /= 10;
                cont++;
            }
            Console.WriteLine("el numero tiene "+cont+" digitos" );

            Console.ReadKey();



        }
    }
}
