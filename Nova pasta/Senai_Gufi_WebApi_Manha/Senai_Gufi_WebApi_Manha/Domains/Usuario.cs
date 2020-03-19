﻿using System;
using System.Collections.Generic;

namespace Senai_Gufi_WebApi_Manha.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Presenca = new HashSet<Presenca>();
        }

        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Genero { get; set; }
        public int? IdTipousuario { get; set; }

        public TipoUsuario IdTipousuarioNavigation { get; set; }
        public ICollection<Presenca> Presenca { get; set; }
    }
}
