﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace PantallaInicio
{
    public partial class IngresoVoluntarios : Form
    {
        Voluntarios  voluntario;
        Boolean boolModoActualizar;

        public IngresoVoluntarios()
        {
            InitializeComponent();
            voluntario  = new Voluntarios (txt_Id_Voluntarios,txt_Nom_Voluntarios,txt_Apelli_Voluntarios,date_Fn_Voluntarios,date_FI_Voluntarios,radio_mas_Voluntarios,radio_fem_Voluntarios,txt_Email_Voluntarios,txt_Tel_Voluntarios,txt_Info_Voluntarios,txtHoras);
            boolModoActualizar = false;

            this.date_Fn_Voluntarios.Value = new DateTime((DateTime.Now.Year - 16), 1, 1);
            this.date_Fn_Voluntarios.Update();

            txt_Id_Voluntarios.ReadOnly = false;
            btnPagar.Visible = false;
        }

        public IngresoVoluntarios(DataGridViewRow fila)
        {
            InitializeComponent();
            voluntario = new Voluntarios(txt_Id_Voluntarios, txt_Nom_Voluntarios, txt_Apelli_Voluntarios, date_Fn_Voluntarios, date_FI_Voluntarios, radio_mas_Voluntarios, radio_fem_Voluntarios, txt_Email_Voluntarios, txt_Tel_Voluntarios, txt_Info_Voluntarios, txtHoras);

            voluntario.ConseguirDatosToUpdate(txt_Apelli_Voluntarios,fila);
            boolModoActualizar = true;

            txt_Id_Voluntarios.ReadOnly = true;
            

            if (Log.Cargo(Log.sesion) == 2)
            {
                btnPagar.Visible = false;
            }else
                btnPagar.Visible = true;
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            txt_Tel_Voluntarios.Text = Herramientas.SoloNumeros(txt_Tel_Voluntarios);
            errorProvider5.Clear();
        }

        private void btn_save_Voluntario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Id_Voluntarios.Text))
            {
                errorProvider1.SetError(txt_Id_Voluntarios, "Falta llenar campos vacios");
            }
            if (string.IsNullOrEmpty(txt_Nom_Voluntarios.Text))
            {
                errorProvider2.SetError(txt_Nom_Voluntarios, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Apelli_Voluntarios.Text))
            {
                errorProvider3.SetError(txt_Apelli_Voluntarios, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Tel_Voluntarios.Text))
            {
                errorProvider5.SetError(txt_Tel_Voluntarios, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Email_Voluntarios.Text))
            {
                errorProvider6.SetError(txt_Email_Voluntarios, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Info_Voluntarios.Text))
            {
                errorProvider7.SetError(txt_Info_Voluntarios, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txtHoras.Text))
            {
                errorProvider9.SetError(txtHoras, "Falta llenar Campo");
            }
            else
            {
                if (boolModoActualizar)
                {
                    voluntario.actualizarDatos(txt_Id_Voluntarios);
                }
                else
                {
                    voluntario.ingresarDatos(txt_Id_Voluntarios);
                }
            }
        }

        private void txt_Id_Voluntarios_TextChanged(object sender, EventArgs e)
        {
             txt_Id_Voluntarios.Text = Herramientas.NingunCaracterEspecial(txt_Id_Voluntarios);
             errorProvider1.Clear();
        }

        private void txt_Nom_Voluntarios_TextChanged(object sender, EventArgs e)
        {
            txt_Nom_Voluntarios.Text = Herramientas.SoloLetrasYEspaciosSec(txt_Nom_Voluntarios);
            errorProvider2.Clear();
        }

        private void txt_Apelli_Voluntarios_TextChanged(object sender, EventArgs e)
        {
            txt_Apelli_Voluntarios.Text = Herramientas.SoloLetrasYEspaciosSec(txt_Apelli_Voluntarios);
            errorProvider3.Clear();
        }

        private void txt_Email_Voluntarios_TextChanged(object sender, EventArgs e)
        {
            txt_Email_Voluntarios.Text = Herramientas.NingunEspacioEnBlanco(txt_Email_Voluntarios);
            errorProvider6.Clear();
        }

        private void txt_Info_Voluntarios_TextChanged(object sender, EventArgs e)
        {
            txt_Info_Voluntarios.Text = Herramientas.NingunEspacioInicial(txt_Info_Voluntarios.Text);
            errorProvider7.Clear();
        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {
            txtHoras.Text = Herramientas.SoloNumeros(txtHoras);
            errorProvider9.Clear();
        }

        private void txt_Email_Voluntarios_Leave(object sender, EventArgs e)
        {
            if (!validarEmail(txt_Email_Voluntarios.Text))
            {
                MessageBox.Show("Direccion de correo electronico no valida el correo debe terner un formato nombre@dominio.com");
                txt_Email_Voluntarios.Clear();
            }
        }

        private void date_Fn_Voluntarios_Leave(object sender, EventArgs e)
        {
            int anoActual, anoIntroducido;

            anoActual = Convert.ToInt32(DateTime.Today.Year);
            anoIntroducido = date_Fn_Voluntarios.Value.Year;

            if ((anoActual - anoIntroducido) < 16 && (!(anoIntroducido >= anoActual)))
            {
                this.date_Fn_Voluntarios.Value = new DateTime((DateTime.Now.Year - 16), 1, 1);
                this.date_Fn_Voluntarios.Update();
                MessageBox.Show("Introdujo un voluntario muy joven", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (anoIntroducido > anoActual)
            {
                this.date_Fn_Voluntarios.Value = new DateTime((DateTime.Now.Year - 16), 1, 1);
                this.date_Fn_Voluntarios.Update();
                MessageBox.Show("Introdujo un voluntario que no a nacido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (anoIntroducido == anoActual)
            {
                this.date_Fn_Voluntarios.Value = new DateTime((DateTime.Now.Year - 16), 1, 1);
                this.date_Fn_Voluntarios.Update();
                MessageBox.Show(" Introdujo un voluntario recien nacido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea ingresar pago?", "Pagar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                voluntario.PagarMensualidad(txt_Id_Voluntarios);
            }
        }
    }
}
