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

        public static bool AgregarComponente(Componente comp)
        {
            if (componentes.Contains(comp))
            {
                return false;
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
        public static List<Componente> Componentes
        {
            get
            {
                return componentes;
            }
        }

    }
}
