﻿using System;
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
    public partial class frmEstudiantesBaneados : Form
    {
        public frmEstudiantesBaneados()
        {
            InitializeComponent();
        }

        private void btnBaneados_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverBaneados_Click(object sender, EventArgs e)
        {
            Close();//cerrar el formulario
        }
    }
}
