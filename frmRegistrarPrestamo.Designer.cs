namespace BibliotecaUnimar
{
    partial class frmRegistrarPrestamo
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
            this.lblRegistroPrestamo = new System.Windows.Forms.Label();
            this.lblIngresoCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblRegistroPrestamo
            // 
            this.lblRegistroPrestamo.AutoSize = true;
            this.lblRegistroPrestamo.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.lblRegistroPrestamo.Location = new System.Drawing.Point(6, 15);
            this.lblRegistroPrestamo.Name = "lblRegistroPrestamo";
            this.lblRegistroPrestamo.Size = new System.Drawing.Size(440, 45);
            this.lblRegistroPrestamo.TabIndex = 0;
            this.lblRegistroPrestamo.Text = "Registro De Préstamo";
            // 
            // lblIngresoCedula
            // 
            this.lblIngresoCedula.AutoSize = true;
            this.lblIngresoCedula.Location = new System.Drawing.Point(50, 97);
            this.lblIngresoCedula.Name = "lblIngresoCedula";
            this.lblIngresoCedula.Size = new System.Drawing.Size(372, 26);
            this.lblIngresoCedula.TabIndex = 1;
            this.lblIngresoCedula.Text = "Ingrese la Cédula del Usuario ";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(207, 167);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(139, 32);
            this.txtCedula.TabIndex = 7;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.White;
            this.lblCedula.Location = new System.Drawing.Point(95, 163);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(133, 38);
            this.lblCedula.TabIndex = 6;
            this.lblCedula.Text = "Cédula:";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(168, 236);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 41);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar ";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnControlUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(452, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 551);
            this.panel1.TabIndex = 9;
            // 
            // frmRegistrarPrestamo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1094, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblIngresoCedula);
            this.Controls.Add(this.lblRegistroPrestamo);
            this.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistroPrestamo;
        private System.Windows.Forms.Label lblIngresoCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
    }
}