using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje5_tp8
{
    internal class Torre
    {
        private string avance;
        private string posicion;
        private int cantidad;
        private string lugares;

        public Torre(string avance, string posicion, int cantidad, string lugares)
        {
            this.avance = avance;
            this.posicion = posicion;
            this.cantidad = cantidad;
            this.lugares = lugares;
        }
        public string Avance
        {
            get { return avance; }
            set { avance = value; }
        }
        public string Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string Lugares
        {
            get { return lugares; }
            set { lugares = value; }
        }
    }
}
