﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*En nuevo proyecto crear una clase de nombre Perro, cuyos atributos son: nombre, raza, peso y edad. La
clase tendrás un constructor que permita inicializar todos sus atributos y los métodos getter y setter.
Además agregaremos un método adicional de nombre mostrarInfo que visualizará por consola todos los
datos de este animal. Por último, desde el método main de la clase principal del proyecto usted creará un
Perro de nombre “Olivia” de raza “Buldog Francés” que pese 1.2Kg con 1 año de edad; en la línea siguiente
invocará el método mostrarInfo de la instancia creada anteriormente.*/
namespace eje4_TP8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("Olivia", "Buldog Frances", 1.2, 1);

            perro.mostrarInfo();

            Console.ReadKey();
        }
    }
}
