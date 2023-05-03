using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje1_TP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            int numPalabras = 0;

            Console.WriteLine("Ingrese una palabra de 4 caracteres");
            palabra = Console.ReadLine();

            numPalabras = palabra.Length;

            if (numPalabras==4)
            {
                Console.WriteLine(palabra + "!");

            }
            else
            {
                Console.WriteLine(palabra + "?");
            }


            Console.ReadKey();





        }
    }
}
