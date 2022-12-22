using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase3.clases
{
    public class Ejercicios_Clases1y2
    {
        public void Ejercicio1()
        {
            Console.Write("Ejercicio nro 1\n");
            int num = 210;

            if (num > 100)
            {
                Console.WriteLine("El valor es mayor que 100");
            }
        }
        public void Ejercicio2()
        {
            Console.Write("Ejercicio nro 2\n");
            int num;
            Console.Write("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es Par!");
            }
            else
            {
                Console.WriteLine("El numero es Impar!");
            }
        }
        public void Ejercicio3()
        {
            Console.Write("Ejercicio nro 3\n");
            int num = 6;

            int val = num / 2;
            if (val % 2 != 0)
            {
                Console.WriteLine("El numero es el doble de un impar!");
            }
            else
            {
                Console.WriteLine("No pue");
            }
        }
        public void Ejercicio4()
        {
            Console.Write("Ejercicio nro 4\n");
            int num = 6;

            switch (num)
            {
                case 1:
                    Console.WriteLine("{0} en numeros romanos: I", num);
                    break;
                case 2:
                    Console.WriteLine("{0} en numeros romanos: II", num);
                    break;
                case 3:
                    Console.WriteLine("{0} en numeros romanos: III", num);
                    break;
                case 4:
                    Console.WriteLine("{0} en numeros romanos: IV", num);
                    break;
                case 5:
                    Console.WriteLine("{0} en numeros romanos: V", num);
                    break;
                case 6:
                    Console.WriteLine("{0} en numeros romanos: VI", num);
                    break;
                case 7:
                    Console.WriteLine("{0} en numeros romanos: VII", num);
                    break;
                case 8:
                    Console.WriteLine("{0} en numeros romanos: VIII", num);
                    break;
                case 9:
                    Console.WriteLine("{0} en numeros romanos: IX", num);
                    break;
                case 10:
                    Console.WriteLine("{0} en numeros romanos: X", num);
                    break;
                default:
                    Console.WriteLine("El numero debe estar entre 1 y 10");
                    break;
            }
        }
        public void Ejercicio5()
        {
            Console.Write("Ejercicio nro 5\n");
            string nombre1, nombre2;
            int edad1, edad2;
            //persona 1
            Console.Write("Ingrese el nombre de la persona 1: ");
            nombre1 = Convert.ToString(Console.ReadLine());
            Console.Write("Ingrese la edad de la persona 1: ");
            edad1 = Convert.ToInt32(Console.ReadLine());

            //persona 2
            Console.Write("Ingrese el nombre de la persona 2: ");
            nombre2 = Convert.ToString(Console.ReadLine());
            Console.Write("Ingrese la edad de la persona 2: ");
            edad2 = Convert.ToInt32(Console.ReadLine());

            if (edad1 < edad2)
            {
                Console.WriteLine("El nombre del menor es {0} y la diferencia de edades es {1}", nombre1, edad2 - edad1);
            }
            else if (edad2 < edad1)
            {
                Console.WriteLine("El nombre del menor es {0} y la diferencia de edades es {1}", nombre2, edad1 - edad2);
            }
            else
            {
                Console.WriteLine("Ambas personas tienen la misma edad!");
            }
        }
        public void Ejercicio6()
        {
            Console.Write("Ejercicio nro 6\n");
            int a, b, c, bas, alt, area;
            double perim;
            Console.Write("Ingrese el valor del lado a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor del lado b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor del lado c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor de la base: ");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor de la altura: ");
            alt = Convert.ToInt32(Console.ReadLine());

            if (a == b && a == c && b == c)
            {
                Console.WriteLine("El triángulo es equilatero");
            }
            else if (a != b && a != c && b != c)
            {
                Console.WriteLine("El triángulo es escaleno");
            }
            else
            {
                Console.WriteLine("El triángulo es isósceles");
            }

            area = bas * alt;
            perim = bas + alt + Math.Sqrt(bas ^ 2 + alt ^ 2);
            Console.WriteLine("El area es {0} y el perimetro es {1}", area, perim);
        }

        public void Ejercicio7(Ejercicios_Clases1y2 ej)
        {
            Console.Write("Ingrese el valor a desglosar: ");
            int dinero = Convert.ToInt32(Console.ReadLine());
            foreach (var d in ej.Desglose(dinero))
            {
                Console.WriteLine(d);
            }
        }
        public IEnumerable Desglose(int dinero)
        {
            int[] denominaciones = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            int desglose;
            string peso, resultado = "";

            if (dinero > 0)
            {
                for (int i = 0; i < denominaciones.Length; i++)
                {
                    desglose = dinero / denominaciones[i];
                    dinero %= denominaciones[i];

                    if (i < 7)
                    {
                        if (desglose == 1)
                        {
                            resultado = string.Format("{0} billete de {1}", 1, denominaciones[i]);
                        }
                        else if (desglose > 1)
                        {
                            resultado = string.Format("{0} billetes de {1}", desglose, denominaciones[i]);
                        }
                    }
                    else
                    {
                        peso = (i == 8) ? "peso" : "pesos";

                        if (desglose == 1)
                        {
                            resultado = string.Format("{0} moneda de {1} {2}", 1, denominaciones[i], peso);
                        }
                        else if (desglose > 0)
                        {
                            resultado = string.Format("{0} monedas de {1} {2}", desglose, denominaciones[i], peso);
                        }
                    }

                    if (desglose != 0)
                    {
                        yield return resultado;
                    }
                }
            }
        }
        public void Ejercicio8()
        {
            Console.Write("Ingrese un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write("{0}\n", i);
            }
        }
        public void Ejercicio9()
        {
            int num = 0, num2;
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Ingrese un numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                num += num2;
            }
            Console.Write("La suma total es: {0}", num);
        }
        public void Ejercicio10()
        {
            List<int> mult = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 3 == 0)
                {
                    mult.Add(num);
                }
            }
            Console.Write("Numeros multiplos de 3: ");
            foreach (int elem in mult)
            {
                Console.Write("{0} ", elem);
            }

        }
        public void Ejercicio11()
        {
            Console.Write("Ingresar contraseña: ");
            string pass2, pass = Convert.ToString(Console.ReadLine());

            do
            {
                Console.Write("Ingrese nuevamente la contraseña: ");
                pass2 = Convert.ToString(Console.ReadLine());
            } while (pass != pass2);
            Console.WriteLine("Contraseña Autenticada!");

        }
        public void Ejercicio12()
        {
            Console.Write("Ingresar contraseña: ");
            string pass2, pass = Convert.ToString(Console.ReadLine());
            int i = 0;
            do
            {
                i++;
                Console.Write("Ingrese nuevamente la contraseña: ");
                pass2 = Convert.ToString(Console.ReadLine());

            } while (pass != pass2 && i < 3);
            if (i <= 4)
            {
                Console.WriteLine("Contraseña Autenticada!");
            }
            else
            {
                Console.WriteLine("Numero de intentos excedido!");
            }
        }
        public void Ejercicio13()
        {
            Console.Write("Intente adivinar en que numero estoy pensando: ");
            int n = 20, num = Convert.ToInt32(Console.ReadLine());

            while (num != n)
            {
                Console.Write("Incorrecto! Intente nuevamente! \n");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Acertó!");
        }
        public void Ejercicio14()
        {
            Console.Write("Intente adivinar en que numero estoy pensando: ");
            int n = 20, num = Convert.ToInt32(Console.ReadLine());

            while (num != n)
            {
                if (num < n)
                {
                    Console.Write("Intente con un numero mayor... \n");
                }
                else
                {
                    Console.Write("Intente con un numero menor... \n");
                }
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Acertó!");
        }
        public void Ejercicio15()
        {
            int num = 0, n;
            string resp;
            do
            {
                Console.Write("Ingrese un numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                num += n;
                Console.Write("Desea seguir ingresando numeros? \n-si\n-fin\nIngrese su respuesta:");
                resp = Console.ReadLine();
            } while (resp != "fin");

            Console.Write("La suma total es: {0}", num);


        }
    }
}
