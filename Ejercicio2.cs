using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio2
    {
        public void Cuadrado()
        {
            string Tamano;
            int n;
            Console.Write("Defina el tamaño del cuadrado: "); Tamano = Console.ReadLine();
            n = int.Parse(Tamano);
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.WriteLine("PRESS ENTER..."); Console.ReadLine();
            Console.Clear();
        }
    }
}
