﻿using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();

        void Cadastrar(Usuario novoUsuario);

        void Atualizar(int id, Usuario usuarioAtualizado);

        void Deletar(int id);

        Usuario BuscarPorId(int id);

        //List<Usuario> ListarMeusEventos(string evento);

        List<Usuario> Convidar(string convidar);

        Usuario BuscarPorEmailSenha(string email, string senha);

        //List<Usuario> Inscricao(string );
    }
}
