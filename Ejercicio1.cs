using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio1
    {
        public void NumeMayor()
        {
            byte I, K;
            int NunMayor, Numero;
            string linea;
            Console.Write("Digite cuántos números quiere ingresar:"); linea = Console.ReadLine();
            I = byte.Parse(linea);
            Console.Write("Digite un número:"); linea = Console.ReadLine();
            NunMayor = int.Parse(linea);
            for (K = 2; K <= I; K++)
            {
                Console.Write("Digite un número:"); linea = Console.ReadLine();
                Numero = int.Parse(linea);
                if (Numero > NunMayor) NunMayor = Numero;
            }
            Console.WriteLine("El número mayor es: " + NunMayor);
            Console.Write("Pulse una tecla para finalizar:"); Console.ReadLine();
            Console.Clear();

        }


    }
}
