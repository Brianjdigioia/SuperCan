using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Usuario IdUsuarioNavigation { get; set; }
    }
}
