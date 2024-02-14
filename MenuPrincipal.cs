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
            frmRegistrarAlumno frm = new frmRegistrarAlumno();
            frm.ShowDialog(); // Mostrar el formulario
        }
    }
}
