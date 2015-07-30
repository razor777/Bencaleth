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
    class TipoCargo
    {
        //variable para usar la base de datos
        QueriesTableAdapter BDTipoCargo = new QueriesTableAdapter();
        //variabbles que representan los controles del formulario
        private Control ctrlID;
        private Control ctrlDescripcion;
        private Control ctrlSalario;

        public TipoCargo(Control ctrlIde, Control ctrlDes, Control ctrlSal)
        {
            ctrlID = ctrlIde;
            ctrlDescripcion = ctrlDes;
            ctrlSalario = ctrlSal;
        }
        //recibimos un parametro que seria cualquier control del formulario
        //para revisar si son nulls los textbox de su formulario
        //funcion para ingresar datos nuevos en la base de datos
        public void ingresarDatos(Control controles)
        {

            if (!Herramientas.HayCamposNull(controles))
            {
                try
                {
                    decimal? dcmSalario = Convert.ToDecimal(ctrlSalario.Text);
                    //aqui se llama al procedimiento para ingresar registros a la base de datos
                    BDTipoCargo.Insert_TipoCargo(ctrlID.Text, ctrlDescripcion.Text, dcmSalario);
                    MessageBox.Show("Ingresado");
                    //limpiamos
                    ctrlID.Text = "";
                    ctrlDescripcion.Text = "";
                    ctrlSalario.Text = "";
                }
                catch (SqlException e)
                {
                    switch (e.Number)
                    {
                        case 2627:
                            MessageBox.Show("Código Identificador ya existente");
                            break;
                        default:
                            MessageBox.Show("No hay conexion con la base de datos");
                            break;
                    }
                }             
            }
        }
        //recibimos un parametro que seria cualquier control del formulario
        //es un metodo usado para actualizar la base de datos
        public void actualizarDatos(Control controles)
        {
            if (!(Herramientas.HayCamposNull(controles)))
            {
                try
                {
                    decimal? dcmSalario = Convert.ToDecimal(ctrlSalario.Text);
                    //aqui se llama al procedimiento para actualizar registros a la base de datos
                    BDTipoCargo.Update_TipoCargo(ctrlID.Text, ctrlDescripcion.Text, dcmSalario);
                    MessageBox.Show("Actualizado");
                }
                catch (SqlException e)
                {
                    switch (e.Number)
                    {
                        case 2627:
                            MessageBox.Show("Código Identificador ya existente");
                            break;
                        default:
                            MessageBox.Show("No hay conexion con la base de datos");
                            break;
                    }
                }
            }
        }
        //recibimos el ID del objeto a borrar
        public void DeleteDatos(string ID)
        {
            try
            {
                BDTipoCargo.Delete_TipoCargo(ID);
            }
            catch (SqlException e)
            {
                switch (e.Number)
                {
                    case 2627:
                        MessageBox.Show("Código Identificador ya existente");
                        break;
                    case 547:
                        MessageBox.Show("Registro usado por otra tabla de datos");
                        break;
                    default:
                        MessageBox.Show("No hay conexion con la base de datos");
                        break;
                }
            }
        }
        //para mostrar los datos en los datagridview del mantenimiento
        //recibimos los parametros dtgrdvw que seria el del formulario de mantenimiento
        //y txtbBuscado que seria un valor buscado
        public void mostrarDatos(DataGridView dtgrdvw, TextBox txtbBuscado)
        {
            //despejamos el datagridview
            dtgrdvw.DataSource = null;
            dtgrdvw.Update();
            //accedemos al dataset 
            BencalethDataSet dtset = new BencalethDataSet();
            //accedemos a una funcion que devuelve un select de tipo de cargos
            BencalethDataSetTableAdapters.BuscarSelect_TipoCargoTableAdapter tblAdptEmp = new BuscarSelect_TipoCargoTableAdapter();
            //identificamos si esta buscando
            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                //revisamos que esta buscando, el if es para si es el ID
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_TipoCargo, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_TipoCargo, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_TipoCargo, null, null);
            }
            //se lo mandamos y estilisamos las columnas a mostrar
            dtgrdvw.DataSource = dtset.BuscarSelect_TipoCargo.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "Código Identificador";
            dtgrdvw.Columns[1].HeaderText = "Descripción";
            dtgrdvw.Columns[2].HeaderText = "Salario";
            dtgrdvw.Update();
        }
        //Preparamos los datos a establecer en el formulario
        //la variable controles es para cualquier control del formulario
        //la variable fila es para usar los datos de la fila seleccionada del formulario de mantenimiento
        public void ConseguirDatosToUpdate(DataGridViewRow fila)
        {
            ctrlID.Text = fila.Cells[0].Value.ToString();
            ctrlDescripcion.Text = fila.Cells[1].Value.ToString();
            //revisamos si es null 
            if (fila.Cells[2].Value != DBNull.Value) {
                Decimal dclMonto = Convert.ToDecimal(fila.Cells[2].Value);
                ctrlSalario.Text = Convert.ToInt64(dclMonto).ToString();
            }
        }
    }
}
