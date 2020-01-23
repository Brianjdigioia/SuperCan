using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public ICollection<Producto> Producto { get; set; }
    }
}
