﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace PantallaInicio
{
    public partial class IngresoEmpleados : Form    
    {
        Empleados empleado;
        Boolean boolModoActualizar;

        public IngresoEmpleados()
        {
            InitializeComponent();
            empleado = new Empleados(txtIdEmple,txtNomEmple,txt_Apelli_Emple,txt_Dir_Emple,date_FechN_Emple,Date_FechIn_Emple,radio_mas_Emple,radio_fem_Emple,txt_Email_Emple,combobox_CargoTipoComboBox,txt_Tel_Emple);

            this.date_FechN_Emple.Value = new DateTime((DateTime.Now.Year - 18), 1, 1);
            this.date_FechN_Emple.Update();

            boolModoActualizar = false;

            txtIdEmple.ReadOnly = false;
        }

        public IngresoEmpleados(DataGridViewRow fila)
        {
            InitializeComponent();
            empleado = new Empleados(txtIdEmple, txtNomEmple, txt_Apelli_Emple, txt_Dir_Emple, date_FechN_Emple, Date_FechIn_Emple, radio_mas_Emple, radio_fem_Emple, txt_Email_Emple, combobox_CargoTipoComboBox, txt_Tel_Emple);

            empleado.ConseguirDatosToUpdate(txtNomEmple, fila);
            boolModoActualizar = true;

            txtIdEmple.ReadOnly = true;
        }

        private void btn_save_Emple_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdEmple.Text))
            {
                errorProvider1.SetError(txtIdEmple, "Falta llenar campos vacios");
            }
            if (string.IsNullOrEmpty(txtNomEmple.Text))
            {
                errorProvider2.SetError(txtNomEmple, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Apelli_Emple.Text))
            {
                errorProvider3.SetError(txt_Apelli_Emple, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Tel_Emple.Text))
            {
                errorProvider4.SetError(txt_Tel_Emple, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Email_Emple.Text))
            {
                errorProvider5.SetError(txt_Email_Emple, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Dir_Emple.Text))
            {
                errorProvider6.SetError(txt_Dir_Emple, "Falta llenar Campo");
            }
            else
            {
                if(boolModoActualizar){
                    empleado.actualizarDatos(txtNomEmple);
                }else{
                    empleado.ingresarDatos(txtNomEmple);
                }
             }
        }

        private void txtIdEmple_TextChanged(object sender, EventArgs e)
        {
            txtIdEmple.Text = Herramientas.SoloNumeros(txtIdEmple);
            errorProvider1.Clear();
            
        }

        private void txtNomEmple_TextChanged(object sender, EventArgs e)
        {
             txtNomEmple.Text = Herramientas.SoloLetrasYEspaciosSec(txtNomEmple);
             errorProvider2.Clear();
        }

        private void txt_Apelli_Emple_TextChanged(object sender, EventArgs e)
        {
            txt_Apelli_Emple.Text = Herramientas.SoloLetrasYEspaciosSec(txt_Apelli_Emple);
            errorProvider3.Clear();
        }

        private void txt_Tel_Emple_TextChanged(object sender, EventArgs e)
        {
            txt_Tel_Emple.Text=Herramientas.SoloNumeros(txt_Tel_Emple);
            errorProvider4.Clear();
        }

        private void txt_Email_Emple_TextChanged(object sender, EventArgs e)
        {
            txt_Email_Emple.Text=Herramientas.NingunEspacioEnBlanco(txt_Email_Emple);
            errorProvider5.Clear();

        }

        private void txt_Dir_Emple_TextChanged(object sender, EventArgs e)
        {
            txt_Dir_Emple.Text = Herramientas.NingunEspacioInicial(txt_Dir_Emple.Text);
            errorProvider6.Clear();
        }

        public static bool validarEmail(string email)
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }

            }
            else
            { return false; }
        }
        private void txt_Email_Emple_Leave(object sender, EventArgs e)
        {
            if (!validarEmail(txt_Email_Emple.Text))
            {
                MessageBox.Show("Direccion de correo electronico no valida el correo debe terner un formato nombre@dominio.com");
                txt_Email_Emple.Text = "";
            }

        }

        private void date_FechN_Emple_Leave(object sender, EventArgs e)
        {

            int anoActual, anoIntroducido;

            anoActual = Convert.ToInt32(DateTime.Today.Year);
            anoIntroducido = date_FechN_Emple.Value.Year;

            if ((anoActual - anoIntroducido) < 18 && (!(anoIntroducido >= anoActual)))
            {
                this.date_FechN_Emple.Value = new DateTime((DateTime.Now.Year - 18), 1, 1);
                this.date_FechN_Emple.Update();
                MessageBox.Show("Introdujo un empleado muy joven", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (anoIntroducido > anoActual)
            {
                this.date_FechN_Emple.Value = new DateTime((DateTime.Now.Year - 18), 1, 1);
                this.date_FechN_Emple.Update();
                MessageBox.Show("Introdujo un empleado que no a nacido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (anoIntroducido == anoActual)
            {
                this.date_FechN_Emple.Value = new DateTime((DateTime.Now.Year - 18), 1, 1);
                this.date_FechN_Emple.Update();
                MessageBox.Show(" Introdujo un empleado recien nacido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresoEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet.Combobox_CargoTipo' Puede moverla o quitarla según sea necesario.
            this.combobox_CargoTipoTableAdapter.Fill(this.bencalethDataSet.Combobox_CargoTipo);
            empleado.FixComboBox(txt_Apelli_Emple);
        }
    }
}
