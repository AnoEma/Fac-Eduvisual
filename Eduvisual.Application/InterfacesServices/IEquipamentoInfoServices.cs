using Eduvisual.Application.ViewModels;
using System.Collections.Generic;

namespace Eduvisual.Application.InterfacesServices
{
    public interface IEquipamentoInfoServices
    {
        IEnumerable<EquipamentoDeInformaticaModel> Equipamento();
        IEnumerable<EquipamentoDeInformaticaModel> EquipamentoEmUso();
        IEnumerable<EquipamentoDeInformaticaModel> EquipamentoSemUso();
        void InsertEquipamentoInfo(EquipamentoDeInformaticaModel equipamento);
    }
}