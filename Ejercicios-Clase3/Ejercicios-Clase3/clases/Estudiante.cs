using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ejercicios_Clase3.clases
{
    public class Estudiante : Persona, IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public List<Libro> libros = new List<Libro>();

        public Estudiante(string nombre, string apellido, DateTime fechanac, List<Libro> libros)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechanac;
            this.libros = libros;
        }
        public int GetEdad()
        {
            DateTime fechaActual = DateTime.Today;
            return fechaActual.Year - this.FechaNac.Year;
        }
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }
        public List<Libro> GetLibros()
        {
            return this.libros;
        }

        public List<Libro> GetLibrosLeidos()
        {
            List<Libro> LibrosLeidos = new List<Libro>();
            foreach (Libro libro in GetLibros())
            {
                if (libro.WasRead == true)
                    LibrosLeidos.Add(libro);
            }
            return LibrosLeidos;
        }
        public int CantPaginasLeidas()
        {
            int cant = 0;
            foreach (Libro libro in GetLibrosLeidos())
            {
                cant += libro.CantPaginas;
            }
            return cant;
        }

        public int CantLibrosNoLeidos()
        {
            int cant = 0;
            foreach (Libro libro in GetLibros())
            {
                if (libro.WasRead == false)
                    cant += 1;
            }
            return cant;
        }

        public string AgregarLibro(Libro libro)
        {
            GetLibros().Add(libro);
            return "Libro agregado con exito!";
        }
        public string QuitarLibro(Libro libro)
        {
            GetLibros().Remove(libro);
            return "Libro removido exitosamente!";
        }
    }
}
