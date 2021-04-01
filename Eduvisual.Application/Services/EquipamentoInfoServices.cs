using AutoMapper;
using Eduvisual.Application.InterfacesServices;
using Eduvisual.Application.ViewModels;
using Eduvisual.Domain;
using Eduvisual.Domain.Interfaces;
using System.Collections.Generic;

namespace Eduvisual.Application.Services
{
    public class EquipamentoInfoServices : IEquipamentoInfoServices
    {
        private readonly IEquipamentoDeInformaticaRepository _repository;
        private readonly IMapper _mapper;

        public EquipamentoInfoServices(IEquipamentoDeInformaticaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<EquipamentoDeInformaticaModel> Equipamento()
        {
            return _mapper.Map<IEnumerable<EquipamentoDeInformaticaModel>>(_repository.GetEquipamentos());
        }

        public IEnumerable<EquipamentoDeInformaticaModel> EquipamentoEmUso()
        {
            return _mapper.Map<IEnumerable<EquipamentoDeInformaticaModel>>(_repository.GetEquipamentosEmUso());
        }

        public IEnumerable<EquipamentoDeInformaticaModel> EquipamentoSemUso()
        {
            return _mapper.Map<IEnumerable<EquipamentoDeInformaticaModel>>(_repository.GetEquipamentosSemUso());
        }

        public void InsertEquipamentoInfo(EquipamentoDeInformaticaModel equipamento)
        {
            var entidade = _mapper.Map<EquipamentoDeInformatica>(equipamento);
            _repository.InsertEquipamentos(entidade);
        }
    }
}