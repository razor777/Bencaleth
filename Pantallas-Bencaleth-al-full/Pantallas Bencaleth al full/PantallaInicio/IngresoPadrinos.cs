using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    public partial class IngresoPadrinos : Form
    {
        QueriesTableAdapter bd = new QueriesTableAdapter();
        Boolean boolModoActualizar;

        Padrinos pdr;
        public IngresoPadrinos()
        {
            InitializeComponent();
            pdr = new Padrinos(txt_Id_Padrinos, txt_Nom_padrinos, txt_apellido_padrinos, txtbDireccion,ddate_Fn_padrinos,date_Fi_padrinos,txt_iden_padrinos,radio_mas_Padrinos,radio_fem_Padrinos,txt_Email_Padrinos,txt_Mens_Padrinos,txt_Tel_Padrinos);

            this.ddate_Fn_padrinos.Value = new DateTime((DateTime.Now.Year - 18), 1, 1);
            this.ddate_Fn_padrinos.Update();

            boolModoActualizar = false;

            txt_Id_Padrinos.ReadOnly = false;

            btnPago.Visible = false;
        }

        public IngresoPadrinos(DataGridViewRow fila)
        {
            InitializeComponent();
            pdr = new Padrinos(txt_Id_Padrinos, txt_Nom_padrinos, txt_apellido_padrinos, txtbDireccion, ddate_Fn_padrinos, date_Fi_padrinos, txt_iden_padrinos, radio_mas_Padrinos, radio_fem_Padrinos, txt_Email_Padrinos, txt_Mens_Padrinos, txt_Tel_Padrinos);

            pdr.ConseguirDatosToUpdate(txt_apellido_padrinos,fila);
            boolModoActualizar = true;

            txt_Id_Padrinos.ReadOnly = true;

            if (Log.Cargo(Log.sesion) == 2)
            {
                btnPago.Visible = false;
            }
            else
                btnPago.Visible = true;
        }

        private void txt_Id_Padrinos_TextChanged(object sender, EventArgs e)
        {
            txt_Id_Padrinos.Text = Herramientas.NingunCaracterEspecial(txt_Id_Padrinos);
            errorProvider1.Clear();
        }

        private void txt_Nom_padrinos_TextChanged(object sender, EventArgs e)
        {
            txt_Nom_padrinos.Text = Herramientas.SoloLetrasYEspaciosSec(txt_Nom_padrinos);
            errorProvider2.Clear();
        }

        private void txt_apellido_padrinos_TextChanged(object sender, EventArgs e)
        {
            txt_apellido_padrinos.Text = Herramientas.SoloLetrasYEspaciosSec(txt_apellido_padrinos);
            errorProvider3.Clear();
        }

        private void txt_iden_padrinos_TextChanged(object sender, EventArgs e)
        {
            txt_iden_padrinos.Text = Herramientas.SoloNumeros(txt_iden_padrinos);
            errorProvider4.Clear();
        }

        private void txt_Tel_Padrinos_TextChanged(object sender, EventArgs e)
        {
            txt_Tel_Padrinos.Text = Herramientas.SoloNumeros(txt_Tel_Padrinos);
            errorProvider5.Clear();
        }

        private void txt_Email_Padrinos_TextChanged(object sender, EventArgs e)
        {
            txt_Email_Padrinos.Text = Herramientas.NingunEspacioEnBlanco(txt_Email_Padrinos);
            errorProvider6.Clear();
        }

        private void txt_Mens_Padrinos_TextChanged(object sender, EventArgs e)
        {
            txt_Mens_Padrinos.Text = Herramientas.SoloNumeros(txt_Mens_Padrinos);
            errorProvider7.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Id_Padrinos.Text))
            {
                errorProvider1.SetError(txt_Id_Padrinos, "Falta llenar campos vacios");
            }
            if (string.IsNullOrEmpty(txt_Nom_padrinos.Text))
            {
                errorProvider2.SetError(txt_Nom_padrinos, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_apellido_padrinos.Text))
            {
                errorProvider3.SetError(txt_apellido_padrinos, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_iden_padrinos.Text))
            {
                errorProvider4.SetError(txt_iden_padrinos, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Tel_Padrinos.Text))
            {
                errorProvider5.SetError(txt_Tel_Padrinos, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Email_Padrinos.Text))
            {
                errorProvider6.SetError(txt_Email_Padrinos, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txt_Mens_Padrinos.Text))
            {
                errorProvider7.SetError(txt_Mens_Padrinos, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txtbDireccion.Text))
            {
                errorProvider8.SetError(txtbDireccion, "Falta llenar Campo");
            }
            else
            {
                if (boolModoActualizar)
                {
                    pdr.actualizarDatos(txt_apellido_padrinos);
                }
                else
                {
                    pdr.ingresarDatos(txt_Mens_Padrinos);
                }
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea ingresar pago?", "Pagar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txt_Mens_Padrinos.Text))
                {
                    pdr.PagarMensualidad(txt_Id_Padrinos);
                }
                else
                    MessageBox.Show("No puede dejar una mensualidad en 0.00");
            }
        }

        private void txtbDireccion_TextChanged(object sender, EventArgs e)
        {
            txtbDireccion.Text = Herramientas.NingunEspacioInicial(txtbDireccion.Text);
            errorProvider8.Clear();
        }

        private void ddate_Fn_padrinos_Leave(object sender, EventArgs e)
        {
            int anoActual, anoIntroducido;

            anoActual = Convert.ToInt32(DateTime.Today.Year);
            anoIntroducido = ddate_Fn_padrinos.Value.Year;

            if (anoIntroducido > anoActual)
            {
                this.ddate_Fn_padrinos.Value = new DateTime((DateTime.Now.Year - 18), 1, 1);
                this.ddate_Fn_padrinos.Update();
                MessageBox.Show("Introdujo un padrino que no a nacido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (anoIntroducido == anoActual)
            {
                this.ddate_Fn_padrinos.Value = new DateTime((DateTime.Now.Year - 18), 1, 1);
                this.ddate_Fn_padrinos.Update();
                MessageBox.Show(" Introdujo un padrino recien nacido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
