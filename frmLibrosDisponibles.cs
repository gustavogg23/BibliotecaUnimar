using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaUnimar.frmRegistroLibro;

namespace BibliotecaUnimar
{
    public partial class frmLibrosDisponibles : Form
    {
        public frmLibrosDisponibles()
        {
            InitializeComponent();
        }

        string titulo, genero;

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            MostrarLibrosDisponibles();
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void MostrarLibrosDisponibles()
        {
            string datosLibros = DatosListaLibros.lista.mostrarLibros();
            txtLibrosDisponibles.Text = datosLibros;
        }
    }
}
