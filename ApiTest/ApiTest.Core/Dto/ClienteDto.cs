using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTest.Core.Dto
{
    public class ClienteDto
    {
        public int CodCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreCorto { get; set; }
        public string Abreviatura { get; set; }
        public string Ruc { get; set; }
        public string Estado { get; set; }
        public string GrupoFacturacion { get; set; }
    }
}
