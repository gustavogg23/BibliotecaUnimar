using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
