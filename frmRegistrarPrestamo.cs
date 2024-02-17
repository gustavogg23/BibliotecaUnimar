using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void btnControlUsuario_Click(object sender, EventArgs e)
        {
          UsuarioRegistrado();
        }

        private void UsuarioRegistrado()
        {
            cedula = txtCedula.Text;
            if (DatosLista.lista.existeEstudiante(cedula))
            {
                MessageBox.Show("Usuario Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.Controls.Clear();
                CtrlUserRegistroPrestamo ctl = new CtrlUserRegistroPrestamo();
                ctl.Dock = DockStyle.Fill;
                panel1.Controls.Add(ctl);
                ctl.Show();
            }
            else
            {
                MessageBox.Show("Usuario no Registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}

