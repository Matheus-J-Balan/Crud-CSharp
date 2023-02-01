using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Repository;
using SistemaVendas.Dto;
using SistemaVendas.Models;
using SistemaVendas.Context;

namespace SistemaVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase 
    {
        private readonly ClienteRepository _repository;

        public ClienteController(ClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarClienteDTO dto)
        {
            var cliente = new Cliente(dto);
            _repository.Cadastrar(cliente);
            return Ok();
        }

        [HttpGet("{Id}")]
        public IActionResult ObterPorId(int Id)
        {
            var cliente = _repository.ObterPorId(Id);

            if(cliente is not null)
            {
                var clienteDTO = new ObterClienteDTO(cliente);
                return Ok(clienteDTO);
            }
            else
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
            
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var cliente = _repository.ObterPorNome(nome);
            
            if(cliente is not null)
                return Ok(cliente);
            else
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarClienteDTO dto)
        {
            var cliente = _repository.ObterPorId(id);

            if(cliente is not null)
            {
                cliente.MapearAtualizarClienteDTO(dto);
                _repository.AtualizarCliente(cliente);
                return Ok(cliente);
            }
            else
            {
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var cliente = _repository.ObterPorId(id);


            if(cliente is not null)
            {
                _repository.DeletarCliente(cliente);
                return NoContent();

            }
             else
            {
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
            }
        
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizaSenha(int id, AtualizaSenhaClienteDTO dto)
        {
            var cliente = _repository.ObterPorId(id);

            if(cliente is not null)
            {
                _repository.AtualizaSenha(cliente, dto);
                return Ok(cliente);
            }
             else
            {
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
            }
        
        }
    }
}