using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escribir un programa que calcule la suma de los N primeros números naturales. El valor de N se leerá por
teclado.*/

namespace eje5_tp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma=0, N;
            Console.WriteLine("ingrese la cantidad de numeros naturales a sumar: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                suma += i;

            }
            Console.WriteLine("la suma del numero ingresado es: " + suma);

            Console.ReadKey();






        }
    }
}
