using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Mock
    {
        private static List<Empleado> empleados;
        private static Dictionary<int, Mesa> mesas;
        private static List<Pedido> pedidos;
        private static Dictionary<Item, int> items;
        private static List<Componente> componentes;

        public static List<Empleado> Empleados { get { return empleados; } }
        public static Dictionary<int, Mesa> Mesas { get { return mesas; } }
        public static List<Pedido> Pedidos { get { return pedidos; } }
        public static Dictionary<Item, int> Items { get { return items; } }
        public static List<Componente> Componentes { get { return componentes; } }

        public static void Iniciar()
        {
            CargarEmpleados();
            CargarPedidos();
            CargarMesas();
        }
        public static void CargarEmpleados()
        {
            empleados = new List<Empleado>();
            empleados.Add(new Empleado("Robert", "Perez", "37456789", "26/05/1993", "Pepito2568"));
            empleados.Add(new Empleado("Sandra", "Saraza", "39456879", "06/06/1990", "AguanteBoquita9878"));
            empleados.Add(new Administrador("Admin", "Istrador", "04469135", "09/05/1810", "VivaLaPep4"));

        }
        public static void CargarMesas()
        {
            mesas = new Dictionary<int, Mesa>();
            mesas.Add(01, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(02, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(03, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(04, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(05, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(06, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(07, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(08, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(09, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(10, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(11, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(12, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(13, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(14, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(15, new Mesa(Mesa.ETipo.Mesa));
            mesas.Add(16, new Mesa(Mesa.ETipo.Barra));
            mesas.Add(17, new Mesa(Mesa.ETipo.Barra));
            mesas.Add(18, new Mesa(Mesa.ETipo.Barra));
            mesas.Add(19, new Mesa(Mesa.ETipo.Barra));
            mesas.Add(20, new Mesa(Mesa.ETipo.Barra));
        }
        public static void CargarPedidos()
        {
            pedidos = new List<Pedido>();
        }
        public static Administrador LoginAdmin()
        {
            foreach (Empleado item in empleados)
            {
                if (item is Administrador)
                {
                    return (Administrador)item;
                }
            }
            return new Administrador("Admin", "Istrador", "04469135", "09/05/1810", "VivaLaPep4");
        }
        public static Empleado LoginEmpleado()
        {
            foreach (Empleado item in empleados)
            {
                if (item is not Administrador)
                {
                    return item;
                }
            }
            return new Empleado("Robert", "Perez", "37456789", "26/05/1993", "Pepito2568");
        }

    }
}
