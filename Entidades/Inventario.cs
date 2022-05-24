using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Inventario
    {
        private static List<Componente> componentes = new List<Componente>();
        private static List<Item> items = new List<Item>();

        public static List<Componente> Componentes
        {
            get
            {
                return componentes;
            }
        }
        public static List<Item> Items { get { return items; } }

        public static bool AgregarItem(Item item, params Componente[] componentes)
        {
            if (items.Contains(item))
            {
                return false;
            }
            else
            {
                items.Add(item);
                foreach (Componente comp in componentes)
                {
                    item.AgregarReceta(comp);
                }
                return true;
            }
        }
        public static bool AgregarComponente(Componente comp)
        {
            foreach (Componente item in Componentes)
            {
                if(item.Nombre == comp.Nombre)
                {
                    return false;
                }
            }
            componentes.Add(comp);
            return true;
        }
        public static bool EliminarComponente(Componente comp)
        {
            if (!componentes.Contains(comp))
            {
                return false;
            }
            componentes.Remove(comp);
            return true;
        }
        public static void SumarStock(Componente comp, int cantidad)
        {
            int indice = Componentes.IndexOf(comp);
            Componentes[indice].Stock += cantidad;
        }
        public static void RestarStock(Componente comp, int cantidad)
        {

            int indice = Componentes.IndexOf(comp);
            Componentes[indice].Stock -= cantidad;
        }
    }
}
