using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class TipoEntrega
    {
        public TipoEntrega()
        {
            RegistroVenta = new HashSet<RegistroVenta>();
        }

        public int IdEntrega { get; set; }
        public string Nombre { get; set; }

        public ICollection<RegistroVenta> RegistroVenta { get; set; }
    }
}
