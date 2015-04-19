namespace PantallaInicio
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pasw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Ing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BENCALETH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese sus Datos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(513, 342);
            this.txt_user.MaxLength = 30;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(141, 20);
            this.txt_user.TabIndex = 4;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // txt_pasw
            // 
            this.txt_pasw.Location = new System.Drawing.Point(511, 422);
            this.txt_pasw.MaxLength = 30;
            this.txt_pasw.Name = "txt_pasw";
            this.txt_pasw.PasswordChar = '*';
            this.txt_pasw.Size = new System.Drawing.Size(143, 20);
            this.txt_pasw.TabIndex = 5;
            this.txt_pasw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(739, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Ing
            // 
            this.btn_Ing.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Ing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Ing.Location = new System.Drawing.Point(374, 569);
            this.btn_Ing.Name = "btn_Ing";
            this.btn_Ing.Size = new System.Drawing.Size(150, 45);
            this.btn_Ing.TabIndex = 8;
            this.btn_Ing.Text = "Ingresar";
            this.btn_Ing.UseVisualStyleBackColor = false;
            this.btn_Ing.Click += new System.EventHandler(this.btn_Ing_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.Controls.Add(this.btn_Ing);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_pasw);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pasw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Ing;
    }
}

