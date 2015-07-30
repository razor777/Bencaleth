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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.reportePadrinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BencalethDataSet = new PantallaInicio.BencalethDataSet();
            this.reporteNinioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Select_Voluntarios1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportePagoVolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportePagoPadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteInventarioDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteInventarioTerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_invdon = new System.Windows.Forms.RadioButton();
            this.rb_inveter = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_voluntarios = new System.Windows.Forms.RadioButton();
            this.rb_empleados = new System.Windows.Forms.RadioButton();
            this.rb_montoVolun = new System.Windows.Forms.RadioButton();
            this.rb_MontoPadrino = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rb_niños = new System.Windows.Forms.RadioButton();
            this.rb_padrinos = new System.Windows.Forms.RadioButton();
            this.reportePadrinosTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.reportePadrinosTableAdapter();
            this.reporteNinioTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.reporteNinioTableAdapter();
            this.Select_Voluntarios1TableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.Select_Voluntarios1TableAdapter();
            this.reporteEmpleadoTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.reporteEmpleadoTableAdapter();
            this.reportePagoVolTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.reportePagoVolTableAdapter();
            this.reportePagoPadTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.reportePagoPadTableAdapter();
            this.rp_padrinos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rp_ninios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rp_voluntarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rp_empleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rp_monvol = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rp_monpad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rp_invendon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteInventarioDonTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.reporteInventarioDonTableAdapter();
            this.rp_inventer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteInventarioTerTableAdapter = new PantallaInicio.BencalethDataSetTableAdapters.reporteInventarioTerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportePadrinosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BencalethDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteNinioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_Voluntarios1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePagoVolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePagoPadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteInventarioDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteInventarioTerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportePadrinosBindingSource
            // 
            this.reportePadrinosBindingSource.DataMember = "reportePadrinos";
            this.reportePadrinosBindingSource.DataSource = this.BencalethDataSet;
            // 
            // BencalethDataSet
            // 
            this.BencalethDataSet.DataSetName = "BencalethDataSet";
            this.BencalethDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteNinioBindingSource
            // 
            this.reporteNinioBindingSource.DataMember = "reporteNinio";
            this.reporteNinioBindingSource.DataSource = this.BencalethDataSet;
            // 
            // Select_Voluntarios1BindingSource
            // 
            this.Select_Voluntarios1BindingSource.DataMember = "Select_Voluntarios1";
            this.Select_Voluntarios1BindingSource.DataSource = this.BencalethDataSet;
            // 
            // reporteEmpleadoBindingSource
            // 
            this.reporteEmpleadoBindingSource.DataMember = "reporteEmpleado";
            this.reporteEmpleadoBindingSource.DataSource = this.BencalethDataSet;
            // 
            // reportePagoVolBindingSource
            // 
            this.reportePagoVolBindingSource.DataMember = "reportePagoVol";
            this.reportePagoVolBindingSource.DataSource = this.BencalethDataSet;
            // 
            // reportePagoPadBindingSource
            // 
            this.reportePagoPadBindingSource.DataMember = "reportePagoPad";
            this.reportePagoPadBindingSource.DataSource = this.BencalethDataSet;
            // 
            // reporteInventarioDonBindingSource
            // 
            this.reporteInventarioDonBindingSource.DataMember = "reporteInventarioDon";
            this.reporteInventarioDonBindingSource.DataSource = this.BencalethDataSet;
            // 
            // reporteInventarioTerBindingSource
            // 
            this.reporteInventarioTerBindingSource.DataMember = "reporteInventarioTer";
            this.reporteInventarioTerBindingSource.DataSource = this.BencalethDataSet;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.White;
            this.btn_regresar.Location = new System.Drawing.Point(157, 526);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(209, 80);
            this.btn_regresar.TabIndex = 6;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rb_invdon);
            this.panel1.Controls.Add(this.rb_inveter);
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
            // rb_invdon
            // 
            this.rb_invdon.AutoSize = true;
            this.rb_invdon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_invdon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_invdon.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_invdon.Location = new System.Drawing.Point(39, 420);
            this.rb_invdon.Name = "rb_invdon";
            this.rb_invdon.Size = new System.Drawing.Size(97, 20);
            this.rb_invdon.TabIndex = 32;
            this.rb_invdon.TabStop = true;
            this.rb_invdon.Text = "Inventario ";
            this.rb_invdon.UseVisualStyleBackColor = true;
            this.rb_invdon.CheckedChanged += new System.EventHandler(this.rb_invdon_CheckedChanged);
            // 
            // rb_inveter
            // 
            this.rb_inveter.AutoSize = true;
            this.rb_inveter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_inveter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inveter.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_inveter.Location = new System.Drawing.Point(181, 420);
            this.rb_inveter.Name = "rb_inveter";
            this.rb_inveter.Size = new System.Drawing.Size(152, 20);
            this.rb_inveter.TabIndex = 33;
            this.rb_inveter.TabStop = true;
            this.rb_inveter.Text = "Inventario Terapia";
            this.rb_inveter.UseVisualStyleBackColor = true;
            this.rb_inveter.CheckedChanged += new System.EventHandler(this.rb_inveter_CheckedChanged);
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
            this.rb_voluntarios.CheckedChanged += new System.EventHandler(this.rb_voluntarios_CheckedChanged);
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
            this.rb_empleados.CheckedChanged += new System.EventHandler(this.rb_empleados_CheckedChanged_1);
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
            this.rb_montoVolun.CheckedChanged += new System.EventHandler(this.rb_montoVolun_CheckedChanged_1);
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
            this.rb_MontoPadrino.CheckedChanged += new System.EventHandler(this.rb_MontoPadrino_CheckedChanged_1);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PantallaInicio.Properties.Resources.Regresar;
            this.pictureBox2.Location = new System.Drawing.Point(48, 526);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
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
            this.rb_niños.CheckedChanged += new System.EventHandler(this.rb_niños_CheckedChanged);
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
            this.rb_padrinos.CheckedChanged += new System.EventHandler(this.rb_padrinos_CheckedChanged);
            // 
            // reportePadrinosTableAdapter
            // 
            this.reportePadrinosTableAdapter.ClearBeforeFill = true;
            // 
            // reporteNinioTableAdapter
            // 
            this.reporteNinioTableAdapter.ClearBeforeFill = true;
            // 
            // Select_Voluntarios1TableAdapter
            // 
            this.Select_Voluntarios1TableAdapter.ClearBeforeFill = true;
            // 
            // reporteEmpleadoTableAdapter
            // 
            this.reporteEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // reportePagoVolTableAdapter
            // 
            this.reportePagoVolTableAdapter.ClearBeforeFill = true;
            // 
            // reportePagoPadTableAdapter
            // 
            this.reportePagoPadTableAdapter.ClearBeforeFill = true;
            // 
            // rp_padrinos
            // 
            this.rp_padrinos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rp_padrinos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportePadrinosBindingSource;
            this.rp_padrinos.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_padrinos.LocalReport.ReportEmbeddedResource = "PantallaInicio.Report1.rdlc";
            this.rp_padrinos.Location = new System.Drawing.Point(0, 0);
            this.rp_padrinos.Name = "rp_padrinos";
            this.rp_padrinos.Size = new System.Drawing.Size(944, 764);
            this.rp_padrinos.TabIndex = 24;
            this.rp_padrinos.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // rp_ninios
            // 
            this.rp_ninios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rp_ninios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_ninios.DocumentMapWidth = 1;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.reporteNinioBindingSource;
            this.rp_ninios.LocalReport.DataSources.Add(reportDataSource2);
            this.rp_ninios.LocalReport.ReportEmbeddedResource = "PantallaInicio.Report2.rdlc";
            this.rp_ninios.Location = new System.Drawing.Point(0, 0);
            this.rp_ninios.Name = "rp_ninios";
            this.rp_ninios.Size = new System.Drawing.Size(944, 764);
            this.rp_ninios.TabIndex = 25;
            this.rp_ninios.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // rp_voluntarios
            // 
            this.rp_voluntarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rp_voluntarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_voluntarios.DocumentMapWidth = 3;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Select_Voluntarios1BindingSource;
            this.rp_voluntarios.LocalReport.DataSources.Add(reportDataSource3);
            this.rp_voluntarios.LocalReport.ReportEmbeddedResource = "PantallaInicio.Report3.rdlc";
            this.rp_voluntarios.Location = new System.Drawing.Point(0, 0);
            this.rp_voluntarios.Name = "rp_voluntarios";
            this.rp_voluntarios.Size = new System.Drawing.Size(944, 764);
            this.rp_voluntarios.TabIndex = 26;
            this.rp_voluntarios.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rp_voluntarios.Load += new System.EventHandler(this.rp_voluntarios_Load);
            // 
            // rp_empleados
            // 
            this.rp_empleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rp_empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_empleados.DocumentMapWidth = 1;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.reporteEmpleadoBindingSource;
            this.rp_empleados.LocalReport.DataSources.Add(reportDataSource4);
            this.rp_empleados.LocalReport.ReportEmbeddedResource = "PantallaInicio.Report4.rdlc";
            this.rp_empleados.Location = new System.Drawing.Point(0, 0);
            this.rp_empleados.Name = "rp_empleados";
            this.rp_empleados.Size = new System.Drawing.Size(944, 764);
            this.rp_empleados.TabIndex = 27;
            this.rp_empleados.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // rp_monvol
            // 
            this.rp_monvol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rp_monvol.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.reportePagoVolBindingSource;
            this.rp_monvol.LocalReport.DataSources.Add(reportDataSource5);
            this.rp_monvol.LocalReport.ReportEmbeddedResource = "PantallaInicio.Report5.rdlc";
            this.rp_monvol.Location = new System.Drawing.Point(0, 0);
            this.rp_monvol.Name = "rp_monvol";
            this.rp_monvol.Size = new System.Drawing.Size(944, 764);
            this.rp_monvol.TabIndex = 28;
            this.rp_monvol.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // rp_monpad
            // 
            this.rp_monpad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rp_monpad.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.reportePagoPadBindingSource;
            this.rp_monpad.LocalReport.DataSources.Add(reportDataSource6);
            this.rp_monpad.LocalReport.ReportEmbeddedResource = "PantallaInicio.Report6.rdlc";
            this.rp_monpad.Location = new System.Drawing.Point(0, 0);
            this.rp_monpad.Name = "rp_monpad";
            this.rp_monpad.Size = new System.Drawing.Size(944, 764);
            this.rp_monpad.TabIndex = 29;
            this.rp_monpad.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // rp_invendon
            // 
            this.rp_invendon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rp_invendon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.reporteInventarioDonBindingSource;
            this.rp_invendon.LocalReport.DataSources.Add(reportDataSource7);
            this.rp_invendon.LocalReport.ReportEmbeddedResource = "PantallaInicio.Report7.rdlc";
            this.rp_invendon.Location = new System.Drawing.Point(0, 0);
            this.rp_invendon.Name = "rp_invendon";
            this.rp_invendon.Size = new System.Drawing.Size(944, 764);
            this.rp_invendon.TabIndex = 30;
            this.rp_invendon.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // reporteInventarioDonTableAdapter
            // 
            this.reporteInventarioDonTableAdapter.ClearBeforeFill = true;
            // 
            // rp_inventer
            // 
            this.rp_inventer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rp_inventer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_inventer.DocumentMapWidth = 4;
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.reporteInventarioTerBindingSource;
            this.rp_inventer.LocalReport.DataSources.Add(reportDataSource8);
            this.rp_inventer.LocalReport.ReportEmbeddedResource = "PantallaInicio.Report8.rdlc";
            this.rp_inventer.Location = new System.Drawing.Point(0, 0);
            this.rp_inventer.Name = "rp_inventer";
            this.rp_inventer.Size = new System.Drawing.Size(944, 764);
            this.rp_inventer.TabIndex = 31;
            this.rp_inventer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // reporteInventarioTerTableAdapter
            // 
            this.reporteInventarioTerTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1352, 764);
            this.ControlBox = false;
            this.Controls.Add(this.rp_inventer);
            this.Controls.Add(this.rp_invendon);
            this.Controls.Add(this.rp_monpad);
            this.Controls.Add(this.rp_monvol);
            this.Controls.Add(this.rp_empleados);
            this.Controls.Add(this.rp_voluntarios);
            this.Controls.Add(this.rp_ninios);
            this.Controls.Add(this.rp_padrinos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportePadrinosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BencalethDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteNinioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_Voluntarios1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePagoVolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePagoPadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteInventarioDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteInventarioTerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.PictureBox pictureBox2;
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
        private System.Windows.Forms.BindingSource reportePadrinosBindingSource;
        private BencalethDataSet BencalethDataSet;
        private BencalethDataSetTableAdapters.reportePadrinosTableAdapter reportePadrinosTableAdapter;
        private System.Windows.Forms.BindingSource reporteNinioBindingSource;
        private BencalethDataSetTableAdapters.reporteNinioTableAdapter reporteNinioTableAdapter;
        private System.Windows.Forms.BindingSource Select_Voluntarios1BindingSource;
        private BencalethDataSetTableAdapters.Select_Voluntarios1TableAdapter Select_Voluntarios1TableAdapter;
        private System.Windows.Forms.BindingSource reporteEmpleadoBindingSource;
        private BencalethDataSetTableAdapters.reporteEmpleadoTableAdapter reporteEmpleadoTableAdapter;
        private System.Windows.Forms.BindingSource reportePagoVolBindingSource;
        private BencalethDataSetTableAdapters.reportePagoVolTableAdapter reportePagoVolTableAdapter;
        private System.Windows.Forms.BindingSource reportePagoPadBindingSource;
        private BencalethDataSetTableAdapters.reportePagoPadTableAdapter reportePagoPadTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rp_padrinos;
        private Microsoft.Reporting.WinForms.ReportViewer rp_ninios;
        private Microsoft.Reporting.WinForms.ReportViewer rp_voluntarios;
        private Microsoft.Reporting.WinForms.ReportViewer rp_empleados;
        private Microsoft.Reporting.WinForms.ReportViewer rp_monvol;
        private Microsoft.Reporting.WinForms.ReportViewer rp_monpad;
        private System.Windows.Forms.RadioButton rb_invdon;
        private System.Windows.Forms.RadioButton rb_inveter;
        private Microsoft.Reporting.WinForms.ReportViewer rp_invendon;
        private System.Windows.Forms.BindingSource reporteInventarioDonBindingSource;
        private BencalethDataSetTableAdapters.reporteInventarioDonTableAdapter reporteInventarioDonTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rp_inventer;
        private System.Windows.Forms.BindingSource reporteInventarioTerBindingSource;
        private BencalethDataSetTableAdapters.reporteInventarioTerTableAdapter reporteInventarioTerTableAdapter;
    }
}