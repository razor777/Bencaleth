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
    class TipoEmpresa
    {
        //variable para usar la base de datos
        QueriesTableAdapter BDTipoEmpresa = new QueriesTableAdapter();
        //variabbles que representan los controles del formulario
        private Control ctrlID;
        private Control ctrlDescripcion;

        public TipoEmpresa(Control ctrlIde,Control ctrlDes)
        {
            ctrlID = ctrlIde;
            ctrlDescripcion = ctrlDes;
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
                    //aqui se llama al procedimiento para ingresar registros a la base de datos
                    BDTipoEmpresa.Insert_TipoEmpresa(ctrlID.Text,ctrlDescripcion.Text);
                    MessageBox.Show("Ingresado");
                    //limpiamos
                    ctrlID.Text = "";
                    ctrlDescripcion.Text = "";
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
                    //aqui se llama al procedimiento para actualizar registros a la base de datos
                    BDTipoEmpresa.Update_TipoEmpresa(ctrlID.Text, ctrlDescripcion.Text);
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
        //recibimos el ID del objeto a borrar
        public void DeleteDatos(string ID)
        {
            try
            {
                BDTipoEmpresa.Delete_TipoEmpresa(ID);
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
            //accedemos a una funcion que devuelve un select de tipo de empresas
            BencalethDataSetTableAdapters.BuscarSelect_TipoEmpresaTableAdapter tblAdptEmp = new BuscarSelect_TipoEmpresaTableAdapter();
            //identificamos si esta buscando
            if (!(string.IsNullOrEmpty(txtbBuscado.Text)))
            {
                //revisamos que esta buscando, el if es para si es el ID
                if (((RadioButton)txtbBuscado.Parent.Controls["rdbtnID"]).Checked)
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_TipoEmpresa, txtbBuscado.Text, null);
                }
                else
                {
                    tblAdptEmp.Fill(dtset.BuscarSelect_TipoEmpresa, null, txtbBuscado.Text);
                }
            }
            else
            {
                tblAdptEmp.Fill(dtset.BuscarSelect_TipoEmpresa, null, null);
            }
            //se lo mandamos y estilisamos las columnas a mostrar
            dtgrdvw.DataSource = dtset.BuscarSelect_TipoEmpresa.DefaultView;
            dtgrdvw.Columns[0].HeaderText = "Código Identificador";
            dtgrdvw.Columns[1].HeaderText = "Descripción";
            dtgrdvw.Update();
        }
        //Preparamos los datos a establecer en el formulario
        //la variable controles es para cualquier control del formulario
        //la variable fila es para usar los datos de la fila seleccionada del formulario de mantenimiento
        public void ConseguirDatosToUpdate(DataGridViewRow fila)
        {
            ctrlID.Text = fila.Cells[0].Value.ToString();
            ctrlDescripcion.Text = fila.Cells[1].Value.ToString();
        }
    }
}
