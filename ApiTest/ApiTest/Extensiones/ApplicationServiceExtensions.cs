using ApiTest.Core;
using ApiTest.Core.Interfaces.Cliente;
using ApiTest.Core.Query;
using ApiTest.Infrastructure.Persistance.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Extensiones
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            #region Cliente
            services.AddScoped<ICliente, GetCliente>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            #endregion

            return services;
        }
    }
}
