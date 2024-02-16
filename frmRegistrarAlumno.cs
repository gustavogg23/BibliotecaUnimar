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
    public partial class frmRegistrarAlumno : Form
    {
        public frmRegistrarAlumno()
        {
            InitializeComponent();
        }
        ListaEstudiantes lista = new ListaEstudiantes();
        string nombre, apellido, cedula, carrera;


        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarDatos();
        }

        private void AgregarDatos()
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            cedula = txtCedula.Text;
            carrera = cboCarrera.Text;

            Estudiante estudiante = new Estudiante(nombre, apellido, cedula, carrera);
            lista.agregarEstudiante(estudiante);
        }
    }
}
