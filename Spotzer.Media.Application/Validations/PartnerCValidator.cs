using FluentValidation;
using Spotzer.Media.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Validations
{
    public class PartnerCValidator : AbstractValidator<PartnerC>
    {
        public PartnerCValidator()
        {
            RuleFor(x => x.ExposureID)
                .NotNull()
                .WithMessage("ExposureID is required");
            RuleFor(x => x.UDAC)
                .NotNull()
                .WithMessage("ExposureID is required");
            RuleFor(x => x.RelatedOrder)
                .NotNull()
                .WithMessage("ExposureID is required");
        }
    }
}
