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
    public partial class ModalInventario : Form
    {
        private Componente componente;
        private ModalInventario()
        {
            InitializeComponent();

        }
        public ModalInventario(Componente componente) : this()
        {
            this.componente = componente;
            Mostrar();
            this.ShowDialog();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacio");
            }
            else if (!int.TryParse(txtStock.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("Stock invalido");

            }
            else
            {
                Componente nuevo = new(cantidad, txtNombre.Text);
                if (!Inventario.AgregarComponente(nuevo))
                {
                    componente.Stock = cantidad;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Mostrar()
        {
            if (componente is not null)
            {
                txtNombre.Text = componente.Nombre;
                txtStock.Text = componente.Stock.ToString();
            }

        }
    }
}
