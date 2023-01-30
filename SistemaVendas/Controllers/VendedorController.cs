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
    public class VendedorController : ControllerBase
    {
        private readonly VendedorRepository _repository;

        public VendedorController(VendedorRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarVendedorDTO dto)
        {
            var vendedor = new Vendedor(dto);
            _repository.Cadastrar(vendedor);
            return Ok(vendedor);
        }

        [HttpGet("{Id}")]
        public IActionResult ObterPorId(int Id)
        {
            var vendedor = _repository.ObterPorId(Id);

            if(vendedor is not null)
            {
                var vendedorDTO = new ObterVendedorDTO(vendedor);
                return Ok(vendedorDTO);
            }
            else
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
            
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var vendedores = _repository.ObterPorNome(nome);
            
            if(vendedores is not null)
                return Ok(vendedores);
            else
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarVendedorDTO dto)
        {
            var vendedor = _repository.ObterPorId(id);

            if(vendedor is not null)
            {
                vendedor.MapearAtualizarVendedorDTO(dto);
                _repository.AtualizarVendedor(vendedor);
                return Ok(vendedor);
            }
            else
            {
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var vendedor = _repository.ObterPorId(id);


            if(vendedor is not null)
            {
                _repository.DeletarVendedor(vendedor);
                return NoContent();

            }
             else
            {
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
            }
        
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizaSenha(int id, AtualizarSenhaVendedorDTO dto)
        {
            var vendedor = _repository.ObterPorId(id);

            if(vendedor is not null)
            {
                _repository.AtualizaSenha(vendedor, dto);
                return Ok(vendedor);
            }
             else
            {
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
            }
        
        }
    }
}