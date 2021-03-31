using AutoMapper;
using Eduvisual.Application.ViewModels;
using Eduvisual.Domain;

namespace Eduvisual.Application.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<CadastroClientesViewModel, CadastroClientes>();
        }
    }
}