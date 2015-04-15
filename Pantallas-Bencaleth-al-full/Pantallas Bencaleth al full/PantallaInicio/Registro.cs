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
    public partial class Registro : Form
    {
        IngresoNiños ventanaN = new IngresoNiños();
        IngresoEmpleados ventanaE = new IngresoEmpleados();

        public Registro()
        {
            InitializeComponent();
        }
        public Registro(DataGridViewRow fila,int cualRegistro)
        {
            InitializeComponent();

            switch (cualRegistro)
            {
                //Alcancias
                case 0:
                    Herramientas.AbrirEnContainerNewForm(new IngresoAlcancia(fila), splitContainer1.Panel1);
                    break;
                //Empleados
                case 1:
                    Herramientas.AbrirEnContainerNewForm(new IngresoEmpleados(fila),splitContainer1.Panel1);
                    break;
                //Empresas
                case 2:
                    Herramientas.AbrirEnContainerNewForm(new IngresarEmpresa(fila), splitContainer1.Panel1);
                    break;
                //Ninos
                case 3:
                    Herramientas.AbrirEnContainerNewForm(new IngresoNiños(fila), splitContainer1.Panel1);
                    break;
                //Padrinos
                case 4:
                    Herramientas.AbrirEnContainerNewForm(new IngresoPadrinos(fila), splitContainer1.Panel1);
                    break;
                //Voluntarios
                case 5:
                    Herramientas.AbrirEnContainerNewForm(new IngresoVoluntarios(fila), splitContainer1.Panel1);
                    break;
                default:
                    break;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ventanaN.TopLevel = false;
            //splitContainer1.Panel1.Controls.Add(ventanaN);
            //ventanaN.Show();
            //ventanaN.BringToFront();

            Herramientas.AbrirEnContainerNewForm(new IngresoNiños(),splitContainer1.Panel1);
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {         
            //ventanaE.TopLevel = false;
            //splitContainer1.Panel1.Controls.Add(ventanaE);
            //ventanaE.Show();
            //ventanaE.BringToFront();

            Herramientas.AbrirEnContainerNewForm(new IngresoEmpleados(),splitContainer1.Panel1);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            //new Menu().Show();
            //this.Hide();

            Herramientas.AbrirNuevoForm(new Menu());
        }

        private void btn_mant_Click(object sender, EventArgs e)
        {
            //new Mantenimiento().Show();
            //this.Close();
            Herramientas.AbrirNuevoForm(new Mantenimiento());
        }

        private void btn_vol_Click(object sender, EventArgs e)
        {
            //IngresoVoluntarios ventana = new IngresoVoluntarios();
            //ventana.TopLevel = false;
            //splitContainer1.Panel1.Controls.Add(ventana);
            //ventana.Show();
            //ventana.BringToFront();

            Herramientas.AbrirEnContainerNewForm(new IngresoVoluntarios(),splitContainer1.Panel1);
        }

        private void btn_pad_Click(object sender, EventArgs e)
        {
            //IngresoPadrinos ventana = new IngresoPadrinos();
            //ventana.TopLevel = false;
            //splitContainer1.Panel1.Controls.Add(ventana);
            //ventana.Show();
            //ventana.BringToFront();
            Herramientas.AbrirEnContainerNewForm(new IngresoPadrinos(),splitContainer1.Panel1);
        }

        private void btn_alcancias_Click(object sender, EventArgs e)
        {
            //IngresoAlcancia ventana = new IngresoAlcancia();
            //ventana.TopLevel = false;
            //splitContainer1.Panel1.Controls.Add(ventana);
            //ventana.Show();
            //ventana.BringToFront();
            Herramientas.AbrirEnContainerNewForm(new IngresoAlcancia(),splitContainer1.Panel1);
        }

        private void btn_empresas_Click(object sender, EventArgs e)
        {
            //IngresarEmpresa ventana = new IngresarEmpresa();
            //ventana.TopLevel = false;
            //splitContainer1.Panel1.Controls.Add(ventana);
            //ventana.Show();
            //ventana.BringToFront();
            Herramientas.AbrirEnContainerNewForm(new IngresarEmpresa(),splitContainer1.Panel1);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Herramientas.CerrarPrograma();
        }
    }
}
