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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
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
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(45, 145);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 38);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(162, 152);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(185, 26);
            this.txtTitulo.TabIndex = 10;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarLibro.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLibro.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLibro.Location = new System.Drawing.Point(113, 223);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(185, 65);
            this.btnBuscarLibro.TabIndex = 18;
            this.btnBuscarLibro.Text = "BUSCAR";
            this.btnBuscarLibro.UseVisualStyleBackColor = false;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenu.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.Color.White;
            this.btnVolverMenu.Location = new System.Drawing.Point(103, 324);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(204, 65);
            this.btnVolverMenu.TabIndex = 19;
            this.btnVolverMenu.Text = "VOLVER AL MENÚ";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmLibrosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(854, 547);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtLibrosDisponibles);
            this.Controls.Add(this.lblLibrosDisponibles);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}