using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            RegistroVenta = new HashSet<RegistroVenta>();
        }

        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Usuario IdUsuarioNavigation { get; set; }
        public ICollection<RegistroVenta> RegistroVenta { get; set; }
    }
}
