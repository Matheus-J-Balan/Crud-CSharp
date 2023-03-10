using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVendas.Context;
using SistemaVendas.Models;
using SistemaVendas.Dto;

namespace SistemaVendas.Repository
{
    public class ServicoRepository
    {
        private readonly VendasContext _context;

        public ServicoRepository(VendasContext context)
        {
            _context = context;
        }

        public Servico Cadastrar(Servico servico)
        {
            _context.Servicos.Add(servico);
            _context.SaveChanges();

            return servico;
        }

        public List<Servico> Listar()
        {
            var servico = _context.Servicos.ToList();
            return servico;
        }

        public Servico ObterPorId(int id)
        {
            var servico = _context.Servicos.Find(id);

            return servico;
        }

        public Servico AtualizarServico(Servico servico)
        {
            _context.Servicos.Update(servico);
            _context.SaveChanges();

            return servico;
        }

        public void DeletarServico(Servico servico)
        {
            _context.Servicos.Remove(servico);
            _context.SaveChanges();
        }
    }
}