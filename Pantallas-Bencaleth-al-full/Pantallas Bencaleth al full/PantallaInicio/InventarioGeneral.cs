using PantallaInicio.BencalethDataSetTableAdapters;
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
    class InventarioGeneral:Inventario
    {
        //variables
        QueriesTableAdapter BDInventario = new QueriesTableAdapter();
        private Control ctrlCmbNombreEmpresa;

        public InventarioGeneral(Control ctrlIdent, Control ctrlDes, Control ctrlCant, Control ctrlNomEmp)
        {
            ctrlCantidad = ctrlCant;
            ctrlCmbNombreEmpresa = ctrlNomEmp;
            ctrlID = ctrlIdent;
            ctrlDescripcion = ctrlDes;
            boolEditable = true;
        }

        public InventarioGeneral() {
            boolEditable = false;
        }

        //funciones
        public override void IngresarProducto(Control lisControls) {
            if (boolEditable)
            {
                try
                {
                    BDInventario.Insert_inven_Donaciones(Convert.ToInt32(ctrlID.Text), ctrlDescripcion.Text, ctrlCantidad.Text, ((ComboBox)ctrlCmbNombreEmpresa).SelectedValue.ToString());
                    MessageBox.Show("Ingresado");

                    ((TextBox)ctrlID).Clear();
                    ((TextBox)ctrlDescripcion).Clear();
                    ((TextBox)ctrlCantidad).Clear();
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

        public override void mostrarInventario(DataGridView dtgrdvw) {
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();

            BencalethDataSet dtset = new BencalethDataSet();
            BencalethDataSetTableAdapters.SelectDonacionesTableAdapter tblAdptEmp = new SelectDonacionesTableAdapter();

            tblAdptEmp.Fill(dtset.SelectDonaciones);

            dtgrdvw.DataSource = dtset.SelectDonaciones.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "ID";
            dtgrdvw.Columns[1].HeaderText = "Descripción";
            dtgrdvw.Columns[2].HeaderText = "Cantidad";
            dtgrdvw.Columns[3].HeaderText = "Donante";
            dtgrdvw.Update();
        }
    }
}
