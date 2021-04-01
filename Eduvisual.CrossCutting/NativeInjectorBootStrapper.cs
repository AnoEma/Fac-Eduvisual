using Eduvisual.Application.InterfacesServices;
using Eduvisual.Application.Services;
using Eduvisual.Domain.Interfaces;
using Eduvisual.Infrastructure.Context;
using Eduvisual.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Eduvisual.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<ICadastraClientesServices, CadastraClientesServices>();
            service.AddScoped<ICadastraClientesRepository, CadastraClientesRepository>();
            service.AddScoped<ILoginService, LoginService>();
            service.AddScoped<ILoginRepository, LoginRepository>();
            service.AddScoped<EduvisualContext>();
        }
    }
}