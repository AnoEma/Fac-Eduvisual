using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eduvisual.Domain.Interfaces
{
    public interface ICadastraClientesRepository
    {
        IEnumerable<CadastroClientes> GetAllClientes();
        Task<CadastroClientes> InsertCliente(CadastroClientes clientes);
    }
}