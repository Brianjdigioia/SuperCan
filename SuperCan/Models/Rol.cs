﻿using System;
using System.Collections.Generic;

namespace SuperCan.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string Nombre { get; set; }

        public ICollection<Usuario> Usuario { get; set; }
    }
}
