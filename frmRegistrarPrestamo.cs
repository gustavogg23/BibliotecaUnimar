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
using static BibliotecaUnimar.frmRegistroLibro;

namespace BibliotecaUnimar
{
    public partial class frmRegistrarPrestamo : Form
    {
        public frmRegistrarPrestamo()
        {
            InitializeComponent();
        }

        string cedula, titulo;

        // Botón para buscar el usuario registrado
        private void btnControlUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) // Si los campos están llenos
            {
                LeerArchivoEstudiantes(); // Se lee el archivo de estudiantes registrados
                LeerArchivoLibros(); // Se lee el archivo de libros registrados
                UsuarioRegistrado(); // Se busca el usuario registrado
                EscribirArchivo(); // Se escribe el préstamo en el archivo
            }
            else return; // Si no, no se puede continuar
        }

        private Boolean ValidarCampos()
        {
            if (txtCedula.Text == "" || txtLibro.Text == "") // Si la caja de texto está vacía
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
                string ruta = @"EstudiantesRegistrados.txt"; // Ruta del archivo
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
                MessageBox.Show("No existe un archivo con los estudiantes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
            }
        }

        private void LeerArchivoLibros()
        {
            try
            {
                string ruta = @"LibrosIngresados.txt";
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(' ');
                    Libro libro = new Libro(datos[0], datos[1], datos[2], datos[3], true);
                    DatosListaLibros.lista.agregarLibro(libro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe un archivo con los libros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Método para buscar el usuario registrado
        private void UsuarioRegistrado()
        {
            cedula = txtCedula.Text; // Se obtiene la cédula ingresada de la caja de texto
            titulo = txtLibro.Text; // Se obtiene el título del libro ingresado de la caja de texto
            if (DatosLista.lista.existeEstudiante(cedula) && DatosListaLibros.lista.existeLibro(titulo)) // Se utiliza el método existeEstudiante de la lista de estudiantes para verificar si está registrado
            {
                MessageBox.Show("Préstamo Registrado"); // Se muestra un mensaje de éxito
                DatosListaLibros.lista.buscarLibro(titulo).setDisponible(false); // Se cambia el estado del libro a no disponible
            }
            else if (DatosLista.lista.existeEstudiante(cedula) == false) // Si el estudiante no está registrado
            {
                MessageBox.Show("Usuario no Registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia indicando que el estudiante no se ha registrado
            }
            else if (DatosListaLibros.lista.existeLibro(titulo) == false) // Si el libro no está disponible no está registrado
            {
                MessageBox.Show("Libro no Disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtCedula.Clear(); // Se limpia la caja de texto
            txtLibro.Clear();
        }

        private void EscribirArchivo()
        {
            string cedula = txtCedula.Text;
            string titulo = txtLibro.Text;
            string nombre = DatosLista.lista.buscarEstudiante(cedula).getNombre();
            string apellido = DatosLista.lista.buscarEstudiante(cedula).getApellido();
            string carrera = DatosLista.lista.buscarEstudiante(cedula).getCarrera();
            string ruta = @"PrestamosActivos.txt"; // Ruta del archivo
            if (File.Exists(ruta)) // Verifica si el archivo en la ruta especificada existe
            {
                StreamWriter agregar = File.AppendText(ruta); // Se crea un objeto de tipo StreamWriter para agregar información al archivo
                agregar.WriteLine(nombre + " " + apellido + " " + cedula + " " + carrera + " " + titulo); // Se escriben los datos del estudiante recién registrado en el archivo
                agregar.Close(); // Se cierra el archivo
            }
            else // Si el archivo no existe
            {
                TextWriter escribir = new StreamWriter(ruta); // Se crea un objeto de tipo TextWriter para escribir en el archivo
                escribir.WriteLine(nombre + " " + apellido + " " + cedula + " " + carrera + " " + titulo); // Se escriben los datos del estudiante recién registrado en el archivo
                escribir.Close(); // Se cierra el archivo
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

        private void txtLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

