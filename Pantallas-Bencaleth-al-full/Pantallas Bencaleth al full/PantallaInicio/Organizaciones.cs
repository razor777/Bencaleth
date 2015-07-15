using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;
namespace PantallaInicio
{
    public class Organizaciones
    {
        public static QueriesTableAdapter BD = new QueriesTableAdapter();

        private bool boolEditable;
        private object ValueCombobox = null;
        private Control ctrlID;
        private Control ctrlNombre;
        private Control ctrlDireccion;
        private Control ctrlPais;
        private Control ctrlContacto;
        private Control ctrlTelefono1;
        private Control ctrlTelefono2;
        private Control ctrlEmail;
        private Control ctrlTipoEmpresa;

        public Organizaciones(Control ctrlIdent, Control ctrlNom,Control ctrlDir,Control ctrlPa,Control ctrlCont, Control ctrlTel1, Control ctrlTel2,Control ctrlCor,Control ctrlTiEm) {
            ctrlID = ctrlIdent;
            ctrlNombre = ctrlNom;
            ctrlDireccion = ctrlDir;
            ctrlPais = ctrlPa;
            ctrlContacto = ctrlCont;
            ctrlTelefono1 = ctrlTel1;
            ctrlTelefono2 = ctrlTel2;
            ctrlEmail = ctrlCor;
            ctrlTipoEmpresa = ctrlTiEm;
            boolEditable = true;
        }

        public Organizaciones() {
            boolEditable = false;
        }
       
        public void ingresarDatos(Control controles) {
            if (boolEditable)
            {
                string strCombo = ((ComboBox)ctrlTipoEmpresa).SelectedValue.ToString();

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BD.Insert_Empresas(ctrlNombre.Text, strCombo, ctrlDireccion.Text, ctrlTelefono1.Text, ctrlTelefono2.Text, ctrlPais.Text, ctrlContacto.Text, ctrlEmail.Text);
                        MessageBox.Show("Ingresado");

                        ctrlNombre.Text = "";
                        ctrlDireccion.Text = "";
                        ctrlPais.Text = "";
                        ctrlContacto.Text = "";
                        ctrlTelefono1.Text = "";
                        ctrlTelefono2.Text = "";
                        ctrlEmail.Text = "";
                    }
                    catch (SqlException e)
                    {
                        switch (e.Number)
                        {
                            case 2627:
                                MessageBox.Show("ID ya existente");
                                break;
                            default:
                                MessageBox.Show("No hay conexion con la base de datos");
                                break;
                        }
                    }
                }

            }
        }

        public void actualizarDatos(Control controles) {
            if (boolEditable)
            {
                string strCombo = ((ComboBox)ctrlTipoEmpresa).SelectedValue.ToString();

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BD.Update_Empresas(ctrlID.Text, ctrlNombre.Text, strCombo, ctrlDireccion.Text, ctrlContacto.Text, ctrlTelefono1.Text, ctrlTelefono2.Text, ctrlPais.Text, ctrlEmail.Text);
                        MessageBox.Show("Ha sido actualizado");
                    }
                    catch (SqlException e)
                    {
                        switch (e.Number)
                        {
                            case 2627:
                                MessageBox.Show("ID ya existente");
                                break;
                            default:
                                MessageBox.Show("No hay conexion con la base de datos");
                                break;
                        }
                    }
                }
            }
        }

        public void DeleteDatos(string ID) {
            try
            {
                if (!string.IsNullOrEmpty(ID))
                {
                    BD.Delete_Empresas(Convert.ToInt32(ID));
                }
            }catch(SqlException){
                MessageBox.Show("No hay conexion con la base de datos");
            }
        }

        public void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado)
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_EmpresasTableAdapter tblAdptEmp = new BuscarSelect_EmpresasTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Empresas, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Empresas, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_Empresas, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Empresas.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Tipo de Empresa";
            dtgrdvw.Columns[3].HeaderText = "Dirección";
            dtgrdvw.Columns[4].HeaderText = "Contacto";
            dtgrdvw.Columns[5].HeaderText = "Teléfono 1";
            dtgrdvw.Columns[6].HeaderText = "Teléfono 2";
            dtgrdvw.Columns[7].HeaderText = "País";
            dtgrdvw.Columns[8].HeaderText = "Correo Electrónico";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles, DataGridViewRow fila) {
            ctrlID.Text = fila.Cells["Id"].Value.ToString();
            ctrlNombre.Text = fila.Cells["Nombre"].Value.ToString();

            try
            {
                this.ValueCombobox = BD.GetIDToComboBoxTipoEmpr_Empresas(fila.Cells[2].Value.ToString());
            }
            catch (SqlException) {
                MessageBox.Show("No hay conexion con la base de datos");
            }

            ctrlDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            ctrlPais.Text = fila.Cells["Pais"].Value.ToString(); ;
            ctrlContacto.Text = fila.Cells["Contacto"].Value.ToString();
            ctrlTelefono1.Text = fila.Cells["Telefono1"].Value.ToString();
            ctrlTelefono2.Text = fila.Cells["Telefono2"].Value.ToString();
            ctrlEmail.Text = fila.Cells["Email"].Value.ToString();
        }

        public void FixComboBox(Control controles)
        {
            //invocar en el load de la clase
            if (ValueCombobox != null)
            {
                ((ComboBox)ctrlTipoEmpresa).SelectedValue = this.ValueCombobox;
                this.ValueCombobox = null;
            }
        }
    }
}
