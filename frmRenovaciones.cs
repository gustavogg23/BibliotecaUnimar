using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaUnimar.frmPrestamosActivos;

namespace BibliotecaUnimar
{
    public partial class frmRenovaciones : Form
    {
        public frmRenovaciones()
        {
            InitializeComponent();
        }

        string cedula;

        private void btnVOlver_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) // Si los campos están llenos
            {
                ValidarCedula(); // Se valida la cédula
                actulizarArchivoPrestamos(); // Se actualiza el archivo de préstamos
                MessageBox.Show("Renovación exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); // Se muestra un mensaje de información
                LimpiarTexto(); // Se limpian los campos
            }
            else return; // Si no, no se puede continuar
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

        private void ValidarCedula()
        {
            LeerArchivoPrestamos(); // Se leen los préstamos activos
            cedula = txtCedula.Text; // Se almacena la cédula ingresada

            if (DatosListaPrestamos.lista.existePrestamo(cedula)) // Se verifica si el prestamo a renovar existe
            {
                Prestamo prestamo = DatosListaPrestamos.lista.buscarPrestamo(cedula); // Se busca el préstamo
                int difFechas = (DateTime.Now - prestamo.getFechaPrestamo()).Days; // Se calcula la diferencia de días entre la fecha actual y la fecha de préstamo
                if (difFechas > 3) // Si la diferencia de días es mayor a 3
                {
                    MessageBox.Show("El préstamo no puede ser renovado, ya que está suspendido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
                }
                else // Si la diferencia de días es menor o igual a 3
                {
                    prestamo.setFechaPrestamo(DateTime.Now); // Se actualiza la fecha de préstamo
                }
            }
            else // Si el préstamo no existe
            {
                MessageBox.Show("El préstamo no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
            }
        }

        private Boolean ValidarCampos()
        {
            if (txtCedula.Text == "") // Si el campo de cédula está vacío
            {
                MessageBox.Show("Debe ingresar la cédula del estudiante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
                return false; // Se retorna false
            }
            return true; // Si no, se retorna true
        }

        private void actulizarArchivoPrestamos()
        {
            string ruta = @"PrestamosActivos.txt"; // Ruta del archivo
            System.IO.File.WriteAllText(ruta, string.Empty); // Se vacía el archivo
            Nodo aux = DatosListaPrestamos.lista.getCabeza(); // Se crea un nodo auxiliar
            while (aux != null) // Se recorre la lista de préstamos
            {
                Prestamo prestamo = aux.getValorPr(); // Se obtiene el préstamo
                Estudiante estudiante = prestamo.getEstudiante(); // Se obtiene el estudiante
                Libro libro = prestamo.getLibro(); // Se obtiene el libro
                DateTime fechaPrestamo = prestamo.getFechaPrestamo(); // Se obtiene la fecha de préstamo
                string linea = estudiante.getNombre() + "-" + estudiante.getApellido() + "-" + estudiante.getCedula() + "-" + estudiante.getCarrera() + "-" + libro.getTitulo() + "-" + libro.getnombreAutor() + "-" + libro.getApellidoAutor() + "-" + fechaPrestamo; // Se concatenan los datos
                System.IO.File.AppendAllText(ruta, linea + Environment.NewLine); // Se escribe la línea en el archivo
                aux = aux.getSiguiente(); // Se avanza al siguiente nodo
            }
        }

        private void LimpiarTexto()
        {
            txtCedula.Clear(); // Se limpia el campo de cédula
        }
    }
}
