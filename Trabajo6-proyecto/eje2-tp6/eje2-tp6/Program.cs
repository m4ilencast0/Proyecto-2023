using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje2_tp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("ingrese una frase: ");
            frase = Console.ReadLine();
            foreach (char f in frase)
            {
                Console.Write(f + " ");
            }
            Console.ReadKey();

        }
    }
}
