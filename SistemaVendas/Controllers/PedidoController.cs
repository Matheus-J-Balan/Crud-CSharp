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
        public IActionResult Obter()
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
        public IActionResult ObterPorId(int id)
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
        
        [HttpGet("ObterPorVendedor/{id}")]
        public IActionResult ObterPorVendedor(int id)
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
        [HttpGet("ObterPorCliente/{id}")]
        public IActionResult ObterPorCliente(int id)
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

    }
}