namespace BibliotecaUnimar
{
    partial class frmRegistroLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroLibro));
            this.lblRegistroLibros = new System.Windows.Forms.Label();
            this.lblDatosLibros = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblnombreAutor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.BtnAgregarLibro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtApellidoAutor = new System.Windows.Forms.TextBox();
            this.lblApellidoAutor = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistroLibros
            // 
            this.lblRegistroLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegistroLibros.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.lblRegistroLibros.ForeColor = System.Drawing.Color.White;
            this.lblRegistroLibros.Location = new System.Drawing.Point(0, 0);
            this.lblRegistroLibros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistroLibros.Name = "lblRegistroLibros";
            this.lblRegistroLibros.Size = new System.Drawing.Size(851, 92);
            this.lblRegistroLibros.TabIndex = 0;
            this.lblRegistroLibros.Text = "Registro De Libros ";
            this.lblRegistroLibros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatosLibros
            // 
            this.lblDatosLibros.AutoSize = true;
            this.lblDatosLibros.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblDatosLibros.ForeColor = System.Drawing.Color.White;
            this.lblDatosLibros.Location = new System.Drawing.Point(261, 92);
            this.lblDatosLibros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosLibros.Name = "lblDatosLibros";
            this.lblDatosLibros.Size = new System.Drawing.Size(336, 26);
            this.lblDatosLibros.TabIndex = 1;
            this.lblDatosLibros.Text = "Ingrese los Datos del Libro";
            // 
            // lblGenero
            // 
            this.lblGenero.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(108, 210);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(100, 32);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Género:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(108, 40);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(101, 22);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo:";
            this.lblTitulo.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblnombreAutor
            // 
            this.lblnombreAutor.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblnombreAutor.ForeColor = System.Drawing.Color.White;
            this.lblnombreAutor.Location = new System.Drawing.Point(35, 100);
            this.lblnombreAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombreAutor.Name = "lblnombreAutor";
            this.lblnombreAutor.Size = new System.Drawing.Size(168, 22);
            this.lblnombreAutor.TabIndex = 4;
            this.lblnombreAutor.Text = "Nombre Autor:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(206, 41);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(185, 26);
            this.txtTitulo.TabIndex = 5;
            this.txtTitulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.BackColor = System.Drawing.Color.White;
            this.txtNombreAutor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.txtNombreAutor.ForeColor = System.Drawing.Color.Black;
            this.txtNombreAutor.Location = new System.Drawing.Point(206, 100);
            this.txtNombreAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(185, 26);
            this.txtNombreAutor.TabIndex = 6;
            this.txtNombreAutor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtNombreAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutor_KeyPress);
            // 
            // BtnAgregarLibro
            // 
            this.BtnAgregarLibro.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnAgregarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarLibro.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarLibro.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarLibro.Location = new System.Drawing.Point(40, 281);
            this.BtnAgregarLibro.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregarLibro.Name = "BtnAgregarLibro";
            this.BtnAgregarLibro.Size = new System.Drawing.Size(182, 75);
            this.BtnAgregarLibro.TabIndex = 8;
            this.BtnAgregarLibro.Text = "AGREGAR";
            this.BtnAgregarLibro.UseVisualStyleBackColor = false;
            this.BtnAgregarLibro.Click += new System.EventHandler(this.BtnAgregarLibro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtApellidoAutor);
            this.panel1.Controls.Add(this.lblApellidoAutor);
            this.panel1.Controls.Add(this.btnVolverMenu);
            this.panel1.Controls.Add(this.cboGenero);
            this.panel1.Controls.Add(this.BtnAgregarLibro);
            this.panel1.Controls.Add(this.txtNombreAutor);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.lblnombreAutor);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Location = new System.Drawing.Point(185, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 410);
            this.panel1.TabIndex = 10;
            // 
            // txtApellidoAutor
            // 
            this.txtApellidoAutor.BackColor = System.Drawing.Color.White;
            this.txtApellidoAutor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.txtApellidoAutor.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoAutor.Location = new System.Drawing.Point(206, 154);
            this.txtApellidoAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoAutor.Name = "txtApellidoAutor";
            this.txtApellidoAutor.Size = new System.Drawing.Size(185, 26);
            this.txtApellidoAutor.TabIndex = 19;
            this.txtApellidoAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoAutor_KeyPress);
            // 
            // lblApellidoAutor
            // 
            this.lblApellidoAutor.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblApellidoAutor.ForeColor = System.Drawing.Color.White;
            this.lblApellidoAutor.Location = new System.Drawing.Point(10, 153);
            this.lblApellidoAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoAutor.Name = "lblApellidoAutor";
            this.lblApellidoAutor.Size = new System.Drawing.Size(200, 22);
            this.lblApellidoAutor.TabIndex = 18;
            this.lblApellidoAutor.Text = "Apellido Autor:";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenu.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnVolverMenu.ForeColor = System.Drawing.Color.White;
            this.btnVolverMenu.Location = new System.Drawing.Point(248, 281);
            this.btnVolverMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(182, 75);
            this.btnVolverMenu.TabIndex = 17;
            this.btnVolverMenu.Text = "VOLVER AL MENÚ";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // cboGenero
            // 
            this.cboGenero.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Fantasía",
            "Romance",
            "Histórico",
            "Ciencia Ficción",
            "Poesía",
            "Libros Técnicos",
            "Libros de Texto",
            "Tesis de Grado"});
            this.cboGenero.Location = new System.Drawing.Point(206, 210);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(185, 27);
            this.cboGenero.TabIndex = 16;
            // 
            // frmRegistroLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(851, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDatosLibros);
            this.Controls.Add(this.lblRegistroLibros);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Libros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroLibros;
        private System.Windows.Forms.Label lblDatosLibros;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblnombreAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.Button BtnAgregarLibro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.TextBox txtApellidoAutor;
        private System.Windows.Forms.Label lblApellidoAutor;
    }
}