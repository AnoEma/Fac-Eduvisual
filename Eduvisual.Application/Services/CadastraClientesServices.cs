using AutoMapper;
using Eduvisual.Application.InterfacesServices;
using Eduvisual.Application.ViewModels;
using Eduvisual.Domain;
using Eduvisual.Domain.Interfaces;
using System.Collections.Generic;

namespace Eduvisual.Application.Services
{
    public class CadastraClientesServices : ICadastraClientesServices
    {
        private readonly ICadastraClientesRepository _repository;
        private readonly IMapper _mapper;

        public CadastraClientesServices(ICadastraClientesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<CadastroClientesViewModel> GetAllClientes()
        {
            return _mapper.Map<IEnumerable<CadastroClientesViewModel>>(_repository.GetAllClientes());
        }

        public void InsertCliente(CadastroClientesViewModel clientes)
        {
            var entidade = _mapper.Map<CadastroClientes>(clientes);
            _repository.InsertCliente(entidade);
        }
    }
}