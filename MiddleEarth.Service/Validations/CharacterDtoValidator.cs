using FluentValidation;
using MiddleEarth.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Service.Validations
{
    public class CharacterDtoValidator:AbstractValidator<CharacterDto>
    {
        public CharacterDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} is required!").NotEmpty().WithMessage(
                "{PropertyName} is required!");
        }
    }
}
