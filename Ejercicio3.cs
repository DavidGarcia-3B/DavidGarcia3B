using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{
    class Ejercicio3
    {
        public void facturacion()
        {
            string totalc, uprecio;
            int cantidad; float precio, subtotal; double factura = 0, precioconiva;
            Console.WriteLine("\t\t*******************************************************");
            Console.WriteLine("Introduzca la cantidad vendida: "); totalc = Console.ReadLine();
            cantidad = int.Parse(totalc);

            Console.Write("Introduzca el precio: $"); uprecio = Console.ReadLine();
            precio = float.Parse(uprecio);
            subtotal = precio * cantidad;
            factura = factura + subtotal;
            if (cantidad > 0)
            {
                while (cantidad != 0)
                {
                    Console.WriteLine("Introduzca la cantidad vendida: "); totalc = Console.ReadLine();
                    cantidad = int.Parse(totalc);
                    if (cantidad > 0)
                    {
                        Console.Write("Introduzca el precio: $"); uprecio = Console.ReadLine();
                        precio = float.Parse(uprecio);
                    }
                    subtotal = precio * cantidad;
                    factura = factura + subtotal;
                }
            }
            Console.Clear();
            precioconiva = (factura * 14) / 100;
            precioconiva = factura + precioconiva;
            Console.WriteLine("\t\t*******************************************************");
            Console.WriteLine("\t\t\t\t\t   $|\t𝐅𝐀𝐂𝐓𝐔𝐑𝐀\t|$");
            Console.WriteLine("\t\t*******************************************************");
            Console.WriteLine("Usuario: Consumidor Final.");
            Console.WriteLine("Su precio a pagar es de: $" + factura);
            Console.WriteLine("Se aplicó un iva del 14%. Precio final a pagar +iva: $" + precioconiva);
            Console.WriteLine("");
            Console.WriteLine("PRESIONE ENTER PARA CONTINUAR..."); Console.ReadLine();
            Console.Clear();

        }
    }
}
