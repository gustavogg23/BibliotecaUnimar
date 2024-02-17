namespace BibliotecaUnimar
{
    partial class frmAlumnoRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnoRegistro));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistroPrestamo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtListEstudiantes = new System.Windows.Forms.TextBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(191, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 26);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(69, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(133, 38);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegistroPrestamo
            // 
            this.lblRegistroPrestamo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegistroPrestamo.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.lblRegistroPrestamo.ForeColor = System.Drawing.Color.White;
            this.lblRegistroPrestamo.Location = new System.Drawing.Point(0, 0);
            this.lblRegistroPrestamo.Name = "lblRegistroPrestamo";
            this.lblRegistroPrestamo.Size = new System.Drawing.Size(850, 112);
            this.lblRegistroPrestamo.TabIndex = 10;
            this.lblRegistroPrestamo.Text = "Registro De Préstamo";
            this.lblRegistroPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVolverMenu);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtListEstudiantes);
            this.panel1.Controls.Add(this.cboCarrera);
            this.panel1.Controls.Add(this.lblCarrera);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(87, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 402);
            this.panel1.TabIndex = 11;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenu.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.Color.White;
            this.btnVolverMenu.Location = new System.Drawing.Point(278, 278);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(201, 65);
            this.btnVolverMenu.TabIndex = 18;
            this.btnVolverMenu.Text = "VOLVER AL MENÚ";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(62, 278);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(185, 65);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "REGISTRAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtListEstudiantes
            // 
            this.txtListEstudiantes.Location = new System.Drawing.Point(515, 45);
            this.txtListEstudiantes.Multiline = true;
            this.txtListEstudiantes.Name = "txtListEstudiantes";
            this.txtListEstudiantes.Size = new System.Drawing.Size(207, 298);
            this.txtListEstudiantes.TabIndex = 16;
            // 
            // cboCarrera
            // 
            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrera.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Items.AddRange(new object[] {
            "Ingeniería de Sistema",
            "Derecho",
            "Administración",
            "Contaduría Pública",
            "Psicología",
            "Idiomas Modernos",
            "Diseño Gráfico"});
            this.cboCarrera.Location = new System.Drawing.Point(191, 201);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(185, 27);
            this.cboCarrera.TabIndex = 15;
            // 
            // lblCarrera
            // 
            this.lblCarrera.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.ForeColor = System.Drawing.Color.White;
            this.lblCarrera.Location = new System.Drawing.Point(69, 193);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(133, 38);
            this.lblCarrera.TabIndex = 14;
            this.lblCarrera.Text = "Carrera:";
            this.lblCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(191, 100);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 26);
            this.txtApellido.TabIndex = 13;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(57, 90);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(133, 38);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(191, 150);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(185, 26);
            this.txtCedula.TabIndex = 11;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.White;
            this.lblCedula.Location = new System.Drawing.Point(69, 142);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(133, 38);
            this.lblCedula.TabIndex = 10;
            this.lblCedula.Text = "Cédula:";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAlumnoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(850, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRegistroPrestamo);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlumnoRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Alumno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegistroPrestamo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtListEstudiantes;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}