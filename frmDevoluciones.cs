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
using static BibliotecaUnimar.frmPrestamosActivos;
using static BibliotecaUnimar.frmRegistroLibro;

namespace BibliotecaUnimar
{
    public partial class frmDevoluciones : Form
    {
        public frmDevoluciones()
        {
            InitializeComponent();
        }

        string cedula, titulo;

        private void btnVOLVer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ValidarDevolucion();
                LimpiarTexto();
            }
            else return;
        }

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
                string ruta = @"LibrosIngresados.txt"; // Ruta del archivo
                string[] lineas = File.ReadAllLines(ruta); // Se leen todas las líneas del archivo y se guardan en un arreglo
                foreach (string linea in lineas) // Se recorre el arreglo, es decir, cada línea del archivo
                {
                    string[] datos = linea.Split(' '); // Se separan los datos de cada línea cuando encuentre un espacio
                    Libro libro = new Libro(datos[0], datos[1], datos[2], datos[3], true); // Se crea un objeto de tipo libro con los datos separados
                    DatosListaLibros.lista.agregarLibro(libro); // Se agrega el objeto a la lista de libros
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe un archivo con los libros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LeerArchivoPrestamos()
        {
            try // Intentar leer el archivo
            {
                string ruta = @"PrestamosActivos.txt"; // Ruta del archivo
                string[] lineas = System.IO.File.ReadAllLines(ruta); // Se leen todas las líneas del archivo
                foreach (string linea in lineas) // Se recorre cada línea del archivo
                {
                    string[] datos = linea.Split('-'); // Se usa el método Split para separar los datos de cada línea cuando encuentre un guión
                    Estudiante estudiante = new Estudiante(datos[0], datos[1], datos[2], datos[3]); // Se crea un objeto de tipo estudiante con los datos separados
                    Libro libro = new Libro(datos[4], datos[5], datos[6], datos[7], false); // Se crea un objeto de tipo libro con los datos separados
                    DateTime fechaPrestamo = Convert.ToDateTime(datos[8]); // Se convierte la fecha de string a DateTime
                    Prestamo prestamo = new Prestamo(estudiante, libro, fechaPrestamo); // Se crea un objeto de tipo préstamo con los datos separados
                    DatosListaPrestamos.lista.agregarPrestamo(prestamo); // Se agrega el objeto a la lista de préstamos
                }
            }
            catch (Exception ex) // Si hay un error
            {
                MessageBox.Show("Error al leer el archivo de préstamos activos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Se muestra un mensaje de error
            }
        }

        // Método para validar la devolución del libro
        private void ValidarDevolucion()
        {
            cedula = txtCedula.Text;
            titulo = txtLibro.Text;

            LeerArchivoEstudiantes();
            LeerArchivoLibros();

            if (DatosLista.lista.existeEstudiante(cedula) == false)
            {
                MessageBox.Show("El estudiante no está registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (DatosListaLibros.lista.existeLibro(titulo) == false)
            {
                MessageBox.Show("El libro no está registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (DatosListaPrestamos.lista.existePrestamo(cedula) == false)
            {
                MessageBox.Show("El estudiante no tiene préstamos activos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DatosListaPrestamos.lista.eliminarPrestamo(cedula);
                actulizarArchivoPrestamos();
                MessageBox.Show("Devolución exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void actulizarArchivoPrestamos()
        {
            string datosListaPrestamos = DatosListaPrestamos.lista.mostrarPrestamos();
            string ruta = @"PrestamosActivos.txt";
            
            TextWriter escribir = new StreamWriter(ruta, false);
            if (datosListaPrestamos == "")
            {
                escribir.Write("");
                escribir.Close();
                return;
            }
            escribir.WriteLine(datosListaPrestamos);
            escribir.Close();
        }

        private Boolean ValidarCampos()
        {
            if (txtLibro.Text == "" || txtCedula.Text == "") // Si alguno de los campos está vacío
            {
                MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
                return false; // No se puede continuar
            }
            return true; // Todos los campos están llenos
        }

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

        private void LimpiarTexto()
        {
            txtCedula.Clear();
            txtLibro.Clear();
        }
    }
}
