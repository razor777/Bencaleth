namespace PantallaInicio
{
    partial class TipoEmpleEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoEmpleEmpresa));
            this.cmbModulos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbValor = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnEmpleado = new System.Windows.Forms.RadioButton();
            this.rdbtnEmpresa = new System.Windows.Forms.RadioButton();
            this.txtbSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.txtbABuscar = new System.Windows.Forms.TextBox();
            this.rdbtnDes = new System.Windows.Forms.RadioButton();
            this.rdbtnID = new System.Windows.Forms.RadioButton();
            this.lblBucar = new System.Windows.Forms.Label();
            this.dtgdvwDatos = new System.Windows.Forms.DataGridView();
            this.grpbVisualizar = new System.Windows.Forms.GroupBox();
            this.grpbEditar = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwDatos)).BeginInit();
            this.grpbVisualizar.SuspendLayout();
            this.grpbEditar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbModulos
            // 
            this.cmbModulos.BackColor = System.Drawing.SystemColors.Window;
            this.cmbModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModulos.FormattingEnabled = true;
            this.cmbModulos.Items.AddRange(new object[] {
            "Tipo de Empresa",
            "Cargo de Empleado"});
            this.cmbModulos.Location = new System.Drawing.Point(531, 48);
            this.cmbModulos.Name = "cmbModulos";
            this.cmbModulos.Size = new System.Drawing.Size(164, 28);
            this.cmbModulos.TabIndex = 1;
            this.cmbModulos.SelectedIndexChanged += new System.EventHandler(this.cmbModulos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(525, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 31);
            this.label7.TabIndex = 92;
            this.label7.Text = "Módulos:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.Location = new System.Drawing.Point(531, 102);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(164, 64);
            this.btnEditar.TabIndex = 93;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBorrar.Location = new System.Drawing.Point(531, 206);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(164, 64);
            this.btnBorrar.TabIndex = 94;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(139, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 95;
            this.label1.Text = "Valor a Tratar";
            // 
            // txtbValor
            // 
            this.txtbValor.BackColor = System.Drawing.Color.White;
            this.txtbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbValor.Location = new System.Drawing.Point(401, 136);
            this.txtbValor.MaxLength = 50;
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(211, 26);
            this.txtbValor.TabIndex = 96;
            this.txtbValor.TextChanged += new System.EventHandler(this.txtbValor_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(531, 132);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(164, 64);
            this.btnGuardar.TabIndex = 97;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(139, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 31);
            this.label2.TabIndex = 100;
            this.label2.Text = "Clase de Valor a Tratar:";
            // 
            // rdbtnEmpleado
            // 
            this.rdbtnEmpleado.AutoSize = true;
            this.rdbtnEmpleado.Checked = true;
            this.rdbtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbtnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEmpleado.ForeColor = System.Drawing.Color.White;
            this.rdbtnEmpleado.Location = new System.Drawing.Point(372, 54);
            this.rdbtnEmpleado.Name = "rdbtnEmpleado";
            this.rdbtnEmpleado.Size = new System.Drawing.Size(247, 33);
            this.rdbtnEmpleado.TabIndex = 102;
            this.rdbtnEmpleado.TabStop = true;
            this.rdbtnEmpleado.Tag = "f";
            this.rdbtnEmpleado.Text = "Cargo de Empleado";
            this.rdbtnEmpleado.UseVisualStyleBackColor = true;
            this.rdbtnEmpleado.CheckedChanged += new System.EventHandler(this.rdbtnEmpleado_CheckedChanged);
            // 
            // rdbtnEmpresa
            // 
            this.rdbtnEmpresa.AutoSize = true;
            this.rdbtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbtnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEmpresa.ForeColor = System.Drawing.Color.White;
            this.rdbtnEmpresa.Location = new System.Drawing.Point(145, 54);
            this.rdbtnEmpresa.Name = "rdbtnEmpresa";
            this.rdbtnEmpresa.Size = new System.Drawing.Size(217, 33);
            this.rdbtnEmpresa.TabIndex = 101;
            this.rdbtnEmpresa.Tag = "m";
            this.rdbtnEmpresa.Text = "Tipo de Empresa";
            this.rdbtnEmpresa.UseVisualStyleBackColor = true;
            this.rdbtnEmpresa.CheckedChanged += new System.EventHandler(this.rdbtnEmpresa_CheckedChanged);
            // 
            // txtbSalario
            // 
            this.txtbSalario.BackColor = System.Drawing.Color.White;
            this.txtbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSalario.Location = new System.Drawing.Point(401, 178);
            this.txtbSalario.MaxLength = 10;
            this.txtbSalario.Name = "txtbSalario";
            this.txtbSalario.Size = new System.Drawing.Size(211, 26);
            this.txtbSalario.TabIndex = 104;
            this.txtbSalario.TextChanged += new System.EventHandler(this.txtbSalario_TextChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSalario.Location = new System.Drawing.Point(139, 171);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(98, 31);
            this.lblSalario.TabIndex = 103;
            this.lblSalario.Text = "Salario";
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.BackColor = System.Drawing.Color.White;
            this.txtbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCodigo.Location = new System.Drawing.Point(401, 93);
            this.txtbCodigo.MaxLength = 15;
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(211, 26);
            this.txtbCodigo.TabIndex = 110;
            this.txtbCodigo.TextChanged += new System.EventHandler(this.txtbCodigo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(139, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 31);
            this.label5.TabIndex = 109;
            this.label5.Text = "Código Identificador";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(944, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 764);
            this.panel1.TabIndex = 115;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PantallaInicio.Properties.Resources.Logo_Bencaleth_2;
            this.pictureBox1.Location = new System.Drawing.Point(22, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PantallaInicio.Properties.Resources.Menú_Principal;
            this.pictureBox4.Location = new System.Drawing.Point(48, 264);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Location = new System.Drawing.Point(157, 264);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(209, 80);
            this.btn_menu.TabIndex = 17;
            this.btn_menu.Text = "Menú";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // txtbABuscar
            // 
            this.txtbABuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbABuscar.Location = new System.Drawing.Point(20, 48);
            this.txtbABuscar.MaxLength = 50;
            this.txtbABuscar.Name = "txtbABuscar";
            this.txtbABuscar.Size = new System.Drawing.Size(468, 26);
            this.txtbABuscar.TabIndex = 108;
            this.txtbABuscar.TextChanged += new System.EventHandler(this.txtbABuscar_TextChanged);
            // 
            // rdbtnDes
            // 
            this.rdbtnDes.AutoSize = true;
            this.rdbtnDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbtnDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnDes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbtnDes.Location = new System.Drawing.Point(304, 15);
            this.rdbtnDes.Name = "rdbtnDes";
            this.rdbtnDes.Size = new System.Drawing.Size(143, 30);
            this.rdbtnDes.TabIndex = 107;
            this.rdbtnDes.Tag = "nombre";
            this.rdbtnDes.Text = "Descripción";
            this.rdbtnDes.UseVisualStyleBackColor = true;
            this.rdbtnDes.CheckedChanged += new System.EventHandler(this.rdbtnDes_CheckedChanged);
            // 
            // rdbtnID
            // 
            this.rdbtnID.AutoSize = true;
            this.rdbtnID.Checked = true;
            this.rdbtnID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbtnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbtnID.Location = new System.Drawing.Point(206, 15);
            this.rdbtnID.Name = "rdbtnID";
            this.rdbtnID.Size = new System.Drawing.Size(98, 30);
            this.rdbtnID.TabIndex = 106;
            this.rdbtnID.TabStop = true;
            this.rdbtnID.Tag = "id";
            this.rdbtnID.Text = "Código";
            this.rdbtnID.UseVisualStyleBackColor = true;
            this.rdbtnID.CheckedChanged += new System.EventHandler(this.rdbtnID_CheckedChanged);
            // 
            // lblBucar
            // 
            this.lblBucar.AutoSize = true;
            this.lblBucar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBucar.Location = new System.Drawing.Point(15, 15);
            this.lblBucar.Name = "lblBucar";
            this.lblBucar.Size = new System.Drawing.Size(137, 29);
            this.lblBucar.TabIndex = 105;
            this.lblBucar.Text = "Buscar Por:";
            // 
            // dtgdvwDatos
            // 
            this.dtgdvwDatos.AllowUserToAddRows = false;
            this.dtgdvwDatos.AllowUserToDeleteRows = false;
            this.dtgdvwDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgdvwDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgdvwDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgdvwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgdvwDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgdvwDatos.Location = new System.Drawing.Point(20, 91);
            this.dtgdvwDatos.Name = "dtgdvwDatos";
            this.dtgdvwDatos.ReadOnly = true;
            this.dtgdvwDatos.Size = new System.Drawing.Size(468, 238);
            this.dtgdvwDatos.TabIndex = 115;
            this.dtgdvwDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdvwDatos_CellClick_1);
            // 
            // grpbVisualizar
            // 
            this.grpbVisualizar.Controls.Add(this.dtgdvwDatos);
            this.grpbVisualizar.Controls.Add(this.lblBucar);
            this.grpbVisualizar.Controls.Add(this.rdbtnID);
            this.grpbVisualizar.Controls.Add(this.rdbtnDes);
            this.grpbVisualizar.Controls.Add(this.txtbABuscar);
            this.grpbVisualizar.Controls.Add(this.cmbModulos);
            this.grpbVisualizar.Controls.Add(this.label7);
            this.grpbVisualizar.Controls.Add(this.btnEditar);
            this.grpbVisualizar.Controls.Add(this.btnBorrar);
            this.grpbVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbVisualizar.Location = new System.Drawing.Point(108, 232);
            this.grpbVisualizar.Name = "grpbVisualizar";
            this.grpbVisualizar.Size = new System.Drawing.Size(704, 356);
            this.grpbVisualizar.TabIndex = 114;
            this.grpbVisualizar.TabStop = false;
            // 
            // grpbEditar
            // 
            this.grpbEditar.Controls.Add(this.btnGuardar);
            this.grpbEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbEditar.Location = new System.Drawing.Point(108, 11);
            this.grpbEditar.Name = "grpbEditar";
            this.grpbEditar.Size = new System.Drawing.Size(704, 210);
            this.grpbEditar.TabIndex = 113;
            this.grpbEditar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpbEditar);
            this.panel2.Controls.Add(this.grpbVisualizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 764);
            this.panel2.TabIndex = 116;
            // 
            // TipoEmpleEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1352, 764);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.rdbtnEmpleado);
            this.Controls.Add(this.rdbtnEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "TipoEmpleEmpresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TipoEmpleEmpresa_FormClosed);
            this.Load += new System.EventHandler(this.TipoEmpleEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwDatos)).EndInit();
            this.grpbVisualizar.ResumeLayout(false);
            this.grpbVisualizar.PerformLayout();
            this.grpbEditar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModulos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbValor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbtnEmpleado;
        private System.Windows.Forms.RadioButton rdbtnEmpresa;
        private System.Windows.Forms.TextBox txtbSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpbEditar;
        private System.Windows.Forms.GroupBox grpbVisualizar;
        private System.Windows.Forms.DataGridView dtgdvwDatos;
        private System.Windows.Forms.Label lblBucar;
        private System.Windows.Forms.RadioButton rdbtnID;
        private System.Windows.Forms.RadioButton rdbtnDes;
        private System.Windows.Forms.TextBox txtbABuscar;
        private System.Windows.Forms.Panel panel2;
    }
}