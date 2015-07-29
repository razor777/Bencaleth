namespace PantallaInicio
{
    partial class Reportes
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
            this.btn_regresar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_niños = new System.Windows.Forms.RadioButton();
            this.rb_padrinos = new System.Windows.Forms.RadioButton();
            this.rb_voluntarios = new System.Windows.Forms.RadioButton();
            this.rb_empleados = new System.Windows.Forms.RadioButton();
            this.rb_montoVolun = new System.Windows.Forms.RadioButton();
            this.rb_MontoPadrino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.White;
            this.btn_regresar.Location = new System.Drawing.Point(157, 461);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(209, 80);
            this.btn_regresar.TabIndex = 6;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PantallaInicio.Properties.Resources.Regresar;
            this.pictureBox2.Location = new System.Drawing.Point(48, 461);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(947, 764);
            this.reportViewer1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PantallaInicio.Properties.Resources.Logo_Bencaleth_2;
            this.pictureBox1.Location = new System.Drawing.Point(39, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rb_voluntarios);
            this.panel1.Controls.Add(this.rb_empleados);
            this.panel1.Controls.Add(this.rb_montoVolun);
            this.panel1.Controls.Add(this.rb_MontoPadrino);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_regresar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.rb_niños);
            this.panel1.Controls.Add(this.rb_padrinos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(944, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 764);
            this.panel1.TabIndex = 23;
            // 
            // rb_niños
            // 
            this.rb_niños.AutoSize = true;
            this.rb_niños.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_niños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_niños.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_niños.Location = new System.Drawing.Point(39, 308);
            this.rb_niños.Name = "rb_niños";
            this.rb_niños.Size = new System.Drawing.Size(69, 20);
            this.rb_niños.TabIndex = 24;
            this.rb_niños.TabStop = true;
            this.rb_niños.Text = " Niños";
            this.rb_niños.UseVisualStyleBackColor = true;
            // 
            // rb_padrinos
            // 
            this.rb_padrinos.AutoSize = true;
            this.rb_padrinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_padrinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_padrinos.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_padrinos.Location = new System.Drawing.Point(39, 347);
            this.rb_padrinos.Name = "rb_padrinos";
            this.rb_padrinos.Size = new System.Drawing.Size(91, 20);
            this.rb_padrinos.TabIndex = 25;
            this.rb_padrinos.TabStop = true;
            this.rb_padrinos.Text = " Padrinos";
            this.rb_padrinos.UseVisualStyleBackColor = true;
            // 
            // rb_voluntarios
            // 
            this.rb_voluntarios.AutoSize = true;
            this.rb_voluntarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_voluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_voluntarios.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_voluntarios.Location = new System.Drawing.Point(39, 385);
            this.rb_voluntarios.Name = "rb_voluntarios";
            this.rb_voluntarios.Size = new System.Drawing.Size(107, 20);
            this.rb_voluntarios.TabIndex = 26;
            this.rb_voluntarios.TabStop = true;
            this.rb_voluntarios.Text = " Voluntarios";
            this.rb_voluntarios.UseVisualStyleBackColor = true;
            // 
            // rb_empleados
            // 
            this.rb_empleados.AutoSize = true;
            this.rb_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_empleados.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_empleados.Location = new System.Drawing.Point(181, 308);
            this.rb_empleados.Name = "rb_empleados";
            this.rb_empleados.Size = new System.Drawing.Size(108, 20);
            this.rb_empleados.TabIndex = 27;
            this.rb_empleados.TabStop = true;
            this.rb_empleados.Text = " Empleados";
            this.rb_empleados.UseVisualStyleBackColor = true;
            // 
            // rb_montoVolun
            // 
            this.rb_montoVolun.AutoSize = true;
            this.rb_montoVolun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_montoVolun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_montoVolun.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_montoVolun.Location = new System.Drawing.Point(181, 347);
            this.rb_montoVolun.Name = "rb_montoVolun";
            this.rb_montoVolun.Size = new System.Drawing.Size(196, 20);
            this.rb_montoVolun.TabIndex = 28;
            this.rb_montoVolun.TabStop = true;
            this.rb_montoVolun.Text = "Mensualidad Voluntarios";
            this.rb_montoVolun.UseVisualStyleBackColor = true;
            // 
            // rb_MontoPadrino
            // 
            this.rb_MontoPadrino.AutoSize = true;
            this.rb_MontoPadrino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_MontoPadrino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_MontoPadrino.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_MontoPadrino.Location = new System.Drawing.Point(181, 385);
            this.rb_MontoPadrino.Name = "rb_MontoPadrino";
            this.rb_MontoPadrino.Size = new System.Drawing.Size(179, 20);
            this.rb_MontoPadrino.TabIndex = 29;
            this.rb_MontoPadrino.TabStop = true;
            this.rb_MontoPadrino.Text = "Mensualidad padrinos";
            this.rb_MontoPadrino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(76, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Seleccione el informe ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(93, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = " que desea generar";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1352, 764);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_voluntarios;
        private System.Windows.Forms.RadioButton rb_empleados;
        private System.Windows.Forms.RadioButton rb_montoVolun;
        private System.Windows.Forms.RadioButton rb_MontoPadrino;
        private System.Windows.Forms.RadioButton rb_niños;
        private System.Windows.Forms.RadioButton rb_padrinos;
        private System.Windows.Forms.Label label2;
    }
}