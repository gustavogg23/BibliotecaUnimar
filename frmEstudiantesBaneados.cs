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
    public partial class frmEstudiantesBaneados : Form
    {
        public frmEstudiantesBaneados()
        {
            InitializeComponent();
        }

        private void btnBaneados_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverBaneados_Click(object sender, EventArgs e)
        {
            Close();//cerrar el formulario
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

        private void frmEstudiantesBaneados_Load(object sender, EventArgs e)
        {
            LeerArchivoPrestamos(); // Se lee el archivo de préstamos activos
            txtSancionados.Text = DatosListaPrestamos.lista.mostrarSancionados(); // Se muestra la lista de préstamos activos
        }
    }
}
