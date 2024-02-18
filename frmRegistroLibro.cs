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
        string titulo, autor, categoria; 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            titulo = txtTitulo.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            autor = txtAutor.Text;
        }

        private void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            DatosLibros();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextReader Leer = new StreamReader("LibrosUnimar");
            //Leer.ReadToEnd();
            // sirve para leer el documento 
            MessageBox.Show(Leer.ReadToEnd());
            // sirve para leer el documento y salga una ventana emergente con lo q este escrito en eol documento
            Leer.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            categoria = txtCategoria.Text;
        }
        private void DatosLibros()
        {    //metodo para crear y guardar datos en un archivo
            StreamWriter Libros = new StreamWriter("LibrosUnimar");
            Libros.WriteLine(titulo + " " + autor + " " + categoria);
            Libros.Close();

            MessageBox.Show("Se Agrego Correctamente el libro");
        }
    }
}
