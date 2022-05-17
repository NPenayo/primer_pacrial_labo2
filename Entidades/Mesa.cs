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
        private decimal total;
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
        private Mesa()
        {
            pedidos = new List<Pedido>();
        }
        public Mesa(ETipo tipo) : this()
        {
            Tipo = tipo;
        }

        public List<Pedido> Pedidos { get { return pedidos; } }
        public bool Disponible { get { return disponible; } set { disponible = value; } }
        public decimal Total { get { return total; } }
        public ETipo Tipo { get { return tipoMesa; } set { tipoMesa = value; } }

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
        public decimal CalcularTotal(MedioDePago medioDePago, bool estacionamiento)
        {
            decimal total = 0;
            decimal parcial = 0;
            foreach (Pedido pedido in pedidos)
            {
                foreach (KeyValuePair<Item, int> item in pedido.Items)
                {
                    parcial += item.Value * item.Key.Precio;
                }
            }
            total = parcial;
            if (medioDePago is MedioDePago.Credito)
            {
                total = parcial + parcial + (10 / 100 * parcial);
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