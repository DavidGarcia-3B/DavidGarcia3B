using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio9
    {
        public void Multiplicacion()
        {
            string linea;
            int numero, resultado = 0;
            Console.Write("Ingrese el número para realizar la tabla de multiplicar: "); linea = Console.ReadLine();
            numero = int.Parse(linea);
            Console.WriteLine(" ");
            Console.WriteLine(" TABLA DE MULTIPLICAR DEL NÚMERO " + numero);

            for (int tabla = 1; tabla <= 15; tabla++)
            {
                resultado = numero * tabla;
                Console.WriteLine("            " + numero + "x" + tabla + "=" + resultado);
            }
            Console.WriteLine("PRESIONE ENTER PARA CONTINUAR..."); Console.ReadLine();
            Console.Clear();
        }

    }
}
   