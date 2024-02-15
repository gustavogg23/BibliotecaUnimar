using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnimar
{
    public class NodoEs
    {
        // Atributos de la clase Nodo Estudiantes
        private Estudiante valor;
        private NodoEs siguiente;

        // Método Constructor
        public NodoEs(Estudiante valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }

        // Métodos Getters
        public Estudiante getValor()
        {
            return valor;
        }

        public NodoEs getSiguiente()
        {
            return siguiente;
        }

        // Métodos Setters
        public void setValor(Estudiante valor)
        {
            this.valor = valor;
        }

        public void setSiguiente(NodoEs siguiente)
        {
            this.siguiente = siguiente;
        }
    }
}
