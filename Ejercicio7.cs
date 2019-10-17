using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio7
    {
        public void ColNum()
        {
            Console.Write("Columna#1" + "      " + "Columna#2");
            Console.WriteLine(" ");
            for (int columna1 = 1; columna1 <= 100; columna1++)
            {
                Console.WriteLine("   " + columna1 + "           " + (101 - columna1));
            }
            Console.WriteLine("PRESIONE ENTER PARA CONTINUAR..."); Console.ReadLine();
            Console.Clear();
        }
    }
}
