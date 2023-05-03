using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*- Escriba un programa que solicite al usuario números decimales mientras que el usuario
escriba números mayores al primero que se ingresó. Por ejemplo: si el usuario ingresa
como primer número un 3.1, y luego ingresa un 4, el programa debe solicitar un tercer
número. El programa continuará solicitando valores sucesivamente mientras los valores
ingresados sean mayores que 3.1, caso contrario, el programa finaliza.*/

namespace eje6_TP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deci, num;
            int cont = 0;
            Console.WriteLine("escriba un numero minimo dicemial");
            deci =double.Parse( Console.ReadLine());

            do
            {
                cont++;
                Console.WriteLine("escriba un numero");
                num =double.Parse(Console.ReadLine());

            } while (num >= deci);

            Console.WriteLine("el numero "+num+ " es menor al minimo ingresado  "+deci);

            Console.ReadKey();
            


        }
    }
}
