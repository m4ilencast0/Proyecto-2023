using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace eje2_tp8_
{
    internal class Computadora
    {
        private string marca;
        private string color;
        private int capacidadRAM;
    
        public Computadora (string marca, string color, int capacidadRAM)
     {
        this.marca = marca;
        this.color = color;
        this.capacidadRAM = capacidadRAM;
        }
      public string Marca
      {
        get { return marca; }
        set { marca = value; }
      }
        public string Color
        {
        get { return color;}
        set { color = value; }
        }
        public int CapacidadRAM
        {
        get { return capacidadRAM; }
        set { capacidadRAM = value; }
        }

    }
}
