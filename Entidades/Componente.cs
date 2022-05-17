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

        private string GenerarId()
        {
            char[] letras = nombre.ToCharArray();
            string id = $"{letras[0]}{letras[2]}";
            return id;
        }
        public static int operator +(Componente comp, int stock)
        {
            return comp.stock + stock;
        }
        public static int operator -(Componente comp,int stock)
        {
            if(comp.stock == 0 || comp.stock - stock < 0)
            {
                return 0;
            }
            else
            {
                return comp.stock - stock;
            }
        }
    }
}
