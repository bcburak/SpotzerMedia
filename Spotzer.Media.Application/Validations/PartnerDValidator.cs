using FluentValidation;
using Spotzer.Media.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Validations
{
    public class PartnerDValidator : AbstractValidator<PartnerD>
    {
        public PartnerDValidator()
        {
            RuleForEach(x => x.LineItems).ChildRules(orders =>
            {
                orders.RuleFor(x => x.AdwordCampaign).NotNull();
            });
        }
    }
}
