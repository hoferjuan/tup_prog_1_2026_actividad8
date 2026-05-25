using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num, cont = 0;
            int opcion;
            double acum = 0;
            double prom;
            
            do
            {
                
                Console.WriteLine("(--) Seleccionar opción (--)");
                Console.WriteLine("(-1-) Ingresar Número");
                Console.WriteLine("(-2-) Mostrar Acumulados");
                Console.WriteLine("(-3-) Mostrar cantidad de Acumulados");
                Console.WriteLine("(-4-) Mostrar promedio");
                Console.WriteLine("(-5-) Salir");

                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                { 
                
                case 1:
                    Console.WriteLine("Ingrese número deseado");
                    num = Convert.ToInt32(Console.ReadLine());
                    cont++;
                    acum += num;
                break;

                case 2: 
                        Console.WriteLine($"El total acumulado es {acum}");
                break;

                case 3: 
                        Console.WriteLine($"La cantidad de números ingresados es {cont}");
                break;

                case 4: 
                        prom = acum / cont;
                        Console.WriteLine($"El promedio es {prom}");
                break;

                default: Console.WriteLine("Opción Invalida");
                break;

                }
                

            } while (opcion != 5);
        }
    }
}
