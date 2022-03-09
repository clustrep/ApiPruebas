using ApiTest.Core.Interfaces.Cliente;
using ApiTest.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.Infrastructure.Persistance.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public readonly PruebasContext _dbContext;
        public ClienteRepository(PruebasContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Cliente>> GetClientes()
        {
            return await _dbContext.Cliente.ToListAsync();
        }

        public async Task PostCliente(Cliente cliente)
        {
            await _dbContext.Cliente.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();
        }
    }
}
