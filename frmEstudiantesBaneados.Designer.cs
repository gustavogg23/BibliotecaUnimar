namespace BibliotecaUnimar
{
    partial class frmEstudiantesBaneados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantesBaneados));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaneados = new System.Windows.Forms.Button();
            this.btnVolverBaneados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 52);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(526, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiantes Sancionados";
            // 
            // btnBaneados
            // 
            this.btnBaneados.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBaneados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaneados.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnBaneados.ForeColor = System.Drawing.Color.White;
            this.btnBaneados.Location = new System.Drawing.Point(202, 396);
            this.btnBaneados.Name = "btnBaneados";
            this.btnBaneados.Size = new System.Drawing.Size(215, 66);
            this.btnBaneados.TabIndex = 1;
            this.btnBaneados.Text = "MOSTRAR SANCIONADOS";
            this.btnBaneados.UseVisualStyleBackColor = false;
            this.btnBaneados.Click += new System.EventHandler(this.btnBaneados_Click);
            // 
            // btnVolverBaneados
            // 
            this.btnVolverBaneados.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVolverBaneados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverBaneados.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnVolverBaneados.ForeColor = System.Drawing.Color.White;
            this.btnVolverBaneados.Location = new System.Drawing.Point(478, 396);
            this.btnVolverBaneados.Name = "btnVolverBaneados";
            this.btnVolverBaneados.Size = new System.Drawing.Size(171, 66);
            this.btnVolverBaneados.TabIndex = 2;
            this.btnVolverBaneados.Text = "VOLVER AL MENÚ";
            this.btnVolverBaneados.UseVisualStyleBackColor = false;
            this.btnVolverBaneados.Click += new System.EventHandler(this.btnVolverBaneados_Click);
            // 
            // frmEstudiantesBaneados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(883, 548);
            this.Controls.Add(this.btnVolverBaneados);
            this.Controls.Add(this.btnBaneados);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstudiantesBaneados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes Sancionados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaneados;
        private System.Windows.Forms.Button btnVolverBaneados;
    }
}