using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.Core.Interfaces.Cliente
{
    public interface IClienteRepository
    {
        Task<List<Domain.Cliente>> GetClientes();
        Task PostCliente(Domain.Cliente cliente);
    }
}
