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

        string cedula;

        // Btón para buscar el usuario registrado
        private void btnControlUsuario_Click(object sender, EventArgs e)
        {
            LeerArchivoEstudiantes();
            UsuarioRegistrado();
        }

        // Método para leer el archivo de estudiantes registrados
        private void LeerArchivoEstudiantes()
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

        // Método para buscar el usuario registrado
        private void UsuarioRegistrado()
        {
            cedula = txtCedula.Text; // Se obtiene la cédula ingresada de la caja de texto
            if (DatosLista.lista.existeEstudiante(cedula)) // Se utiliza el método existeEstudiante de la lista de estudiantes para verificar si está registrado
            {
                panel1.Controls.Clear();
                CtrlUserRegistroPrestamo ctl = new CtrlUserRegistroPrestamo(); // Se crea un control de usuario para el registro de préstamo
                ctl.Dock = DockStyle.Fill;
                panel1.Controls.Add(ctl);
                ctl.Show();
            }
            else // Si no está registrado
            {
                MessageBox.Show("Usuario no Registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia indicando que el estudiante no se ha registrado
            }
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
    }
}

