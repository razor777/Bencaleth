namespace PantallaInicio
{
    partial class Vista_Inventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Inventarios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cbb_Mantenimiento = new System.Windows.Forms.ComboBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(895, 545);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cbb_Mantenimiento
            // 
            this.Cbb_Mantenimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_Mantenimiento.FormattingEnabled = true;
            this.Cbb_Mantenimiento.Items.AddRange(new object[] {
            "Donaciones",
            "Terapia Física"});
            this.Cbb_Mantenimiento.Location = new System.Drawing.Point(110, 23);
            this.Cbb_Mantenimiento.Name = "Cbb_Mantenimiento";
            this.Cbb_Mantenimiento.Size = new System.Drawing.Size(157, 21);
            this.Cbb_Mantenimiento.TabIndex = 2;
            this.Cbb_Mantenimiento.SelectedIndexChanged += new System.EventHandler(this.Cbb_Mantenimiento_SelectedIndexChanged);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Menu.Location = new System.Drawing.Point(1054, 200);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(150, 45);
            this.btn_Menu.TabIndex = 17;
            this.btn_Menu.Text = "Menú";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCyan;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_back.Location = new System.Drawing.Point(1054, 116);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 45);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Regresar";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Vista_Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cbb_Mantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista_Inventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de Inventarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vista_Inventarios_FormClosed);
            this.Load += new System.EventHandler(this.Vista_Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Cbb_Mantenimiento;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_back;
    }
}