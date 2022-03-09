using ApiTest.Core.Dto;
using ApiTest.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTest.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
        }
    }
}
