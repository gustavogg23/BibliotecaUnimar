namespace BibliotecaUnimar
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegistroAlum = new System.Windows.Forms.Button();
            this.btnRegistroPrest = new System.Windows.Forms.Button();
            this.btnPrestamosAct = new System.Windows.Forms.Button();
            this.btnLibrosDisp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(840, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIBLIOTECA UNIMAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRegistroAlum);
            this.flowLayoutPanel1.Controls.Add(this.btnRegistroPrest);
            this.flowLayoutPanel1.Controls.Add(this.btnPrestamosAct);
            this.flowLayoutPanel1.Controls.Add(this.btnLibrosDisp);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(237, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 269);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnRegistroAlum
            // 
            this.btnRegistroAlum.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegistroAlum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroAlum.FlatAppearance.BorderSize = 3;
            this.btnRegistroAlum.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.btnRegistroAlum.ForeColor = System.Drawing.Color.White;
            this.btnRegistroAlum.Location = new System.Drawing.Point(3, 3);
            this.btnRegistroAlum.Name = "btnRegistroAlum";
            this.btnRegistroAlum.Size = new System.Drawing.Size(170, 61);
            this.btnRegistroAlum.TabIndex = 0;
            this.btnRegistroAlum.Text = "Registrar Alumno";
            this.btnRegistroAlum.UseVisualStyleBackColor = false;
            this.btnRegistroAlum.Click += new System.EventHandler(this.btnRegistroAlum_Click);
            // 
            // btnRegistroPrest
            // 
            this.btnRegistroPrest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegistroPrest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroPrest.FlatAppearance.BorderSize = 3;
            this.btnRegistroPrest.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.btnRegistroPrest.ForeColor = System.Drawing.Color.White;
            this.btnRegistroPrest.Location = new System.Drawing.Point(179, 3);
            this.btnRegistroPrest.Name = "btnRegistroPrest";
            this.btnRegistroPrest.Size = new System.Drawing.Size(170, 61);
            this.btnRegistroPrest.TabIndex = 1;
            this.btnRegistroPrest.Text = "Registro de Préstamos";
            this.btnRegistroPrest.UseVisualStyleBackColor = false;
            this.btnRegistroPrest.Click += new System.EventHandler(this.btnRegistroPrest_Click);
            // 
            // btnPrestamosAct
            // 
            this.btnPrestamosAct.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrestamosAct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamosAct.FlatAppearance.BorderSize = 3;
            this.btnPrestamosAct.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.btnPrestamosAct.ForeColor = System.Drawing.Color.White;
            this.btnPrestamosAct.Location = new System.Drawing.Point(3, 70);
            this.btnPrestamosAct.Name = "btnPrestamosAct";
            this.btnPrestamosAct.Size = new System.Drawing.Size(170, 61);
            this.btnPrestamosAct.TabIndex = 2;
            this.btnPrestamosAct.Text = "Préstamos Activos";
            this.btnPrestamosAct.UseVisualStyleBackColor = false;
            // 
            // btnLibrosDisp
            // 
            this.btnLibrosDisp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLibrosDisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibrosDisp.FlatAppearance.BorderSize = 3;
            this.btnLibrosDisp.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.btnLibrosDisp.ForeColor = System.Drawing.Color.White;
            this.btnLibrosDisp.Location = new System.Drawing.Point(179, 70);
            this.btnLibrosDisp.Name = "btnLibrosDisp";
            this.btnLibrosDisp.Size = new System.Drawing.Size(170, 61);
            this.btnLibrosDisp.TabIndex = 3;
            this.btnLibrosDisp.Text = "Libros Disponibles";
            this.btnLibrosDisp.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Estudiantes Sancionados";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(179, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 61);
            this.button2.TabIndex = 5;
            this.button2.Text = "Renovación";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 61);
            this.button3.TabIndex = 6;
            this.button3.Text = "Devolución";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(179, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 61);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ingresar Libro Nuevo";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(840, 544);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRegistroAlum;
        private System.Windows.Forms.Button btnRegistroPrest;
        private System.Windows.Forms.Button btnPrestamosAct;
        private System.Windows.Forms.Button btnLibrosDisp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}