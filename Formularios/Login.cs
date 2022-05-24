using Entidades;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtUser.Text = Mock.LoginAdmin().Id;
            txtPass.Text = "VivaLaPep4";
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            txtUser.Text = Mock.LoginEmpleado().Id;
            txtPass.Text = "Pepito2568";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Usuario y/o Clave incorrectos");
            }
            else
            {
                Program.logueado = Seguridad.Credenciales(Mock.Empleados, txtUser.Text, Seguridad.EncriptarPassword(txtPass.Text));
                if (Program.logueado is not null)
                {
                    if (Program.logueado is Administrador)
                    {
                        MenuAdmin menuadm = new();
                        menuadm.Show();
                    }
                    else
                    {
                        MenuEmpleados menuemp = new();
                        menuemp.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Clave incorrectos");
                }
            }
        }
    }
}
