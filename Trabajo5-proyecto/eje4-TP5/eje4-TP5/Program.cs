using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escriba un programa en el cual se ingrese un número y mientras ese número sea mayor
de 10, se pedirá el número de nuevo.*/
namespace eje4_TP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());
            }
            while (numero > 10) ;
           
            Console.ReadKey();
            

           


        }
    }
}
