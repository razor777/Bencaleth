using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    public class Alcancias
    {
        QueriesTableAdapter BDAlcancias = new QueriesTableAdapter();

        private bool boolEditable;
        private object ValueCombobox=null;
        private Control ctrlID;
        private Control ctrlDireccion;
        private Control ctrlLocal;
        private Control ctrlFechaInicio;
        private Control ctrlTelefono;
        private Control ctrlCmbRecurrencia;

        public Alcancias(Control ctrlIdent,Control ctrlDesc, Control ctrlDir, Control ctrlTel,Control ctrlRecu,Control ctrlFchIni) {
            ctrlID = ctrlIdent;
            ctrlLocal = ctrlDesc;
            ctrlDireccion = ctrlDir;
            ctrlTelefono = ctrlTel;
            ctrlCmbRecurrencia = ctrlRecu;
            ctrlFechaInicio = ctrlFchIni;
            boolEditable = true;
        }

        public Alcancias() {
            boolEditable = false;
        }

        public void ingresarDatos(Control controles) {
            if (boolEditable)
            {
                System.DateTime? dtetFecha = Convert.ToDateTime(ctrlFechaInicio.Text);
                int intCombo = Convert.ToInt32(((ComboBox)ctrlCmbRecurrencia).SelectedValue.ToString());

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BDAlcancias.Insert_Alcancias2(ctrlID.Text, ctrlDireccion.Text, ctrlLocal.Text, dtetFecha, intCombo, ctrlTelefono.Text);
                        MessageBox.Show("Ingresado");
                        ctrlID.Text = "";
                        ctrlDireccion.Text = "";
                        ctrlLocal.Text = "";
                        ctrlTelefono.Text = "";
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
            System.DateTime? dtetFecha = Convert.ToDateTime(ctrlFechaInicio.Text);
            int intCombo = Convert.ToInt32(((ComboBox)ctrlCmbRecurrencia).SelectedValue.ToString());

            if (!(Herramientas.HayCamposNull(controles)))
            {
                try
                {
                    BDAlcancias.Update_alcancias(ctrlID.Text, ctrlDireccion.Text, ctrlLocal.Text, dtetFecha, intCombo, ctrlTelefono.Text); 
                    MessageBox.Show("Actualizado");
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

        public void DeleteDatos(string ID) {
            try
            {
                BDAlcancias.Delete_Alcancias(ID);
            }
            catch (SqlException) {
                MessageBox.Show("No hay conexion con la base de datos");
            }
        }

        public void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_AlcanciasTableAdapter tblAdptEmp = new BuscarSelect_AlcanciasTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Alcancias, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Alcancias, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_Alcancias, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Alcancias.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Dirección";
            dtgrdvw.Columns[2].HeaderText = "Local";
            dtgrdvw.Columns[3].HeaderText = "Teléfono";
            dtgrdvw.Columns[4].HeaderText = "Fecha";
            dtgrdvw.Columns[5].HeaderText = "Recurrencia";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles, DataGridViewRow fila) {
            ctrlID.Text = fila.Cells[0].Value.ToString();
            ctrlDireccion.Text = fila.Cells[1].Value.ToString();
            ctrlLocal.Text = fila.Cells[2].Value.ToString();
            ctrlTelefono.Text = fila.Cells[3].Value.ToString();
            ctrlFechaInicio.Text = fila.Cells["Fecha"].Value.ToString();

            try
            {
                this.ValueCombobox = BDAlcancias.GetIDToComboBoxRecur_Alcancias(fila.Cells["Recurrencia"].Value.ToString());
            }
            catch (SqlException) {
                MessageBox.Show("No hay conexion con la base de datos");
            }
        }

        public void FixComboBox(Control controles)
        {
            //invocar en el load de la clase
            if (ValueCombobox != null)
            {
                ((ComboBox)ctrlCmbRecurrencia).SelectedValue = this.ValueCombobox;
                this.ValueCombobox = null;
            }
        }
    }
}
