using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSetTableAdapters;

namespace PantallaInicio
{
    public class Padrinos:Personas
    {
        QueriesTableAdapter BDpadrinos = new QueriesTableAdapter();

        private bool boolEditable;

        private Control ctrlDireccion;
        private Control ctrlFechaInicio;
        private Control ctrlCedulaIdentidad;
        private Control ctrlEmail;
        private Control ctrlMensualidad;
        private Control ctrlTelefono;

        public Padrinos(Control ctrlIden, Control ctrlNom, Control ctrlApell, Control ctrlDir, Control ctrlFechNaci, Control ctrlIni, Control ctrlIdent, Control ctrlGenM, Control ctrlGenF, Control ctrlCor, Control ctrlMen, Control ctrlTel)
        {
            ctrlID = ctrlIden;
            ctrlNombre = ctrlNom;
            ctrlApellido = ctrlApell;
            ctrlDireccion = ctrlDir;
            ctrlFechaNacimiento = ctrlFechNaci;
            ctrlCedulaIdentidad = ctrlIdent;
            ctrlGeneroM = ctrlGenM;
            ctrlGeneroF = ctrlGenF;
            ctrlEmail = ctrlCor;
            ctrlMensualidad = ctrlMen;
            ctrlTelefono = ctrlTel;
            ctrlFechaInicio = ctrlIni;
            boolEditable = true;
        }

        public Padrinos()
        {
            boolEditable = false;
        }

        public override void ingresarDatos(Control controles) {
            if (boolEditable)
            {
                string strGenero = Herramientas.determinarCualRadioButtonEsGenero(controles);
                System.DateTime? Fecha_Nacimiento = Convert.ToDateTime(ctrlFechaNacimiento.Text);
                System.DateTime? Fecha_Inicio = Convert.ToDateTime(ctrlFechaInicio.Text);
                Decimal decMensualidad = string.IsNullOrEmpty(ctrlMensualidad.Text.ToString()) ? 0 : Convert.ToDecimal(ctrlMensualidad.Text.ToString());

                if (!Herramientas.HayCamposNull(controles))
                {
                    try
                    {
                        BDpadrinos.Insert_Padrinos2(ctrlID.Text, ctrlNombre.Text, ctrlApellido.Text, strGenero, Fecha_Nacimiento, Fecha_Inicio, ctrlCedulaIdentidad.Text, ctrlTelefono.Text, ctrlEmail.Text, decMensualidad, ctrlDireccion.Text);

                        MessageBox.Show("Ingresado");

                        ctrlID.Text = "";
                        ctrlNombre.Text = "";
                        ctrlApellido.Text = "";
                        ctrlMensualidad.Text = "";
                        ctrlCedulaIdentidad.Text = "";
                        ctrlEmail.Text = "";
                        ctrlTelefono.Text = "";
                        ctrlDireccion.Text = "";
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
                Decimal decMensualidad = string.IsNullOrEmpty(ctrlMensualidad.Text.ToString()) ? 0 : Convert.ToDecimal(ctrlMensualidad.Text.ToString());

                if (!(Herramientas.HayCamposNull(controles)))
                {
                    try
                    {
                        BDpadrinos.Update_Padrinos2(ctrlID.Text, ctrlNombre.Text, ctrlApellido.Text, strGenero, Fecha_Nacimiento, Fecha_Inicio, ctrlCedulaIdentidad.Text, ctrlTelefono.Text, ctrlEmail.Text, decMensualidad, ctrlDireccion.Text);
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
            try
            {
                if (!string.IsNullOrEmpty(ID))
                {
                    BDpadrinos.Delete_Padrinos2(ID);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No hay conexion con la base de datos");
            }
        }

        public override void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado)
        {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.BuscarSelect_PadrinosTableAdapter tblAdptEmp = new BuscarSelect_PadrinosTableAdapter();

            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Padrinos, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_Padrinos, null, txtbBuscado.Text);
                }
            }
            else {
                tblAdptEmp.Fill(dtset.BuscarSelect_Padrinos, null, null);
            }

            dtgrdvw.DataSource = dtset.BuscarSelect_Padrinos.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Nombre";
            dtgrdvw.Columns[2].HeaderText = "Apellidos";
            dtgrdvw.Columns[3].HeaderText = "Género";
            dtgrdvw.Columns[4].HeaderText = "Dirección";
            dtgrdvw.Columns[5].HeaderText = "Fecha de Nacimiento";
            dtgrdvw.Columns[6].HeaderText = "Fecha de Inicio";
            dtgrdvw.Columns[7].HeaderText = "Identidad";
            dtgrdvw.Columns[8].HeaderText = "Teléfono";
            dtgrdvw.Columns[9].HeaderText = "Correo Electrónico";
            dtgrdvw.Columns[10].HeaderText = "Monto";
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles,DataGridViewRow fila)
        {
            if (boolEditable)
            {
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

                ctrlDireccion.Text = fila.Cells[4].Value.ToString();
                ctrlFechaNacimiento.Text = fila.Cells[5].Value.ToString();
                ctrlFechaInicio.Text = fila.Cells[6].Value.ToString();
                ctrlCedulaIdentidad.Text = fila.Cells[7].Value.ToString();
                ctrlTelefono.Text = fila.Cells[8].Value.ToString();
                ctrlEmail.Text = fila.Cells[9].Value.ToString();

                string monto = fila.Cells["Monto"].Value.ToString();
                monto = monto.Remove(monto.IndexOf(","));
                ctrlMensualidad.Text = monto;
            }
        }

        public void PagarMensualidad(Control ctrls) {
            Decimal decMensualidad = string.IsNullOrEmpty(ctrlMensualidad.Text.ToString()) ? 0 : Convert.ToDecimal(ctrlMensualidad.Text.ToString());
            try
            {
                BDpadrinos.setPadrinoPago(ctrlID.Text, decMensualidad);
                MessageBox.Show("Se ingreso el registro de pago");
            }
            catch (SqlException) {
                MessageBox.Show("No hay conexion con la base de datos");
            }
        }
    }
}
