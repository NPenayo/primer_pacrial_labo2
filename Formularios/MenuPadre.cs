using Entidades;
using System.Windows.Forms;


namespace Formularios
{
    public partial class MenuPadre : Form
    {
        public MenuPadre()
        {
            InitializeComponent();
        }
        public MenuPadre(Empleado empleado) : this()
        {

        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
