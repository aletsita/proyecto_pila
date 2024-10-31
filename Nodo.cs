using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    internal class Nodo
    {
        private int Valor;
        private Nodo Siguiente;

        public Nodo (int Valor)
        {
            Valor1 = Valor;
            Siguiente1 = null;

        }

        public int Valor1 { get => Valor; set => Valor = value; }
        internal Nodo Siguiente1 { get => Siguiente; set => Siguiente = value; }
    }
}