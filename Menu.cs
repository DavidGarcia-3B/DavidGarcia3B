using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidGarcia3B
{

    class Menu
    {
        static void Main(string[] args)
        {
            Menucito menu;
            menu = new Menucito();
            menu.menucito();
        }
    }
    public class Menucito { 
          
            //Objetos de metodos|INICIO
           public void menucito() {
            
            Ejercicio1 ejercicio1; ejercicio1 = new Ejercicio1();
                Ejercicio2 ejercicio2; ejercicio2 = new Ejercicio2();
                Ejercicio3 ejercicio3; ejercicio3 = new Ejercicio3();
                Ejercicio4 ejercicio4; ejercicio4 = new Ejercicio4();
                Ejercicio5 ejercicio5; ejercicio5 = new Ejercicio5();
                Ejercicio6 ejercicio6; ejercicio6 = new Ejercicio6();
                Ejercicio7 ejercicio7; ejercicio7 = new Ejercicio7();
                Ejercicio8 ejercicio8; ejercicio8 = new Ejercicio8();
                Ejercicio9 ejercicio9; ejercicio9 = new Ejercicio9();
                Ejercicio10 ejercicio10; ejercicio10 = new Ejercicio10();
                //Objetos de metodos|FIN
                string opcion2;
                byte opcion;
                do
                {
                    Console.Write("Ingrese opción \n"
                                    + "(1) Averiguar numero mayor. \n"
                                    + "(2) Realizar un cuadrado.\n" +
                                    "(3) Realizar factura. \n" +
                                    "(4) Salario.\n" +
                                    "(5) Crear una piramide.\n" +
                                    "(6) Crear un rombo.\n" +
                                    "(7) Crear dos columnas de numero.\n" +
                                    "(8) Crear tres columnas de numero.\n" +
                                    "(9) Crear tabla de multiplicar \n" +
                                    "(10) Menu de operaciones.\n" +
                                    "(11)Salir.\n" +
                                    ": "); opcion2 = Console.ReadLine(); opcion = byte.Parse(opcion2);
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1: ejercicio1.NumeMayor(); break;
                        case 2: ejercicio2.Cuadrado(); break;
                        case 3: ejercicio3.facturacion(); break;
                        case 4: ejercicio4.salario(); break;
                        case 5: ejercicio5.Piramide(); break;
                        case 6: ejercicio6.Rombo(); break;
                        case 7: ejercicio7.ColNum(); break;
                        case 8: ejercicio8.ConteoNum(); break;
                        case 9: ejercicio9.Multiplicacion(); break;
                        case 10: ejercicio10.operaciones(); break;
                    }
                } while (opcion != 11);

                //OBJETOS DE METODOS.
            }
        
        
        
        
    }




    //Linea de fin



}

