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
            lvEmpleados.Items.Clear();
            foreach (Empleado empleado in Mock.Empleados)
            {
                string[] fila = { empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.FechaDeNacimiento,empleado.GetType().Name.ToString()};
                ListViewItem item = new ListViewItem(fila);
                lvEmpleados.Items.Add(item);
            }
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            Modales.ModalEmpleado modalEmpleado = new Modales.ModalEmpleado(new Empleado("Nombre", "Apellido", "12345678", "NTO", "PASS"));
            ListarEmpleados();
        }

        private void lvEmpleados_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccionado = lvEmpleados.SelectedItems;
            Empleado empleado = null;
            foreach (ListViewItem item in seleccionado)
            {
                empleado = Empleado.ObtenerPorId(item.SubItems[0].Text);
                break;
            }
            Modales.ModalEmpleado modalEmpleado = new Modales.ModalEmpleado(empleado);
            ListarEmpleados();
        }
    }
}
