namespace BibliotecaUnimar
{
    partial class frmLibrosDisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibrosDisponibles));
            this.lblLibrosDisponibles = new System.Windows.Forms.Label();
            this.txtLibrosDisponibles = new System.Windows.Forms.TextBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLibrosDisponibles
            // 
            this.lblLibrosDisponibles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLibrosDisponibles.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrosDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblLibrosDisponibles.Location = new System.Drawing.Point(0, 0);
            this.lblLibrosDisponibles.Name = "lblLibrosDisponibles";
            this.lblLibrosDisponibles.Size = new System.Drawing.Size(854, 135);
            this.lblLibrosDisponibles.TabIndex = 0;
            this.lblLibrosDisponibles.Text = "Libros Disponibles";
            this.lblLibrosDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLibrosDisponibles
            // 
            this.txtLibrosDisponibles.Location = new System.Drawing.Point(411, 103);
            this.txtLibrosDisponibles.Multiline = true;
            this.txtLibrosDisponibles.Name = "txtLibrosDisponibles";
            this.txtLibrosDisponibles.ReadOnly = true;
            this.txtLibrosDisponibles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLibrosDisponibles.Size = new System.Drawing.Size(386, 432);
            this.txtLibrosDisponibles.TabIndex = 1;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarLibro.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLibro.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLibro.Location = new System.Drawing.Point(115, 324);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(204, 65);
            this.btnBuscarLibro.TabIndex = 18;
            this.btnBuscarLibro.Text = "MOSTRAR LIBROS";
            this.btnBuscarLibro.UseVisualStyleBackColor = false;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenu.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.Color.White;
            this.btnVolverMenu.Location = new System.Drawing.Point(115, 411);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(204, 65);
            this.btnVolverMenu.TabIndex = 19;
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
            "Libros de Texto"});
            this.cboGenero.Location = new System.Drawing.Point(166, 157);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(185, 27);
            this.cboGenero.TabIndex = 21;
            // 
            // lblGenero
            // 
            this.lblGenero.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(68, 157);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(100, 32);
            this.lblGenero.TabIndex = 20;
            this.lblGenero.Text = "Género:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(115, 239);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(204, 65);
            this.btnFiltrar.TabIndex = 22;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // frmLibrosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(854, 547);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.txtLibrosDisponibles);
            this.Controls.Add(this.lblLibrosDisponibles);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLibrosDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros Disponible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibrosDisponibles;
        private System.Windows.Forms.TextBox txtLibrosDisponibles;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnFiltrar;
    }
}