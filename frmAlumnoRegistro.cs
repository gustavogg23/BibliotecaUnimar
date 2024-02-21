using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaUnimar
{
    public partial class frmAlumnoRegistro : Form
    {
        // Clase estática para poder utilizar la lista creada en cualquiero otra clase del programa
        public static class DatosLista
        {
            public static ListaEstudiantes lista = new ListaEstudiantes(); // Se crea una lista de estudiantes
        }

        public frmAlumnoRegistro()
        {
            InitializeComponent();
        }

        string nombre, apellido, cedula, carrera;
        

        // Evento de tecla presionada en el campo de texto de la cédula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)) // Si el caracter presionado no es un número o la tecla de retroceso
            {
                e.Handled = true; // No se escribe el caracter
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Mensaje de advertencia
                return; // Salir del evento
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AgregarDatos();
                LimpiarDatos();
                EscribirArchivo();
                MessageBox.Show("Se ha registrado el estudiante");
            }
            else return;
        }

        // Método para agregar la información de las cajas de texto a la lista de estudiantes
        private void AgregarDatos()
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            cedula = txtCedula.Text;
            carrera = cboCarrera.Text;

            Estudiante estudiante = new Estudiante(nombre, apellido, cedula, carrera); // Se crea un objeto de tipo estudiante con los datos ingresados

            DatosLista.lista.agregarEstudiante(estudiante); // Se agrega el objeto a la lista de estudiantes
        }

        private void EscribirArchivo()
        {
            string ruta = @"EstudiantesRegistrados.txt"; // Ruta del archivo
            if (File.Exists(ruta)) // Verifica si el archivo en la ruta especificada existe
            {
                StreamWriter agregar = File.AppendText(ruta); // Se crea un objeto de tipo StreamWriter para agregar información al archivo
                agregar.WriteLine(nombre + " " + apellido + " " + cedula + " " + carrera); // Se escriben los datos del estudiante recién registrado en el archivo
                agregar.Close(); // Se cierra el archivo
            }
            else // Si el archivo no existe
            {
                TextWriter escribir = new StreamWriter(ruta); // Se crea un objeto de tipo TextWriter para escribir en el archivo
                escribir.WriteLine(nombre + " " + apellido + " " + cedula + " " + carrera); // Se escriben los datos del estudiante recién registrado en el archivo
                escribir.Close(); // Se cierra el archivo
            }
        }

        // Método para limpiar los campos de texto
        private void LimpiarDatos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            cboCarrera.SelectedIndex = -1; // Seleccionar el índice -1 del combo box para que quede en blanco
        }

        // Método para asegurar que todos los campos estén llenos
        private Boolean ValidarCampos()
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCedula.Text == "" || cboCarrera.SelectedIndex == -1) // Si alguno de los campos está vacío
            {
                MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
                return false; // No se puede continuar
            }
            return true; // Todos los campos están llenos
        }

        // Evento de tecla presionada en el campo de texto del nombre
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        // Evento de tecla presionada en el campo de texto del apellido
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        // Botón para volver al menú principal
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close(); // Cerrar el formulario actual
        }
    }
}
