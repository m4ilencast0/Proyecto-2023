using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eje4_TP8
{
    internal class Perro
    {
        private string nombre;
        private string raza;
        private double peso;
        private int edad;
        public Perro(string nombre, string raza, double peso, int edad)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.peso = peso;
            this.edad = edad;

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public void mostrarInfo()
        {
            Console.WriteLine("nombre: " + this.nombre);
            Console.WriteLine("raza: " + this.raza);
            Console.WriteLine("peso: " + this.peso);
            Console.WriteLine("edad: " + this.edad);
        }
    }
}
