using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escriba un programa que solicite dos números enteros (mínimo y máximo). A
continuación, se debe pedir al usuario que ingrese números enteros situados entre el
máximo y mínimo. Cada vez que un número se encuentre entre ese intervalo, se sumara
uno a una variable. El programa terminará cuando se escriba un número que no
pertenezca a ese intervalo, y al finalizar se debe mostrar por pantalla la cantidad de
números ingresados dentro del intervalo.*/
namespace eje5_TP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max, num, cont= -1;

            Console.WriteLine("ingrese un minimo");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero maximo");
            max = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("ingrese un numero");
                num = int.Parse(Console.ReadLine());
                cont++;
            } while (num >= min && num <= max);

            Console.WriteLine("el numero está fuera de los limites establecidos");

            Console.WriteLine("la cantidad de numeros correctos ingresados en el intervalo es: " + cont);

            Console.ReadKey();



        }
    }
}
