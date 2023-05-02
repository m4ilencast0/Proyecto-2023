using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Un hombre desea saber si su sueldo es mayor al sueldo mínimo, el programa le pedirá al usuario su 
sueldo actual y el sueldo mínimo. Si el sueldo es mayor al mínimo se debe mostrar un mensaje por pantalla 
indicándolo*/


namespace ejercicio1_TP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldo, sueldomin;

            Console.WriteLine("ingrese su sueldo actual");
            sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el sueldo minimo");
            sueldomin = int.Parse(Console.ReadLine());

            if (sueldo <= sueldomin){
                Console.WriteLine("su sueldo actual es menor que el sueldo minimo");
            }else {
                Console.WriteLine("su sueldo actual es mayor al sueldo munimo");
            
            }
            Console.ReadKey();


        }






    }
}
