using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio4
    {
        public void salario()
        {
            Console.WriteLine("\t\t@ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ ");
            Console.WriteLine("\t      BIENVENIDOS AL SISTEMA DE SALARIOS DE TEEMO CORP");
            Console.WriteLine("\t\t@ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ ");

            string horas, respuesta, nombre;
            double salario = 0, salario2 = 0, total;
            int h, extras;
            do
            {
                Console.WriteLine("Digite el nombre del empleado: "); nombre = Console.ReadLine();
                Console.WriteLine("Digite la horas que trabaja " + nombre + ":"); horas = Console.ReadLine();

                h = int.Parse(horas);

                if (h > 35)
                {
                    extras = h - 35;
                    for (int i = 0; i <= 35; i++)
                    {
                        salario = h * 15;
                    }
                    for (int j = 0; j <= h - 35; j++)
                    {
                        salario2 = (h - 35) * 22;
                    }
                    total = salario + salario2;
                }
                else
                {

                    salario = h * 15;
                    total = salario;
                    extras = 0;
                }
                Console.Clear();
                Console.WriteLine("\t\t|* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine(" El empleado " + nombre + " ha trabajado " + h + "horas, por lo que su sueldo es de " + total + ".");
                Console.WriteLine("\t\t\t   Horas extras trabajada: " + extras + ".");
                Console.WriteLine("\t\t|* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine("");
                Console.WriteLine("\t\t\t¿Quiere ingresar otro salario?"); respuesta = Console.ReadLine();
                Console.Clear();
            } while (respuesta != "no");
            Console.Clear();
            Console.WriteLine("\t\t|******************************************** ");
            Console.WriteLine("\t\t\t\t\tGracias por usar nuestro sistema.");
            Console.WriteLine("\t\t|******************************************** ");
            Console.WriteLine("...");
            Console.Clear();
        }
    }
}
