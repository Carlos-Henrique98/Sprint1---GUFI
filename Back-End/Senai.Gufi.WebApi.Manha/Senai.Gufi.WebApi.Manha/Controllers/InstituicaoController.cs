﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using Senai.Gufi.WebApi.Manha.Repositories;

namespace Senai.Gufi.WebApi.Manha.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class InstituicaoController : ControllerBase
    {
        private IInstituicaoRepository _instituicaoRepository { get; set; }

        public InstituicaoController()
        {
            _instituicaoRepository = new InstituicaoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_instituicaoRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_instituicaoRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Instituicao novaInstituicao)
        {
            _instituicaoRepository.Cadastrar(novaInstituicao);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Instituicao instituicaoAtualizada)
        {
            try
            {
                _instituicaoRepository.Atualizar(id, instituicaoAtualizada);

                return StatusCode(204);
            }
            catch(Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _instituicaoRepository.Deletar(id);

            return StatusCode(201);
        }
    }
}