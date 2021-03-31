using Eduvisual.Domain;
using Eduvisual.Domain.Interfaces;
using Eduvisual.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduvisual.Infrastructure.Repository
{
    public class CadastraClientesRepository : ICadastraClientesRepository
    {
        private readonly EduvisualContext _context;

        public CadastraClientesRepository(EduvisualContext context)
        {
            _context = context;
        }

        public IEnumerable<CadastroClientes> GetAllClientes()
        {
           return _context.CadastroClientes.Where(x => x.Excluido != true);
        }

        public async Task<CadastroClientes> InsertCliente(CadastroClientes clientes)
        {
            clientes.Excluido = false;
            clientes.DataDeCadastro = DateTime.Now;

            _context.CadastroClientes.Add(clientes);
            await _context.SaveChangesAsync();
            return clientes;
        }
    }
}