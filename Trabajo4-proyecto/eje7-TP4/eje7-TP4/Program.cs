using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Continuando el ejercicio anterior, ahora se pedirá una frase o palabra y se validará si la primera letra de
la frase es igual a la última letra de la frase. Se deberá de imprimir un mensaje por pantalla que diga
“CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”.*/
namespace eje7_TP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string principio, final;
            int let;

            Console.WriteLine("escribir palabra o frase");
            frase = Console.ReadLine();

            let = frase.Length - 1;
            principio = (frase.Substring(0, 1));
            final = (frase.Substring(let));

            if (principio == final)
            {
                Console.WriteLine("CORRECTO");
            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }
            Console.ReadKey();

        }
    }
}
