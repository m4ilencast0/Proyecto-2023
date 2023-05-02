using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje3_tp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char abc;
            Console.WriteLine("ingrese una letra del abecedario");
            abc = char.Parse(Console.ReadLine());

            if (abc=='a'||abc=='e'||abc=='i'||abc=='o'||abc=='u') 
            {
                Console.WriteLine("su letra es una vocal");
            }
            else
            {
                Console.WriteLine("su letra es una consonante");
            }
            Console.ReadKey();


        }
    }
}
