using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Item
    {
        private string id;
        private string nombre;
        private List<Componente> componentes;
        private decimal precio;
        private double disponible;
        public enum Tipo
        {
            Comida,
            Bebida
        }
        private Item()
        {
            componentes = new List<Componente>();
            precio = 0;
        }
        public Item(string nombre, decimal precio, List<Componente> componentes) : this()
        {
            Nombre = nombre;
            Precio = precio;
            id = GenerarId();
        }
        public string Id { get { return id; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        internal List<Componente> Componentes { get { return componentes; } }
        public decimal Precio { get { return precio; } set { if (value > 0) { precio = value; } } }
        public double Disponible { get { return disponible; } }

        private string GenerarId()
        {
            char[] letras = nombre.ToCharArray();
            string id = $"{letras[0]}{letras[2]}{letras[3]}";
            return id;

        }
        public bool EstaDisponible()
        {
            foreach (Componente comp in componentes)
            {
                if(comp.Stock == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
