using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escriba un programa que pida una frase o palabra y valide si la primera letra de esa frase es una ‘A’. Si la
primera letra es una ‘A’, se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en caso
contrario, se deberá imprimir “INCORRECTO”.*/
namespace eje6_TP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("escriba una frase que inicie con A");
            frase = Console.ReadLine();

            frase = frase.Substring(0, 1);

            if (frase == "a")
            {
                Console.WriteLine("CORRECTO");
            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }
            Console.ReadKey();

        }
    }
}
