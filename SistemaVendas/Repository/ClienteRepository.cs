using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Context;
using SistemaVendas.Models;
using SistemaVendas.Dto;


namespace SistemaVendas.Repository
{
    public class ClienteRepository
    {
        private readonly VendasContext _context;

        public ClienteRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public Cliente ObterPorId(int Id)
        {
            var cliente =_context.Cliente.Find(Id);
            return vendedor;    
        }

        public List<ObterClienteDTO> ObterPorNome(string nome)
        {
            var cliente = _context.Clientes.Where(x => x.Nome.Contains(nome))
                                           .Select(x => new ObterClienteDTO(x))
                                           .ToList();
            return cliente;
        }  

        public Cliente AtualizarCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();

            return cliente;
        }

        public void DeletarCliente(Cliente cliente)
        {
            _context.Vendedores.Remove(cliente);
            _context.SaveChanges();
        }

        public void AtualizaSenha(Cliente cliente, AtualizarSenhaClienteDTO dto)
        {
            cliente.Senha = dto.senha;
            AtualizarVendedor(cliente);
        }
    }
}