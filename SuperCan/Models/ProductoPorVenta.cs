using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class ProductoPorVenta
    {
        public int IdProductoPorVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCantidad { get; set; }

        public Producto IdProductoNavigation { get; set; }
        public RegistroVenta IdVentaNavigation { get; set; }
    }
}
