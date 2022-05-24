using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Item
    {
        private string id;
        private string nombre;
        private decimal precio;
        private bool disponible;
        private List<Componente> listaComponentes;
        private ETipo tipoProducto;
        public enum ETipo
        {
            Comida,
            Bebida
        }
        private Item()
        {
            listaComponentes = new List<Componente>();
            precio = 0;
        }
        public Item(string nombre, decimal precio,ETipo tipo) : this()
        {
            Nombre = nombre;
            Precio = precio;
            tipoProducto = tipo;
            id = GenerarId();
        }
        public string Id { get { return id; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public decimal Precio { get { return precio; } set { if (value > 0) { precio = value; } } }
        public bool Disponible { get { return disponible; } }
        public List<Componente> Receta { get { return listaComponentes; } }
        public ETipo TipoProducto { get { return tipoProducto; } }

        private string GenerarId()
        {
            char[] letras = nombre.ToCharArray();
            string id = $"{letras[0]}{letras[2]}{letras[3]}";
            return id;

        }
        public bool EstaDisponible()
        {
            this.disponible = true;
            foreach (Componente comp in Receta)
            {
                if (comp.Stock == 0)
                {
                    this.disponible = false;
                }
            }
            return Disponible;
        }
        public void AgregarReceta(params Componente[] componentes)
        {
            foreach (Componente comp in componentes)
            {
                listaComponentes.Add(comp);
            }
        }
        public static Item ObtenerPorNombre(string nombre)
        {
            foreach (Item item in Inventario.Items)
            {
                if (nombre == item.Nombre)
                {
                    return item;
                }
            }
            return null;
        }
        public static Item ObtenerPorId(string id)
        {
            foreach (Item item in Inventario.Items)
            {
                if (id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }
        public static bool operator -(Item item, int cantidad)
        {
            foreach (Componente comp in item.Receta)
            {
                Inventario.RestarStock(comp, cantidad);
                if (comp.Stock < 0)
                {
                    Inventario.SumarStock(comp, cantidad);
                    return false;
                }
            }

            return true;
        }
    }
}
