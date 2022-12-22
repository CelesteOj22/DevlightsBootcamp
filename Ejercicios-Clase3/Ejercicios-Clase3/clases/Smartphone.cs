using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase3.clases
{
    public class Smartphone
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public bool Encendido { get; set; }
        public bool Sonido { get; set; }

        public Smartphone() { }
        public Smartphone(string modelo, string marca, string color)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Color = color;
            this.Encendido = false;
            this.Sonido = false;
        }

        public bool getEncendido() { return this.Encendido; }
        public void setEncendido(bool val) { this.Encendido = val; }
        public bool getSonido() { return this.Sonido; }
        public void setSonido(bool val) { this.Sonido = val; }
        public string Encender()
        {
            setEncendido(true);
            return "Celular encendido!";
        }
        public string Apagar()
        {
            setEncendido(false);
            return "Celular apagado!";
        }
        public string SubirVolumen()
        {
            if (getSonido() == false)
            {
                setSonido(true);
            }
            return "Incrementando volumen!";
        }
        public string BajarVolumen()
        {
            return "Decrementando volumen!";
        }
        public string SubirBrillo()
        {
            return "Incrementando brillo!";
        }
        public string BajarBrillo()
        {
            return "Decrementando brillo!";
        }
        public string Silenciar()
        {
            setSonido(false);
            return "Silenciado!";
        }
    }
}
