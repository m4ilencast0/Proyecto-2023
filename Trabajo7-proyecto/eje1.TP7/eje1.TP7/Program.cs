using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar un programa que rellene un vector con 5 valores ingresados por el usuario y los muestre por 
pantalla.*/

namespace eje1.TP7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nIngrese un numero para rellenar el vector: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
