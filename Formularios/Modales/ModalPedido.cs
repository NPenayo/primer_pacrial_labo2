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

namespace Formularios.Modales
{
    public partial class ModalPedido : Form
    {
        private Pedido pedido;
        private ModalPedido()
        {
            InitializeComponent();

        }
        public ModalPedido(Pedido pedido) : this()
        {
            this.pedido = pedido;
            ListarInventario();
            ListarPedido();
            if (pedido.Items.Count != 0)
            {
                lvPedido.Enabled = false;
                lvInventario.Enabled = false;
            }
            this.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void ListarInventario()
        {
            lvInventario.Items.Clear();
            if (pedido.TipoMesa == Mesa.ETipo.Barra)
            {
                foreach (Item producto in Inventario.Items)
                {
                    string[] fila = { producto.Id, producto.Nombre, producto.Precio.ToString() };
                    if (producto.TipoProducto == Item.ETipo.Bebida)
                    {
                        ListViewItem item = new ListViewItem(fila);
                        lvInventario.Items.Add(item);
                        if (!producto.EstaDisponible())
                        {
                            item.ForeColor = Color.DarkGray;
                        }
                    }

                }
            }
            else
            {
                foreach (Item producto in Inventario.Items)
                {
                    string[] fila = { producto.Id, producto.Nombre, producto.Precio.ToString() };
                    ListViewItem item = new ListViewItem(fila);
                    lvInventario.Items.Add(item);
                    if (!producto.EstaDisponible())
                    {
                        item.ForeColor = Color.DarkGray;
                    }
                }

            }
        }
        private void ListarPedido()
        {
            lvPedido.Items.Clear();
            foreach (KeyValuePair<Item, int> producto in pedido.Items)
            {
                string[] fila = { producto.Key.Id, producto.Key.Nombre, producto.Value.ToString(), (producto.Key.Precio * producto.Value).ToString() };
                ListViewItem item = new ListViewItem(fila);
                lvPedido.Items.Add(item);
            }

        }
        private void lvInventario_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccionado = lvInventario.SelectedItems;
            Item producto = null;
            foreach (ListViewItem item in seleccionado)
            {
                producto = Item.ObtenerPorId(item.SubItems[0].Text);
                break;
            }
            if (producto.EstaDisponible())
            {

                ModalCantidad modalCantidad = new ModalCantidad(producto);
                int.TryParse(modalCantidad.txtCantidad.Text, out int cantidad);
                if (modalCantidad.DialogResult == DialogResult.OK && producto is not null)
                {

                    pedido.AgregarItem(producto, cantidad);

                }
                if (modalCantidad.DialogResult == DialogResult.Cancel)
                {
                    pedido.EliminarItem(producto);
                    foreach (Componente item in producto.Receta)
                    {
                        Inventario.SumarStock(item, cantidad);
                    }
                }
            }
            else
            {
                MessageBox.Show("Producto sin stock");
            }
            ListarPedido();
            ListarInventario();
        }
        private void lvPedido_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccionado = lvPedido.SelectedItems;
            Item producto = null;
            int cantidad = 0;
            foreach (ListViewItem item in seleccionado)
            {
                producto = Item.ObtenerPorId(item.SubItems[0].Text);
                cantidad = int.Parse(item.SubItems[2].Text);
                break;
            }

            pedido.EliminarItem(producto);
            foreach (Componente item in producto.Receta)
            {
                Inventario.SumarStock(item, cantidad);
            }

            ListarPedido();
            ListarInventario();
        }
    }
}
