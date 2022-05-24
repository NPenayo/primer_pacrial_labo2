using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Salon
    {
        private static Dictionary<int, Mesa> mesas = new Dictionary<int, Mesa>();
        private static int capacidad;

        public static int Capacidad { get { return capacidad; } private set { if (value > 0 && value < int.MaxValue) { capacidad = value; } else { capacidad = 0; } } }
        public static Dictionary<int, Mesa> Mesas{get{return mesas;}}

        public static void AgregarMesa(int numeroMesa, Mesa mesa)
        {
            if (!mesas.ContainsKey(numeroMesa))
            {
                mesas.Add(numeroMesa, mesa);
            }
        }
        public static void EliminarMesa(int numeroMesa)
        {
            if (mesas.ContainsKey(numeroMesa))
            {
                mesas.Remove(numeroMesa);
            }
        }
    }
}
