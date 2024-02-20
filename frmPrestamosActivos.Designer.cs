namespace BibliotecaUnimar
{
    partial class frmPrestamosActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamosActivos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarPrestramosActiv = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamos Activos";
            // 
            // btnBuscarPrestramosActiv
            // 
            this.btnBuscarPrestramosActiv.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscarPrestramosActiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPrestramosActiv.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPrestramosActiv.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPrestramosActiv.Location = new System.Drawing.Point(193, 387);
            this.btnBuscarPrestramosActiv.Name = "btnBuscarPrestramosActiv";
            this.btnBuscarPrestramosActiv.Size = new System.Drawing.Size(210, 77);
            this.btnBuscarPrestramosActiv.TabIndex = 1;
            this.btnBuscarPrestramosActiv.Text = "MOSTRAR PRÉSTAMOS";
            this.btnBuscarPrestramosActiv.UseVisualStyleBackColor = false;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenu.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnVolverMenu.ForeColor = System.Drawing.Color.White;
            this.btnVolverMenu.Location = new System.Drawing.Point(471, 387);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(194, 77);
            this.btnVolverMenu.TabIndex = 2;
            this.btnVolverMenu.Text = "VOLVER AL MENÚ";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmPrestamosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(886, 543);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnBuscarPrestramosActiv);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrestamosActivos";
            this.Text = "Préstamos Activos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPrestramosActiv;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}