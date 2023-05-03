using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje3_tp8
{
    internal class Jugador
    {
        private string nombre;
        private int puntaje;
        private string nacionalidad;
        private int edad;

        public Jugador(string nombre, int puntaje, string nacionalidad,int edad)
        {
            this.nombre = nombre;
            this.puntaje = puntaje;
            this.nacionalidad = nacionalidad;
            this.edad = edad;
        }
        public string Nombre
        {
            get { return nombre;}
            set { nombre = value; }
        }
        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
