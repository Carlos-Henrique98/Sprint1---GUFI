﻿using System;
using System.Collections.Generic;

namespace Senai_Gufi_WebApi_Manha.Domains
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdTipoUsuario { get; set; }
        public string TituloTipoUsuario { get; set; }

        public ICollection<Usuario> Usuario { get; set; }
    }
}
