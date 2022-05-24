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
using Formularios.Modales;

namespace Formularios
{
    public partial class FormSalon : Form
    {
        private Dictionary<int, Button> btnsMesas;
        public FormSalon()
        {
            InitializeComponent();
            btnsMesas = new Dictionary<int, Button>();
            btnsMesas.Add(1, btnMesa1);
            btnsMesas.Add(2, btnMesa2);
            btnsMesas.Add(3, btnMesa3);
            btnsMesas.Add(4, btnMesa4);
            btnsMesas.Add(5, btnMesa5);
            btnsMesas.Add(6, btnMesa6);
            btnsMesas.Add(7, btnMesa7);
            btnsMesas.Add(8, btnMesa8);
            btnsMesas.Add(9, btnMesa9);
            btnsMesas.Add(10, btnMesa10);
            btnsMesas.Add(11, btnMesa11);
            btnsMesas.Add(12, btnMesa12);
            btnsMesas.Add(13, btnMesa13);
            btnsMesas.Add(14, btnMesa14);
            btnsMesas.Add(15, btnMesa15);
            btnsMesas.Add(16, btnBarra16);
            btnsMesas.Add(17, btnBarra17);
            btnsMesas.Add(18, btnBarra18);
            btnsMesas.Add(19, btnBarra19);
            btnsMesas.Add(20, btnBarra20);

            VerificarEstadoMesas();
        }
        private void VerificarEstadoMesas()
        {
            foreach (KeyValuePair<int, Mesa> mesa in Salon.Mesas)
            {
                if (!mesa.Value.Disponible)
                {
                    btnsMesas[mesa.Key].BackColor = Color.FromArgb(225, 191, 65, 36);
                }
                else
                {
                    btnsMesas[mesa.Key].BackColor = Color.FromArgb(225, 59, 191, 130);

                }
            }
        }

        private void AbrirModalMesa(object sender, MouseEventArgs e)
        {
            foreach (KeyValuePair<int, Mesa> mesa in Salon.Mesas)
            {
                if (mesa.Key == ObtenerBotonPresionado(sender))
                {
                    ModalMesa modalMesa = new ModalMesa(mesa);
                    VerificarEstadoMesas();
                    break;
                }
            }
        }
        private int ObtenerBotonPresionado(object sender)
        {
            foreach (KeyValuePair<int, Button> boton in btnsMesas)
            {
                if (boton.Value == sender)
                {
                    return boton.Key;
                }
            }
            return 0;
        }
    }
}
