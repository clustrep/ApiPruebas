using ApiTest.Core.Dto;
using ApiTest.Core.Interfaces.Cliente;
using ApiTest.Domain;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.Core.Query
{
    public class GetCliente : ICliente
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public GetCliente(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
        public async Task<List<ClienteDto>> Get()
        {
            List<ClienteDto> clientesDtos = new List<ClienteDto>();

            // Obtenemos los clientes
            List<Cliente> clientes = await _clienteRepository.GetClientes();
            foreach (var cliente in clientes)
            {
                clientesDtos.Add(_mapper.Map<Cliente, ClienteDto>(cliente));
            }

            return clientesDtos;
        }

        public async Task Post(ClienteDto clienteDto)
        {
            Cliente cliente = _mapper.Map<ClienteDto, Cliente>(clienteDto);

            // Registra los clientes
            await _clienteRepository.PostCliente(cliente);
        }
    }
}
