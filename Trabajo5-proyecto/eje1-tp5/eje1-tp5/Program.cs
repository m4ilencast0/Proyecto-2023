using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escriba un programa que valide si una nota está entre 0 y 10, sino está entre 0 y 10 la nota se pedirá de
nuevo hasta que la nota sea correcta.*/
namespace eje1_tp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;
            do
            {
                Console.WriteLine("Nota");
                nota = int.Parse(Console.ReadLine());


            } while (nota < 0 || nota > 10); 
            { 
            
                Console.WriteLine("su nota es correcta");
             }
            Console.ReadKey();
        }
    }
}
