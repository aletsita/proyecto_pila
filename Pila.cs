using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    internal class Pila
    {
        private int MAX;
        private int Tope = 0;
        private Nodo Inicio;

        //Asignando el tope de la Pila
        public Pila(int max)
        {
            MAX = max;
            Inicio = null;
        }

        //Metodo de Empty
        public bool Empty()
        {
            if (Inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Metodo de Pila llena
        public bool Full()
        {
            if (Tope == MAX)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        //Metodo para Imprimir
        public void PrintStack()
        {
            Nodo actual = Inicio;
            Console.WriteLine("Contenido de la pila:");
            while (actual != null)
            {
                Console.WriteLine(actual.Valor1); // Imprime el valor de cada nodo usando Valor1
                actual = actual.Siguiente1;       // Avanza al siguiente nodo usando Siguiente1
            }
        }

        //Metodo para Insertar si la pila esta llena
        public bool Push(int valor)
        {
            if (Full())
            {
                Console.WriteLine("La pila está llena");
                return false;
            }
            else
            {
                Nodo nuevoNodo = new Nodo(valor);
                nuevoNodo.Siguiente1 = Inicio; // El nuevo nodo apunta al actual "Inicio"
                Inicio = nuevoNodo;            // El nuevo nodo se convierte en el "Inicio"
                Tope++;                        // Incrementamos el Tope
                return true;
            }
        }

        //Metodo para regresar un entero sin parametro
        public bool Pop()
        {
            if (Empty())
            {
                Console.WriteLine("La pila está vacía");
                return false; // Código para indicar que la pila está vacía
            }
            else
            {
                int valor = Inicio.Valor1;    // Guardamos el valor del nodo en la cima usando Valor1
                Inicio = Inicio.Siguiente1;   // Movemos el Inicio al siguiente nodo usando Siguiente1
                Tope--;                       // Decrementamos el Tope
                return true;
            }
        }

    }
}