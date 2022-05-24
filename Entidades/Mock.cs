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

        public static List<Empleado> Empleados { get { return empleados; } }

        public static void Iniciar()
        {
            CargarEmpleados();
            CargarComponentes();
            CargarMesas();
            CargarPedidos();
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
            
            Salon.AgregarMesa(01, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(02, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(03, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(04, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(05, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(06, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(07, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(08, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(09, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(10, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(11, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(12, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(13, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(14, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(15, new Mesa(Mesa.ETipo.Mesa));
            Salon.AgregarMesa(16, new Mesa(Mesa.ETipo.Barra));
            Salon.AgregarMesa(17, new Mesa(Mesa.ETipo.Barra));
            Salon.AgregarMesa(18, new Mesa(Mesa.ETipo.Barra));
            Salon.AgregarMesa(19, new Mesa(Mesa.ETipo.Barra));
            Salon.AgregarMesa(20, new Mesa(Mesa.ETipo.Barra));
        }
        public static void CargarPedidos()
        {
            Salon.Mesas[3].AbrirMesa();
            Salon.Mesas[16].AbrirMesa();
            Pedido p1 = new Pedido(Empleados[0], Salon.Mesas[3]);
            Pedido p2 = new Pedido(Empleados[0], Salon.Mesas[3]);
            Pedido p3 = new Pedido(Empleados[1], Salon.Mesas[16]);
            p1.AgregarItem(Item.ObtenerPorNombre("Hamburguesa Completa"), 1);
            p2.AgregarItem(Item.ObtenerPorNombre("Destornillador"), 1);
            p3.AgregarItem(Item.ObtenerPorNombre("Pinta Stout"), 2);
            Salon.Mesas[3].CargarPedido(p1);
            Salon.Mesas[3].CargarPedido(p2);
            Salon.Mesas[16].CargarPedido(p3);
        }
        private static void CargarItems()
        {
            Item i1 = new Item("Hamburguesa Completa", 750,Item.ETipo.Comida);
            Item i2 = new Item("Coca de 150cc.", 200, Item.ETipo.Bebida);
            Item i3 = new Item("Hamburguesa Vegana", 700, Item.ETipo.Comida);
            Item i4 = new Item("Pinta Scotish", 500,Item.ETipo.Bebida);
            Item i5 = new Item("Pinta Honey", 500, Item.ETipo.Bebida);
            Item i6 = new Item("Pinta Stout", 500, Item.ETipo.Bebida);
            Item i7 = new Item("Destornillador", 550, Item.ETipo.Bebida);
            Item i8 = new Item("Pizza Napolitana", 650,Item.ETipo.Comida);


            i1.AgregarReceta(Componente.ObtenerPorNombre("Pan de hamburguesa"), Componente.ObtenerPorNombre("Medallon de carne"), Componente.ObtenerPorNombre("Queso cheddar"), Componente.ObtenerPorNombre("Panceta"));
            i2.AgregarReceta(Componente.ObtenerPorNombre("Coca Cola"));
            i3.AgregarReceta(Componente.ObtenerPorNombre("Pan de hamburguesa"), Componente.ObtenerPorNombre("Medallon vegano"));
            i4.AgregarReceta(Componente.ObtenerPorNombre("Cerveza Scotish"));
            i5.AgregarReceta(Componente.ObtenerPorNombre("Cerveza Honey"));
            i6.AgregarReceta(Componente.ObtenerPorNombre("Cerveza Stout"));
            i7.AgregarReceta(Componente.ObtenerPorNombre("Fanta"), Componente.ObtenerPorNombre("Smirnoff"));
            i8.AgregarReceta(Componente.ObtenerPorNombre("Prepizza"), Componente.ObtenerPorNombre("Mozzarella"));

            Inventario.AgregarItem(i1);
            Inventario.AgregarItem(i2);
            Inventario.AgregarItem(i3);
            Inventario.AgregarItem(i4);
            Inventario.AgregarItem(i5);
            Inventario.AgregarItem(i6);
            Inventario.AgregarItem(i7);
            Inventario.AgregarItem(i8);

        }
        public static void CargarComponentes()
        {
            Inventario.AgregarComponente(new Componente(150, "Coca Cola"));
            Inventario.AgregarComponente(new Componente(500, "Pan de hamburguesa"));
            Inventario.AgregarComponente(new Componente(1000, "Medallon de carne"));
            Inventario.AgregarComponente(new Componente(50, "Cerveza Scotish"));
            Inventario.AgregarComponente(new Componente(50, "Cerveza Honey"));
            Inventario.AgregarComponente(new Componente(50, "Cerveza Stout"));
            Inventario.AgregarComponente(new Componente(1, "Smirnoff"));
            Inventario.AgregarComponente(new Componente(80, "Fanta"));
            Inventario.AgregarComponente(new Componente(1000, "Queso cheddar"));
            Inventario.AgregarComponente(new Componente(1000, "Panceta"));
            Inventario.AgregarComponente(new Componente(500, "Medallon vegano"));
            Inventario.AgregarComponente(new Componente(0, "Prepizza"));
            Inventario.AgregarComponente(new Componente(0, "Mozzarella"));

            CargarItems();

        }
        public static Administrador LoginAdmin()
        {
            return new Administrador("Admin", "Istrador", "04469135", "09/05/1810", "VivaLaPep4");
        }
        public static Empleado LoginEmpleado()
        {
            return new Empleado("Robert", "Perez", "37456789", "26/05/1993", "Pepito2568");
        }

    }
}
