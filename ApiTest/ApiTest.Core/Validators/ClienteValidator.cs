using ApiTest.Core.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTest.Core.Validators
{
    class ClienteValidator : AbstractValidator<ClienteDto>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Estado).NotEmpty().NotNull().WithMessage("Estado es requerido");
        }
    }
}
