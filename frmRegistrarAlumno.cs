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
        string nombre, apellido, cedula;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarDatos();
        }

        private void AgregarDatos()
        {
            ListaEstudiantes lista = new ListaEstudiantes();

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            cedula = txtCedula.Text;

            Estudiante estudiante = new Estudiante(nombre, apellido, cedula);
            lista.agregarEstudiante(estudiante);
        }
    }
}
