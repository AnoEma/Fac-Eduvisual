using AutoMapper;
using Eduvisual.Application.ViewModels;
using Eduvisual.Domain;

namespace Eduvisual.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<CadastroClientes, CadastroClientesViewModel>();
            CreateMap<Usuario, UsuarioModel>();
        }
    }
}