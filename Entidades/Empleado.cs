using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        private string id;
        private string nombre;
        private string apellido;
        private string dni;
        private string fechaDeNacimiento;
        private string password;

        public Empleado(string nombre, string apellido, string dni, string fechaDeNacimiento, string password)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Password = password;
            FechaDeNacimiento = fechaDeNacimiento;
            id = GenerarId();
        }

        public string Id { get { return id; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Dni { get { return dni; } set { if (Seguridad.Dni(value)) { dni = value; } } }
        public string FechaDeNacimiento { get { return fechaDeNacimiento; } set { if (Seguridad.Fecha(value)) { fechaDeNacimiento = value; } } }
        public string Password { get { return password; } private set { if (Seguridad.FormatoPassword(value)) { password = Seguridad.EncriptarPassword(value); } } }

        private string GenerarId()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nombre[0]}{Apellido[0]}{Dni.Substring(5,3)}");
            return sb.ToString().Trim();
        }


    }
}
