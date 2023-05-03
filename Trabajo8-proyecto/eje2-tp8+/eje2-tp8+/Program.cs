using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje2_tp8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora computadora = new Computadora("noc","rojo",32);

            Console.WriteLine("La marca de su computadora es: " + computadora.Marca);
            Console.WriteLine("El color de su computadora es: " + computadora.Color);
            Console.WriteLine("La capacidad de RAM de su computadora es: " + computadora.CapacidadRAM);

            Console.ReadKey();

        }
    }
}
