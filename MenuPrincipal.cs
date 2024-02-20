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
using static BibliotecaUnimar.frmRegistroLibro;

namespace BibliotecaUnimar
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // Botón para abrir el formulario de registro de estudiantes
        private void btnRegistroAlum_Click(object sender, EventArgs e)
        {
            frmAlumnoRegistro frm = new frmAlumnoRegistro();
            frm.ShowDialog(); // Mostrar el formulario
        }

        // Botón para abrir el formulario de registro de préstamos
        private void btnRegistroPrest_Click(object sender, EventArgs e)
        {
            frmRegistrarPrestamo frm = new frmRegistrarPrestamo(); 
            frm.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRegistroLibro frm = new frmRegistroLibro();
            frm.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLibrosDisp_Click(object sender, EventArgs e)
        {
            LeerArchivoLibrosDisponible();
            frmLibrosDisponibles frm = new frmLibrosDisponibles();
            frm.ShowDialog();
        }

        private void LeerArchivoLibrosDisponible()
        {
            try
            {
                string ruta = @"LibrosIngresados.txt";
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(' ');
                    datos[3] = Convert.ToString(datos[3]);
                    if (datos[3] == "True")
                    {
                        Libro libro = new Libro(datos[0], datos[1], datos[2], datos[3], true);
                        DatosListaLibros.lista.agregarLibro(libro);
                    }
                    else
                    {
                        Libro libro = new Libro(datos[0], datos[1], datos[2], datos[3], false);
                        DatosListaLibros.lista.agregarLibro(libro);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de libros disponibles: " + ex.Message);
            }
        }

        private void btnEstudiantesBaneados_Click(object sender, EventArgs e)
        {
            frmEstudiantesBaneados frm = new frmEstudiantesBaneados();
            frm.ShowDialog();
        }

        private void btnPrestamosAct_Click(object sender, EventArgs e)
        {
            frmPrestamosActivos frm = new frmPrestamosActivos();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRenovaciones frm = new frmRenovaciones();
            frm.ShowDialog();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            frmDevoluciones frm = new frmDevoluciones ();
            frm.ShowDialog();
        }
    }
}
