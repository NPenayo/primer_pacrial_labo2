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

        private Pedido()
        {
            items = new Dictionary<Item, int>();
            ultimoPedido++;
        }
        public Pedido(Empleado empleado, Dictionary<Item, int> items, Mesa mesa) : this()
        {
            Empleado = empleado;
            Items = items;
            Id = EstablecerId(mesa);
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
        public string EstablecerId(Mesa mesa)
        {
            int nroMesa = 0;
            StringBuilder sb = new StringBuilder();
            string tipoMesa = mesa.Tipo.ToString();
            sb.AppendLine($"{tipoMesa.Substring(0, 3)}");
            foreach (KeyValuePair<int, Mesa> mesas in Salon.Mesas)
            {
                if (mesas.Value == mesa)
                {
                    nroMesa = mesas.Key;
                }
            }
            sb.Append($"{nroMesa}");
            sb.Append($"{ultimoPedido++}");
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
        public void EditarItem(Item item, int cantidad)
        {
            if (Items.ContainsKey(item))
            {
                Items[item] = cantidad;

            }
        }

    }
}
