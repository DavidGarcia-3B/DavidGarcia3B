using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio5
    {
        public void Piramide()
        {
            string linea;
            int tamano;
            Console.WriteLine("Digite un numero para crear la piramide: "); linea = Console.ReadLine();
            tamano = int.Parse(linea);
            Console.Write("");
            for (int altura = 1; altura <= tamano; altura++)
            {
                for (int vacio = 1; vacio <= tamano - altura; vacio++)
                {
                    Console.Write(" ");
                }
                for (int forma = 1; forma <= (altura * 2) - 1; forma++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("PRESIONE ENTER PARA CONTINUAR..."); Console.ReadLine();
            Console.Clear();
        }
    }
}
