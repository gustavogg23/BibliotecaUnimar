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
        private string genero;
        private Boolean disponible = true;

        // Método Constructor
        public Libro(string titulo, string autor, string genero, Boolean disponible)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.disponible = disponible;
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

        public string getGenero()
        {
            return genero;
        }

        public Boolean getDisponible()
        {
            return disponible;
        }

        public void setDisponible(Boolean disponible)
        {
            this.disponible = disponible;
        }

        // Método ToString para mostrar los datos del libro
        public override string ToString()
        {
            return $"Título: {getTitulo()} \r\nAutor: {getAutor()} \r\nGénero: {getGenero()}\r\n";
        }
    }
}
