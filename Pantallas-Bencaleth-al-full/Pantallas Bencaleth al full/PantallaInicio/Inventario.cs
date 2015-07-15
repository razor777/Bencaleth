using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaInicio
{
    abstract class Inventario
    {
        //variables
        protected Control ctrlID;
        protected Control ctrlDescripcion;
        protected Control ctrlCantidad;
        protected bool boolEditable;

        //funciones
        public abstract void IngresarProducto(Control lisControls);

        public abstract void mostrarInventario(DataGridView dtgrdvw);
    }
}
