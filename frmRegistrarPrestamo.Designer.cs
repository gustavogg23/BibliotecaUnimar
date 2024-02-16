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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnControlUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registro De Prestamo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingrese La Cedula Del Usuario ";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(207, 191);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(139, 32);
            this.txtCedula.TabIndex = 7;
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.White;
            this.lblCedula.Location = new System.Drawing.Point(95, 187);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(133, 38);
            this.lblCedula.TabIndex = 6;
            this.lblCedula.Text = "Cédula:";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnControlUsuario
            // 
            this.btnControlUsuario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnControlUsuario.Location = new System.Drawing.Point(168, 260);
            this.btnControlUsuario.Name = "btnControlUsuario";
            this.btnControlUsuario.Size = new System.Drawing.Size(100, 41);
            this.btnControlUsuario.TabIndex = 8;
            this.btnControlUsuario.Text = "Buscar ";
            this.btnControlUsuario.UseVisualStyleBackColor = false;
            this.btnControlUsuario.Click += new System.EventHandler(this.btnControlUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(14, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 150);
            this.panel1.TabIndex = 9;
            // 
            // frmRegistrarPrestamo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1094, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnControlUsuario);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmRegistrarPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnControlUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}