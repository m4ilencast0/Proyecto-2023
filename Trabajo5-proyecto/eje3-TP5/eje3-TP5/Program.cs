using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Dada una secuencia de números ingresados por teclado que finaliza con la entrada de
un número negativo, por ejemplo: 5,3,0,2,4,4,0,0,2,3,6,0,......,-1; realizar un
programa que calcule el promedio de los números ingresados.*/
namespace eje3_TP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num, promedio, suma = 0;
            int aux = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    suma = suma + num;
                    aux = aux + 1;

                }

            } while (num > 0);

            promedio = suma / aux;

            Console.WriteLine("el promedio de los numeros ingresados es: " + promedio);

            Console.ReadKey();


        }
    }
}
