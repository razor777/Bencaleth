using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PantallaInicio
{
    public abstract class Personas
    {

        protected Control ctrlID;
        protected Control ctrlNombre;
        protected Control ctrlApellido;
        protected Control ctrlFechaNacimiento;
        protected Control ctrlGeneroM;
        protected Control ctrlGeneroF;

        public abstract void ingresarDatos(Control controles);
        public abstract void actualizarDatos(Control controles);
        public abstract void DeleteDatos(string ID);
        public abstract void mostrarDatos(DataGridView dtgrdvw,TextBox txtbBuscado);
    }
}
