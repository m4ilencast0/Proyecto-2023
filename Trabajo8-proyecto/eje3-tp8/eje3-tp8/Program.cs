using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*- En un nuevo proyecto crear una clase de nombre Jugador con los atributos: nombre, puntaje,
nacionalidad y edad. Luego un constructor vació y un constructor que inicialice todos sus atributos; agregue
además los respectivos métodos getter y setter. Desde el método main de la clase principal del proyecto
crear un Jugador utilizando el constructor vacío; luego, a dicho jugador darle de nombre “Juan”, con 140
puntos, de nacionalidad “Argentino” y una edad de 29 años; por último mostrar por consola el estado de
cada uno de sus atributos.*/
namespace eje3_tp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("juan", 140, "Argentino", 29);

            Console.WriteLine("El nombre de el jugador es: " + jugador.Nombre);
            Console.WriteLine("El puntaje de el jugador es: " + jugador.Puntaje);
            Console.WriteLine("La nacionalidad de el jugador es: " + jugador.Nacionalidad);
            Console.WriteLine("La edad de el jugador es: " + jugador.Edad);

            Console.ReadKey();

        }
    }
}
