using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio8
    {
        public void ConteoNum()
        {
            string linea;
            int numero, cont = 0, cont2 = 0, cont3 = 0;
            Console.Write("Ingrese el número hasta donde se quiere contar: "); linea = Console.ReadLine();
            numero = int.Parse(linea);
            Console.WriteLine(" ");
            Console.WriteLine("Columna#1");
            while (cont < numero)
            {
                cont++;
                Console.WriteLine("   " + cont + "  ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Columna#2");
            while (cont2 < numero)
            {
                cont2 = (cont2 + 2);
                if (cont2 < numero)
                {
                    Console.WriteLine("   " + (cont2));
                }
                else { Console.WriteLine("   "); }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Columna#3");
            while (cont3 < numero)
            {
                cont3 = (cont3 + 3);
                if (cont3 < numero)
                {
                    Console.WriteLine("   " + (cont3));
                }
                else { Console.WriteLine("  "); }
            }
            Console.WriteLine("PRESIONE ENTER PARA CONTINUAR..."); Console.ReadLine();
            Console.Clear();
        }
    }
}
