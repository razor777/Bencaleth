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
    public partial class TipoEmpleEmpresa : Form
    {
        //Son las instancias de las clases que vamos a utilizar
        TipoCargo cargo;
        TipoEmpresa empresa;
        //Son variables que nos permiten borrar y actualizar datos
        String strIdAEnviar;
        DataGridViewRow filaAEnviar = null;

        public TipoEmpleEmpresa()
        {
            InitializeComponent();
            cargo = new TipoCargo(txtbCodigo,txtbValor,txtbSalario);
            empresa = new TipoEmpresa(txtbCodigo,txtbValor);

            strIdAEnviar = null;
            filaAEnviar = null;

            dtgdvwDatos.DataSource = null;

            cmbModulos.SelectedIndex = 0;

            boolModoActualizar = false;
            rdbtnEmpleado.Checked = true;
        }
        //Para habilitar que el usuario pueda actualizar y evitarnos errores al momento
        //de cargar el datagridview
        private void InicializarUserSelection()
        {
            try
            {
                strIdAEnviar = dtgdvwDatos.Rows[0].Cells[0].Value.ToString();
                filaAEnviar = dtgdvwDatos.Rows[0];
            }
            catch (Exception)
            {

                strIdAEnviar = null;
                filaAEnviar = null;
            }
        }
        //Decide cual fuente de datos usar para el datagridview y actualiza
        private void SelectPantalla()
        {
            switch (cmbModulos.SelectedIndex)
            {
                //Tipo Empresa
                case 0:
                    empresa.mostrarDatos(dtgdvwDatos, txtbABuscar);
                    dtgdvwDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                //Tipo Cargo
                case 1:
                    cargo.mostrarDatos(dtgdvwDatos, txtbABuscar);
                    dtgdvwDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                default:
                    break;
            }
            InicializarUserSelection();
            txtbABuscar.Clear();
            dtgdvwDatos.AutoResizeColumns();
        }
        //Simplemente es el controlador del combobox
        private void cmbModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectPantalla();
        }
        //Para evitar errores de llamar nuevamente al formulario
        private void TipoEmpleEmpresa_Load(object sender, EventArgs e)
        {
            InicializarUserSelection();
        }
        //Para actualizar registros, primero revisa que tipo de registro y luego le manda la fila correspondiente
        //claro que solo si tiene seleccionada una celda
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (filaAEnviar != null)
            {
                SelectMiniForm();
                switch (cmbModulos.SelectedIndex)
                {
                    //Tipo Empresa
                    case 0:
                        actualizarRegistro(rdbtnEmpresa);
                        empresa.ConseguirDatosToUpdate(filaAEnviar);
                        txtbSalario.Visible = false;
                        lblSalario.Visible = false;
                        break;
                    //Tipo Cargo
                    case 1:
                        actualizarRegistro(rdbtnEmpleado);
                        cargo.ConseguirDatosToUpdate(filaAEnviar);
                        break;
                    default:
                        break;
                }
                txtbCodigo.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("No hay nada que enviar");
            }
        }
        //Para borrar un registro, primero pregunta si realmente lo desea borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            SelectMiniForm();
            txtbCodigo.ReadOnly = false;
            if (MessageBox.Show("¿Esta seguro que desea borrarlo?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (filaAEnviar != null)
                {
                    switch (cmbModulos.SelectedIndex)
                    {
                        //Tipo Empresa
                        case 0:
                            empresa.DeleteDatos(strIdAEnviar);
                            break;
                        //Tipo Cargo
                        case 1:
                            cargo.DeleteDatos(strIdAEnviar);
                            break;
                        default:
                            break;
                    }
                    this.SelectPantalla();
                }
            }
        }
        //en caso que cierre el formulario
        private void TipoEmpleEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Herramientas.CerrarPrograma();
        }
        //Arreglamos el dato en formato correcto y luego lo buscamos en la base de datos,
        private void txtbABuscar_TextChanged(object sender, EventArgs e)
        {
            txtbABuscar.Text = Herramientas.NingunCharEspecialExpEspaciosSecundarios(txtbABuscar);
            this.SelectPantalla();
        }
      
        //Limpiamos el control txtbABuscar cuando seleccionamos un radioButton
        private void rdbtnID_CheckedChanged(object sender, EventArgs e)
        {
            txtbABuscar.Clear();
        }
        //Limpiamos el control txtbABuscar cuando seleccionamos un radioButton
        private void rdbtnDes_CheckedChanged(object sender, EventArgs e)
        {
            txtbABuscar.Clear();
        }
        //Variable para controlar el llenado de los controles 
        private bool boolModoActualizar;
        //Permite el llenado de los controles a modificar
        private void actualizarRegistro(RadioButton rdbtnAChequear) {
            boolModoActualizar = true;
            rdbtnAChequear.Checked = true;
            SelectMiniForm();
            btnGuardar.Text = "Actualizar";
        }
        //Para limpiar y estilizar campos para un ingreso normal de un registro
        private void SelectMiniForm() {
            if (!boolModoActualizar)
            {
                txtbCodigo.Text="";
                txtbValor.Text="";
                txtbSalario.Text="";
                btnGuardar.Text = "Guardar";
            }
            boolModoActualizar = false;
        }
        //Establecemos parametros para el ingreso de un registro tipo de empresa
        private void rdbtnEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            SelectMiniForm();
            txtbSalario.Visible = false;
            lblSalario.Visible = false;
            txtbCodigo.ReadOnly = false;
        }
        //Establecemos parametros para el ingreso de un registro tipo de cargo
        private void rdbtnEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            SelectMiniForm();
            txtbSalario.Visible = true;
            lblSalario.Visible = true;
            txtbCodigo.ReadOnly = false;
        }
        //Obligando a que el usuario solo pueda escribir numeros
        private void txtbCodigo_TextChanged(object sender, EventArgs e)
        {
            txtbCodigo.Text = Herramientas.SoloNumeros(txtbCodigo);
            errorProvider1.Clear();
        }
        //Obligando a que el usuario solo pueda escribir numeros y espacions en blanco no iniciales
        private void txtbValor_TextChanged(object sender, EventArgs e)
        {
            txtbValor.Text = Herramientas.SoloLetrasYEspaciosSec(txtbValor);
            errorProvider2.Clear();
        }
        //Obligando a que el usuario solo pueda escribir numeros
        private void txtbSalario_TextChanged(object sender, EventArgs e)
        {
            txtbSalario.Text = Herramientas.SoloNumeros(txtbSalario);
            errorProvider3.Clear();
        }
        //Este evento nos permite actualizar e ingresar en todos los campos de tipo empresa y cargo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbCodigo.Text))
            {
                errorProvider1.SetError(txtbCodigo, "Falta llenar campos vacios");
            }
            if (string.IsNullOrEmpty(txtbValor.Text))
            {
                errorProvider2.SetError(txtbValor, "Falta llenar Campo");
            }
            if (string.IsNullOrEmpty(txtbSalario.Text) && txtbSalario.Visible)
            {
                errorProvider3.SetError(txtbSalario, "Falta llenar Campo");
            }
            if (btnGuardar.Text == "Actualizar")
            {
                if (rdbtnEmpresa.Checked)
                {
                    txtbSalario.Text = "12";
                    empresa.actualizarDatos(txtbCodigo);
                    txtbSalario.Text = "";
                }
                else
                    cargo.actualizarDatos(txtbCodigo);
                SelectPantalla();
            }
            else {
                if (rdbtnEmpresa.Checked)
                {
                    txtbSalario.Text = "12";
                    empresa.ingresarDatos(txtbCodigo); 
                    txtbSalario.Text = "";
                }
                else
                    cargo.ingresarDatos(txtbCodigo);
                SelectPantalla();
            }
        }
        //Asignamos la variable filaAEnviar y strIdAEnviar con los datos de la celda para el registro
        //que el usuario desea actualizar
        private void dtgdvwDatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgdvwDatos.DataSource != null)
            {
                strIdAEnviar = dtgdvwDatos.CurrentRow.Cells[0].Value.ToString();
                filaAEnviar = dtgdvwDatos.Rows[e.RowIndex];
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Herramientas.AbrirNuevoForm(new Menu());
        }
    }
}
