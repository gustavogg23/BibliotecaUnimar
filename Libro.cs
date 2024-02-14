using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnimar
{
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
    }
}
