using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pal;
            string fra;
            Console.WriteLine("frase o palabra de 6 digitos");
            fra = Console.ReadLine();
            pal = fra.Length;
                
            if (pal==6)
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
