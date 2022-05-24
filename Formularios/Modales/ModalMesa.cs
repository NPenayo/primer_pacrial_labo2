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
    public partial class ModalMesa : Form
    {
        private KeyValuePair<int, Mesa> mesa;
        private ModalMesa()
        {
            InitializeComponent();

        }
        public ModalMesa(KeyValuePair<int, Mesa> mesa) : this()
        {
            this.mesa = mesa;
            lblNroMesa.Text = $"Mesa Nro.: {this.mesa.Key}";
            this.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModalMesa_Load(object sender, EventArgs e)
        {
            ActualizarEstado();
            ListarPedidos();
        }

        private void btnAbrirMesa_Click(object sender, EventArgs e)
        {
            this.mesa.Value.Disponible = false;
            ActualizarEstado();
        }

        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            RadioButton rb = null;
            if (lvPedidos.Items.Count != 0)
            {

                if (rbCredito.Checked)
                {
                    rb = rbCredito;
                    mesa.Value.MedioPago = Mesa.MedioDePago.Credito;

                }
                if (rbDebito.Checked)
                {
                    rb = rbDebito;
                    mesa.Value.MedioPago = Mesa.MedioDePago.Debito;
                }
                if (rbEfectivo.Checked)
                {
                    rb = rbEfectivo;
                    mesa.Value.MedioPago = Mesa.MedioDePago.Efectivo;
                }

                if (rb is not null)
                {

                    if (cbEstacionamiento.Checked)
                    {


                        MessageBox.Show($"Total a pagar: ${mesa.Value.CalcularTotal(true)}");
                        this.DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show($"Total a pagar: ${mesa.Value.CalcularTotal(false)}");
                        this.DialogResult = DialogResult.OK;

                    }
                }
                else
                {
                    MessageBox.Show("Se debe seleccionar un método de pago");
                }
            }
            else
            {
                mesa.Value.CalcularTotal(false);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Pedido nuevo = new Pedido(Program.logueado, this.mesa.Value);
            ModalPedido nuevoPedido = new ModalPedido(nuevo);
            if (nuevoPedido.DialogResult == DialogResult.OK)
            {
                mesa.Value.CargarPedido(nuevo);
                ListarPedidos();
            }
        }

        private void lvPedidos_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection seleccionado = lvPedidos.SelectedItems;
            foreach (ListViewItem item in seleccionado)
            {
                foreach (Pedido pedido in mesa.Value.Pedidos)
                {
                    if (pedido.Id == item.SubItems[0].Text)
                    {
                        ModalPedido nuevoPedido = new ModalPedido(pedido);
                        if (nuevoPedido.DialogResult == DialogResult.OK)
                        {
                            ListarPedidos();
                        }
                    }
                }
                break;
            }
        }
        private void ListarPedidos()
        {
            decimal parcial = 0;
            lvPedidos.Items.Clear();
            foreach (Pedido pedido in this.mesa.Value.Pedidos)
            {
                string[] fila = { pedido.Id, pedido.Empleado.Id, pedido.CalcularParcial().ToString() };
                ListViewItem item = new ListViewItem(fila);
                lvPedidos.Items.Add(item);
                parcial += pedido.CalcularParcial();
            }
            lblParcial.Text = $"Gastado: $ {parcial}";
        }
        private void ActualizarEstado()
        {
            btnAgregarPedido.Visible = false;
            if (this.mesa.Value.Disponible)
            {
                btnAbrirMesa.Visible = true;
                btnCerrarMesa.Visible = false;

            }
            else
            {
                btnAbrirMesa.Visible = false;
                btnCerrarMesa.Visible = true;
                btnAgregarPedido.Visible = true;
            }
        }
    }
}
