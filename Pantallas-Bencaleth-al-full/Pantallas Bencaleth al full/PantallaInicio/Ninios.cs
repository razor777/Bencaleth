using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    public class Ninios : Personas
    {
        QueriesTableAdapter BDninios = new QueriesTableAdapter();

        private bool boolEditable;
        private object ValueCombobox = null;
        private Control ctrlFechaInicio;
        private Control ctrlResponsables;

        public Ninios(Control ctrlIden, Control ctrlNom, Control ctrlApell, Control ctrlFechNaci, Control ctrlIni, Control ctrlGenM, Control ctrlGenF, Control ctrlRes)
        {
            ctrlID = ctrlIden;
            ctrlNombre = ctrlNom;
            ctrlApellido = ctrlApell;
            ctrlFechaNacimiento = ctrlFechNaci;
            ctrlFechaInicio = ctrlIni;
            ctrlGeneroM = ctrlGenM;
            ctrlGeneroF = ctrlGenF;
            ctrlResponsables = ctrlRes;
            boolEditable = true;
        }

        public Ninios() {
            boolEditable = false;
        }

        public override void ingresarDatos(Control controles)
        {
            if (boolEditable)
            {
                string strGenero = Herramientas.determinarCualRadioButtonEsGenero(controles);
                System.DateTime? naci = Convert.ToDateTime(ctrlFechaNacimiento.Text);
                System.DateTime? ingreso = Convert.ToDateTime(ctrlFechaInicio.Text);
                string strResponsable = ((ComboBox)ctrlResponsables).SelectedValue.ToString();

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BDninios.Insert_Niños(ctrlID.Text, ctrlNombre.Text, ctrlApellido.Text, strGenero, naci, ingreso, strResponsable);
                        MessageBox.Show("Ingresado");

                        ctrlID.Text = "";
                        ctrlNombre.Text = "";
                        ctrlApellido.Text = "";
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

        public override void actualizarDatos(Control controles) {
            if (boolEditable)
            {
                string strGenero = Herramientas.determinarCualRadioButtonEsGenero(controles);
                System.DateTime? naci = Convert.ToDateTime(ctrlFechaNacimiento.Text);
                System.DateTime? ingreso = Convert.ToDateTime(ctrlFechaInicio.Text);
                string strResponsable = ((ComboBox)ctrlResponsables).SelectedValue.ToString();

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BDninios.Update_Ninos2(ctrlID.Text, ctrlNombre.Text, ctrlApellido.Text, strGenero, naci, ingreso, strResponsable);
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
        }

        public override void DeleteDatos(string ID) { 
            if(!string.IsNullOrEmpty(ID)){
                BDninios.Delete_Ninos(ID);
            }
        }

        public override void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado)
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_NinosTableAdapter tblAdptEmp = new BuscarSelect_NinosTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Ninos, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Ninos, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_Ninos, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Ninos.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "Identidad";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Apellidos";
            dtgrdvw.Columns[3].HeaderText = "Género";
            dtgrdvw.Columns[4].HeaderText = "Fecha de Nacimiento";
            dtgrdvw.Columns[5].HeaderText = "Fecha de Ingreso";
            dtgrdvw.Columns[6].HeaderText = "Encargado";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles, DataGridViewRow fila) {
            ctrlID.Text = fila.Cells[0].Value.ToString();
            ctrlNombre.Text = fila.Cells[1].Value.ToString();
            ctrlApellido.Text = fila.Cells[2].Value.ToString();

            if (fila.Cells[3].Value.ToString() == "Femenino")
            {
                ((RadioButton)ctrlGeneroM).Checked = false;
                ((RadioButton)ctrlGeneroF).Checked = true;
            }
            else
            {
                ((RadioButton)ctrlGeneroM).Checked = true;
                ((RadioButton)ctrlGeneroF).Checked = false;
            }

            ctrlFechaNacimiento.Text = fila.Cells[4].Value.ToString();
            ctrlFechaInicio.Text = fila.Cells[5].Value.ToString();

            this.ValueCombobox = BDninios.GetIDToComboBoxResponsable_Empleados(fila.Cells[6].Value.ToString());
        }

        public void FixComboBox(Control controles)
        {
            //invocar en el load de la clase
            if (ValueCombobox != null)
            {
                ((ComboBox)ctrlResponsables).SelectedValue = this.ValueCombobox;
                this.ValueCombobox = null;
            }
        }
    }
}
