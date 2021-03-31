using Eduvisual.Application.ViewModels;
using System.Collections.Generic;

namespace Eduvisual.Application.InterfacesServices
{
    public interface ICadastraClientesServices
    {
        IEnumerable<CadastroClientesViewModel> GetAllClientes();
        void InsertCliente(CadastroClientesViewModel clientes);
    }
}