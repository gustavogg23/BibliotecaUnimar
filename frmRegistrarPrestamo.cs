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
    public partial class frmRegistrarPrestamo : Form
    {
        public frmRegistrarPrestamo()
        {
            InitializeComponent();
        }

        private void btnControlUsuario_Click(object sender, EventArgs e)
        {
          ValidacionUserPrestamo();
        }
        private void ValidacionUserPrestamo()
        {
            CtrlUserRegistroPrestamo ctl = new CtrlUserRegistroPrestamo();
            ctl.Dock = DockStyle.Fill;               
            panel1.Controls.Add(ctl);
            ctl.Show();
        }
    }
}

