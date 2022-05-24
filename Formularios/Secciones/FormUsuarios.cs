using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios.Secciones
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            ListarEmpleados();
        }
        private void ListarEmpleados()
        {
            foreach (Empleado empleado in Mock.Empleados)
            {
                string[] fila = { empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.FechaDeNacimiento,empleado.GetType().Name.ToString()};
                ListViewItem item = new ListViewItem(fila);
                lvEmpleados.Items.Add(item);
            }
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void lvEmpleados_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
