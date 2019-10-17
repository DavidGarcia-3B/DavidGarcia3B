using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio10
    {
        
        public void operaciones()
        {
            Menucito menucito; menucito = new Menucito();
            string opcion2;
            byte opcion;
            Problemas menu;
            menu = new Problemas();
            do
            {
                Console.Write("Ingrese opción \n"
                                + "(1) Salir. \n"
                                + "(2) Sumatorio.\n" +
                                "(3) Factorial. \n"); opcion2 = Console.ReadLine();opcion = byte.Parse(opcion2);
                Console.Clear(); 
                switch (opcion)
                {
                    case 1: menucito.menucito(); break;
                    case 2: menu.sumatorio(); break;
                    case 3: menu.factorial(); break;
                }

            } while (opcion != 1);
        }
    }

    class Problemas
    {
        public void sumatorio()
        {
            int numero, resultado = 1;
            string linea;
            Console.WriteLine("Ingresar la cantidad para hacer el sumatorio: "); linea = Console.ReadLine();
            numero = int.Parse(linea);
            for (int inicial = 0; inicial <= numero; inicial++)
            {
                resultado = resultado + inicial;

            }
            Console.WriteLine("El sumatorio de" + numero + "es: " + resultado);
            Console.WriteLine("Presione enter para continuar..."); Console.ReadLine();
            Console.Clear();
        }
        public void factorial()
        {
            int numero, resultado = 1;
            string linea;
            Console.WriteLine("Ingresar la cantidad para hacer el factorial: "); linea = Console.ReadLine();
            numero = int.Parse(linea);
            for (int inicial = 1; inicial <= numero; inicial++)
            {
                resultado = resultado * inicial;
            }
            Console.WriteLine("El factorial de" + numero + "es: " + resultado);
            Console.WriteLine("Presione enter para continuar..."); Console.ReadLine();
            Console.Clear();
        }

        public void salida()
        {
            Console.WriteLine("GRACIAS POR USAR EL SISTEMA...");
            Console.WriteLine("..."); Console.ReadLine();
            Console.Clear();
        }
    }
}
    

