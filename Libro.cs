using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnimar
{
    // Clase Libro
    public class Libro
    {
        // Atributos
        private string titulo;
        private string autor;
        private string categoria;

        // Método Constructor
        public Libro(string titulo, string autor, string categoria)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.categoria = categoria;
        }

        // Métodos Getters
        public string getTitulo()
        {
            return titulo;
        }

        public string getAutor()
        {
            return autor;
        }

        public string getCategoria()
        {
            return categoria;
        }

        // Método ToString para mostrar los datos del libro
        public override string ToString()
        {
            return $"Título: {getTitulo()} \r\nAutor: {getAutor()} \r\nCategoría: {getCategoria()}\r\n";
        }
    }
}
