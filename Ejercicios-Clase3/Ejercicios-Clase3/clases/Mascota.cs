using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase3.clases
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Energia { get; set; }
        public string Tamaño { get; set; }

        public Mascota() { }
        public Mascota(string nombre, string tipo, string tamaño)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Energia = 38;
            this.Tamaño = tamaño;
        }

        public int getEnergia() { return this.Energia; }
        public void setEnergia(int value) { this.Energia = value; }
        public string Alimentar()
        {
            setEnergia(getEnergia()+30);
            return "Mascota alimentada! Energia incrementada en un 30%";
        }

        public string Correr()
        {
            if (getEnergia() > 20)
            {
                setEnergia(getEnergia() - 10);
                return "Corre! 10% menos de energia";
            }
            else
                return "Su energia es menor al 20%. No puede correr!";
        }
    }
}
