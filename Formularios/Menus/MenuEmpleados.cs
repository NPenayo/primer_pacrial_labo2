using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class MenuEmpleados : MenuPadre
    {
        public MenuEmpleados():base()
        {
            InitializeComponent();
            btnInventario.Visible = false;
            btnUsuarios.Visible = false;  
            pbInventario.Visible = false;
            pbUsuarios.Visible = false;
            panelNavMenu.BackColor = Color.FromArgb(96, 171, 144);
        }
    }
}
