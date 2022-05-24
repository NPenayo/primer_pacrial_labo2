using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        private static int ultimoPedido = 000;
        private string id;
        private Empleado empleado;
        private Dictionary<Item, int> items;
        private Mesa.ETipo tipoMesa;

        private Pedido()
        {
            items = new Dictionary<Item, int>();
            ultimoPedido++;
        }
        public Pedido(Empleado empleado, Mesa mesa) : this()
        {
            Empleado = empleado;
            Items = items;
            Id = EstablecerId(mesa);
            tipoMesa = mesa.Tipo;
        }
        public Empleado Empleado
        {
            get
            {
                return empleado;
            }
            private set
            {
                empleado = value;
            }
        }
        public Dictionary<Item, int> Items
        {
            get
            {
                return items;
            }
            private set
            {
                items = value;
            }
        }
        public string Id { get { return id; } private set { id = value; } }
        public Mesa.ETipo TipoMesa { get { return tipoMesa; } }
        public string EstablecerId(Mesa mesa)
        {
            int nroMesa = 0;
            StringBuilder sb = new StringBuilder();
            string tipoMesa = mesa.Tipo.ToString();
            sb.AppendLine($"{tipoMesa.Substring(0, 3)}");
            foreach (KeyValuePair<int,Mesa> item in Salon.Mesas)
            {
                if(item.Value == mesa)
                {
                    nroMesa = item.Key;
                }
            }
            sb.Append($"{nroMesa}");
            sb.Append($"{ultimoPedido}");
            return sb.ToString();
        }
        public void AgregarItem(Item item, int cantidad)
        {
            if (!Items.ContainsKey(item))
            {
                Items.Add(item, cantidad);

            }
        }
        public void EliminarItem(Item item)
        {
            Items.Remove(item);
        }
        public decimal CalcularParcial()
        {
            decimal parcial = 0;

            foreach (KeyValuePair<Item, int> item in Items)
            {
                parcial += item.Value * item.Key.Precio;
            }
            return parcial;
        }
    }
}
