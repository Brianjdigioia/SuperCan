using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class RegistroVenta
    {
        public RegistroVenta()
        {
            ProductoPorVenta = new HashSet<ProductoPorVenta>();
        }

        public int IdVenta { get; set; }
        public int? IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public int TipoEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public double CostoTotal { get; set; }
        public int EstadoVenta { get; set; }
        public string DireccionEntrega { get; set; }
        public string CodigoPostal { get; set; }
        public string Localidad { get; set; }
        public double? CostoEnvio { get; set; }

        public EstadoVenta EstadoVentaNavigation { get; set; }
        public Cliente IdClienteNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
        public TipoEntrega TipoEntregaNavigation { get; set; }
        public ICollection<ProductoPorVenta> ProductoPorVenta { get; set; }
    }
}
