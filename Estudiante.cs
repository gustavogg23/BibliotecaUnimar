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

        // Método Constructor
        public Estudiante(string nombre, string apellido, string cedula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
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
    }
}
