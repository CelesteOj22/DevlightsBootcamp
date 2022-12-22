using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicios_Clase3.clases
{
    public class Persona
    {
        //Atributos
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNac { get; set; }
        public Smartphone Smartphone { get; set; }

        //constructores
        public Persona() { }
        public Persona(int dni, string nombre, string apellido, int edad)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }
        public Persona(string nombre, string apellido,DateTime fechanac)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechanac;
            this.Smartphone = new Smartphone("A20s","Samsung","Blanco");
        }

        public string GetNombreCompleto()
        {
            return this.Nombre+" "+this.Apellido;
        }

        public int GetEdad()
        {
            DateTime fechaActual = DateTime.Today;
            return fechaActual.Year - this.FechaNac.Year;
        }
    }
}
