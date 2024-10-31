using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = null;
            int opcion;

            do
            {
                Console.WriteLine("         MENU Pilas        ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine(" 1.- Establecer Tamaño");
                Console.WriteLine(" 2.- Push");
                Console.WriteLine(" 3.- Pop");
                Console.WriteLine(" 4.- Imprimir");
                Console.WriteLine(" 5.- Salir");
                Console.WriteLine("---------------------------------");
                Console.Write("Seleccionar Opción => ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Establecer tamaño de la pila
                        Console.Write("Establecer el tamaño máximo de la pila: ");
                        int maxSize = Convert.ToInt32(Console.ReadLine());
                        pila = new Pila(maxSize);
                        Console.WriteLine("Tamaño de la pila establecido.");
                        break;

                    case 2:
                        // Opción para Push
                        if (pila == null)
                        {
                            Console.WriteLine("Primero debes establecer el tamaño de la pila.");
                        }
                        else
                        {
                            Console.Write("Ingrese el valor a insertar en la pila: ");
                            int valor = Convert.ToInt32(Console.ReadLine());
                            if (pila.Push(valor))
                            {
                                Console.WriteLine("Valor insertado correctamente en la pila.");
                            }
                            else
                            {
                                Console.WriteLine("La pila está llena. No se pudo insertar el valor.");
                            }
                        }
                        break;

                    case 3:
                        // Opción para Pop
                        if (pila == null)
                        {
                            Console.WriteLine("Primero debes establecer el tamaño de la pila.");
                        }
                        else
                        {
                            if (pila.Pop())
                            {
                                Console.WriteLine("Valor extraído de la pila correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("La pila está vacía. No se pudo extraer ningún valor.");
                            }
                        }
                        break;

                    case 4:
                        // Opción para Imprimir
                        if (pila == null)
                        {
                            Console.WriteLine("Primero debes establecer el tamaño de la pila.");
                        }
                        else
                        {
                            pila.PrintStack();
                        }
                        break;

                    case 5:
                        // Opción para Salir
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intenta nuevamente.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();

            } while (opcion != 5);
        }
    }
}