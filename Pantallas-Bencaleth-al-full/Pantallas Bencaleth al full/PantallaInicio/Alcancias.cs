using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PantallaInicio.BencalethDataSet1TableAdapters;

namespace PantallaInicio
{
    public class Alcancias
    {
        QueriesTableAdapter BDAlcancias = new QueriesTableAdapter();
        
        private string _IdOrganizacion;
        public string IdOrganizacion
        {
            get
            {
                return _IdOrganizacion;
            }
            set
            {
                _IdOrganizacion = value;
            }
        }

        private int _Codigo_Alcancias;
        public string Codigo_Alcancias
        {
            get
            {
                return _Codigo_Alcancias.ToString();
            }
            set
            {
                if (Herramientas.IsNumeric(value))
                    _Codigo_Alcancias = Convert.ToInt16(value);
            }
        }

        private string _Direccion;
        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                _Direccion = value;
            }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }

        private int _Telefono;
        public string Telefono
        {
            get
            {
                return _Telefono.ToString();
            }
            set
            {
                if (Herramientas.IsNumeric(value))
                    _Telefono = Convert.ToInt16(value);
            }
        }

        private object ValueCombobox=null;

        public void ingresarDatos(Control controles) { 
            this.Codigo_Alcancias=controles.Parent.Controls["textBox1"].Text;
            this.Direccion = controles.Parent.Controls["txtbDir"].Text;
            this.Descripcion = controles.Parent.Controls["txtbDes"].Text;
            System.DateTime? Fecha = Convert.ToDateTime(controles.Parent.Controls["dtpFecha"].Text);
            int combo = Convert.ToInt32(((ComboBox)controles.Parent.Controls["mostrarRecurenciasComboBox"]).SelectedValue.ToString());

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    BDAlcancias.Insert_Alcancias2(this.Codigo_Alcancias, this.Direccion, this.Descripcion, Fecha, combo);
                    MessageBox.Show("Ingresado");
                    controles.Parent.Controls["textBox1"].Text = "";
                    controles.Parent.Controls["txtbDir"].Text = "";
                    controles.Parent.Controls["txtbDes"].Text = "";
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

        public void actualizarDatos(Control controles) {
            this.Codigo_Alcancias = controles.Parent.Controls["textBox1"].Text;
            this.Direccion = controles.Parent.Controls["txtbDir"].Text;
            this.Descripcion = controles.Parent.Controls["txtbDes"].Text;
            System.DateTime? Fecha = Convert.ToDateTime(controles.Parent.Controls["dtpFecha"].Text);
            int combo = Convert.ToInt32(((ComboBox)controles.Parent.Controls["mostrarRecurenciasComboBox"]).SelectedValue.ToString());

            if (!(Herramientas.HayCamposNull(controles)))
            {
                try
                {
                    BDAlcancias.Update_alcancias(this.Codigo_Alcancias, this.Direccion, this.Descripcion, Fecha, combo); 
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
            BDAlcancias.Delete_Alcancias(ID);
        }

        public void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet1 dtset = new BencalethDataSet1();
            BencalethDataSet1TableAdapters.BuscarSelect_AlcanciasTableAdapter tblAdptEmp = new BuscarSelect_AlcanciasTableAdapter();

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
            dtgrdvw.Update();
        }

        public void ConseguirDatosToUpdate(Control controles, DataGridViewRow fila) {
            controles.Parent.Controls["textBox1"].Text = fila.Cells[0].Value.ToString();
            controles.Parent.Controls["txtbDir"].Text = fila.Cells[1].Value.ToString();
            controles.Parent.Controls["txtbDes"].Text = fila.Cells[2].Value.ToString();

            controles.Parent.Controls["dtpFecha"].Text = fila.Cells["Fecha"].Value.ToString();
            
            this.ValueCombobox = BDAlcancias.GetIDToComboBoxRecur_Alcancias(fila.Cells["Recurrencia"].Value.ToString());
        }

        public void FixComboBox(Control controles)
        {
            //invocar en el load de la clase
            if (ValueCombobox != null)
            {
                ((ComboBox)controles.Parent.Controls["mostrarRecurenciasComboBox"]).SelectedValue = this.ValueCombobox;
                this.ValueCombobox = null;
            }
        }
    }
}
