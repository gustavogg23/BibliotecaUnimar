namespace BibliotecaUnimar
{
    partial class frmRenovaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenovaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.btnVOlver = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renovar Préstamo";
            // 
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRenovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenovar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnRenovar.ForeColor = System.Drawing.Color.White;
            this.btnRenovar.Location = new System.Drawing.Point(265, 302);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(115, 60);
            this.btnRenovar.TabIndex = 1;
            this.btnRenovar.Text = "RENOVAR";
            this.btnRenovar.UseVisualStyleBackColor = false;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnVOlver
            // 
            this.btnVOlver.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVOlver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVOlver.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnVOlver.ForeColor = System.Drawing.Color.White;
            this.btnVOlver.Location = new System.Drawing.Point(449, 302);
            this.btnVOlver.Name = "btnVOlver";
            this.btnVOlver.Size = new System.Drawing.Size(164, 61);
            this.btnVOlver.TabIndex = 2;
            this.btnVOlver.Text = "VOLVER AL MENÚ";
            this.btnVOlver.UseVisualStyleBackColor = false;
            this.btnVOlver.Click += new System.EventHandler(this.btnVOlver_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(456, 183);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(173, 30);
            this.txtCedula.TabIndex = 25;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.White;
            this.lblCedula.Location = new System.Drawing.Point(242, 173);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(213, 38);
            this.lblCedula.TabIndex = 24;
            this.lblCedula.Text = "C.I. Estudiante:";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRenovaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(886, 548);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.btnVOlver);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRenovaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renovaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Button btnVOlver;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
    }
}