using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApiTest.Core.Dto;
using ApiTest.Domain;

namespace ApiTest.Core.Interfaces.Cliente
{
    public interface ICliente
    {
        Task<List<ClienteDto>> Get();
        Task Post(ClienteDto clienteDto);
    }
}
