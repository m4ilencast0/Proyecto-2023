using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace eje1_tp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto(1004, "Mai produc", 123, 15);

            Console.WriteLine("el codigo del producto es: " + producto.Codigo);
            Console.WriteLine("La descripcion del producto es: " + producto.Descripcion);
            Console.WriteLine("el Precio del producto es: " + producto.Precio);
            Console.WriteLine("el Stock del producto es: " + producto.Stock);

            Console.ReadKey();

        }
    }
}
