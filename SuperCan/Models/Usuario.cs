using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cliente = new HashSet<Cliente>();
            Empleado = new HashSet<Empleado>();
            RegistroVenta = new HashSet<RegistroVenta>();
        }

        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }

        public Rol IdRolNavigation { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Empleado> Empleado { get; set; }
        public ICollection<RegistroVenta> RegistroVenta { get; set; }
    }
}
