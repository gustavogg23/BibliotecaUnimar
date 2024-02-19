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
    public partial class frmRegistroLibro : Form
    {

        public static class DatosListaLibros
        {
            public static ListaLibros lista = new ListaLibros(); // Se crea una lista de libros
        }
        public frmRegistroLibro()
        {
            InitializeComponent();
        }
        string titulo, nombreAutor, apellidoAutor, genero; 
        Boolean disponible = true;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AgregarDatos();
                LimpiarTexto();
                DatosLibros();
                MessageBox.Show("Se ha registrado el libro");
            }
            else return;
        }

        private void AgregarDatos()
        {
            titulo = txtTitulo.Text;
            nombreAutor = txtNombreAutor.Text;
            apellidoAutor = txtApellidoAutor.Text;
            genero = cboGenero.Text;

            Libro libro = new Libro(titulo, nombreAutor, apellidoAutor, genero, disponible);
            DatosListaLibros.lista.agregarLibro(libro);
        }

        private Boolean ValidarCampos()
        {
            if (txtTitulo.Text == "" || txtNombreAutor.Text == "" || cboGenero.SelectedIndex == -1) // Si alguno de los campos está vacío
            {
                MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se muestra un mensaje de advertencia
                return false; // No se puede continuar
            }
            return true; // Todos los campos están llenos
        }

        private void LimpiarTexto()
        {
            txtNombreAutor.Clear();
            txtApellidoAutor.Clear();
            cboGenero.SelectedIndex = -1;
            txtTitulo.Clear();
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

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void txtApellidoAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close(); // Cerrar el formulario actual
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void DatosLibros()
        {
            string ruta = @"LibrosIngresados.txt"; // Ruta del archivo
            if (File.Exists(ruta)) // Verifica si el archivo en la ruta especificada existe
            {
                StreamWriter agregar = File.AppendText(ruta); // Se crea un objeto de tipo StreamWriter para agregar información al archivo
                agregar.WriteLine(titulo + " " + nombreAutor + " " + apellidoAutor + " " + genero); // Se escriben los datos del libro recién registrado en el archivo
                agregar.Close();
            }
            else // Si el archivo no existe
            {
                TextWriter escribir = new StreamWriter(ruta); // Se crea un objeto de tipo TextWriter para escribir en el archivo
                escribir.WriteLine(titulo + " " + nombreAutor + " " + apellidoAutor + " " + genero);
                escribir.Close();
            }
        }
    }
}
