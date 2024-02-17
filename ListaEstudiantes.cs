using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnimar
{
    public class ListaEstudiantes
    {
        // Atributos
        private Nodo cabeza;
        private int tamano;

        // Método Constructor
        public ListaEstudiantes()
        {
            cabeza = null;
            tamano = 0;
        }

        // Método para saber si la lista está vacía
        public bool estaVacia()
        {
            return cabeza == null;
        }

        // Método para agregar un estudiante a la lista
        public void agregarEstudiante(Estudiante valor)
        {
            // Se define un nuevo nodo
            Nodo nuevo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo aux = cabeza;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            tamano++;
        }

        // Método para buscar un estudiante en la lista
        public Estudiante buscarEstudiante(string cedula)
        {
            Nodo aux = cabeza;
            while (aux != null)
            {
                if (aux.getValor().getCedula() == cedula)
                {
                    return aux.getValor();
                }
                aux = aux.getSiguiente();
            }
            return null;
        }

        // Método para verificar si un estudiante está registrado
        public Boolean existeEstudiante(string cedula)
        {
            Nodo actual = cabeza;

            while (actual != null)
            {
                if (actual.getValor().getCedula() == cedula)
                {
                    return true;
                }
                actual = actual.getSiguiente();
            }
            return false;
        }

        // Método para eliminar un estudiante de la lista
        public void eliminarEstudiante(string cedula)
        {
            if (cabeza != null)
            {
                if (cabeza.getValor().getCedula() == cedula)
                {
                    cabeza = cabeza.getSiguiente();
                }
                else
                {
                    Nodo aux = cabeza;
                    while (aux.getSiguiente() != null)
                    {
                        if (aux.getSiguiente().getValor().getCedula() == cedula)
                        {
                            aux.setSiguiente(aux.getSiguiente().getSiguiente());
                            break;
                        }
                        aux = aux.getSiguiente();
                    }
                }
                tamano--;
            }
        }

       // Método para obtener el tamaño de la lista
        public int getTamano()
        {
            return tamano;
        }
    }
}
