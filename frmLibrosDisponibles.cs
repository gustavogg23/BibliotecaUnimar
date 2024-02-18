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

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            MostrarLibrosDisponibles();
        }

        private void MostrarLibrosDisponibles()
        {
            string datosLibros = DatosListaLibros.lista.mostrarLibros();
            txtLibrosDisponibles.Text = datosLibros;
        }
    }
}
