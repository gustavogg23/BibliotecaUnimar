using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnimar
{
    public class ListaPrestamos
    {
        // Atributos
        private Nodo cabeza;
        private int tamano;

        // Método Constructor
        public ListaPrestamos()
        {
            cabeza = null;
            tamano = 0;
        }

        // Métodos Getters
        public Nodo getCabeza()
        {
            return cabeza;
        }

        public int getTamano()
        {
            return tamano;
        }

        // Método para agregar un préstamo a la lista
        public void agregarPrestamo(Prestamo prestamo)
        {
            Nodo nuevo = new Nodo(prestamo); // Se define un nuevo nodo
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
            tamano++; // Se incrementa el tamaño de la lista
        }

        // Método para eliminar un préstamo de la lista
        public void eliminarPrestamo(string cedula)
        {
            Nodo aux = cabeza; // Se crea un nodo auxiliar
            Nodo anterior = null; // Se crea un nodo para almacenar el nodo anterior
            while (aux != null) // Se recorre la lista
            {
                if (aux.getValorPr().getEstudiante().getCedula() == cedula) // Si se encuentra la cédula del estudiante
                {
                    if (anterior == null) // Si el nodo a eliminar es la cabeza
                    {
                        cabeza = aux.getSiguiente(); // La cabeza apunta al siguiente nodo
                    }
                    else // Si el nodo a eliminar no es la cabeza
                    {
                        anterior.setSiguiente(aux.getSiguiente()); // El nodo anterior apunta al siguiente nodo
                    }
                    tamano--; // Se decrementa el tamaño de la lista
                    return;
                }
                anterior = aux; // El nodo anterior apunta al nodo actual
                aux = aux.getSiguiente(); // Se avanza al siguiente nodo
            }
        }

        // Método para buscar un préstamo en la lista
        public Prestamo buscarPrestamo(string cedula)
        {
            Nodo aux = cabeza; // Se crea un nodo auxiliar
            while (aux != null) // Se recorre la lista
            {
                if (aux.getValorPr().getEstudiante().getCedula() == cedula) // Si se encuentra la cédula del estudiante
                {
                    return aux.getValorPr(); // Se retorna el préstamo
                }
                aux = aux.getSiguiente(); // Se avanza al siguiente nodo
            }
            return null; // Si no se encuentra el estudiante, se retorna null
        }

        // Método para verificar si ya existe un préstamo en la lista bajo una cédula específica
        public Boolean existePrestamo(string cedula)
        {
            Nodo actual = cabeza; // Se crea un nodo auxiliar
            while (actual != null) // Se recorre la lista
            {
                if (actual.getValorPr().getEstudiante().getCedula() == cedula) // Si se encuentra la cédula del estudiante
                {
                    return true; // Se retorna true
                }
                actual = actual.getSiguiente(); // Se avanza al siguiente nodo
            }
            return false; // Si no se encuentra el estudiante, se retorna false
        }

        public string mostrarPrestamos()
        {
            string listaPrestamos = "";
            Nodo aux = cabeza;
            while (aux != null)
            {
                Prestamo prestamo = aux.getValorPr();
                Estudiante estudiante = prestamo.getEstudiante();
                Libro libro = prestamo.getLibro();
                int difFechas = (DateTime.Now - prestamo.getFechaPrestamo()).Days;
                if (difFechas > 3)
                 {
                    listaPrestamos += "\r\n" + estudiante.ToString() + libro.ToString() + "Estado: Suspendido/a\r\n";
                    aux = aux.getSiguiente();
                 }
                 else
                 {
                    listaPrestamos += "\r\n" + estudiante.ToString() + libro.ToString() + "Estado: Habilitado/a\r\n";
                    aux = aux.getSiguiente();
                 }           
            }
            return listaPrestamos;
        }
    }
}
