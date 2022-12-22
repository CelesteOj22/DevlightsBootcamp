using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase3.clases
{
    public class Libro
    {
        public string Nombre { get; set; }
        public Persona Autor { get; set; }
        public int CantPaginas { get; set; }
        public bool WasRead { get; set; }

        
        public Libro() { }
        public Libro(string nombre, Persona autor, int cantpaginas, bool wasread) {
            this.Nombre = nombre;
            this.Autor = autor;
            this.CantPaginas = cantpaginas;
            this.WasRead = wasread;
        }
    }
}
