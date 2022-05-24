using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa
    {
        private List<Pedido> pedidos;
        private bool disponible;
        private ETipo tipoMesa;
        private MedioDePago medioPago;
        public enum ETipo
        {
            Mesa,
            Barra
        }
        public enum MedioDePago
        {
            Debito,
            Credito,
            Efectivo
        }
        public Mesa(ETipo tipo)
        {
            pedidos = new List<Pedido>();
            Tipo = tipo;
            Disponible = true;
        }

        public List<Pedido> Pedidos { get { return pedidos; } }
        public bool Disponible { get { return disponible; } set { disponible = value; } }
        public ETipo Tipo { get { return tipoMesa; } set { tipoMesa = value; } }
        public MedioDePago MedioPago { get {return medioPago; } set { medioPago = value; } }

        public bool AbrirMesa()
        {
            if (Disponible)
            {
                Disponible = false;
                return Disponible;
            }
            return Disponible;
        }
        private bool CerrarMesa()
        {
            if (!Disponible)
            {
                Disponible = true;
                Pedidos.Clear();
                return Disponible;
            }
            return Disponible;
        }
        public void CargarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
        public void CancelarPedido(Pedido pedido)
        {
            foreach (Pedido ordenado in Pedidos)
            {
                if (ordenado == pedido)
                {
                    Pedidos.Remove(ordenado);
                }
            }
        }
        public decimal CalcularTotal(bool estacionamiento)
        {
            decimal total = 0;
            decimal parcial = 0;
            foreach (Pedido pedido in pedidos)
            {
                parcial += pedido.CalcularParcial();
            }
            total = parcial;
            if (MedioPago is MedioDePago.Credito)
            {
                total = total + (10*total/100);
            }
            if (estacionamiento)
            {
                total += 500;
            }
            CerrarMesa();
            return total;
        }

    }
}