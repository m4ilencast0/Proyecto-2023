using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*En un nuevo proyecto para un juego de ajedrez, nos piden modelar e implementar una clase que
representa una Pieza de dicho juego. Usted deberá pensar que atributos serían necesarios para describir las
características de dicha clase, agregarle los métodos getter y setter correspondientes y luego probar desde
el main de la clase principal del proyecto.*/
namespace eje5_tp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torre torre = new Torre("lineal", "lateral", 2, "indefinidos");

            Console.WriteLine("El avance que tiene una torre en el juego es: " + torre.Avance);
            Console.WriteLine("La posicion que tiene una torre en el juego es: " + torre.Posicion);
            Console.WriteLine("La cantidad de piezas iguales en el juego es: " + torre.Cantidad);
            Console.WriteLine("Los lugares que avanza una torre en el juego es: " + torre.Lugares);

            Console.ReadKey();

        }
    }
}
