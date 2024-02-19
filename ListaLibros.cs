using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnimar
{
    public class ListaLibros
    {
        // Atributos
        private Nodo cabeza;
        private int tamaño;

        // Método Constructor
        public ListaLibros()
        {
            cabeza = null;
            tamaño = 0;
        }

        // Métodos Getters
        public Nodo getCabeza()
        {
            return cabeza;
        }

        public int getTamaño()
        {
            return tamaño;
        }

        // Método para agregar un libro a la lista
        public void agregarLibro(Libro libro)
        {
            Nodo nuevo = new Nodo(libro); // Se define un nuevo nodo
            if (cabeza == null) 
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
            tamaño++; // Se incrementa el tamaño de la lista
        }

        // Método para buscar un libro en la lista
        public Libro buscarLibro(string titulo)
        {
            Nodo aux = cabeza; // Se crea un nodo auxiliar
            while (aux != null) // Se recorre la lista
            {
                if (aux.getValorLib().getTitulo() == titulo) // Si se encuentra el título del libro
                {
                    return aux.getValorLib(); // Se retorna el libro
                }
                aux = aux.getSiguiente(); // Se avanza al siguiente nodo
            }
            return null; // Si no se encuentra el libro, se retorna null
        }

        // Método para verificar si un libro existe
        public Boolean existeLibro(string titulo)
        {
            Nodo actual = cabeza; // Se crea un nodo auxiliar
            while (actual != null) // Se recorre la lista
            {
                if (actual.getValorLib().getTitulo() == titulo) // Si se encuentra el libro según su título
                {
                    return true; // Se retorna true
                }
                actual = actual.getSiguiente(); // Se avanza al siguiente nodo
            }
            return false; // Si no se encuentra el libro, se retorna false
        }

        // Método para eliminar un libro de la lista
        public void eliminarLibro(string titulo)
        {
            if (cabeza != null) // Si la lista no está vacía
            {
                if (cabeza.getValorLib().getTitulo() == titulo) // Si el libro a eliminar es la cabeza
                {
                    cabeza = cabeza.getSiguiente(); // Se elimina la cabeza
                    tamaño--; // Se decrementa el tamaño de la lista
                }
                else // Si el libro a eliminar no es la cabeza
                {
                    Nodo aux = cabeza; // Se crea un nodo auxiliar
                    while (aux.getSiguiente() != null) // Se recorre la lista
                    {
                        if (aux.getSiguiente().getValorLib().getTitulo() == titulo) // Si se encuentra el libro según su título
                        {
                            aux.setSiguiente(aux.getSiguiente().getSiguiente()); // Se elimina el libro
                            tamaño--; // Se decrementa el tamaño de la lista
                            break; // Se rompe el ciclo
                        }
                        aux = aux.getSiguiente(); // Se avanza al siguiente nodo
                    }
                }
            }
        }

        // Método para mostrar los libros de la lista
        public string mostrarLibros()
        {
            string listaLibros = ""; // Se crea una cadena vacía
            Nodo aux = cabeza; // Se crea un nodo auxiliar
            while (aux != null) // Se recorre la lista
            {
                Libro libro = aux.getValorLib(); // Se obtiene el libro del nodo
                if (libro.getDisponible()) // Si el libro está disponible
                {
                    listaLibros += libro.ToString() + "\r\n"; // Se concatenan los datos del libro
                }
                aux = aux.getSiguiente(); // Se avanza al siguiente nodo
            }
            return listaLibros; // Se retorna la cadena con los títulos de los libros
        }
    }
}
