using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio6
    {
        public void Rombo()
        {
            string linea;
            int tamano;
            Console.WriteLine("Digite un numero para crear el rombo: "); linea = Console.ReadLine();
            tamano = int.Parse(linea);
            Console.Write("");
            for (int altura = 0; altura < tamano; altura++)
            {
                for (int evacio = tamano - altura; evacio > 0; evacio--)
                {
                    Console.Write(" ");
                }
                for (int forma = 0; forma < altura; forma++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");

            }
            for (int altura = 0; altura < tamano; altura++)
            {
                for (int evacio = 0; evacio < altura; evacio++)
                {
                    Console.Write(" ");
                }
                for (int forma = tamano - altura; forma > 0; forma--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");

            }
            Console.WriteLine("PRESIONE ENTER PARA CONTINUAR..."); Console.ReadLine();
            Console.Clear();
        }
    }
}
