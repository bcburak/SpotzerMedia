using FluentValidation;
using Spotzer.Media.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Validations
{
    public class PartnerAValidator: AbstractValidator<PartnerA>
    {
        public PartnerAValidator()
        {
            RuleFor(x => x.ContactFirstName)
                .NotNull()
                .WithMessage("ContactFirstName is required");
            RuleFor(x => x.ContactLastName)
                .NotNull()
                .WithMessage("ContactLastName is required");
            RuleFor(x => x.ContactTitle)
                .NotNull()
                .WithMessage("ContactTitle is required");
            RuleFor(x => x.ContactPhone)
                .NotNull()
                .WithMessage("ContactPhone is required");
            RuleFor(x => x.ContactMobile)
                .NotNull()
                .WithMessage("ContactMobile is required");
            RuleFor(x => x.ContactEmail).EmailAddress();
        }
    }
}
