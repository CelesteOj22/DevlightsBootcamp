using Ejercicios_Clase3.clases;
using Ejercicios_Clase3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

public class Ejercicios_clase3
{
    public static void Main(string[] args)
    {
        /*
        //Ejercicio 2
        var cuadrado = new Cuadrado(2);
        double area = cuadrado.CalcularArea();
        Console.WriteLine("El area del cuadrado esspecificado es: ", area);
        
        //Ejercicio 3 y 4
        DateTime fechanac = new DateTime(2000, 4, 4);
        var persona1 = new Persona("Daniela","Mariño",fechanac);
        string nomyape = persona1.GetNombreCompleto();
        Console.WriteLine("Nombre completo: {0}",nomyape);
        int edad = persona1.GetEdad();
        Console.WriteLine("Edad: {0}", edad);
        
        //Ejercicio 5
        var auto = new Auto("KOK195", "206", "Peugeot", "Azul");
        Console.WriteLine("Caracteristicas del auto: \nPatente: {0}\nMarca: {1}\nModelo: {2}\nColor: {3}",auto.Patente,auto.Marca,auto.Modelo,auto.Color);
        Console.WriteLine(auto.Encender());
        Console.WriteLine(auto.Apagar());
        
        //Ejercicio 6 y 7
        var perro = new Mascota("Pepi", "Perro");
        Console.WriteLine("Energia: {0}%",perro.getEnergia());
        Console.WriteLine(perro.Correr());
        Console.WriteLine(perro.Correr());
        Console.WriteLine(perro.Correr());
        Console.WriteLine("Energia: {0}%", perro.getEnergia());
        Console.WriteLine(perro.Alimentar());
        Console.WriteLine("Energia: {0}%", perro.getEnergia());
        
        //Ejercicio 8
        var smartphone = new Smartphone();
        Console.WriteLine(smartphone.Encender());
        Console.WriteLine(smartphone.Apagar());
        Console.WriteLine(smartphone.Encender());
        Console.WriteLine(smartphone.SubirVolumen());
        Console.WriteLine(smartphone.BajarVolumen());
        Console.WriteLine(smartphone.SubirBrillo());
        Console.WriteLine(smartphone.BajarBrillo());
        Console.WriteLine(smartphone.Silenciar());
        
        //Ejercicio 9 al 14
        //DateTime fechanacConductor1 = new DateTime(2000, 4, 4);
        //DateTime fechanacConductor2 = new DateTime(2006, 10, 5);
        var conductorMayor = new Persona("Pepe", "Perez", new DateTime(2000, 4, 4));
        var conductorMenor = new Persona("Lali", "Perez", new DateTime(2006, 10, 5));
        var mascotaGrande = new Mascota("Pepo", "perro", "grande");
        var mascotaPequeña = new Mascota("Lolo", "gato", "pequeño");
        var auto1 = new Auto(4, 2, conductorMayor, mascotaGrande);
        var auto2 = new Auto(4, 1, conductorMenor, mascotaGrande);
        var auto3 = new Auto(4, 1, conductorMayor, mascotaPequeña);
        Console.WriteLine("Velocidad del auto 2: {0}",auto2.getVelocidad());
        Console.WriteLine(auto2.Acelerar());
        Console.WriteLine(auto2.Encender()); //conductor menor de edad

        Console.WriteLine("Velocidad del auto 1: {0}", auto1.getVelocidad());
        Console.WriteLine(auto1.Acelerar());
        Console.WriteLine(auto1.Encender());
        Console.WriteLine(auto1.subirMascota());
        Console.WriteLine("Cantidad de pasajeros actual: {0}",auto1.getPasajeros());
        Console.WriteLine(auto1.Acelerar());
        Console.WriteLine(auto1.Acelerar());
        Console.WriteLine("Velocidad del auto 1: {0}", auto1.getVelocidad());
        Console.WriteLine(auto1.Frenar());
        Console.WriteLine("Velocidad del auto 1: {0}", auto1.getVelocidad());
        Console.WriteLine(auto1.Acelerar());
        Console.WriteLine(auto1.Acelerar());
        Console.WriteLine(auto1.BajarPasajeros()); //auto en movimiento
        */
        //Ejercicio 15
        int i = 1;
        var libro1 = new Libro("Programación I", new Persona("Leon", "Lane", new DateTime(1985, 8, 10)),690,true);
        var libro2 = new Libro("Programación II", new Persona("Marian", "Pome", new DateTime(1990, 1, 5)), 810, true);
        var libro3 = new Libro("Programación III", new Persona("Vivian", "Prail", new DateTime(1998, 6, 12)), 520, false);
        List<Libro> ListaLibros= new List<Libro>();
        ListaLibros.Add(libro1);
        ListaLibros.Add(libro2);
        ListaLibros.Add(libro3);
        var estudiante1 = new Estudiante("Rodolfo", "Lezcano", new DateTime(1998, 10, 22), ListaLibros);
        Console.WriteLine("Lista de libros leidos:");
        foreach (Libro libro in estudiante1.GetLibrosLeidos()){
            Console.WriteLine("{0}-{1}", i, libro.Nombre);
            i++;
        }
        i = 1;
        Console.WriteLine("Total de paginas leidas: {0}",estudiante1.CantPaginasLeidas());
        Console.WriteLine("Cantidad de libros sin leer: {0}",estudiante1.CantLibrosNoLeidos());
        Console.WriteLine("Lista total de libros:");
        foreach (Libro libro in estudiante1.GetLibros())
        {
            Console.WriteLine("{0}-{1}", i, libro.Nombre);
            i++;
        }
        i = 1;
        Console.WriteLine(estudiante1.QuitarLibro(libro3));
        Console.WriteLine("Lista total de libros:");
        foreach (Libro libro in estudiante1.GetLibros())
        {
            Console.WriteLine("{0}-{1}", i, libro.Nombre);
            i++;
        }
        i = 1;
        Console.WriteLine(estudiante1.AgregarLibro(libro3));
        Console.WriteLine("Lista total de libros:");
        foreach (Libro libro in estudiante1.GetLibros())
        {
            Console.WriteLine("{0}-{1}", i, libro.Nombre);
            i++;
        }
        
    }
    //Funcion para ejercicio 15
}