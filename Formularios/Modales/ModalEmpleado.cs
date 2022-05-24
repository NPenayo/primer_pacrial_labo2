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
    public partial class ModalEmpleado : Form
    {
        Empleado empleado;
        private ModalEmpleado()
        {
            InitializeComponent();
        }
        public ModalEmpleado(Empleado empleado) : this()
        {
            this.empleado = empleado;
            Mostrar();
            this.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) && String.IsNullOrEmpty(txtApellido.Text) && String.IsNullOrEmpty(txtDni.Text) && Seguridad.Dni(txtDni.Text) && String.IsNullOrEmpty(txtNto.Text) && String.IsNullOrEmpty(txtPassword.Text) && Seguridad.FormatoPassword(txtPassword.Text) )
            {
                MessageBox.Show("Los campos no se pueden encontrar vacíos");
            }
            else
            {
                Empleado nuevo = new(txtNombre.Text,txtApellido.Text,txtDni.Text,txtNto.Text,txtPassword.Text);
                if (Mock.Empleados.Contains(nuevo))
                {
                    int indice = Mock.Empleados.IndexOf(nuevo);
                    Mock.Empleados[indice] = nuevo;
                }
                else
                {
                Mock.Empleados.Add(nuevo);

                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void Mostrar()
        {
            if (empleado is not null)
            {
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                txtDni.Text = empleado.Dni;
                txtNto.Text = empleado.FechaDeNacimiento;
                txtPassword.Text = empleado.Password;
            }

        }
    }
}
