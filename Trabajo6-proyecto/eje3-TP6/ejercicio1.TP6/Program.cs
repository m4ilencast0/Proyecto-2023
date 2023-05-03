using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.TP6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int alumnos = 0;
            double integral, parcial, expo, promedio;
            int aprobadointe;

            Console.WriteLine("Ingrese la cantidad de alumnos");
            alumnos = int.Parse(Console.ReadLine());

              for (int i = 0; i < alumnos; i++ ) {
                Console.WriteLine("ingrese la nota integral");
                integral = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la nota parcial");
                parcial = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la nota expo");
                expo = double.Parse(Console.ReadLine());

                promedio = (parcial + integral + expo) / 3;

                if(integral>= 7.5)
                {
                    aprobadointe ++;
                }
            }




        }
    }
}
