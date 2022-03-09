using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiTest.Domain
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreCorto { get; set; }
        public string Abreviatura { get; set; }
        public string Ruc { get; set; }
        public string Estado { get; set; }
        public string GrupoFacturacion { get; set; }
        public DateTime? InactivoDesde { get; set; }
        public string CodigoSap { get; set; }
    }
}
