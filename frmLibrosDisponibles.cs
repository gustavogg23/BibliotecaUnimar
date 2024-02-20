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

        string genero;

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            txtLibrosDisponibles.Clear();
            string datosLibros = DatosListaLibros.lista.mostrarLibros();
            txtLibrosDisponibles.Text = datosLibros;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                txtLibrosDisponibles.Clear();
                genero = cboGenero.Text;
                string datosLibros = DatosListaLibros.lista.mostrarLibrosGenero(genero);
                txtLibrosDisponibles.Text = datosLibros;
                cboGenero.SelectedIndex = -1;
            }
            else return;
            
        }

        private Boolean ValidarCampos()
        {
            if (cboGenero.Text == "") // Si la caja de texto está vacía
            {
                MessageBox.Show("Debe seleccionar un género para filtrar los libros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
                return false; // No se puede continuar
            }
            return true; // Todos los campos están llenos
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
    }
}
