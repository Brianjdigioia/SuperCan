using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class Producto
    {
        public Producto()
        {
            ProductoPorVenta = new HashSet<ProductoPorVenta>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int Categoria { get; set; }

        public Categoria CategoriaNavigation { get; set; }
        public ICollection<ProductoPorVenta> ProductoPorVenta { get; set; }
    }
}
