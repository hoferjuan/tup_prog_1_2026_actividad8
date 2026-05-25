using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static int acumulado = 0, cantidad = 0, opcion;
        static int MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("(1)- Ingresar Número");
            Console.WriteLine("(2)- Mostrar Acumulación");
            Console.WriteLine("(3)- Cantidad de Números acumulados");
            Console.WriteLine("(4)- Ver Promedio");
            Console.WriteLine("(5)- Salir");
            
            opcion=Convert.ToInt32(Console.ReadLine());
            
            return opcion;
        }

        #region Registro de Número y calculos
        static void RegistrarNumero(int numero)
        {
            cantidad++;
            acumulado += numero;
        }
        static double ObtenerAcumulado()
        {
            return (double)acumulado;
        }
        static double CalcularPromedio()
        {
            if (cantidad > 0)
            {
                double promedio = (double)acumulado / cantidad;
                return promedio;
            }
            else
            { return 0; }
           
        }
        #endregion

        //Mostrar en Pantalla

        static int MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el valor deseado");
            int valor = Convert.ToInt32(Console.ReadLine());
            return valor;
            
        }
        static void MostrarAcumulado()
        {
            Console.Clear();
            Console.WriteLine($"El valor acumulado es {acumulado}");
        }
        static void MostrarCantidad()
        {
            
            Console.WriteLine($"La cantidad de números ingresados es {cantidad}.");
        }
        static void MostrarPromedio()
        {
            if (cantidad > 0)
                Console.WriteLine($"El promedio es {CalcularPromedio()}");
            else
                Console.WriteLine("No hay números ingresados todavía");
        }
        static void Main(string[] args)
        {
            do
            {
                
                opcion= MostrarMenu();

                switch (opcion)
                {
                    case 1: int numero = MostrarPantallaSolicitarNumero();
                        RegistrarNumero(numero);
                        Console.ReadKey();
                        break;
                    case 2: MostrarAcumulado();
                        Console.ReadKey();
                    break;
                    case 3: MostrarCantidad();
                        Console.ReadKey();
                        break;
                    case 4: MostrarPromedio();
                        Console.ReadKey();
                        break;
                    default: Console.WriteLine("La Opción Ingresada es invalida");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 5);
        }
    }
}
