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

        // Btón para buscar el usuario registrado
        private void btnControlUsuario_Click(object sender, EventArgs e)
        {
          UsuarioRegistrado();
        }

        // Método para buscar el usuario registrado
        private void UsuarioRegistrado()
        {
            cedula = txtCedula.Text; // Se obtiene la cédula ingresada de la caja de texto
            if (DatosLista.lista.existeEstudiante(cedula)) // Se utiliza el método existeEstudiante de la lista de estudiantes para verificar si está registrado
            {
                panel1.Controls.Clear();
                CtrlUserRegistroPrestamo ctl = new CtrlUserRegistroPrestamo(); // Se crea un control de usuario para el registro de préstamo
                ctl.Dock = DockStyle.Fill;
                panel1.Controls.Add(ctl);
                ctl.Show();
            }
            else // Si no está registrado
            {
                MessageBox.Show("Usuario no Registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia indicando que el estudiante no se ha registrado
            }
        }

        // Evento de tecla presionada en el campo de texto de la cédula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)) // Si el caracter presionado no es un número o la tecla de retroceso
            {
                e.Handled = true; // No se escribe el caracter
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
                return; // Salir del evento
            }
        }
    }
}

