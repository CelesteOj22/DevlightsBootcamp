using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase3.clases
{
    public class Auto
    {
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public int Velocidad { get; set; }
        public bool Encendido { get; set; }
        public Persona Conductor { get; set; }
        public int Capacidad { get; set; }
        public Mascota Mascota { get; set; }
        public int Pasajeros { get; set; }

        public Auto() { }

        public Auto(string patente, string modelo, string marca, string color, int capacidad, int pasajeros, Persona conductor)
        {
            this.Patente = patente;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Color = color;
            this.Velocidad = 0;
            this.Encendido = false;
            this.Capacidad = capacidad;
            this.Conductor = conductor;
            this.Mascota = new Mascota("Pepo", "perro","grande");
            this.Pasajeros = pasajeros;
        }
        public Auto(int capacidad, int pasajeros, Persona conductor)
        {
            this.Velocidad = 0;
            this.Encendido = false;
            this.Capacidad = capacidad;
            this.Conductor = conductor;
            this.Mascota = new Mascota("Pepo", "perro", "grande");
            this.Pasajeros = pasajeros;
        }
        public Auto(int capacidad, int pasajeros, Persona conductor,Mascota mascota)
        {
            this.Velocidad = 0;
            this.Encendido = false;
            this.Capacidad = capacidad;
            this.Conductor = conductor;
            this.Mascota = mascota;
            this.Pasajeros = pasajeros;
        }
        public int getVelocidad() { return this.Velocidad; }
        public void setVelocidad(int velocidad) { this.Velocidad = velocidad; }
        public bool getEncendido() { return this.Encendido; }
        public void setEncendido(bool encendido) { this.Encendido = encendido; }
        public bool existeConductor() { return true; }
        public int getPasajeros() { return this.Pasajeros; }
        public void setPasajeros(int pasajeros) { this.Pasajeros = pasajeros; }
        public string AgregarPasajero()
        {
            if (getPasajeros() < Capacidad) {
                setPasajeros(getPasajeros() + 1);
                return "Pasajero agregado!";
            }
            else
                return "Auto lleno!"; }
        public string subirMascota()
        {
            if (existeConductor())
            {
                if (Mascota.Tamaño == "grande") {
                    string agregar = AgregarPasajero();
                    if (agregar == "Pasajero agregado!")
                        return "La mascota es grande y cuenta como un pasajero";
                    else
                        return "No se pudo agregar a la mascota como pasajero. Auto lleno!";                }
                else
                {
                    if (getPasajeros() > 0)
                        return "Mascota subida en el regazo de un pasajero.";
                    else
                        return "La mascota no puede ir en el regazo del conductor.";
                }
                   
            }
            else
                return "Debe haber un conductor ";
        }
        public string Encender()
        {
            if (existeConductor() && Conductor.GetEdad() >=18)
            {
                setEncendido(true);
                return "Motor encendido!";
            }
            else
                return "Debe haber un conductor que encienda el auto y este debe ser mayor de edad!";

        }
        public string Apagar()
        {
            setEncendido(false);
            return "Motor apagado!";
        }
        public string Acelerar()
        {
            if (getEncendido())
            {
                setVelocidad(getVelocidad() + 10);
                return "Acelerando! Velocidad incrementada 10%";
            }
            else
                return "Primero encienda el auto!";
        }
        public string Frenar()
        {
            setVelocidad(getVelocidad() - 20);
            return "Frenando! Velocidad decrementada 20%";
        }
        public string BajarPasajeros()
        {
            if (getVelocidad() == 0)
            {
                while (Capacidad > 0)
                {
                    setPasajeros(getPasajeros() - 1);
                }
                return "Se bajaron los pasajeros!";
            }
            else
                return "Debe frenar el vehiculo para bajar a los pasajeros!";
        }
        public string BajarConductor()
        {
            if (Encendido == false)
                return "Se bajó el conductor!";
            else
                return "Debe apagar el motor para que se baje el conductor";
        }
    }
}
