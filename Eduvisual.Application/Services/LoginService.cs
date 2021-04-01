using AutoMapper;
using Eduvisual.Application.InterfacesServices;
using Eduvisual.Application.ViewModels;
using Eduvisual.Domain;
using Eduvisual.Domain.Interfaces;

namespace Eduvisual.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repository;
        private readonly IMapper _mapper;

        public LoginService(ILoginRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void InsertLogin(UsuarioModel login)
        {
            var logon = _mapper.Map<Usuario>(login);
            _repository.InsertLogin(logon);
        }
    }
}