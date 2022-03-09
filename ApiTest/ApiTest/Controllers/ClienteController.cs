using ApiTest.Core.Dto;
using ApiTest.Core.Interfaces.Cliente;
using ApiTest.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ICliente _clientes;
        public ClienteController(ICliente clientes)
        {
            _clientes = clientes;
        }
        
        [HttpGet]
        public async Task<List<ClienteDto>> Get()
        {
            return await _clientes.Get();
        }

        [HttpPost]
        public async Task Post([FromBody] ClienteDto clienteDto)
        {
            await _clientes.Post(clienteDto);
        }
    }
}
