using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    public class Voluntarios:Personas
    {
        QueriesTableAdapter BDVoluntario = new QueriesTableAdapter();

        private bool boolEditable;

        private Control ctrlFechaInicio;
        private Control ctrlEmail;
        private Control ctrlTelefono;
        private Control ctrlInformacion;
        private Control ctrlHoras;

        public Voluntarios(Control ctrlIden, Control ctrlNom, Control ctrlApell, Control ctrlFechNaci, Control ctrlIni, Control ctrlGenM, Control ctrlGenF, Control ctrlCor, Control ctrlTel, Control ctrlInfo, Control ctrlHor)
        {
            ctrlID = ctrlIden;
            ctrlNombre = ctrlNom;
            ctrlApellido = ctrlApell;
            ctrlFechaNacimiento = ctrlFechNaci;
            ctrlGeneroM = ctrlGenM;
            ctrlGeneroF = ctrlGenF;
            ctrlEmail = ctrlCor;
            ctrlTelefono = ctrlTel;
            ctrlFechaInicio = ctrlIni;
            ctrlInformacion = ctrlInfo;
            ctrlHoras = ctrlHor;
            boolEditable = true;
        }

        public Voluntarios() {
            boolEditable = false;
        }

        public override void ingresarDatos(Control controles) {
            if (boolEditable)
            {
                string strGenero = Herramientas.determinarCualRadioButtonEsGenero(controles);
                System.DateTime? Fecha_Nacimiento = Convert.ToDateTime(ctrlFechaNacimiento.Text);
                System.DateTime? Fecha_Inicio = Convert.ToDateTime(ctrlFechaInicio.Text);

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BDVoluntario.Insert2_Voluntarios(ctrlID.Text, ctrlNombre.Text, ctrlApellido.Text, strGenero, Fecha_Nacimiento, Fecha_Inicio, ctrlTelefono.Text, ctrlEmail.Text, ctrlHoras.Text, ctrlInformacion.Text);
                        MessageBox.Show("Ingresado");

                        ctrlID.Text = "";
                        ctrlNombre.Text = "";
                        ctrlApellido.Text = "";
                        ctrlTelefono.Text = "";
                        ctrlEmail.Text = "";
                        ctrlHoras.Text = "";
                        ctrlInformacion.Text = "";
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
                System.DateTime? Fecha_Nacimiento = Convert.ToDateTime(ctrlFechaNacimiento.Text);
                System.DateTime? Fecha_Inicio = Convert.ToDateTime(ctrlFechaInicio.Text);

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BDVoluntario.Update2_Voluntarios(ctrlID.Text, ctrlNombre.Text, ctrlApellido.Text, strGenero, Fecha_Nacimiento, Fecha_Inicio, ctrlTelefono.Text, ctrlEmail.Text, ctrlHoras.Text, ctrlInformacion.Text);
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
                BDVoluntario.Delete_Voluntarios(ID);
            }
        }

        public override void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_VoluntariosTableAdapter tblAdptEmp = new BuscarSelect_VoluntariosTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Voluntarios, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Voluntarios, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_Voluntarios, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Voluntarios.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Apellidos";
            dtgrdvw.Columns[3].HeaderText = "Género";
            dtgrdvw.Columns[4].HeaderText = "Fecha de Nacimiento";
            dtgrdvw.Columns[5].HeaderText = "Fecha de Inicio";
            dtgrdvw.Columns[6].HeaderText = "Teléfono";
            dtgrdvw.Columns[7].HeaderText = "Correo Electrónico";
            dtgrdvw.Columns[8].HeaderText = "Horas";
            dtgrdvw.Columns[9].HeaderText = "Información";
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

            ctrlTelefono.Text = fila.Cells[6].Value.ToString();
            ctrlEmail.Text = fila.Cells[7].Value.ToString();
            ctrlHoras.Text = fila.Cells[8].Value.ToString();
            ctrlInformacion.Text = fila.Cells[9].Value.ToString();
        }

        public void PagarMensualidad(Control ctrls)
        {
            try
            {
                BDVoluntario.setVoluntarioPago(ctrlID.Text, 100);
                MessageBox.Show("Se ingreso el registro de pago");
            }
            catch (SqlException) {
                MessageBox.Show("No hay conexion con la base de datos");
            }
        }
    }
}
