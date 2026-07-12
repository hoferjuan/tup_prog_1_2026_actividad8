using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static int Acumulado = 0;
        static int Cantidad = 0;

        public static void RegistrarNumero(int numero)
        {
            Acumulado += numero;
            Cantidad++;
        }
        public static int ObtenerAcumulado()
        {
            return Acumulado;
        }
        public static double CalcularPromedio()
        {
            if (Cantidad > 0)
            {
                double prom = ((double)Acumulado / Cantidad);

                return prom;
            }
            else
            {
                return 0;
            }
        }
        public static int MostrarPantallaMenu()
        {
            int opcion;

            Console.WriteLine($"");
            Console.WriteLine($"-- Menú --");

            Console.WriteLine($"1 - Ingresar Número");
            Console.WriteLine($"2 - Mostrar Acumulados");
            Console.WriteLine($"3 - Mostrar Cantidad Ingresados");
            Console.WriteLine($"4 - Mostrar Promedio");
            Console.WriteLine($"5 - Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
        public static void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine($"-- Ingrese su número --");
            RegistrarNumero(Convert.ToInt32(Console.ReadLine()));
        }
        public static void MostrarPantallaAcumulado()
        {
            Console.WriteLine($"-- Acumulado --");
            Console.WriteLine($"{ObtenerAcumulado()}");
        }
        public static void MostrarPantallaCantidadIngresados()
        {
            Console.WriteLine($"-- Cantidad Ingresados --");
            Console.WriteLine($"{Cantidad}");
        }
        public static void MostrarPantallaPromedio()
        {
            Console.WriteLine($"-- Promedio --");
            Console.WriteLine($"{CalcularPromedio()}");

        }
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                opcion = MostrarPantallaMenu();

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        MostrarPantallaSolicitarNumero();
                        break;

                    case 2:
                        Console.Clear();
                        MostrarPantallaAcumulado();
                        break;

                    case 3:
                        Console.Clear();
                        MostrarPantallaCantidadIngresados();
                        break;

                    case 4:
                        Console.Clear();
                        MostrarPantallaPromedio();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine($"Opcion no valida");
                        break;
                }
            }
            while (opcion != 5);
        }
    }
}
