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
    public partial class ModalCantidad : Form
    {
        private Item item;
        private ModalCantidad()
        {
            InitializeComponent();

        }
        public ModalCantidad(Item item) : this()
        {
            this.item = item;
            this.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                if (cantidad >= 0 && item -cantidad)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cantidad invalida");

                }
            }
            else
            {
                MessageBox.Show("Cantidad invalida");
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
