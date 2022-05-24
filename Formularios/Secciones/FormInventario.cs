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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
            ListarInventario();
        }

        private void lvInventario_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccionado = lvInventario.SelectedItems;
            Componente producto = null;
            foreach (ListViewItem item in seleccionado)
            {
                producto = Componente.ObtenerPorId(item.SubItems[0].Text);
                break;
            }
            Modales.ModalInventario modalInventario = new Modales.ModalInventario(producto);
            ListarInventario();
        }
        private void ListarInventario()
        {
            lvInventario.Items.Clear();

            foreach (Componente componente in Inventario.Componentes)
            {
                string[] fila = { componente.Id, componente.Nombre, componente.Stock.ToString() };
                ListViewItem item = new ListViewItem(fila);
                lvInventario.Items.Add(item);
                if (componente.Stock ==0 )
                {
                    item.ForeColor = Color.DarkGray;
                }
                if(componente.Stock > 0  && componente.Stock <= 50)
                {
                    item.ForeColor = Color.FromArgb(225, 249, 133, 44);

                }
            }

        }

        private void btnNuevoItem_Click(object sender, EventArgs e)
        {
            Modales.ModalInventario modalInventario = new Modales.ModalInventario(new Componente(0,"Nombre"));
            ListarInventario();
        }
    }
}
