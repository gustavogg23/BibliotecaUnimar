namespace BibliotecaUnimar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevoluciones));
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
            this.label1.Location = new System.Drawing.Point(339, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devoluciones";
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(166, 383);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(201, 104);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "DEVOLVER";
            this.btnDevolver.UseVisualStyleBackColor = false;
            // 
            // btnVOLVer
            // 
            this.btnVOLVer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVOLVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVOLVer.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnVOLVer.ForeColor = System.Drawing.Color.White;
            this.btnVOLVer.Location = new System.Drawing.Point(529, 383);
            this.btnVOLVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVOLVer.Name = "btnVOLVer";
            this.btnVOLVer.Size = new System.Drawing.Size(252, 104);
            this.btnVOLVer.TabIndex = 2;
            this.btnVOLVer.Text = "VOLVER AL MENÚ";
            this.btnVOLVer.UseVisualStyleBackColor = false;
            this.btnVOLVer.Click += new System.EventHandler(this.btnVOLVer_Click);
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(880, 549);
            this.Controls.Add(this.btnVOLVer);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución de Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnVOLVer;
    }
}