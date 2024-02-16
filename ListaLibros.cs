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
            Nodo nuevo = new Nodo(libro);
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
            tamaño++;
        }

        // Método para buscar un libro en la lista
        public Libro buscarLibro(string titulo)
        {
            Nodo aux = cabeza;
            while (aux != null)
            {
                if (aux.getValorLib().getTitulo() == titulo)
                {
                    return aux.getValorLib();
                }
                aux = aux.getSiguiente();
            }
            return null;
        }

        // Método para eliminar un libro de la lista
        public void eliminarLibro(string titulo)
        {
            if (cabeza != null)
            {
                if (cabeza.getValorLib().getTitulo() == titulo)
                {
                    cabeza = cabeza.getSiguiente();
                    tamaño--;
                }
                else
                {
                    Nodo aux = cabeza;
                    while (aux.getSiguiente() != null)
                    {
                        if (aux.getSiguiente().getValorLib().getTitulo() == titulo)
                        {
                            aux.setSiguiente(aux.getSiguiente().getSiguiente());
                            tamaño--;
                            break;
                        }
                        aux = aux.getSiguiente();
                    }
                }
            }
        }
    }
}
