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


namespace Formularios
{
    public partial class MenuPadre : Form
    {

        private Form formActivo;
        public MenuPadre()
        {

            InitializeComponent();
            AbrirFormEnCuerpo(new FormSalon());

        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AbrirFormEnCuerpo(Form abrirForm)
        {
            if (formActivo != null && formActivo != abrirForm)
            {
                formActivo.Close();
            }
            formActivo = abrirForm;
            abrirForm.TopLevel = false;
            abrirForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(abrirForm);
            panelMain.Tag = abrirForm;
            abrirForm.BringToFront();
            abrirForm.Show();
        }
        private void btnSalon_Click(object sender, EventArgs e)
        {
            AbrirFormEnCuerpo(new FormSalon());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormEnCuerpo(new Secciones.FormInventario());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnCuerpo(new Secciones.FormUsuarios());
        }
    }
}
