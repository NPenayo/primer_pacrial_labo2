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
    public partial class MenuAdmin : MenuPadre
    {
        public MenuAdmin():base()
        {
            InitializeComponent();
            panelNavMenu.BackColor = Color.FromArgb(184, 151, 144);

        }
    }
}
