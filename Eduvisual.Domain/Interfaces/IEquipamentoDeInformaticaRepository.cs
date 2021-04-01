using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eduvisual.Domain.Interfaces
{
    public interface IEquipamentoDeInformaticaRepository
    {
        IEnumerable<EquipamentoDeInformatica> GetEquipamentos();
        IEnumerable<EquipamentoDeInformatica> GetEquipamentosEmUso();
        IEnumerable<EquipamentoDeInformatica> GetEquipamentosSemUso();
        Task<EquipamentoDeInformatica> InsertEquipamentos(EquipamentoDeInformatica equipamento);
    }
}