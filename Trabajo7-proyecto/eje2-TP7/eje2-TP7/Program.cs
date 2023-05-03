using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar un programa que lea 10 números reales por teclado, los almacene en un arreglo y muestre por 
pantalla la suma, resta y multiplicación de todos los números ingresados al arreglo.*/
namespace eje2_TP7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0, resta, multiplicacion = 1, num = 1;
            double[] array = new double[10];

            Console.WriteLine("Ingrese 10 numeros Reales");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el " + num + " numero: ");
                array[i] = Double.Parse(Console.ReadLine());
                num++;
            }

            resta = array[0] + array[0];

            for (int i = 0; i < 10; i++)
            {
                suma += array[i];
                resta -= array[i];
                multiplicacion *= array[i];
            }

            Console.Clear();

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicacion es: " + multiplicacion);


            Console.ReadKey();

        }
    }
}
