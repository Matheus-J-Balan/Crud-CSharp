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
    public class PedidoController : ControllerBase
    {
        private readonly PedidoRepository _repository;

        public PedidoController(PedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarPedidoDTO dto)
        {
            var pedido = new Pedido(dto);
            _repository.Cadastrar(pedido);
            return Ok(pedido);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var pedido = _repository.Listar();

            if(pedido is not null)
            {
                return Ok(pedido);
            }
            else
            {
                return NotFound(new { Mensagem = "Não há pedidos"});
            }
        }      
        
        [HttpGet("{id}")]
        public IActionResult ConsultarPorId(int id)
        {
            var pedido = _repository.ObterPorId(id);

            if(pedido is not null)
            {
                return Ok(pedido);
            }
            else
            {
                return NotFound(new { Mensagem = "Pedido não encontrado"});
            }
        }      
        
        [HttpGet("ConsultarPorVendedor/{id}")]
        public IActionResult ConsultarPorVendedor(int id)
        {
            var vendedor = _repository.ObterVendedorPedido(id);

            if(vendedor is not null)
            {
                return Ok(vendedor);
            }
            else
            {
                return NotFound(new { Mensagem = "Este vendedor não possui nenhum pedido"});
            }
        }
        [HttpGet("ConsultarPorCliente/{id}")]
        public IActionResult ConsultarPorCliente(int id)
        {
            var cliente = _repository.ObterClientePedido(id);

            if(cliente is not null)
            {
                return Ok(cliente);
            }
            else
            {
                return NotFound(new { Mensagem = "Este cliente não possui nenhum pedido"});
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarPedidoDTO dto)
        {
            var pedido = _repository.ObterPorId(id);

            if(pedido is not null)
            {
                pedido.MapearAtualizarPedidoDTO(dto);
                _repository.AtualizarPedido(pedido);
                return Ok(pedido);
            }
            else
            {
                return NotFound(new { Mensagem = "Pedido não encontrado ou não existente"});
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var pedido = _repository.ObterPorId(id);


            if(pedido is not null)
            {
                _repository.DeletarPedido(pedido);
                return NoContent();

            }
             else
            {
                return NotFound(new { Mensagem = "Pedido não encontrado"});
            }
        
        }

    }
}