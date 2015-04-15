namespace PantallaInicio
{
    partial class IngresoAlcancia
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbDes = new System.Windows.Forms.TextBox();
            this.txtbDir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save_Alcancias = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bencalethDataSet = new PantallaInicio.BencalethDataSet();
            this.mostrarRecurenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarRecurenciasTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.MostrarRecurenciasTableAdapter();
            this.tableAdapterManager = new PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager();
            this.mostrarRecurenciasComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarRecurenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 100;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbDes
            // 
            this.txtbDes.Location = new System.Drawing.Point(480, 330);
            this.txtbDes.Name = "txtbDes";
            this.txtbDes.Size = new System.Drawing.Size(200, 20);
            this.txtbDes.TabIndex = 95;
            this.txtbDes.TextChanged += new System.EventHandler(this.txtbDes_TextChanged);
            // 
            // txtbDir
            // 
            this.txtbDir.Location = new System.Drawing.Point(480, 278);
            this.txtbDir.Name = "txtbDir";
            this.txtbDir.Size = new System.Drawing.Size(200, 20);
            this.txtbDir.TabIndex = 94;
            this.txtbDir.TextChanged += new System.EventHandler(this.txtbDir_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(430, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 24);
            this.label9.TabIndex = 93;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(367, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 92;
            this.label8.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(402, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 91;
            this.label7.Text = "Local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(483, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 86;
            this.label1.Text = "Alcancias";
            // 
            // btn_save_Alcancias
            // 
            this.btn_save_Alcancias.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_save_Alcancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_Alcancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_Alcancias.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_save_Alcancias.Location = new System.Drawing.Point(683, 506);
            this.btn_save_Alcancias.Name = "btn_save_Alcancias";
            this.btn_save_Alcancias.Size = new System.Drawing.Size(88, 35);
            this.btn_save_Alcancias.TabIndex = 114;
            this.btn_save_Alcancias.Text = "Guardar";
            this.btn_save_Alcancias.UseVisualStyleBackColor = false;
            this.btn_save_Alcancias.Click += new System.EventHandler(this.btn_save_Alcancias_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(317, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 115;
            this.label2.Text = "Fecha de Inicio";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(480, 381);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(344, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 117;
            this.label3.Text = "Recurrencia";
            // 
            // bencalethDataSet
            // 
            this.bencalethDataSet.DataSetName = "BencalethDataSet";
            this.bencalethDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarRecurenciasBindingSource
            // 
            this.mostrarRecurenciasBindingSource.DataMember = "MostrarRecurencias";
            this.mostrarRecurenciasBindingSource.DataSource = this.bencalethDataSet;
            // 
            // mostrarRecurenciasTableAdapter
            // 
            this.mostrarRecurenciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PantallaInicio.BencalethDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mostrarRecurenciasComboBox
            // 
            this.mostrarRecurenciasComboBox.DataSource = this.mostrarRecurenciasBindingSource;
            this.mostrarRecurenciasComboBox.DisplayMember = "Nombre";
            this.mostrarRecurenciasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mostrarRecurenciasComboBox.FormattingEnabled = true;
            this.mostrarRecurenciasComboBox.Location = new System.Drawing.Point(480, 430);
            this.mostrarRecurenciasComboBox.Name = "mostrarRecurenciasComboBox";
            this.mostrarRecurenciasComboBox.Size = new System.Drawing.Size(200, 21);
            this.mostrarRecurenciasComboBox.TabIndex = 118;
            this.mostrarRecurenciasComboBox.ValueMember = "Id";
            this.mostrarRecurenciasComboBox.SelectedIndexChanged += new System.EventHandler(this.mostrarRecurenciasComboBox_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // IngresoAlcancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1008, 752);
            this.ControlBox = false;
            this.Controls.Add(this.mostrarRecurenciasComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save_Alcancias);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbDes);
            this.Controls.Add(this.txtbDir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "IngresoAlcancia";
            this.Load += new System.EventHandler(this.IngresoAlcancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bencalethDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarRecurenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbDes;
        private System.Windows.Forms.TextBox txtbDir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save_Alcancias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private BencalethDataSet bencalethDataSet;
        private System.Windows.Forms.BindingSource mostrarRecurenciasBindingSource;
        private BencalethDataSetTableAdapters.MostrarRecurenciasTableAdapter mostrarRecurenciasTableAdapter;
        private BencalethDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox mostrarRecurenciasComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}