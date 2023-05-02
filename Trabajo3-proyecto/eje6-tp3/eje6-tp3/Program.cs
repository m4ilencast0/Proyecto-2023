using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*a política de cobro de la empresa telefónica CELphone es: Cuando se realiza una llamada, el cobro es 
por el tiempo que esta dura, de tal forma el costo por minuto es uniforme y es de 30 pesos; además, se 
carga un impuesto del 3% cuando es domingo, y si es otro día, en turno de mañana 15% y en turno de tarde 
10%. Realiza un programa para determinar cuánto debe pagar una persona que realiza una llamada, el 
usuario debe ingresar los minutos que duró la llamada, el día, y el turno*/

namespace eje6_tp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tiem, dia, turno, total, precio, porc3, porc15, porc10, precio, total, mañana, tarde, domingo;
            Console.Write("ingrese el tiempo de llamada");
            tiem = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el día que hizo la llamada");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("en que turno fue realizada?");
            turno = int.Parse(Console.ReadLine());


            if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes" || dia == "sabado")
            {
                Console.WriteLine("en que turno?");

                if (mañana=mañana)
                {
                    mañana = (15 * precio) / 100;
                }
                else
                {
                    tarde = (10 * precio) / 100;
                }

            }
            if (dia == "domingo")
            {
                domingo = precio * 3 / 100;

            }
            Console.WriteLine("su total a pagar es: " + (tiem + turno + dia));

            Console.ReadKey();
        }
                   
    }

}
