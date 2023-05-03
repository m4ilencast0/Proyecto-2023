using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escriba un programa en el cual se ingrese un valor límite positivo, y a continuación
solicite números al usuario hasta que la suma de los números introducidos supere el
límite inicial.*/
namespace eje2_TP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, limit, num;
            Console.WriteLine("ingrese un valor limite positivo");
            limit = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("ingrese un numero");
                num = int.Parse(Console.ReadLine());

                suma = suma + num;
            } while (suma <= limit);

                Console.WriteLine("la suma de los numeros es: " +suma+ " Y supero el limite ("+limit+")");

            Console.ReadLine();
                

            
        }
    }
}
