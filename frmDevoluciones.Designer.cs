﻿namespace BibliotecaUnimar
{
    partial class frmDevoluciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnVOLVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devoluciones";
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDevolver.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(213, 348);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(118, 56);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            // 
            // btnVOLVer
            // 
            this.btnVOLVer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVOLVer.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnVOLVer.ForeColor = System.Drawing.Color.White;
            this.btnVOLVer.Location = new System.Drawing.Point(446, 348);
            this.btnVOLVer.Name = "btnVOLVer";
            this.btnVOLVer.Size = new System.Drawing.Size(120, 56);
            this.btnVOLVer.TabIndex = 2;
            this.btnVOLVer.Text = "Volver al menú";
            this.btnVOLVer.UseVisualStyleBackColor = false;
            this.btnVOLVer.Click += new System.EventHandler(this.btnVOLVer_Click);
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVOLVer);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.label1);
            this.Name = "frmDevoluciones";
            this.Text = "Devoluciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnVOLVer;
    }
}