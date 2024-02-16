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

namespace BibliotecaUnimar
{
    public partial class frmRegistrarAlumno : Form
    {
        public frmRegistrarAlumno()
        {
            InitializeComponent();
        }

        public ListaEstudiantes lista = new ListaEstudiantes();
        string nombre, apellido, cedula, carrera;


        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8 || e.KeyChar == 130 || e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8 || e.KeyChar == 130 || e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarDatos();
            LimpiarDatos();
        }

        private void AgregarDatos()
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            cedula = txtCedula.Text;
            carrera = cboCarrera.Text;

            Estudiante estudiante = new Estudiante(nombre, apellido, cedula, carrera);
            txtListEstudiantes.Text += estudiante.ToString() + "\r\n";

            lista.agregarEstudiante(estudiante);
        }

        private void LimpiarDatos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            cboCarrera.SelectedIndex = -1;
        }
    }
}
