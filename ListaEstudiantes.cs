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
            if (cabeza == null) // Si la lista está vacía
            {
                cabeza = nuevo; // El nuevo nodo es la cabeza
            }
            else // Si la lista no está vacía
            {
                Nodo aux = cabeza; // Se crea un nodo auxiliar
                while (aux.getSiguiente() != null) // Se recorre la lista hasta llegar al último nodo
                {
                    aux = aux.getSiguiente(); // Se avanza al siguiente nodo
                }
                aux.setSiguiente(nuevo); // Se agrega el nuevo nodo al final de la lista
            }
            tamano++; // Se incrementa el tamaño de la lista
        }

        // Método para buscar un estudiante en la lista
        public Estudiante buscarEstudiante(string cedula)
        {
            Nodo aux = cabeza; // Se crea un nodo auxiliar
            while (aux != null) // Se recorre la lista
            {
                if (aux.getValor().getCedula() == cedula) // Si se encuentra la cédula del estudiante
                {
                    return aux.getValor(); // Se retorna el estudiante
                }
                aux = aux.getSiguiente(); // Se avanza al siguiente nodo
            }
            return null; // Si no se encuentra el estudiante, se retorna null
        }

        // Método para verificar si un estudiante está registrado
        public Boolean existeEstudiante(string cedula)
        {
            Nodo actual = cabeza; // Se crea un nodo auxiliar

            while (actual != null) // Se recorre la lista
            {
                if (actual.getValor().getCedula() == cedula) // Si se encuentra la cédula del estudiante
                {
                    return true; 
                }
                actual = actual.getSiguiente(); // Se avanza al siguiente nodo
            }
            return false; // Si no se encuentra el estudiante, se retorna false
        }

        // Método para eliminar un estudiante de la lista
        public void eliminarEstudiante(string cedula)
        {
            Boolean encontrado = false; // Se inicializa la variable encontrado en false
            if (cabeza != null) // Si la lista no está vacía
            {
                if (cabeza.getValor().getCedula() == cedula) // Si el estudiante a eliminar es la cabeza
                {
                    cabeza = cabeza.getSiguiente(); // Se elimina la cabeza
                    encontrado = true; // Se cambia el valor de encontrado a true
                }
                else // Si el estudiante a eliminar no es la cabeza
                {
                    Nodo aux = cabeza; // Se crea un nodo auxiliar
                    while (aux.getSiguiente() != null) // Se recorre la lista
                    {
                        if (aux.getSiguiente().getValor().getCedula() == cedula) // Si se encuentra el estudiante a eliminar
                        {
                            aux.setSiguiente(aux.getSiguiente().getSiguiente()); // Se elimina el estudiante
                            encontrado = true; // Se cambia el valor de encontrado a true
                            break; // Se rompe el ciclo
                        }
                        aux = aux.getSiguiente(); // Se avanza al siguiente nodo
                    }
                }
                if (encontrado) // Si se encontró el estudiante
                {
                    tamano--; // Se decrementa el tamaño de la lista
                }
            }
        }

       // Método para obtener el tamaño de la lista
        public int getTamano()
        {
            return tamano;
        }
    }
}
