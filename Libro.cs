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
        private string nombreAutor;
        private string apellidoAutor;
        private string genero;
        private Boolean disponible = true;

        // Método Constructor
        public Libro(string titulo, string nombreAutor, string apellidoAutor, string genero, Boolean disponible)
        {
            this.titulo = titulo;
            this.nombreAutor = nombreAutor;
            this.apellidoAutor = apellidoAutor;
            this.genero = genero;
            this.disponible = disponible;
        }

        // Métodos Getters
        public string getTitulo()
        {
            return titulo;
        }

        public string getnombreAutor()
        {
            return nombreAutor;
        }

        public string getApellidoAutor()
        {
            return apellidoAutor;
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
            return $"Título: {getTitulo()} \r\nAutor: {getnombreAutor()}" + " " + $"{getApellidoAutor()} \r\nGénero: {getGenero()}\r\n";
        }
    }
}
