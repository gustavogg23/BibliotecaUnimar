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
using static BibliotecaUnimar.frmAlumnoRegistro;

namespace BibliotecaUnimar
{
    public partial class frmRegistrarPrestamo : Form
    {
        public frmRegistrarPrestamo()
        {
            InitializeComponent();
        }

        string cedula, titulo;

        // Btón para buscar el usuario registrado
        private void btnControlUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) // Si los campos están llenos
            {
                LeerArchivoEstudiantes(); // Se lee el archivo de estudiantes registrados
                UsuarioRegistrado(); // Se busca el usuario registrado
            }
            else return; // Si no, no se puede continuar
        }

        private Boolean ValidarCampos()
        {
            if (txtCedula.Text == "") // Si la caja de texto está vacía
            {
                MessageBox.Show("Debe ingresar la cédula del estudiante que desea solicitar un préstamo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
                return false; // No se puede continuar
            }
            return true; // Todos los campos están llenos
        }

        // Método para leer el archivo de estudiantes registrados
        private void LeerArchivoEstudiantes()
        {
            try // Intentar leer el archivo
            {
                string ruta = @"C:\\Users\\gusta\\Documentos\\UNIMAR\\TRIMESTRE V\\Programación 2\\BibliotecaUnimar\\EstudiantesRegistrados.txt"; // Ruta del archivo
                string[] lineas = File.ReadAllLines(ruta); // Se leen todas las líneas del archivo
                foreach (string linea in lineas) // Se recorre cada línea del archivo
                {
                    string[] datos = linea.Split(' '); // Se usa el método Split para separar los datos de cada línea cuando encuentre un espacio
                    Estudiante estudiante = new Estudiante(datos[0], datos[1], datos[2], datos[3]); // Se crea un objeto de tipo estudiante con los datos separados
                    DatosLista.lista.agregarEstudiante(estudiante); // Se agrega el objeto a la lista de estudiantes
                }
            }
            catch (Exception ex) // Si hay un error
            {
                MessageBox.Show("No existe un archivo con los registros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
            }
        }

        // Método para buscar el usuario registrado
        private void UsuarioRegistrado()
        {
            cedula = txtCedula.Text; // Se obtiene la cédula ingresada de la caja de texto
            if (DatosLista.lista.existeEstudiante(cedula)) // Se utiliza el método existeEstudiante de la lista de estudiantes para verificar si está registrado
            {
                // TODO
            }
            else // Si no está registrado
            {
                MessageBox.Show("Usuario no Registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia indicando que el estudiante no se ha registrado
            }
            txtCedula.Clear(); // Se limpia la caja de texto
        }

        // Evento de tecla presionada en el campo de texto de la cédula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)) // Si el caracter presionado no es un número o la tecla de retroceso
            {
                e.Handled = true; // No se escribe el caracter
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
                return; // Salir del evento
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

