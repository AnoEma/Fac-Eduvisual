using Eduvisual.Domain;
using Eduvisual.Domain.Interfaces;
using Eduvisual.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduvisual.Infrastructure.Repository
{
    public class EquipamentoDeInformaticaRepository : IEquipamentoDeInformaticaRepository
    {
        private readonly EduvisualContext _context;
        public EquipamentoDeInformaticaRepository(EduvisualContext context)
        {
            _context = context;
        }
        public IEnumerable<EquipamentoDeInformatica> GetEquipamentos()
        {
            return _context.EquipamentoDeInformaticas;
        }

        public IEnumerable<EquipamentoDeInformatica> GetEquipamentosEmUso()
        {
            return _context.EquipamentoDeInformaticas.Where(x => x.EmUso == true);
        }

        public IEnumerable<EquipamentoDeInformatica> GetEquipamentosSemUso()
        {
            return _context.EquipamentoDeInformaticas.Where(x => x.EmUso == false);
        }

        public async Task<EquipamentoDeInformatica> InsertEquipamentos(EquipamentoDeInformatica equipamento)
        {
             equipamento.DataRegistro = DateTime.Now;
             equipamento.EmUso = false;

            _context.EquipamentoDeInformaticas.Add(equipamento);
            await _context.SaveChangesAsync();

            return equipamento;
        }
    }
}