using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Componente
    {
        private int stock;
        private string nombre;
        private string id;

        public Componente(int stock, string nombre)
        {
            this.Stock = stock;
            this.Nombre = nombre;
            id = GenerarId();
        }

        public int Stock { get { return stock; } set { stock = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Id { get { return id; } }


        private string GenerarId()
        {
            string formateado = String.Concat(nombre.Where(c => !Char.IsWhiteSpace(c)));
            char[] letras = formateado.ToCharArray();
            string id = $"{letras[0]}{letras[letras.Length/2]}{letras[letras.Length-1]}";
            return id;
        }
        public static Componente ObtenerPorNombre(string nombre)
        {
            foreach (Componente comp in Inventario.Componentes)
            {
                if (nombre == comp.Nombre)
                {
                    return comp;
                }
            }
            return null;
        }
        public static Componente ObtenerPorId(string id)
        {
            foreach (Componente comp in Inventario.Componentes)
            {
                if (id == comp.Id)
                {
                    return comp;
                }
            }
            return null;
        }
    }
}
