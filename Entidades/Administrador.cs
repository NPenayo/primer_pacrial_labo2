using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, string apellido, string dni, string fechaDeNacimiento, string password) : base(nombre, apellido, dni, fechaDeNacimiento, password)
        {
        }
    }
}
