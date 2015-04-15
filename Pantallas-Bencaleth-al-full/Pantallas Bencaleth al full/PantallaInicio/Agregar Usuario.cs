using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaInicio
{
    public partial class Agregar_Usuario : Form
    {
        public Agregar_Usuario()
        {
            InitializeComponent();
        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bencalethDataSet.mostarCargo' Puede moverla o quitarla según sea necesario.
            this.mostarCargoTableAdapter.Fill(this.bencalethDataSet.mostarCargo);

        }

        private void btn_Acep_Adduseer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nom_Adduser.Text) || string.IsNullOrEmpty(txt_Pass_Adduser.Text) || string.IsNullOrEmpty(txt_Confir_Adduser.Text))
            {
                MessageBox.Show("No se pueden dejar campos vacios.");
            }
            else
            {

                MessageBox.Show(Log.IngresoUsuario(txt_Nom_Adduser.Text, txt_Pass_Adduser.Text, txt_Confir_Adduser.Text, Convert.ToInt32(mostarCargoComboBox.SelectedValue)));
                if (Log.aprobado == 1)
                { this.Close(); Log.aprobado = 0; }
            }
        }

        private void txt_Nom_Adduser_TextChanged(object sender, EventArgs e)
        {
            txt_Nom_Adduser.Text = Herramientas.NingunCaracterEspecial(txt_Nom_Adduser);

        }

        private void txt_Pass_Adduser_TextChanged(object sender, EventArgs e)
        {
            txt_Pass_Adduser.Text = Herramientas.NingunCaracterEspecial(txt_Pass_Adduser);
        }

        private void txt_Confir_Adduser_TextChanged(object sender, EventArgs e)
        {
            txt_Confir_Adduser.Text = Herramientas.NingunCaracterEspecial(txt_Confir_Adduser);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mostarCargoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Adduser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
