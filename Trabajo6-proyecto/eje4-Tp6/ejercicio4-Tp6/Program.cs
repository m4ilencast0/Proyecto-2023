using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar un programa que muestre la cantidad de números que son múltiplos de 2 o de 3 comprendidos 
entre 1 y 100*/

namespace ejercicio4_Tp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant2=0, cant3=0;

            for (int i = 1; i <= 100; i++)
            {
                if((i % 2) ==0)
                {
                    cant2++;                  
                }
                if((i % 3) ==0)
                {
                    cant3++;
                }

            }

            Console.WriteLine("cantidad multiplo de 2 entre 1 y 100 son: " + cant2);
            Console.WriteLine("cantidad multiplo de 3 entre 1 y 100 son: " + cant3);

            Console.ReadKey();
        }
        
    }
}
