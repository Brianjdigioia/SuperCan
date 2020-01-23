using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class EstadoVenta
    {
        public EstadoVenta()
        {
            RegistroVenta = new HashSet<RegistroVenta>();
        }

        public int IdEstado { get; set; }
        public string Nombre { get; set; }

        public ICollection<RegistroVenta> RegistroVenta { get; set; }
    }
}
