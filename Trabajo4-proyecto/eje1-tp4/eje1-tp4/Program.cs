using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realiza un programa que sólo permita introducir los caracteres ‘S’ y ‘N’. Si el usuario ingresa alguno de 
esos dos caracteres se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en caso 
contrario, se deberá imprimir “INCORRECTO”.*/
namespace eje2_tp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("ingrese un caracter");
            letra = char.Parse(Console.ReadLine());
            if (letra=='s'|| letra=='n')
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
