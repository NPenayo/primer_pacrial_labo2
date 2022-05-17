using System;

namespace Entidades
{
    public static class Bar
    {
        private static string razonSocial;
        private static string cuit;
        private static string direccion;

        public static string RazonSocial
        {
            get { return "Bar UTN"; }
        }
        public static string CUIT
        {
            get { return "30-12489647-8"; }
        }
        public static string Direccion
        {
            get { return "Calle cualquiera 2520, Lomas de Zamora"; }
        }
    }
}
