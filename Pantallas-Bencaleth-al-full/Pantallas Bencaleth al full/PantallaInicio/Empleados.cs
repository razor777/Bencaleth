using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    class Empleados:Personas
    {
        QueriesTableAdapter BDPersonas = new QueriesTableAdapter();

        private object ValueCombobox = null;
        private bool boolEditable;

        private Control ctrlDireccion;
        private Control ctrlFechaContratacion;
        private Control ctrlEmail;
        private Control ctrlCargo;
        private Control ctrlTelefono;

        public Empleados() {
            boolEditable = false;
        }

        public Empleados(Control ctrlIden,Control ctrlNom,Control ctrlApell, Control ctrlDir, Control ctrlFechNaci,Control ctrlFechCont,Control ctrlGenM,Control ctrlGenF,Control ctrlCor,Control ctrlCar,Control ctrlTel)
        {
            ctrlID=ctrlIden;
            ctrlNombre=ctrlNom;
            ctrlApellido=ctrlApell;
            ctrlDireccion=ctrlDir;
            ctrlFechaNacimiento=ctrlFechNaci;
            ctrlFechaContratacion=ctrlFechCont;
            ctrlGeneroM=ctrlGenM;
            ctrlGeneroF=ctrlGenF;
            ctrlEmail=ctrlCor;
            ctrlCargo=ctrlCar;
            ctrlTelefono=ctrlTel;
            boolEditable = true;
        }

        public override void ingresarDatos(Control controles) {
            if (boolEditable)
            {
                string strCargo = ((ComboBox)ctrlCargo).SelectedValue.ToString();
                System.DateTime? Naci = Convert.ToDateTime(ctrlFechaNacimiento.Text);
                System.DateTime? Contra = Convert.ToDateTime(ctrlFechaContratacion.Text);
                string strGenero = Herramientas.determinarCualRadioButtonEsGenero(controles);

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BDPersonas.Insert_Empleados(ctrlID.Text, ctrlNombre.Text, ctrlApellido.Text, Naci, Contra, ctrlDireccion.Text, ctrlTelefono.Text, strCargo, ctrlEmail.Text, strGenero);
                        MessageBox.Show("Ingresado");

                        ctrlID.Text = "";
                        ctrlNombre.Text = "";
                        ctrlApellido.Text = "";
                        ctrlDireccion.Text = "";
                        ctrlTelefono.Text = "";
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

        public override void actualizarDatos(Control controles) {
            if (boolEditable)
            {
                string strCargo = ((ComboBox)ctrlCargo).SelectedValue.ToString();
                System.DateTime? Naci = Convert.ToDateTime(ctrlFechaNacimiento.Text);
                System.DateTime? Contra = Convert.ToDateTime(ctrlFechaContratacion.Text);
                string strGenero = Herramientas.determinarCualRadioButtonEsGenero(controles);

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BDPersonas.update_Empleados(ctrlID.Text, ctrlNombre.Text, ctrlApellido.Text, Naci, Contra, ctrlDireccion.Text, ctrlTelefono.Text, strCargo, ctrlEmail.Text, strGenero);
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
                try
                {
                    BDPersonas.Delete_Empleados(ID);
                }
                catch(SqlException) {
                    MessageBox.Show("Actualmente esta encargado a un Niño");
                }
            }
        }

        public override void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_EmpleadosTableAdapter tblAdptEmp = new BuscarSelect_EmpleadosTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Empleados, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Empleados, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_Empleados, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Empleados.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Apellidos";
            dtgrdvw.Columns[3].HeaderText = "Género";
            dtgrdvw.Columns[4].HeaderText = "Fecha de Nacimiento";
            dtgrdvw.Columns[5].HeaderText = "Fecha de Contratación";
            dtgrdvw.Columns[6].HeaderText = "Dirección";
            dtgrdvw.Columns[7].HeaderText = "Teléfono";
            dtgrdvw.Columns[8].HeaderText = "Cargo";
            dtgrdvw.Columns[9].HeaderText = "Correo Electrónico";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles, DataGridViewRow fila) {
            if (boolEditable)
            {
                this.ValueCombobox = BDPersonas.GetIDToComboBoxCargoTipo_Empleados(fila.Cells["Cargo"].Value.ToString());

                ctrlID.Text = fila.Cells["Id"].Value.ToString();
                ctrlNombre.Text = fila.Cells["Nombre"].Value.ToString();
                ctrlApellido.Text = fila.Cells["Apellido"].Value.ToString();
                ctrlDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                ctrlFechaNacimiento.Text = fila.Cells["Fecha_Nacimiento"].Value.ToString();
                ctrlFechaContratacion.Text = fila.Cells["Fecha_Contratacion"].Value.ToString();
                ctrlEmail.Text = fila.Cells["correo"].Value.ToString();
                ctrlTelefono.Text = fila.Cells["Telefono"].Value.ToString();

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
            }
        }

        public void FixComboBox(Control controles)
        {
            //invocar en el load de la clase
            if (ValueCombobox != null)
            {
                ((ComboBox)ctrlCargo).SelectedValue = this.ValueCombobox;
                this.ValueCombobox = null;
            }
        }
    }
}
