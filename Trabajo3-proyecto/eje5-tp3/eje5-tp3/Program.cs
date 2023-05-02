using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje5_tp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("ingrese un dia de la semana");
            dia = Console.ReadLine();

            if (dia =="lunes"||dia=="martes"||dia=="miercoles"||dia=="jueves"||dia=="viernes")
            {
                Console.WriteLine("es un dia laboral");
            }
            if (dia == "sabado" || dia == "domingo")
            {
                Console.WriteLine("es un día de descanso");
            }

            Console.ReadKey();
        }
    }
}
