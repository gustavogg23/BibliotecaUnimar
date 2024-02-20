using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnimar
{
    public class Prestamo
    {
        // Atributos
        private Estudiante estudiante;
        private Libro libro;
        private DateTime fechaPrestamo;

        // Método Constructor
        public Prestamo(Estudiante estudiante, Libro libro, DateTime fechaPrestamo)
        {
            this.estudiante = estudiante;
            this.libro = libro;
            this.fechaPrestamo = fechaPrestamo;
        }

        // Métodos Getters
        public Estudiante getEstudiante()
        {
            return estudiante;
        }

        public Libro getLibro()
        {
            return libro;
        }

        public DateTime getFechaPrestamo()
        {
            return fechaPrestamo;
        }

        // Método ToString para mostrar los datos del préstamo
        public override string ToString()
        {
            return  estudiante.getNombre() + "-" + estudiante.getApellido() + "-" + estudiante.getCedula() + "-" + estudiante.getCarrera() + "-" + libro.getTitulo() + "-" + libro.getnombreAutor() + "-" + libro.getApellidoAutor() + "-" + libro.getGenero() + "-" + fechaPrestamo;
        }
    }
}
