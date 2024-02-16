using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnimar
{
    public class Estudiante
    {
        // Atributos
        private string nombre;
        private string apellido;
        private string cedula;
        private string carrera;

        // Método Constructor
        public Estudiante(string nombre, string apellido, string cedula, string carrera)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.carrera = carrera;
        }

        // Métodos Getters
        public string getNombre()
        {
            return nombre;
        }

        public string getApellido()
        {
            return apellido;
        }

        public string getCedula()
        {
            return cedula;
        }

        public string getCarrera()
        {
            return carrera;
        }
    }
}
