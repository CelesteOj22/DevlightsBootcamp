using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase3.clases
{
    public class Cuadrado
    {
        private double Lado { get; set; }//atributo

        public Cuadrado() {}//constructor default
        public Cuadrado(double lado) { this.Lado = lado; }//constructor

        public double CalcularArea() { return this.Lado*this.Lado; }
    }
}
