﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_Gufi_WebApi_Manha.Domains;
using Senai_Gufi_WebApi_Manha.Interface;
using Senai_Gufi_WebApi_Manha.Repository;

namespace Senai_Gufi_WebApi_Manha.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private IEventoRepository _eventoRepository { get; set; }

        public EventoController()
        {
            _eventoRepository = new EventoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_eventoRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_eventoRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Evento novoEvento)
        {
            _eventoRepository.Cadastrar(novoEvento);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Evento eventoAtualizado)
        {
            try
            {
                _eventoRepository.Atualizar(id, eventoAtualizado);

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
            _eventoRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}