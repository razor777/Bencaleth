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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txt_pasw.Text = Herramientas.NingunCaracterEspecial(txt_pasw);
        }

        private void btn_Ing_Click(object sender, EventArgs e)
        {

            if (Log.Validacion(txt_user.Text, txt_pasw.Text) == 1)
            {

                Log.sesion = this.txt_user.Text;

                this.txt_user.Clear();
                this.txt_pasw.Clear();
                Herramientas.initProgramaGestionForms(this, new Menu());
            }
            else
            {

                if (Log.intentosActuales == Log.intentosMax) { Log.Block(Log.NombreBlock); }
                MessageBox.Show("Usuario o contraseña incorrecto.");

            }
           
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            txt_user.Text = Herramientas.NingunCaracterEspecial(txt_user);
        }
    }
}
