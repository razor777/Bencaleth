using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace PantallaInicio
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BencalethDataSet.reporteInventarioTer' Puede moverla o quitarla según sea necesario.
            this.reporteInventarioTerTableAdapter.Fill(this.BencalethDataSet.reporteInventarioTer);
            // TODO: esta línea de código carga datos en la tabla 'BencalethDataSet.reporteInventarioDon' Puede moverla o quitarla según sea necesario.
            this.reporteInventarioDonTableAdapter.Fill(this.BencalethDataSet.reporteInventarioDon);
            // TODO: esta línea de código carga datos en la tabla 'BencalethDataSet.reportePagoPad' Puede moverla o quitarla según sea necesario.
            this.reportePagoPadTableAdapter.Fill(this.BencalethDataSet.reportePagoPad);
            // TODO: esta línea de código carga datos en la tabla 'BencalethDataSet.reportePagoVol' Puede moverla o quitarla según sea necesario.
            this.reportePagoVolTableAdapter.Fill(this.BencalethDataSet.reportePagoVol);
            // TODO: esta línea de código carga datos en la tabla 'BencalethDataSet.reporteEmpleado' Puede moverla o quitarla según sea necesario.
            this.reporteEmpleadoTableAdapter.Fill(this.BencalethDataSet.reporteEmpleado);
            // TODO: esta línea de código carga datos en la tabla 'BencalethDataSet.Select_Voluntarios1' Puede moverla o quitarla según sea necesario.
            this.Select_Voluntarios1TableAdapter.Fill(this.BencalethDataSet.Select_Voluntarios1);
            // TODO: esta línea de código carga datos en la tabla 'BencalethDataSet.reporteNinio' Puede moverla o quitarla según sea necesario.
            this.reporteNinioTableAdapter.Fill(this.BencalethDataSet.reporteNinio);
            
            // TODO: esta línea de código carga datos en la tabla 'BencalethDataSet.reportePadrinos' Puede moverla o quitarla según sea necesario.
            this.reportePadrinosTableAdapter.Fill(this.BencalethDataSet.reportePadrinos);

            rp_inventer.Visible = false;
            rp_padrinos.Visible = false;
            rp_ninios.Visible = false;
            rp_voluntarios.Visible = false;
            rp_empleados.Visible = false;
            rp_monvol.Visible = false;
            rp_monpad.Visible = false;
            rp_invendon.Visible = false;
            


            this.rp_padrinos.RefreshReport();
            this.rp_ninios.RefreshReport();
            this.rp_voluntarios.RefreshReport();
            this.rp_voluntarios.RefreshReport();
            this.rp_empleados.RefreshReport();
            this.rp_monvol.RefreshReport();
            this.rp_monpad.RefreshReport();
            this.rp_invendon.RefreshReport();
            this.rp_inventer.RefreshReport();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Herramientas.AbrirNuevoForm(new Mantenimiento());
        }

        private void rb_padrinos_CheckedChanged(object sender, EventArgs e)
        {
            rp_invendon.Visible = false;
            rp_monpad.Visible = false;
            rp_monvol.Visible = false;
            rp_empleados.Visible = false;
            rp_voluntarios.Visible = false;
            rp_ninios.Visible = false;
            rp_inventer.Visible = false;
            rp_padrinos.Visible = true;
        }

        private void rb_niños_CheckedChanged(object sender, EventArgs e)
        {
            rp_inventer.Visible = false;
            rp_invendon.Visible = false;
            rp_monpad.Visible = false;
            rp_monvol.Visible = false;
            rp_empleados.Visible = false;
            rp_voluntarios.Visible = false;
            rp_padrinos.Visible = false;
            rp_ninios.Visible = true;  
        }

        private void rb_voluntarios_CheckedChanged(object sender, EventArgs e)
        {
            rp_inventer.Visible = false;
            rp_invendon.Visible = false;
            rp_monpad.Visible = false;
            rp_monvol.Visible = false;
            rp_empleados.Visible = false;
            rp_padrinos.Visible = false;
            rp_ninios.Visible = false;
            rp_voluntarios.Visible = true;
        }

        private void rb_empleados_CheckedChanged_1(object sender, EventArgs e)
        {
            rp_inventer.Visible = false;
            rp_invendon.Visible = false;
            rp_monpad.Visible = false;
            rp_monvol.Visible = false;
            rp_ninios.Visible = false;
            rp_padrinos.Visible = false;
            rp_voluntarios.Visible = false;
            rp_empleados.Visible = true;
        }

        private void rb_montoVolun_CheckedChanged_1(object sender, EventArgs e)
        {
            rp_inventer.Visible = false;
            rp_invendon.Visible = false;
            rp_monpad.Visible = false;
            rp_empleados.Visible = false;
            rp_ninios.Visible = false;
            rp_padrinos.Visible = false;
            rp_voluntarios.Visible = false;
            rp_monvol.Visible = true;  
        }

        private void rb_MontoPadrino_CheckedChanged_1(object sender, EventArgs e)
        {
            rp_inventer.Visible = false;
            rp_invendon.Visible = false;
            rp_monpad.Visible = false;
            rp_empleados.Visible = false;
            rp_ninios.Visible = false;
            rp_padrinos.Visible = false;
            rp_voluntarios.Visible = false;
            rp_monpad.Visible = true;
        }

        private void rb_invdon_CheckedChanged(object sender, EventArgs e)
        {
            rp_inventer.Visible = false;
            rp_monpad.Visible = false;
            rp_empleados.Visible = false;
            rp_ninios.Visible = false;
            rp_padrinos.Visible = false;
            rp_voluntarios.Visible = false;
            rp_monpad.Visible = false;
            rp_invendon.Visible = true;
        }

        private void rb_inveter_CheckedChanged(object sender, EventArgs e)
        {            
            rp_monpad.Visible = false;
            rp_empleados.Visible = false;
            rp_ninios.Visible = false;
            rp_padrinos.Visible = false;
            rp_voluntarios.Visible = false;
            rp_monpad.Visible = false;
            rp_invendon.Visible = false;
            rp_inventer.Visible = true;
        }

        private void rp_voluntarios_Load(object sender, EventArgs e)
        {

        }
    }
}
